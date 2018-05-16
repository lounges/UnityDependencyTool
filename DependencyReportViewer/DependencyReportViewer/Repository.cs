using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyReportViewer
{
    public class Repository
    {        
        private static Repository _repository;

        SQLiteAsyncConnection _connection = null;
        List<ProjectAsset> _allAssets = null;

        public List<ProjectAsset> AllAssets { get { return _allAssets; } }

        private Repository(){}

        public static Repository Instance
        {
            get
            {
                if (_repository == null)
                    _repository = new Repository();

                return _repository;
            }
        }

        public async Task OpenDatabase(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _allAssets = await _connection.Table<ProjectAsset>().OrderBy(a => a.Path).ToListAsync();
            await PopulateDependencyAndReferenceCounts(_allAssets);
        }

        private async Task PopulateDependencyAndReferenceCounts(List<ProjectAsset> assets)
        {
            foreach (var asset in _allAssets)
            {
                asset.DependencyCount = await _connection.Table<AssetDependency>().Where(d => d.AssetUId == asset.Id).CountAsync();
                asset.ReferenceCount = await _connection.Table<AssetDependency>().Where(d => d.DependantId == asset.Id).CountAsync();
            }
        }

        public async Task<List<ProjectAsset>> DependenciesForAsset(Guid assetToCheckId)
        {
            var assets = new List<ProjectAsset>();

            if(_connection != null)
            {
                var dependencyInfo = await _connection.Table<AssetDependency>().Where(d => d.AssetUId == assetToCheckId).ToListAsync();
                var dependentIds = dependencyInfo.Select(d => d.DependantId).Distinct();

                assets.AddRange(_allAssets.Where(a => dependentIds.Contains(a.Id)));
            }

            return assets;
        }

        public async Task<List<ProjectAsset>> FindReferences(Guid assetToCheckId)
        {
            var assets = new List<ProjectAsset>();

            if (_connection != null)
            {
                var referenceInfo = await _connection.Table<AssetDependency>().Where(d => d.DependantId == assetToCheckId).ToListAsync();
                var referenceIds = referenceInfo.Select(d => d.AssetUId).Distinct();

                assets.AddRange(_allAssets.Where(a => referenceIds.Contains(a.Id)));
            }

            return assets;
        }
    }
}
