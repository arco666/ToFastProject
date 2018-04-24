namespace ToFast
{
    partial class Prof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prof));
            this.gridview = new System.Windows.Forms.DataGridView();
            this.pictureboxSetting = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(27, 55);
            this.gridview.Name = "gridview";
            this.gridview.RowTemplate.Height = 30;
            this.gridview.Size = new System.Drawing.Size(667, 514);
            this.gridview.TabIndex = 1;
            // 
            // pictureboxSetting
            // 
            this.pictureboxSetting.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxSetting.Image")));
            this.pictureboxSetting.Location = new System.Drawing.Point(700, 519);
            this.pictureboxSetting.Name = "pictureboxSetting";
            this.pictureboxSetting.Size = new System.Drawing.Size(67, 50);
            this.pictureboxSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxSetting.TabIndex = 2;
            this.pictureboxSetting.TabStop = false;
            // 
            // Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.pictureboxSetting);
            this.Controls.Add(this.gridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prof";
            this.Text = "Prof";
            this.Load += new System.EventHandler(this.Prof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.PictureBox pictureboxSetting;
    }
}