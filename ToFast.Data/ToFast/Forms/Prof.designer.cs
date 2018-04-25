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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prof));
            this.pictureboxSetting = new System.Windows.Forms.PictureBox();
            this.dgvProfContents = new System.Windows.Forms.DataGridView();
            this.questionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionIndexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfContents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.pictureboxSetting.Click += new System.EventHandler(this.pictureboxSetting_Click);
            // 
            // dgvProfContents
            // 
            this.dgvProfContents.AutoGenerateColumns = false;
            this.dgvProfContents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.questionTimeDataGridViewTextBoxColumn,
            this.contextDataGridViewTextBoxColumn});
            this.dgvProfContents.DataSource = this.questionIndexBindingSource1;
            this.dgvProfContents.Location = new System.Drawing.Point(27, 29);
            this.dgvProfContents.Name = "dgvProfContents";
            this.dgvProfContents.RowHeadersVisible = false;
            this.dgvProfContents.RowTemplate.Height = 30;
            this.dgvProfContents.Size = new System.Drawing.Size(667, 540);
            this.dgvProfContents.TabIndex = 3;
            this.dgvProfContents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfContents_CellDoubleClick);
            // 
            // questionViewBindingSource
            // 
            this.questionViewBindingSource.DataSource = typeof(ToFast.Data.QuestionView);
            // 
            // questionIndexBindingSource
            // 
            this.questionIndexBindingSource.DataSource = typeof(ToFast.Data.QuestionIndex);
            // 
            // questionIndexBindingSource1
            // 
            this.questionIndexBindingSource1.DataSource = typeof(ToFast.Data.QuestionIndex);
            // 
            // contextDataGridViewTextBoxColumn
            // 
            this.contextDataGridViewTextBoxColumn.DataPropertyName = "Context";
            this.contextDataGridViewTextBoxColumn.HeaderText = "내용";
            this.contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            // 
            // questionTimeDataGridViewTextBoxColumn
            // 
            this.questionTimeDataGridViewTextBoxColumn.DataPropertyName = "QuestionTime";
            this.questionTimeDataGridViewTextBoxColumn.HeaderText = "시간";
            this.questionTimeDataGridViewTextBoxColumn.Name = "questionTimeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "학생명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            this.questionIdDataGridViewTextBoxColumn.DataPropertyName = "QuestionId";
            this.questionIdDataGridViewTextBoxColumn.HeaderText = "No.";
            this.questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            // 
            // Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.dgvProfContents);
            this.Controls.Add(this.pictureboxSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prof";
            this.Text = "Prof";
            this.Load += new System.EventHandler(this.Prof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfContents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureboxSetting;
        private System.Windows.Forms.BindingSource questionIndexBindingSource;
        private System.Windows.Forms.DataGridView dgvProfContents;
        private System.Windows.Forms.BindingSource questionViewBindingSource;
        private System.Windows.Forms.BindingSource questionIndexBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
    }
}