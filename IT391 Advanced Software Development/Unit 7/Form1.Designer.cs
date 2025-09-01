
namespace IT391_Crooks_Unit7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMeanGrd = new System.Windows.Forms.Label();
            this.lblMaxGrd = new System.Windows.Forms.Label();
            this.lblMinGrd = new System.Windows.Forms.Label();
            this.txtMeanGrd = new System.Windows.Forms.TextBox();
            this.txtMaxGrd = new System.Windows.Forms.TextBox();
            this.txtMinGrd = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatsHeader = new System.Windows.Forms.Label();
            this.lblRefreshWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMeanGrd
            // 
            this.lblMeanGrd.AutoSize = true;
            this.lblMeanGrd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMeanGrd.Location = new System.Drawing.Point(134, 117);
            this.lblMeanGrd.Name = "lblMeanGrd";
            this.lblMeanGrd.Size = new System.Drawing.Size(173, 28);
            this.lblMeanGrd.TabIndex = 0;
            this.lblMeanGrd.Text = "Mean Grade:";
            // 
            // lblMaxGrd
            // 
            this.lblMaxGrd.AutoSize = true;
            this.lblMaxGrd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxGrd.Location = new System.Drawing.Point(78, 184);
            this.lblMaxGrd.Name = "lblMaxGrd";
            this.lblMaxGrd.Size = new System.Drawing.Size(229, 28);
            this.lblMaxGrd.TabIndex = 1;
            this.lblMaxGrd.Text = "Maximum Grade:";
            // 
            // lblMinGrd
            // 
            this.lblMinGrd.AutoSize = true;
            this.lblMinGrd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinGrd.Location = new System.Drawing.Point(84, 255);
            this.lblMinGrd.Name = "lblMinGrd";
            this.lblMinGrd.Size = new System.Drawing.Size(223, 28);
            this.lblMinGrd.TabIndex = 2;
            this.lblMinGrd.Text = "Minimum Grade:";
            // 
            // txtMeanGrd
            // 
            this.txtMeanGrd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMeanGrd.Location = new System.Drawing.Point(368, 107);
            this.txtMeanGrd.Name = "txtMeanGrd";
            this.txtMeanGrd.ReadOnly = true;
            this.txtMeanGrd.Size = new System.Drawing.Size(307, 43);
            this.txtMeanGrd.TabIndex = 3;
            this.txtMeanGrd.TabStop = false;
            // 
            // txtMaxGrd
            // 
            this.txtMaxGrd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaxGrd.Location = new System.Drawing.Point(368, 178);
            this.txtMaxGrd.Name = "txtMaxGrd";
            this.txtMaxGrd.ReadOnly = true;
            this.txtMaxGrd.Size = new System.Drawing.Size(307, 43);
            this.txtMaxGrd.TabIndex = 4;
            this.txtMaxGrd.TabStop = false;
            // 
            // txtMinGrd
            // 
            this.txtMinGrd.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinGrd.Location = new System.Drawing.Point(368, 249);
            this.txtMinGrd.Name = "txtMinGrd";
            this.txtMinGrd.ReadOnly = true;
            this.txtMinGrd.Size = new System.Drawing.Size(307, 43);
            this.txtMinGrd.TabIndex = 5;
            this.txtMinGrd.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(368, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStatsHeader
            // 
            this.lblStatsHeader.AutoSize = true;
            this.lblStatsHeader.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatsHeader.Location = new System.Drawing.Point(228, 18);
            this.lblStatsHeader.Name = "lblStatsHeader";
            this.lblStatsHeader.Size = new System.Drawing.Size(341, 36);
            this.lblStatsHeader.TabIndex = 7;
            this.lblStatsHeader.Text = "GRADE STATISTICS";
            // 
            // lblRefreshWarning
            // 
            this.lblRefreshWarning.AutoSize = true;
            this.lblRefreshWarning.BackColor = System.Drawing.Color.White;
            this.lblRefreshWarning.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRefreshWarning.Location = new System.Drawing.Point(254, 54);
            this.lblRefreshWarning.Name = "lblRefreshWarning";
            this.lblRefreshWarning.Size = new System.Drawing.Size(289, 22);
            this.lblRefreshWarning.TabIndex = 8;
            this.lblRefreshWarning.Text = "-Data only updates when the program starts-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRefreshWarning);
            this.Controls.Add(this.lblStatsHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtMinGrd);
            this.Controls.Add(this.txtMaxGrd);
            this.Controls.Add(this.txtMeanGrd);
            this.Controls.Add(this.lblMinGrd);
            this.Controls.Add(this.lblMaxGrd);
            this.Controls.Add(this.lblMeanGrd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeanGrd;
        private System.Windows.Forms.Label lblMaxGrd;
        private System.Windows.Forms.Label lblMinGrd;
        private System.Windows.Forms.TextBox txtMeanGrd;
        private System.Windows.Forms.TextBox txtMaxGrd;
        private System.Windows.Forms.TextBox txtMinGrd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatsHeader;
        private System.Windows.Forms.Label lblRefreshWarning;
    }
}

