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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.picture = new System.Windows.Forms.PictureBox();
            this.textbox = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkboxAnonymous = new System.Windows.Forms.CheckBox();
            this.btnViewHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(537, 13);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(79, 65);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(13, 13);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(501, 280);
            this.textbox.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(537, 244);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 49);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // checkboxAnonymous
            // 
            this.checkboxAnonymous.AutoSize = true;
            this.checkboxAnonymous.Location = new System.Drawing.Point(537, 201);
            this.checkboxAnonymous.Name = "checkboxAnonymous";
            this.checkboxAnonymous.Size = new System.Drawing.Size(70, 22);
            this.checkboxAnonymous.TabIndex = 5;
            this.checkboxAnonymous.Text = "익명";
            this.checkboxAnonymous.UseVisualStyleBackColor = true;
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(526, 87);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(101, 39);
            this.btnViewHistory.TabIndex = 6;
            this.btnViewHistory.Text = "기록 보기";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 315);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.checkboxAnonymous);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.picture);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox checkboxAnonymous;
        private System.Windows.Forms.Button btnViewHistory;
    }
}