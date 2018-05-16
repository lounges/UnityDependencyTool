namespace DependencyReportViewer
{
    partial class AssetListViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.panelTopBarButtons = new System.Windows.Forms.Panel();
            this.checkBoxUnreferenced = new System.Windows.Forms.CheckBox();
            this.checkBoxNoDeps = new System.Windows.Forms.CheckBox();
            this.panelSeperator = new System.Windows.Forms.Panel();
            this.textBoxPathFilter = new System.Windows.Forms.TextBox();
            this.labelPathFilter = new System.Windows.Forms.Label();
            this.panelStatusBar = new System.Windows.Forms.Panel();
            this.labelStatusLine = new System.Windows.Forms.Label();
            this.listViewAssetList = new DependencyReportViewer.ListViewEx();
            this.columnHeaderDummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAssetPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderChildDependencies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReferencedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTopBar.SuspendLayout();
            this.panelTopBarButtons.SuspendLayout();
            this.panelStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTopBar.Controls.Add(this.panelTopBarButtons);
            this.panelTopBar.Controls.Add(this.textBoxPathFilter);
            this.panelTopBar.Controls.Add(this.labelPathFilter);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1274, 83);
            this.panelTopBar.TabIndex = 4;
            // 
            // panelTopBarButtons
            // 
            this.panelTopBarButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTopBarButtons.Controls.Add(this.checkBoxUnreferenced);
            this.panelTopBarButtons.Controls.Add(this.checkBoxNoDeps);
            this.panelTopBarButtons.Controls.Add(this.panelSeperator);
            this.panelTopBarButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopBarButtons.Location = new System.Drawing.Point(809, 0);
            this.panelTopBarButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTopBarButtons.Name = "panelTopBarButtons";
            this.panelTopBarButtons.Size = new System.Drawing.Size(465, 83);
            this.panelTopBarButtons.TabIndex = 3;
            // 
            // checkBoxUnreferenced
            // 
            this.checkBoxUnreferenced.AutoSize = true;
            this.checkBoxUnreferenced.ForeColor = System.Drawing.Color.White;
            this.checkBoxUnreferenced.Location = new System.Drawing.Point(261, 27);
            this.checkBoxUnreferenced.Name = "checkBoxUnreferenced";
            this.checkBoxUnreferenced.Size = new System.Drawing.Size(192, 36);
            this.checkBoxUnreferenced.TabIndex = 8;
            this.checkBoxUnreferenced.Text = "Unreferenced";
            this.checkBoxUnreferenced.UseVisualStyleBackColor = true;
            this.checkBoxUnreferenced.CheckedChanged += new System.EventHandler(this.UpdateFilter);
            // 
            // checkBoxNoDeps
            // 
            this.checkBoxNoDeps.AutoSize = true;
            this.checkBoxNoDeps.ForeColor = System.Drawing.Color.White;
            this.checkBoxNoDeps.Location = new System.Drawing.Point(16, 27);
            this.checkBoxNoDeps.Name = "checkBoxNoDeps";
            this.checkBoxNoDeps.Size = new System.Drawing.Size(238, 36);
            this.checkBoxNoDeps.TabIndex = 7;
            this.checkBoxNoDeps.Text = "No Dependencies";
            this.checkBoxNoDeps.UseVisualStyleBackColor = true;
            this.checkBoxNoDeps.CheckedChanged += new System.EventHandler(this.UpdateFilter);
            // 
            // panelSeperator
            // 
            this.panelSeperator.BackColor = System.Drawing.Color.White;
            this.panelSeperator.Location = new System.Drawing.Point(5, 0);
            this.panelSeperator.Name = "panelSeperator";
            this.panelSeperator.Size = new System.Drawing.Size(1, 83);
            this.panelSeperator.TabIndex = 5;
            // 
            // textBoxPathFilter
            // 
            this.textBoxPathFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathFilter.Location = new System.Drawing.Point(154, 25);
            this.textBoxPathFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPathFilter.Name = "textBoxPathFilter";
            this.textBoxPathFilter.Size = new System.Drawing.Size(649, 39);
            this.textBoxPathFilter.TabIndex = 1;
            this.textBoxPathFilter.TextChanged += new System.EventHandler(this.UpdateFilter);
            // 
            // labelPathFilter
            // 
            this.labelPathFilter.AutoSize = true;
            this.labelPathFilter.ForeColor = System.Drawing.Color.White;
            this.labelPathFilter.Location = new System.Drawing.Point(5, 28);
            this.labelPathFilter.Name = "labelPathFilter";
            this.labelPathFilter.Size = new System.Drawing.Size(126, 32);
            this.labelPathFilter.TabIndex = 0;
            this.labelPathFilter.Text = "Path Filter:";
            // 
            // panelStatusBar
            // 
            this.panelStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStatusBar.Controls.Add(this.labelStatusLine);
            this.panelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatusBar.Location = new System.Drawing.Point(0, 425);
            this.panelStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelStatusBar.Name = "panelStatusBar";
            this.panelStatusBar.Size = new System.Drawing.Size(1274, 50);
            this.panelStatusBar.TabIndex = 6;
            // 
            // labelStatusLine
            // 
            this.labelStatusLine.AutoSize = true;
            this.labelStatusLine.ForeColor = System.Drawing.Color.White;
            this.labelStatusLine.Location = new System.Drawing.Point(5, 10);
            this.labelStatusLine.Name = "labelStatusLine";
            this.labelStatusLine.Size = new System.Drawing.Size(108, 32);
            this.labelStatusLine.TabIndex = 0;
            this.labelStatusLine.Text = "<count>";
            // 
            // listViewAssetList
            // 
            this.listViewAssetList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAssetList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDummy,
            this.columnHeaderAssetPath,
            this.columnHeaderChildDependencies,
            this.columnHeaderReferencedBy});
            this.listViewAssetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAssetList.FullRowSelect = true;
            this.listViewAssetList.GridLines = true;
            this.listViewAssetList.Location = new System.Drawing.Point(0, 83);
            this.listViewAssetList.Margin = new System.Windows.Forms.Padding(4);
            this.listViewAssetList.MultiSelect = false;
            this.listViewAssetList.Name = "listViewAssetList";
            this.listViewAssetList.ShowGroups = false;
            this.listViewAssetList.Size = new System.Drawing.Size(1274, 342);
            this.listViewAssetList.TabIndex = 7;
            this.listViewAssetList.UseCompatibleStateImageBehavior = false;
            this.listViewAssetList.View = System.Windows.Forms.View.Details;
            this.listViewAssetList.VirtualMode = true;
            // 
            // columnHeaderDummy
            // 
            this.columnHeaderDummy.Width = 0;
            // 
            // columnHeaderAssetPath
            // 
            this.columnHeaderAssetPath.Text = "Asset Path";
            this.columnHeaderAssetPath.Width = 766;
            // 
            // columnHeaderChildDependencies
            // 
            this.columnHeaderChildDependencies.Text = "Child Dependencies";
            this.columnHeaderChildDependencies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderChildDependencies.Width = 250;
            // 
            // columnHeaderReferencedBy
            // 
            this.columnHeaderReferencedBy.Text = "Referenced By";
            this.columnHeaderReferencedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderReferencedBy.Width = 250;
            // 
            // AssetListViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewAssetList);
            this.Controls.Add(this.panelStatusBar);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssetListViewControl";
            this.Size = new System.Drawing.Size(1274, 475);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelTopBarButtons.ResumeLayout(false);
            this.panelTopBarButtons.PerformLayout();
            this.panelStatusBar.ResumeLayout(false);
            this.panelStatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.TextBox textBoxPathFilter;
        private System.Windows.Forms.Label labelPathFilter;
        private System.Windows.Forms.Panel panelStatusBar;
        private System.Windows.Forms.Label labelStatusLine;
        private ListViewEx listViewAssetList;
        private System.Windows.Forms.ColumnHeader columnHeaderDummy;
        private System.Windows.Forms.ColumnHeader columnHeaderAssetPath;
        private System.Windows.Forms.ColumnHeader columnHeaderChildDependencies;
        private System.Windows.Forms.ColumnHeader columnHeaderReferencedBy;
        private System.Windows.Forms.Panel panelTopBarButtons;
        private System.Windows.Forms.Panel panelSeperator;
        private System.Windows.Forms.CheckBox checkBoxUnreferenced;
        private System.Windows.Forms.CheckBox checkBoxNoDeps;
    }
}
