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
			this.components = new System.ComponentModel.Container();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.tbInfo = new System.Windows.Forms.TextBox();
			this.toFastDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.questionIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.questionIndexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.questionIndexBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.QuestionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Context = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Checkable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionTime,
            this.Context,
            this.SubjectName,
            this.Checkable});
			this.dataGridView.Location = new System.Drawing.Point(22, 21);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 30;
			this.dataGridView.Size = new System.Drawing.Size(512, 262);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// studentBindingSource
			// 
			this.studentBindingSource.DataMember = "Student";
			// 
			// toFastDataSet
			// 
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(538, 381);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(52, 29);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "삭제";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(538, 346);
			this.btnOk.Margin = new System.Windows.Forms.Padding(2);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(52, 31);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "확인";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// tbInfo
			// 
			this.tbInfo.Location = new System.Drawing.Point(22, 309);
			this.tbInfo.Margin = new System.Windows.Forms.Padding(2);
			this.tbInfo.Multiline = true;
			this.tbInfo.Name = "tbInfo";
			this.tbInfo.ReadOnly = true;
			this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbInfo.Size = new System.Drawing.Size(512, 101);
			this.tbInfo.TabIndex = 5;
			// 
			// studentTableAdapter
			// 
			// 
			// toFastDataSetBindingSource
			// 
			this.toFastDataSetBindingSource.Position = 0;
			// 
			// toFastDataSet1
			// 
			// 
			// questionIndexBindingSource
			// 
			this.questionIndexBindingSource.DataMember = "QuestionIndex";
			// 
			// questionIndexTableAdapter
			// 
			// 
			// toFastDataSet2
			// 
			// 
			// questionIndexBindingSource1
			// 
			this.questionIndexBindingSource1.DataMember = "QuestionIndex";
			// 
			// questionIndexBindingSource2
			// 
			this.questionIndexBindingSource2.DataMember = "QuestionIndex";
			// 
			// questionIndexTableAdapter2
			// 
			// 
			// QuestionTime
			// 
			this.QuestionTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.QuestionTime.HeaderText = "작성시간";
			this.QuestionTime.Name = "QuestionTime";
			this.QuestionTime.ReadOnly = true;
			this.QuestionTime.Width = 169;
			// 
			// Context
			// 
			this.Context.HeaderText = "내용";
			this.Context.Name = "Context";
			this.Context.ReadOnly = true;
			// 
			// SubjectName
			// 
			this.SubjectName.HeaderText = "과목명";
			this.SubjectName.Name = "SubjectName";
			this.SubjectName.ReadOnly = true;
			// 
			// Checkable
			// 
			this.Checkable.HeaderText = "확인여부";
			this.Checkable.Name = "Checkable";
			this.Checkable.ReadOnly = true;
			// 
			// History
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 435);
			this.Controls.Add(this.tbInfo);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.dataGridView);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "History";
			this.Text = "History";
			this.Load += new System.EventHandler(this.History_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbInfo;
		private System.Windows.Forms.BindingSource studentBindingSource;
		private System.Windows.Forms.BindingSource toFastDataSetBindingSource;
		private System.Windows.Forms.BindingSource questionIndexBindingSource;
		private System.Windows.Forms.BindingSource questionIndexBindingSource1;
		private System.Windows.Forms.BindingSource questionIndexBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuestionTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Context;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checkable;
	}
}