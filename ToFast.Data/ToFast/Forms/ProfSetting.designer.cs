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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfSetting));
            this.pictureboxIcon = new System.Windows.Forms.PictureBox();
            this.Limitation = new System.Windows.Forms.TextBox();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTimeSetting = new System.Windows.Forms.ComboBox();
            this.btnInitialization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxIcon
            // 
            this.pictureboxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxIcon.Image")));
            this.pictureboxIcon.Location = new System.Drawing.Point(30, 39);
            this.pictureboxIcon.Name = "pictureboxIcon";
            this.pictureboxIcon.Size = new System.Drawing.Size(82, 83);
            this.pictureboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxIcon.TabIndex = 0;
            this.pictureboxIcon.TabStop = false;
            // 
            // Limitation
            // 
            this.Limitation.Location = new System.Drawing.Point(134, 39);
            this.Limitation.Name = "Limitation";
            this.Limitation.Size = new System.Drawing.Size(100, 28);
            this.Limitation.TabIndex = 2;
            // 
            // textboxTotal
            // 
            this.textboxTotal.Location = new System.Drawing.Point(265, 39);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.Size = new System.Drawing.Size(100, 28);
            this.textboxTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "시간 설정";
            // 
            // comboBoxTimeSetting
            // 
            this.comboBoxTimeSetting.FormattingEnabled = true;
            this.comboBoxTimeSetting.Location = new System.Drawing.Point(244, 80);
            this.comboBoxTimeSetting.Name = "comboBoxTimeSetting";
            this.comboBoxTimeSetting.Size = new System.Drawing.Size(121, 26);
            this.comboBoxTimeSetting.TabIndex = 6;
            // 
            // btnInitialization
            // 
            this.btnInitialization.Location = new System.Drawing.Point(134, 160);
            this.btnInitialization.Name = "btnInitialization";
            this.btnInitialization.Size = new System.Drawing.Size(130, 30);
            this.btnInitialization.TabIndex = 9;
            this.btnInitialization.Text = "위치 초기화";
            this.btnInitialization.UseVisualStyleBackColor = true;
            // 
            // ProfSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 213);
            this.Controls.Add(this.btnInitialization);
            this.Controls.Add(this.comboBoxTimeSetting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxTotal);
            this.Controls.Add(this.Limitation);
            this.Controls.Add(this.pictureboxIcon);

            this.Name = "ProfSetting";
            this.Text = "ProfSetting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxIcon;
        private System.Windows.Forms.TextBox Limitation;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTimeSetting;
        private System.Windows.Forms.Button btnInitialization;
    }
}