namespace ToFast
{
    partial class ProfSetting
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbStudentLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlarm = new System.Windows.Forms.CheckBox();
            this.cbMute = new System.Windows.Forms.CheckBox();
            this.btnLocReset = new System.Windows.Forms.Button();
            this.lbCurAndTotal = new System.Windows.Forms.Label();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxIcon
            // 
            this.pictureBox1.Image = global::ToFast.Properties.Resources.KakaoTalk_20180424_150106837;
            this.pictureBox1.Location = new System.Drawing.Point(31, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbStudentLimit
            // 
            this.tbStudentLimit.Location = new System.Drawing.Point(94, 26);
            this.tbStudentLimit.Margin = new System.Windows.Forms.Padding(2);
            this.tbStudentLimit.Name = "tbStudentLimit";
            this.tbStudentLimit.Size = new System.Drawing.Size(71, 21);
            this.tbStudentLimit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "시간 설정";
            // 
            // cbAlarm
            // 
            this.cbAlarm.AutoSize = true;
            this.cbAlarm.Location = new System.Drawing.Point(94, 83);
            this.cbAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(88, 16);
            this.cbAlarm.TabIndex = 7;
            this.cbAlarm.Text = "메시지 표시";
            this.cbAlarm.UseVisualStyleBackColor = true;
            // 
            // cbMute
            // 
            this.cbMute.AutoSize = true;
            this.cbMute.Location = new System.Drawing.Point(94, 105);
            this.cbMute.Margin = new System.Windows.Forms.Padding(2);
            this.cbMute.Name = "cbMute";
            this.cbMute.Size = new System.Drawing.Size(60, 16);
            this.cbMute.TabIndex = 8;
            this.cbMute.Text = "음소거";
            this.cbMute.UseVisualStyleBackColor = true;
            // 
            // btnLocReset
            // 
            this.btnLocReset.Location = new System.Drawing.Point(94, 126);
            this.btnLocReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocReset.Name = "btnLocReset";
            this.btnLocReset.Size = new System.Drawing.Size(91, 20);
            this.btnLocReset.TabIndex = 9;
            this.btnLocReset.Text = "위치 초기화";
            this.btnLocReset.UseVisualStyleBackColor = true;
            this.btnLocReset.Click += new System.EventHandler(this.btnLocReset_Click);
            // 
            // lbCurAndTotal
            // 
            this.lbCurAndTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurAndTotal.Location = new System.Drawing.Point(187, 26);
            this.lbCurAndTotal.Name = "lbCurAndTotal";
            this.lbCurAndTotal.Size = new System.Drawing.Size(70, 23);
            this.lbCurAndTotal.TabIndex = 10;
            this.lbCurAndTotal.Text = "15(총 30)";
            this.lbCurAndTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(187, 53);
            this.numTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(70, 21);
            this.numTime.TabIndex = 11;
            this.numTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTime.ValueChanged += new System.EventHandler(this.numTime_ValueChanged);
            // 
            // ProfSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 176);
            this.Controls.Add(this.numTime);
            this.Controls.Add(this.lbCurAndTotal);
            this.Controls.Add(this.btnLocReset);
            this.Controls.Add(this.cbMute);
            this.Controls.Add(this.cbAlarm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStudentLimit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfSetting";
            this.Text = "ProfSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfSetting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbStudentLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAlarm;
        private System.Windows.Forms.CheckBox cbMute;
        private System.Windows.Forms.Button btnLocReset;
        private System.Windows.Forms.Label lbCurAndTotal;
        private System.Windows.Forms.NumericUpDown numTime;
    }
}