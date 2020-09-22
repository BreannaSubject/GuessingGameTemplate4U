namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.orderLabel1 = new System.Windows.Forms.Label();
            this.orderLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Snow;
            this.titleLabel.Location = new System.Drawing.Point(13, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(91, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Results";
            // 
            // guessLabel
            // 
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLabel.ForeColor = System.Drawing.Color.Snow;
            this.guessLabel.Location = new System.Drawing.Point(13, 48);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(219, 18);
            this.guessLabel.TabIndex = 1;
            this.guessLabel.Text = "Guesses Made: ";
            // 
            // orderLabel1
            // 
            this.orderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel1.ForeColor = System.Drawing.Color.Snow;
            this.orderLabel1.Location = new System.Drawing.Point(15, 82);
            this.orderLabel1.Name = "orderLabel1";
            this.orderLabel1.Size = new System.Drawing.Size(255, 85);
            this.orderLabel1.TabIndex = 2;
            this.orderLabel1.Text = "Original Order: ";
            // 
            // orderLabel2
            // 
            this.orderLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel2.ForeColor = System.Drawing.Color.Snow;
            this.orderLabel2.Location = new System.Drawing.Point(15, 192);
            this.orderLabel2.Name = "orderLabel2";
            this.orderLabel2.Size = new System.Drawing.Size(255, 85);
            this.orderLabel2.TabIndex = 3;
            this.orderLabel2.Text = "Sorted Order: ";
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.orderLabel2);
            this.Controls.Add(this.orderLabel1);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Label orderLabel1;
        private System.Windows.Forms.Label orderLabel2;
    }
}
