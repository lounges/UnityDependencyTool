namespace DependencyReportViewer
{
    partial class AssetDetailsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxAssetPath = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelDependencies = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.labelPathFilter = new System.Windows.Forms.Label();
            this.panelReferencedBy = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.assetListViewControlDependencies = new DependencyReportViewer.AssetListViewControl();
            this.assetListViewControlReferences = new DependencyReportViewer.AssetListViewControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelDependencies.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.panelReferencedBy.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1324, 1473);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 64);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxAssetPath
            // 
            this.textBoxAssetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAssetPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAssetPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxAssetPath.Location = new System.Drawing.Point(18, 12);
            this.textBoxAssetPath.Name = "textBoxAssetPath";
            this.textBoxAssetPath.ReadOnly = true;
            this.textBoxAssetPath.Size = new System.Drawing.Size(1456, 43);
            this.textBoxAssetPath.TabIndex = 5;
            this.textBoxAssetPath.Text = "<asset path>";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(18, 67);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelDependencies);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelReferencedBy);
            this.splitContainer1.Size = new System.Drawing.Size(1456, 1390);
            this.splitContainer1.SplitterDistance = 719;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 9;
            // 
            // panelDependencies
            // 
            this.panelDependencies.Controls.Add(this.assetListViewControlDependencies);
            this.panelDependencies.Controls.Add(this.panelTopBar);
            this.panelDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDependencies.Location = new System.Drawing.Point(0, 0);
            this.panelDependencies.Name = "panelDependencies";
            this.panelDependencies.Size = new System.Drawing.Size(1456, 719);
            this.panelDependencies.TabIndex = 9;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTopBar.Controls.Add(this.labelPathFilter);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1456, 63);
            this.panelTopBar.TabIndex = 5;
            // 
            // labelPathFilter
            // 
            this.labelPathFilter.AutoSize = true;
            this.labelPathFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathFilter.ForeColor = System.Drawing.Color.White;
            this.labelPathFilter.Location = new System.Drawing.Point(5, 7);
            this.labelPathFilter.Name = "labelPathFilter";
            this.labelPathFilter.Size = new System.Drawing.Size(237, 45);
            this.labelPathFilter.TabIndex = 0;
            this.labelPathFilter.Text = "Dependencies:";
            // 
            // panelReferencedBy
            // 
            this.panelReferencedBy.Controls.Add(this.assetListViewControlReferences);
            this.panelReferencedBy.Controls.Add(this.panel3);
            this.panelReferencedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReferencedBy.Location = new System.Drawing.Point(0, 0);
            this.panelReferencedBy.Name = "panelReferencedBy";
            this.panelReferencedBy.Size = new System.Drawing.Size(1456, 663);
            this.panelReferencedBy.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1456, 63);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Referenced By:";
            // 
            // assetListViewControlDependencies
            // 
            this.assetListViewControlDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetListViewControlDependencies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.assetListViewControlDependencies.Location = new System.Drawing.Point(0, 63);
            this.assetListViewControlDependencies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assetListViewControlDependencies.Name = "assetListViewControlDependencies";
            this.assetListViewControlDependencies.Size = new System.Drawing.Size(1456, 656);
            this.assetListViewControlDependencies.TabIndex = 6;
            // 
            // assetListViewControlReferences
            // 
            this.assetListViewControlReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetListViewControlReferences.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.assetListViewControlReferences.Location = new System.Drawing.Point(0, 63);
            this.assetListViewControlReferences.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assetListViewControlReferences.Name = "assetListViewControlReferences";
            this.assetListViewControlReferences.Size = new System.Drawing.Size(1456, 600);
            this.assetListViewControlReferences.TabIndex = 6;
            // 
            // AssetDetailsForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(1486, 1549);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBoxAssetPath);
            this.Controls.Add(this.buttonClose);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssetDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssetDetailsForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelDependencies.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelReferencedBy.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxAssetPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelDependencies;
        private AssetListViewControl assetListViewControlDependencies;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label labelPathFilter;
        private System.Windows.Forms.Panel panelReferencedBy;
        private AssetListViewControl assetListViewControlReferences;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}