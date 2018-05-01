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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btSend_Question = new System.Windows.Forms.Button();
            this.ckbAnonymous = new System.Windows.Forms.CheckBox();
            this.btHistrory = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnToFast = new System.Windows.Forms.Button();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbSubject_Select = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Location = new System.Drawing.Point(8, 9);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(381, 218);
            this.txtQuestion.TabIndex = 3;
            // 
            // btSend_Question
            // 
            this.btSend_Question.BackColor = System.Drawing.Color.Transparent;
            this.btSend_Question.BackgroundImage = global::ToFast.Properties.Resources.TextBox_Color001;
            this.btSend_Question.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSend_Question.Location = new System.Drawing.Point(11, 243);
            this.btSend_Question.Margin = new System.Windows.Forms.Padding(2);
            this.btSend_Question.Name = "btSend_Question";
            this.btSend_Question.Size = new System.Drawing.Size(95, 63);
            this.btSend_Question.TabIndex = 4;
            this.btSend_Question.Text = "전송";
            this.btSend_Question.UseMnemonic = false;
            this.btSend_Question.UseVisualStyleBackColor = false;
            this.btSend_Question.Click += new System.EventHandler(this.btSend_Question_Click);
            // 
            // ckbAnonymous
            // 
            this.ckbAnonymous.AutoSize = true;
            this.ckbAnonymous.BackColor = System.Drawing.Color.Transparent;
            this.ckbAnonymous.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckbAnonymous.Location = new System.Drawing.Point(429, 249);
            this.ckbAnonymous.Margin = new System.Windows.Forms.Padding(2);
            this.ckbAnonymous.Name = "ckbAnonymous";
            this.ckbAnonymous.Size = new System.Drawing.Size(48, 16);
            this.ckbAnonymous.TabIndex = 5;
            this.ckbAnonymous.Text = "익명";
            this.ckbAnonymous.UseVisualStyleBackColor = false;
            this.ckbAnonymous.CheckedChanged += new System.EventHandler(this.ckbAnonymous_CheckedChanged);
            // 
            // btHistrory
            // 
            this.btHistrory.BackColor = System.Drawing.Color.Transparent;
            this.btHistrory.BackgroundImage = global::ToFast.Properties.Resources.TextBox_Color001;
            this.btHistrory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHistrory.ForeColor = System.Drawing.Color.Black;
            this.btHistrory.Location = new System.Drawing.Point(405, 134);
            this.btHistrory.Margin = new System.Windows.Forms.Padding(2);
            this.btHistrory.Name = "btHistrory";
            this.btHistrory.Size = new System.Drawing.Size(95, 93);
            this.btHistrory.TabIndex = 6;
            this.btHistrory.Text = "기록 보기";
            this.btHistrory.UseVisualStyleBackColor = false;
            this.btHistrory.Click += new System.EventHandler(this.btHistrory_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbTimer.Location = new System.Drawing.Point(406, 109);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(94, 23);
            this.lbTimer.TabIndex = 7;
            this.lbTimer.Text = "timer";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(ToFast.Data.Subject);
            // 
            // btnToFast
            // 
            this.btnToFast.BackColor = System.Drawing.Color.Transparent;
            this.btnToFast.BackgroundImage = global::ToFast.Properties.Resources.KakaoTalk_20180424_150106837;
            this.btnToFast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToFast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToFast.Location = new System.Drawing.Point(406, 12);
            this.btnToFast.Name = "btnToFast";
            this.btnToFast.Size = new System.Drawing.Size(94, 94);
            this.btnToFast.TabIndex = 9;
            this.btnToFast.UseVisualStyleBackColor = false;
            this.btnToFast.Click += new System.EventHandler(this.btnToFast_Click);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(ToFast.Data.Subject);
            // 
            // cbbSubject_Select
            // 
            this.cbbSubject_Select.AutoCompleteCustomSource.AddRange(new string[] {
            "c#",
            "JAVA"});
            this.cbbSubject_Select.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbbSubject_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbSubject_Select.Font = new System.Drawing.Font("GulimChe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbbSubject_Select.FormattingEnabled = true;
            this.cbbSubject_Select.Location = new System.Drawing.Point(262, 247);
            this.cbbSubject_Select.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSubject_Select.Name = "cbbSubject_Select";
            this.cbbSubject_Select.Size = new System.Drawing.Size(127, 20);
            this.cbbSubject_Select.TabIndex = 10;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ToFast.Properties.Resources.Design_Form_Default_002;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 328);
            this.Controls.Add(this.cbbSubject_Select);
            this.Controls.Add(this.btnToFast);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btHistrory);
            this.Controls.Add(this.ckbAnonymous);
            this.Controls.Add(this.btSend_Question);
            this.Controls.Add(this.txtQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btSend_Question;
        private System.Windows.Forms.CheckBox ckbAnonymous;
        private System.Windows.Forms.Button btHistrory;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.Button btnToFast;
        private System.Windows.Forms.ComboBox cbbSubject_Select;
        //>>>>>>> jky수정본1
    }
}