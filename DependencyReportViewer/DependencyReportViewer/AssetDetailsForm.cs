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
    public partial class AssetDetailsForm : Form
    {
        public AssetDetailsForm()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );

            InitializeComponent();

            Resize += (s, e) => Invalidate();
        }

        public async void ShowForAsset(ProjectAsset asset)
        {
            Text = asset.Path;
            textBoxAssetPath.Text = asset.Path;

            Show();

            assetListViewControlDependencies.Clear();
            assetListViewControlDependencies.UpdateStatusLabel("Loading...");
            assetListViewControlDependencies.DisplayAssets(await Repository.Instance.DependenciesForAsset(asset.Id));

            assetListViewControlReferences.Clear();
            assetListViewControlReferences.UpdateStatusLabel("Loading...");
            assetListViewControlReferences.DisplayAssets(await Repository.Instance.FindReferences(asset.Id));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
