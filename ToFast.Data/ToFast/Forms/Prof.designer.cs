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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prof));
            this.dgvProfContents = new System.Windows.Forms.DataGridView();
            this.questionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionIndexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bgwWorker = new System.ComponentModel.BackgroundWorker();
            this.pictureboxSetting = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfContents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfContents
            // 
            this.dgvProfContents.AutoGenerateColumns = false;
            this.dgvProfContents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfContents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProfContents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gulim", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfContents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionTimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contextDataGridViewTextBoxColumn});
            this.dgvProfContents.DataSource = this.questionIndexBindingSource1;
            this.dgvProfContents.GridColor = System.Drawing.Color.Pink;
            this.dgvProfContents.Location = new System.Drawing.Point(27, 29);
            this.dgvProfContents.Name = "dgvProfContents";
            this.dgvProfContents.ReadOnly = true;
            this.dgvProfContents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProfContents.RowHeadersVisible = false;
            this.dgvProfContents.RowTemplate.Height = 30;
            this.dgvProfContents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfContents.Size = new System.Drawing.Size(667, 540);
            this.dgvProfContents.TabIndex = 3;
            this.dgvProfContents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfContents_CellDoubleClick);
            // 
            // questionTimeDataGridViewTextBoxColumn
            // 
            this.questionTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.questionTimeDataGridViewTextBoxColumn.DataPropertyName = "QuestionTime";
            this.questionTimeDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.questionTimeDataGridViewTextBoxColumn.Frozen = true;
            this.questionTimeDataGridViewTextBoxColumn.HeaderText = "시간";
            this.questionTimeDataGridViewTextBoxColumn.Name = "questionTimeDataGridViewTextBoxColumn";
            this.questionTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.questionTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 65.41435F;
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "학생명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 70;
            // 
            // contextDataGridViewTextBoxColumn
            // 
            this.contextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contextDataGridViewTextBoxColumn.DataPropertyName = "Context";
            this.contextDataGridViewTextBoxColumn.FillWeight = 82.30141F;
            this.contextDataGridViewTextBoxColumn.HeaderText = "내용";
            this.contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            this.contextDataGridViewTextBoxColumn.ReadOnly = true;
            this.contextDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contextDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // questionIndexBindingSource1
            // 
            this.questionIndexBindingSource1.DataSource = typeof(ToFast.Data.QuestionIndex);
            // 
            // bgwWorker
            // 
            this.bgwWorker.WorkerReportsProgress = true;
            this.bgwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWorker_DoWork);
            this.bgwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwWorker_ProgressChanged);
            // 
            // pictureboxSetting
            // 
            this.pictureboxSetting.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxSetting.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxSetting.Image")));
            this.pictureboxSetting.Location = new System.Drawing.Point(722, 519);
            this.pictureboxSetting.Name = "pictureboxSetting";
            this.pictureboxSetting.Size = new System.Drawing.Size(51, 50);
            this.pictureboxSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxSetting.TabIndex = 2;
            this.pictureboxSetting.TabStop = false;
            this.pictureboxSetting.Click += new System.EventHandler(this.pictureboxSetting_Click);
            // 
            // Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::ToFast.Properties.Resources.Design_Form_Default_002;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.dgvProfContents);
            this.Controls.Add(this.pictureboxSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Prof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prof";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prof_FormClosed);
            this.Load += new System.EventHandler(this.Prof_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfContents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureboxSetting;
        private System.Windows.Forms.DataGridView dgvProfContents;
        private System.Windows.Forms.BindingSource questionIndexBindingSource1;
        private System.ComponentModel.BackgroundWorker bgwWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
    }
}