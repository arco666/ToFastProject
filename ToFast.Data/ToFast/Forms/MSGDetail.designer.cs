namespace ToFast
{
    partial class MSGDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSGDetail));
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbEvaluation = new System.Windows.Forms.GroupBox();
            this.radiobtnBad = new System.Windows.Forms.RadioButton();
            this.radiobtnSoso = new System.Windows.Forms.RadioButton();
            this.radiobtnGood = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.gbEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(27, 31);
            this.gridview.Name = "gridview";
            this.gridview.RowTemplate.Height = 30;
            this.gridview.Size = new System.Drawing.Size(546, 391);
            this.gridview.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(599, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저 장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(599, 73);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 36);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "확 인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // gbEvaluation
            // 
            this.gbEvaluation.Controls.Add(this.radiobtnBad);
            this.gbEvaluation.Controls.Add(this.radiobtnSoso);
            this.gbEvaluation.Controls.Add(this.radiobtnGood);
            this.gbEvaluation.Location = new System.Drawing.Point(599, 276);
            this.gbEvaluation.Name = "gbEvaluation";
            this.gbEvaluation.Size = new System.Drawing.Size(189, 134);
            this.gbEvaluation.TabIndex = 8;
            this.gbEvaluation.TabStop = false;
            this.gbEvaluation.Text = "평 가";
            // 
            // radiobtnBad
            // 
            this.radiobtnBad.AutoSize = true;
            this.radiobtnBad.Location = new System.Drawing.Point(7, 97);
            this.radiobtnBad.Name = "radiobtnBad";
            this.radiobtnBad.Size = new System.Drawing.Size(147, 22);
            this.radiobtnBad.TabIndex = 3;
            this.radiobtnBad.TabStop = true;
            this.radiobtnBad.Text = "모욕감 스튜핏";
            this.radiobtnBad.UseVisualStyleBackColor = true;
            // 
            // radiobtnSoso
            // 
            this.radiobtnSoso.AutoSize = true;
            this.radiobtnSoso.Location = new System.Drawing.Point(7, 69);
            this.radiobtnSoso.Name = "radiobtnSoso";
            this.radiobtnSoso.Size = new System.Drawing.Size(57, 22);
            this.radiobtnSoso.TabIndex = 2;
            this.radiobtnSoso.TabStop = true;
            this.radiobtnSoso.Text = "네.";
            this.radiobtnSoso.UseVisualStyleBackColor = true;
            // 
            // radiobtnGood
            // 
            this.radiobtnGood.AutoSize = true;
            this.radiobtnGood.Location = new System.Drawing.Point(6, 41);
            this.radiobtnGood.Name = "radiobtnGood";
            this.radiobtnGood.Size = new System.Drawing.Size(117, 22);
            this.radiobtnGood.TabIndex = 1;
            this.radiobtnGood.TabStop = true;
            this.radiobtnGood.Text = "좋은 질문!";
            this.radiobtnGood.UseVisualStyleBackColor = true;
            // 
            // MSGDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEvaluation);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSGDetail";
            this.Text = "MSGDetail";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.gbEvaluation.ResumeLayout(false);
            this.gbEvaluation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbEvaluation;
        private System.Windows.Forms.RadioButton radiobtnBad;
        private System.Windows.Forms.RadioButton radiobtnSoso;
        private System.Windows.Forms.RadioButton radiobtnGood;
    }
}