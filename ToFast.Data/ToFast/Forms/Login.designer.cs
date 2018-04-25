namespace ToFast
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxClass = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passWord = new System.Windows.Forms.TextBox();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(84, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "구 분";
            // 
            // comboboxClass
            // 
            this.comboboxClass.FormattingEnabled = true;
            this.comboboxClass.Items.AddRange(new object[] {
            "교수님용",
            "학생용"});
            this.comboboxClass.Location = new System.Drawing.Point(165, 383);
            this.comboboxClass.Name = "comboboxClass";
            this.comboboxClass.Size = new System.Drawing.Size(100, 26);
            this.comboboxClass.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(271, 422);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 65);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(165, 460);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(100, 28);
            this.passWord.TabIndex = 10;
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(165, 422);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(100, 28);
            this.textboxID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(46, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "비밀 번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(84, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "이 름";
            // 
            // loginPicture
            // 
            this.loginPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginPicture.Image")));
            this.loginPicture.Location = new System.Drawing.Point(49, 53);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(309, 269);
            this.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPicture.TabIndex = 14;
            this.loginPicture.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 550);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboboxClass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);

            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboboxClass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox loginPicture;
    }
}