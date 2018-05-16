using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyReportViewer
{
    public partial class AssetListViewControl : UserControl
    {
        private enum SortColumn
        {
            Path = 1,
            DependencyCount = 2,
            ReferenceCount = 3,
        }

        List<ProjectAsset> _allAssets = null;
        List<ProjectAsset> _filteredAndSorted = null;

        SortColumn _sortColumn = SortColumn.Path;
        SortOrder _sortOrder = SortOrder.Ascending;

        public AssetListViewControl()
        {
            InitializeComponent();
            labelStatusLine.Text = "";

            listViewAssetList.RetrieveVirtualItem += (s, e) =>
            {
                var projectAsset = _filteredAndSorted[e.ItemIndex];
                if (e.Item == null) e.Item = new ListViewItem();

                e.Item.SubItems.Clear();
                e.Item.SubItems.Add(projectAsset.Path);
                e.Item.SubItems.Add(projectAsset.DependencyCount.ToString());
                e.Item.SubItems.Add(projectAsset.ReferenceCount.ToString());
            };

            listViewAssetList.DoubleClick += (s, e) =>
            {
                var form = new AssetDetailsForm();
                form.ShowForAsset(_filteredAndSorted[listViewAssetList.SelectedIndices[0]]);
            };

            listViewAssetList.ColumnClick += (s, e) =>
            {
                var newColumn = (SortColumn)e.Column;
                var changeDirection = newColumn == _sortColumn;
                _sortColumn = newColumn;

                if (changeDirection)
                    _sortOrder = (_sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;

                FilterAndSort();
            };
        }

        public void Clear()
        {
            listViewAssetList.VirtualListSize = 0;
            listViewAssetList.Invalidate();
            Application.DoEvents();
        }

        public void UpdateStatusLabel(string newStatus)
        {
            labelStatusLine.Text = newStatus;
            Application.DoEvents();
        }

        public void FilterAndSort()
        {
            if ( _allAssets == null || _allAssets.Count < 1)
            {
                labelStatusLine.Text = "No matching assets...";
                return;
            }

            _filteredAndSorted = _allAssets;

            //filter if needed here
            if (checkBoxNoDeps.Checked)
                _filteredAndSorted = _filteredAndSorted.Where(a => a.DependencyCount < 1).ToList();

            if (checkBoxUnreferenced.Checked)
                _filteredAndSorted = _filteredAndSorted.Where(a => a.ReferenceCount < 1).ToList();

            var pathFilter = textBoxPathFilter.Text;
            if (pathFilter.Length > 0)
                _filteredAndSorted = _filteredAndSorted.Where(a => a.Path.ToLower().Contains(pathFilter.ToLower())).ToList();

            switch (_sortColumn)
            {
                case SortColumn.Path:
                    {
                        var sortQuery = (_sortOrder == SortOrder.Ascending) ? _filteredAndSorted.OrderBy(a => a.Path) : _filteredAndSorted.OrderByDescending(a => a.Path);
                        _filteredAndSorted = sortQuery.ToList();
                        break;
                    }
                case SortColumn.DependencyCount:
                    {
                        var sortQuery = (_sortOrder == SortOrder.Ascending) ? _filteredAndSorted.OrderBy(a => a.DependencyCount) : _filteredAndSorted.OrderByDescending(a => a.DependencyCount);
                        _filteredAndSorted = sortQuery.ToList();
                        break;
                    }
                case SortColumn.ReferenceCount:
                    {
                        var sortQuery = (_sortOrder == SortOrder.Ascending) ? _filteredAndSorted.OrderBy(a => a.ReferenceCount) : _filteredAndSorted.OrderByDescending(a => a.ReferenceCount);
                        _filteredAndSorted = sortQuery.ToList();
                        break;
                    }
            }

            Action updateUi = () =>
            {
                listViewAssetList.SetSortIcon((int)_sortColumn, _sortOrder);
                listViewAssetList.VirtualListSize = _filteredAndSorted.Count;
                listViewAssetList.Invalidate();

                labelStatusLine.Text = $"{_filteredAndSorted.Count} assets...";
            };
            Invoke(updateUi);
        }

        public void DisplayAssets(List<ProjectAsset> assets)
        {
            _allAssets = assets;
            FilterAndSort();
        }

        private void UpdateFilter(object sender, EventArgs e)
        {
            FilterAndSort();
        }
    }
}
