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
			this.toFastDataSet = new ToFast.ToFastDataSet();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.tbInfo = new System.Windows.Forms.TextBox();
			this.studentTableAdapter = new ToFast.ToFastDataSetTableAdapters.StudentTableAdapter();
			this.toFastDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toFastDataSet1 = new ToFast.ToFastDataSet1();
			this.questionIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.questionIndexTableAdapter = new ToFast.ToFastDataSet1TableAdapters.QuestionIndexTableAdapter();
			this.toFastDataSet2 = new ToFast.ToFastDataSet2();
			this.questionIndexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.questionIndexTableAdapter1 = new ToFast.ToFastDataSet2TableAdapters.QuestionIndexTableAdapter();
			this.toFastDataSet3 = new ToFast.ToFastDataSet3();
			this.questionIndexBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.questionIndexTableAdapter2 = new ToFast.ToFastDataSet3TableAdapters.QuestionIndexTableAdapter();
			this.QuestionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Context = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Checkable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet3)).BeginInit();
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
			this.studentBindingSource.DataSource = this.toFastDataSet;
			// 
			// toFastDataSet
			// 
			this.toFastDataSet.DataSetName = "ToFastDataSet";
			this.toFastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			this.studentTableAdapter.ClearBeforeFill = true;
			// 
			// toFastDataSetBindingSource
			// 
			this.toFastDataSetBindingSource.DataSource = this.toFastDataSet;
			this.toFastDataSetBindingSource.Position = 0;
			// 
			// toFastDataSet1
			// 
			this.toFastDataSet1.DataSetName = "ToFastDataSet1";
			this.toFastDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// questionIndexBindingSource
			// 
			this.questionIndexBindingSource.DataMember = "QuestionIndex";
			this.questionIndexBindingSource.DataSource = this.toFastDataSet1;
			// 
			// questionIndexTableAdapter
			// 
			this.questionIndexTableAdapter.ClearBeforeFill = true;
			// 
			// toFastDataSet2
			// 
			this.toFastDataSet2.DataSetName = "ToFastDataSet2";
			this.toFastDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// questionIndexBindingSource1
			// 
			this.questionIndexBindingSource1.DataMember = "QuestionIndex";
			this.questionIndexBindingSource1.DataSource = this.toFastDataSet2;
			// 
			// questionIndexTableAdapter1
			// 
			this.questionIndexTableAdapter1.ClearBeforeFill = true;
			// 
			// toFastDataSet3
			// 
			this.toFastDataSet3.DataSetName = "ToFastDataSet3";
			this.toFastDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// questionIndexBindingSource2
			// 
			this.questionIndexBindingSource2.DataMember = "QuestionIndex";
			this.questionIndexBindingSource2.DataSource = this.toFastDataSet3;
			// 
			// questionIndexTableAdapter2
			// 
			this.questionIndexTableAdapter2.ClearBeforeFill = true;
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
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toFastDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionIndexBindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbInfo;
		private ToFastDataSet toFastDataSet;
		private System.Windows.Forms.BindingSource studentBindingSource;
		private ToFastDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
		private System.Windows.Forms.BindingSource toFastDataSetBindingSource;
		private ToFastDataSet1 toFastDataSet1;
		private System.Windows.Forms.BindingSource questionIndexBindingSource;
		private ToFastDataSet1TableAdapters.QuestionIndexTableAdapter questionIndexTableAdapter;
		private ToFastDataSet2 toFastDataSet2;
		private System.Windows.Forms.BindingSource questionIndexBindingSource1;
		private ToFastDataSet2TableAdapters.QuestionIndexTableAdapter questionIndexTableAdapter1;
		private ToFastDataSet3 toFastDataSet3;
		private System.Windows.Forms.BindingSource questionIndexBindingSource2;
		private ToFastDataSet3TableAdapters.QuestionIndexTableAdapter questionIndexTableAdapter2;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuestionTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Context;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checkable;
	}
}