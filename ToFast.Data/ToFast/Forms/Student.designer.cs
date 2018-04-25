namespace ToFast
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.pbtnToFast = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btSend_Question = new System.Windows.Forms.Button();
            this.ckbAnonymous = new System.Windows.Forms.CheckBox();
            this.btHistrory = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.cbbSubject_Select = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbtnToFast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbtnToFast
            // 
            this.pbtnToFast.Image = ((System.Drawing.Image)(resources.GetObject("pbtnToFast.Image")));
            this.pbtnToFast.Location = new System.Drawing.Point(376, 9);
            this.pbtnToFast.Margin = new System.Windows.Forms.Padding(2);
            this.pbtnToFast.Name = "pbtnToFast";
            this.pbtnToFast.Size = new System.Drawing.Size(55, 43);
            this.pbtnToFast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtnToFast.TabIndex = 2;
            this.pbtnToFast.TabStop = false;
            this.pbtnToFast.Click += new System.EventHandler(this.pbtnToFast_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(8, 9);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(352, 188);
            this.txtQuestion.TabIndex = 3;
            // 
            // btSend_Question
            // 
            this.btSend_Question.Location = new System.Drawing.Point(376, 163);
            this.btSend_Question.Margin = new System.Windows.Forms.Padding(2);
            this.btSend_Question.Name = "btSend_Question";
            this.btSend_Question.Size = new System.Drawing.Size(52, 33);
            this.btSend_Question.TabIndex = 4;
            this.btSend_Question.Text = "전송";
            this.btSend_Question.UseVisualStyleBackColor = true;
            this.btSend_Question.Click += new System.EventHandler(this.btSend_Question_Click);
            // 
            // ckbAnonymous
            // 
            this.ckbAnonymous.AutoSize = true;
            this.ckbAnonymous.Location = new System.Drawing.Point(376, 143);
            this.ckbAnonymous.Margin = new System.Windows.Forms.Padding(2);
            this.ckbAnonymous.Name = "ckbAnonymous";
            this.ckbAnonymous.Size = new System.Drawing.Size(48, 16);
            this.ckbAnonymous.TabIndex = 5;
            this.ckbAnonymous.Text = "익명";
            this.ckbAnonymous.UseVisualStyleBackColor = true;
            this.ckbAnonymous.CheckedChanged += new System.EventHandler(this.ckbAnonymous_CheckedChanged);
            // 
            // btHistrory
            // 
            this.btHistrory.Location = new System.Drawing.Point(367, 83);
            this.btHistrory.Margin = new System.Windows.Forms.Padding(2);
            this.btHistrory.Name = "btHistrory";
            this.btHistrory.Size = new System.Drawing.Size(71, 26);
            this.btHistrory.TabIndex = 6;
            this.btHistrory.Text = "기록 보기";
            this.btHistrory.UseVisualStyleBackColor = true;
            this.btHistrory.Click += new System.EventHandler(this.btHistrory_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.Location = new System.Drawing.Point(365, 58);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(71, 23);
            this.lbTimer.TabIndex = 7;
            this.lbTimer.Text = "timer";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSubject_Select
            // 
            this.cbbSubject_Select.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjectBindingSource1, "SubjectName", true));
            this.cbbSubject_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject_Select.FormattingEnabled = true;
            this.cbbSubject_Select.Location = new System.Drawing.Point(367, 118);
            this.cbbSubject_Select.Name = "cbbSubject_Select";
            this.cbbSubject_Select.Size = new System.Drawing.Size(69, 20);
            this.cbbSubject_Select.TabIndex = 8;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(ToFast.Data.Subject);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(ToFast.Data.Subject);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 210);
            this.Controls.Add(this.cbbSubject_Select);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btHistrory);
            this.Controls.Add(this.ckbAnonymous);
            this.Controls.Add(this.btSend_Question);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.pbtnToFast);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbtnToFast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbtnToFast;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btSend_Question;
        private System.Windows.Forms.CheckBox ckbAnonymous;
        private System.Windows.Forms.Button btHistrory;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.ComboBox cbbSubject_Select;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
    }
}