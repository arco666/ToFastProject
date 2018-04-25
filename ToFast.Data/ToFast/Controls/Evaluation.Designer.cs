namespace ToFast.Controls
{
    partial class Evaluation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbEvaluation = new System.Windows.Forms.GroupBox();
            this.btnBad = new System.Windows.Forms.RadioButton();
            this.btnNomal = new System.Windows.Forms.RadioButton();
            this.btnGood = new System.Windows.Forms.RadioButton();
            this.gbEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEvaluation
            // 
            this.gbEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEvaluation.AutoSize = true;
            this.gbEvaluation.Controls.Add(this.btnBad);
            this.gbEvaluation.Controls.Add(this.btnNomal);
            this.gbEvaluation.Controls.Add(this.btnGood);
            this.gbEvaluation.Location = new System.Drawing.Point(3, 3);
            this.gbEvaluation.Name = "gbEvaluation";
            this.gbEvaluation.Size = new System.Drawing.Size(189, 146);
            this.gbEvaluation.TabIndex = 9;
            this.gbEvaluation.TabStop = false;
            this.gbEvaluation.Text = "평 가";
            // 
            // btnBad
            // 
            this.btnBad.AutoSize = true;
            this.btnBad.Location = new System.Drawing.Point(6, 97);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(147, 22);
            this.btnBad.TabIndex = 3;
            this.btnBad.TabStop = true;
            this.btnBad.Text = "모욕감 스튜핏";
            this.btnBad.UseVisualStyleBackColor = true;
            this.btnBad.CheckedChanged += new System.EventHandler(this.Evaluation_Click);
            // 
            // btnNomal
            // 
            this.btnNomal.AutoSize = true;
            this.btnNomal.Location = new System.Drawing.Point(6, 69);
            this.btnNomal.Name = "btnNomal";
            this.btnNomal.Size = new System.Drawing.Size(123, 22);
            this.btnNomal.TabIndex = 2;
            this.btnNomal.TabStop = true;
            this.btnNomal.Text = "예컨데, 네.";
            this.btnNomal.UseVisualStyleBackColor = true;
            this.btnNomal.CheckedChanged += new System.EventHandler(this.Evaluation_Click);
            // 
            // btnGood
            // 
            this.btnGood.AutoSize = true;
            this.btnGood.Location = new System.Drawing.Point(6, 41);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(159, 22);
            this.btnGood.TabIndex = 1;
            this.btnGood.TabStop = true;
            this.btnGood.Text = "아주 좋은 질문!";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.CheckedChanged += new System.EventHandler(this.Evaluation_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gbEvaluation);
            this.Name = "Evaluation";
            this.Size = new System.Drawing.Size(195, 155);
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.Click += new System.EventHandler(this.Evaluation_Click);
            this.gbEvaluation.ResumeLayout(false);
            this.gbEvaluation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEvaluation;
        private System.Windows.Forms.RadioButton btnBad;
        private System.Windows.Forms.RadioButton btnNomal;
        private System.Windows.Forms.RadioButton btnGood;
    }
}
