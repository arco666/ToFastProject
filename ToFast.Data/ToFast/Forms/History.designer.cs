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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toFastDataSet = new ToFast.ToFastDataSet();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionTime,
            this.Context,
            this.SubjectName,
            this.Checkable});
			this.dataGridView1.Location = new System.Drawing.Point(22, 21);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 30;
			this.dataGridView1.Size = new System.Drawing.Size(437, 262);
			this.dataGridView1.TabIndex = 0;
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(463, 381);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 29);
			this.button1.TabIndex = 2;
			this.button1.Text = "삭제";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(463, 337);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(52, 31);
			this.button3.TabIndex = 4;
			this.button3.Text = "확인";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(22, 309);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(437, 101);
			this.textBox1.TabIndex = 5;
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
			this.QuestionTime.HeaderText = "작성시간";
			this.QuestionTime.Name = "QuestionTime";
			this.QuestionTime.ReadOnly = true;
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
			this.ClientSize = new System.Drawing.Size(533, 435);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "History";
			this.Text = "History";
			this.Load += new System.EventHandler(this.History_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
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