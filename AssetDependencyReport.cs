using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class AssetDependencyReport
{
    public class ProjectAsset
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Path { get; set; }
    }

    public class AssetDependency
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Guid AssetUId { get; set; }
        public Guid DependantId { get; set; }
        public string Path { get; set; }
    }

    private static readonly List<string> IgnoredPrefixes = new List<string>
    {
        "Packages",
        "ProjectSettings"
    };

    private static readonly List<string> IgnoredFileExtensions = new List<string> {
            ".meta",
        };

    [MenuItem("Utilities/Generate Asset Dependency Report")]
    public static void GenerateAssetDependencyReport()
    {
        // Get an absolute path to the database file
        var databasePath = Path.Combine(Directory.GetParent(Application.dataPath).ToString(), "AssetReport.sqlite");

        var db = new SQLiteConnection(databasePath);
        db.CreateTable<ProjectAsset>();
        db.CreateTable<AssetDependency>();

        Action<ProjectAsset> CreateAssetIfNeeded = (a) =>
        {
            if( string.IsNullOrWhiteSpace(a.Path))
            {
                Debug.Log($"Missing path for id: {a.Id}");
            }

            var existing = db.Table<ProjectAsset>().FirstOrDefault(pa => pa.Id == a.Id);

            if(existing == null )
                db.Insert(a);
        };

        Action<AssetDependency> AddDependency = (d) =>
        {
            CreateAssetIfNeeded(new ProjectAsset
            {
                Id = d.DependantId,
                Path = d.Path
            });

            db.Insert(d);
        };

        var allAssets = AssetDatabase.GetAllAssetPaths();
        for (var i = 0; i < allAssets.Length; i++)
        {
            var asset = allAssets[i];
            var progress = (float)i / (float)allAssets.Length;

            //update the progress window
            if (EditorUtility.DisplayCancelableProgressBar("Walking dependencies", asset, progress))
            {
                Debug.Log($"User canceled operation...");
                break;
            }

            //get the extension and see if its a file we are supposed to skip
            var extension = Path.GetExtension(asset);
            if (extension != null && IgnoredFileExtensions.Contains(extension.ToLower()))
                continue;

            if( extension != null && extension.Length < 1 )
            {
                if (Directory.Exists(asset))
                {
                    Debug.Log($"Skipping directory: {asset}");
                    continue;
                }
                    
            }

            var shouldSkip = false;
            foreach(var prefix in IgnoredPrefixes)
            {
                if(asset.StartsWith(prefix))
                {
                    shouldSkip = true;
                    break;
                }
            }

            if (shouldSkip)
                continue;

            //create the asset if needed
            var assetId = Guid.Parse(AssetDatabase.AssetPathToGUID(asset));
            CreateAssetIfNeeded(new ProjectAsset
            {
                Id = assetId,
                Path = asset
            });

            var dependancies = AssetDatabase.GetDependencies(asset, false);
            foreach(var dependency in dependancies)
            {
                var dependantId = Guid.Parse(AssetDatabase.AssetPathToGUID(dependency));
                AddDependency(new AssetDependency
                {
                    AssetUId = assetId,
                    DependantId = dependantId,
                    Path = dependency
                });
            }
        }

        db.Close();
        EditorUtility.ClearProgressBar();
        Debug.Log($"Done...");
    }
}
