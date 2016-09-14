namespace File
{
    partial class File
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._toolStripLayer = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCloseProject = new System.Windows.Forms.ToolStripButton();
            this.toolLoadProject = new System.Windows.Forms.ToolStripButton();
            this.toolSaveProject = new System.Windows.Forms.ToolStripButton();
            this.toolSaveProjectAs = new System.Windows.Forms.ToolStripButton();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomMax = new System.Windows.Forms.ToolStripButton();
            this.toolZoomToLayer = new System.Windows.Forms.ToolStripButton();
            this.toolPan = new System.Windows.Forms.ToolStripButton();
            this.toolSetProjection = new System.Windows.Forms.ToolStripButton();
            this.toolLoadData = new System.Windows.Forms.ToolStripButton();
            this._toolStripLayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // _toolStripLayer
            // 
            this._toolStripLayer.AutoSize = false;
            this._toolStripLayer.Dock = System.Windows.Forms.DockStyle.None;
            this._toolStripLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCloseProject,
            this.toolLoadProject,
            this.toolSaveProject,
            this.toolSaveProjectAs,
            this.toolStripSeparator1,
            this.toolOpen,
            this.toolStripSeparator2,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolZoomMax,
            this.toolZoomToLayer,
            this.toolPan,
            this.toolStripSeparator3,
            this.toolSetProjection,
            this.toolStripSeparator4,
            this.toolLoadData});
            this._toolStripLayer.Location = new System.Drawing.Point(0, 0);
            this._toolStripLayer.Name = "_toolStripLayer";
            this._toolStripLayer.Size = new System.Drawing.Size(438, 50);
            this._toolStripLayer.TabIndex = 0;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // toolCloseProject
            // 
            this.toolCloseProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCloseProject.Image = global::File.Properties.Resources.map;
            this.toolCloseProject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolCloseProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCloseProject.Name = "toolCloseProject";
            this.toolCloseProject.Size = new System.Drawing.Size(28, 47);
            this.toolCloseProject.Text = "NewProject";
            // 
            // toolLoadProject
            // 
            this.toolLoadProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLoadProject.Image = global::File.Properties.Resources.open1;
            this.toolLoadProject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolLoadProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoadProject.Name = "toolLoadProject";
            this.toolLoadProject.Size = new System.Drawing.Size(28, 47);
            this.toolLoadProject.Text = "Load Project";
            // 
            // toolSaveProject
            // 
            this.toolSaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSaveProject.Image = global::File.Properties.Resources.save1;
            this.toolSaveProject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSaveProject.Name = "toolSaveProject";
            this.toolSaveProject.Size = new System.Drawing.Size(28, 47);
            this.toolSaveProject.Text = "Save Project";
            // 
            // toolSaveProjectAs
            // 
            this.toolSaveProjectAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSaveProjectAs.Image = global::File.Properties.Resources.save;
            this.toolSaveProjectAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSaveProjectAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSaveProjectAs.Name = "toolSaveProjectAs";
            this.toolSaveProjectAs.Size = new System.Drawing.Size(28, 47);
            this.toolSaveProjectAs.Text = "Save Project As";
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = global::File.Properties.Resources.layer_add;
            this.toolOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(28, 47);
            this.toolOpen.Text = " Add Layer";
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = global::File.Properties.Resources.zoom_in;
            this.toolZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(28, 47);
            this.toolZoomIn.Text = "Zoom In";
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = global::File.Properties.Resources.zoom_out;
            this.toolZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(28, 47);
            this.toolZoomOut.Text = "Zoom Out";
            // 
            // toolZoomMax
            // 
            this.toolZoomMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomMax.Image = global::File.Properties.Resources.zoom_extent;
            this.toolZoomMax.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolZoomMax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomMax.Name = "toolZoomMax";
            this.toolZoomMax.Size = new System.Drawing.Size(28, 47);
            this.toolZoomMax.Text = "Zoom To Max Extents";
            // 
            // toolZoomToLayer
            // 
            this.toolZoomToLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToLayer.Image = global::File.Properties.Resources.zoom_layer;
            this.toolZoomToLayer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolZoomToLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToLayer.Name = "toolZoomToLayer";
            this.toolZoomToLayer.Size = new System.Drawing.Size(28, 47);
            this.toolZoomToLayer.Text = "Zoom To Layer";
            // 
            // toolPan
            // 
            this.toolPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPan.Image = global::File.Properties.Resources.pan1;
            this.toolPan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPan.Name = "toolPan";
            this.toolPan.Size = new System.Drawing.Size(28, 47);
            this.toolPan.Text = "Pan";
            // 
            // toolSetProjection
            // 
            this.toolSetProjection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSetProjection.Image = global::File.Properties.Resources.crs_change;
            this.toolSetProjection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSetProjection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSetProjection.Name = "toolSetProjection";
            this.toolSetProjection.Size = new System.Drawing.Size(28, 47);
            this.toolSetProjection.Text = "Set coordinate system and projection";
            // 
            // toolLoadData
            // 
            this.toolLoadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLoadData.Image = global::File.Properties.Resources.layer_db_add;
            this.toolLoadData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolLoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoadData.Name = "toolLoadData";
            this.toolLoadData.Size = new System.Drawing.Size(28, 47);
            this.toolLoadData.Text = "Load data to the map";
            // 
            // File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._toolStripLayer);
            this.Name = "File";
            this.Size = new System.Drawing.Size(447, 54);
            this._toolStripLayer.ResumeLayout(false);
            this._toolStripLayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolCloseProject;
        private System.Windows.Forms.ToolStripButton toolLoadProject;
        private System.Windows.Forms.ToolStripButton toolSaveProject;
        private System.Windows.Forms.ToolStripButton toolSaveProjectAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripButton toolZoomMax;
        private System.Windows.Forms.ToolStripButton toolZoomToLayer;
        private System.Windows.Forms.ToolStripButton toolPan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolSetProjection;
        private System.Windows.Forms.ToolStrip _toolStripLayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolLoadData;

    }
}
