namespace WindowsFormsApplication1
{
    partial class Loading
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
            this.labelAnalyzing = new System.Windows.Forms.Label();
            this.labelAnalyzingCurrent = new System.Windows.Forms.Label();
            this.labelAnalyzingPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAnalyzing
            // 
            this.labelAnalyzing.AutoSize = true;
            this.labelAnalyzing.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalyzing.Location = new System.Drawing.Point(46, 61);
            this.labelAnalyzing.Name = "labelAnalyzing";
            this.labelAnalyzing.Size = new System.Drawing.Size(124, 29);
            this.labelAnalyzing.TabIndex = 0;
            this.labelAnalyzing.Text = "Analyzing";
            // 
            // labelAnalyzingCurrent
            // 
            this.labelAnalyzingCurrent.AutoSize = true;
            this.labelAnalyzingCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalyzingCurrent.Location = new System.Drawing.Point(47, 90);
            this.labelAnalyzingCurrent.Name = "labelAnalyzingCurrent";
            this.labelAnalyzingCurrent.Size = new System.Drawing.Size(0, 20);
            this.labelAnalyzingCurrent.TabIndex = 1;
            this.labelAnalyzingCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAnalyzingPercentage
            // 
            this.labelAnalyzingPercentage.AutoSize = true;
            this.labelAnalyzingPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalyzingPercentage.Location = new System.Drawing.Point(185, 66);
            this.labelAnalyzingPercentage.Name = "labelAnalyzingPercentage";
            this.labelAnalyzingPercentage.Size = new System.Drawing.Size(35, 24);
            this.labelAnalyzingPercentage.TabIndex = 2;
            this.labelAnalyzingPercentage.Text = "0%";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.labelAnalyzingPercentage);
            this.Controls.Add(this.labelAnalyzingCurrent);
            this.Controls.Add(this.labelAnalyzing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnalyzing;
        private System.Windows.Forms.Label labelAnalyzingCurrent;
        private System.Windows.Forms.Label labelAnalyzingPercentage;
    }
}