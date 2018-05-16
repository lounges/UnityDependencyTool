using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyReportViewer
{
    public partial class MainForm : Form
    {
        public MainForm(string fileToOpen = null)
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );

            InitializeComponent();

            Action<string> openFile = async (p) =>{
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                assetListViewControlMaster.Clear();
                assetListViewControlMaster.UpdateStatusLabel($"Loading {p}");
                await Repository.Instance.OpenDatabase(p);
                assetListViewControlMaster.DisplayAssets(Repository.Instance.AllAssets);
                Cursor.Current = Cursors.Default;
            };

            if (!string.IsNullOrWhiteSpace(fileToOpen))
                openFile(fileToOpen);

            openToolStripMenuItem.Click += (s, e) =>
            {
                var picker = new OpenFileDialog();
                if (picker.ShowDialog() == DialogResult.OK)
                    openFile(picker.FileName);
            };
        }
    }

    public class ProjectAsset
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Path { get; set; }

        public int? DependencyCount { get; set; }
        public int? ReferenceCount { get; set; }
    }

    public class AssetDependency
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Guid AssetUId { get; set; }
        public Guid DependantId { get; set; }
        public string Path { get; set; }
    }
}
