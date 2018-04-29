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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gulim", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionTime,
            this.Context,
            this.SubjectName,
            this.Checkable});
            this.dataGridView.GridColor = System.Drawing.Color.Violet;
            this.dataGridView.Location = new System.Drawing.Point(11, 21);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(523, 284);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::ToFast.Properties.Resources.TextBox_Color001;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(542, 236);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackgroundImage = global::ToFast.Properties.Resources.TextBox_Color001;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(542, 181);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 51);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(192)))), ((int)(((byte)(220)))));
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.Location = new System.Drawing.Point(2, 319);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(640, 115);
            this.tbInfo.TabIndex = 5;
            // 
            // questionIndexBindingSource
            // 
            this.questionIndexBindingSource.DataMember = "QuestionIndex";
            // 
            // questionIndexBindingSource1
            // 
            this.questionIndexBindingSource1.DataMember = "QuestionIndex";
            // 
            // questionIndexBindingSource2
            // 
            this.questionIndexBindingSource2.DataMember = "QuestionIndex";
            // 
            // QuestionTime
            // 
            this.QuestionTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QuestionTime.Frozen = true;
            this.QuestionTime.HeaderText = "작성시간";
            this.QuestionTime.Name = "QuestionTime";
            this.QuestionTime.ReadOnly = true;
            this.QuestionTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QuestionTime.Width = 130;
            // 
            // Context
            // 
            this.Context.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Context.HeaderText = "내용";
            this.Context.Name = "Context";
            this.Context.ReadOnly = true;
            this.Context.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "과목명";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SubjectName.Width = 70;
            // 
            // Checkable
            // 
            this.Checkable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Checkable.HeaderText = "확인여부";
            this.Checkable.Name = "Checkable";
            this.Checkable.ReadOnly = true;
            this.Checkable.Width = 80;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::ToFast.Properties.Resources.Design_Form_Default_002;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 435);
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

//<<<<<<< HEAD
//        private System.Windows.Forms.DataGridView gridbox;
//        private System.Windows.Forms.Button btnDelete;
//        private System.Windows.Forms.Button btnConfirm;
//        private System.Windows.Forms.TextBox textbox;
//    }
//=======
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
//>>>>>>> sojaex
}