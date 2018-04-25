namespace ToFast
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.gridbox = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridbox)).BeginInit();
            this.SuspendLayout();
            // 
            // gridbox
            // 
            this.gridbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbox.Location = new System.Drawing.Point(31, 31);
            this.gridbox.Name = "gridbox";
            this.gridbox.RowTemplate.Height = 30;
            this.gridbox.Size = new System.Drawing.Size(525, 393);
            this.gridbox.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(576, 572);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(576, 527);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 27);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(31, 464);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(525, 149);
            this.textbox.TabIndex = 5;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 653);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gridbox);

            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.gridbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridbox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textbox;
    }
}