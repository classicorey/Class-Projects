
namespace IT391_Crooks_Unit8
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
            lblTitle = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblZipCode = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtState = new System.Windows.Forms.TextBox();
            txtZipCode = new System.Windows.Forms.TextBox();
            btnEnter = new System.Windows.Forms.Button();
            txtInputMessage = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cbxPin = new System.Windows.Forms.CheckBox();
            cbxTerrain = new System.Windows.Forms.CheckBox();
            cbxSatellite = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Corbel", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(243, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(307, 58);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enter Address";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAddress.Location = new System.Drawing.Point(74, 148);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(121, 35);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCity.Location = new System.Drawing.Point(124, 199);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(71, 35);
            lblCity.TabIndex = 2;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblState.Location = new System.Drawing.Point(30, 250);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(165, 35);
            lblState.TabIndex = 3;
            lblState.Text = "State Initial:";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblZipCode.Location = new System.Drawing.Point(66, 300);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new System.Drawing.Size(129, 35);
            lblZipCode.TabIndex = 4;
            lblZipCode.Text = "Zip Code:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(236, 148);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(512, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(236, 206);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(512, 27);
            txtCity.TabIndex = 6;
            // 
            // txtState
            // 
            txtState.Location = new System.Drawing.Point(236, 258);
            txtState.Name = "txtState";
            txtState.Size = new System.Drawing.Size(512, 27);
            txtState.TabIndex = 7;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new System.Drawing.Point(236, 307);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new System.Drawing.Size(512, 27);
            txtZipCode.TabIndex = 8;
            // 
            // btnEnter
            // 
            btnEnter.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEnter.Location = new System.Drawing.Point(321, 720);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new System.Drawing.Size(165, 43);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Open Maps";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtInputMessage
            // 
            txtInputMessage.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtInputMessage.ForeColor = System.Drawing.Color.Black;
            txtInputMessage.Location = new System.Drawing.Point(124, 543);
            txtInputMessage.Multiline = true;
            txtInputMessage.Name = "txtInputMessage";
            txtInputMessage.ReadOnly = true;
            txtInputMessage.Size = new System.Drawing.Size(571, 171);
            txtInputMessage.TabIndex = 10;
            txtInputMessage.Text = "Click \"Open Maps\" to submit the above information to Google Maps in your default web browser.";
            txtInputMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 396);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(539, 35);
            label1.TabIndex = 11;
            label1.Text = "Center the address above, and display it as:";
            // 
            // cbxPin
            // 
            cbxPin.AutoSize = true;
            cbxPin.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxPin.Location = new System.Drawing.Point(48, 430);
            cbxPin.Name = "cbxPin";
            cbxPin.Size = new System.Drawing.Size(99, 39);
            cbxPin.TabIndex = 14;
            cbxPin.Text = "A Pin";
            cbxPin.UseVisualStyleBackColor = true;
            cbxPin.CheckedChanged += cbxPin_CheckedChanged;
            // 
            // cbxTerrain
            // 
            cbxTerrain.AutoSize = true;
            cbxTerrain.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxTerrain.Location = new System.Drawing.Point(160, 430);
            cbxTerrain.Name = "cbxTerrain";
            cbxTerrain.Size = new System.Drawing.Size(326, 39);
            cbxTerrain.TabIndex = 15;
            cbxTerrain.Text = "A Terrain representation.";
            cbxTerrain.UseVisualStyleBackColor = true;
            cbxTerrain.CheckedChanged += cbxTerrain_CheckedChanged;
            // 
            // cbxSatellite
            // 
            cbxSatellite.AutoSize = true;
            cbxSatellite.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbxSatellite.Location = new System.Drawing.Point(504, 430);
            cbxSatellite.Name = "cbxSatellite";
            cbxSatellite.Size = new System.Drawing.Size(244, 39);
            cbxSatellite.TabIndex = 16;
            cbxSatellite.Text = "A Satellite Image.";
            cbxSatellite.UseVisualStyleBackColor = true;
            cbxSatellite.CheckedChanged += cbxSatellite_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 829);
            Controls.Add(cbxSatellite);
            Controls.Add(cbxTerrain);
            Controls.Add(cbxPin);
            Controls.Add(label1);
            Controls.Add(txtInputMessage);
            Controls.Add(btnEnter);
            Controls.Add(txtZipCode);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(lblZipCode);
            Controls.Add(lblState);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Address Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtInputMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxPin;
        private System.Windows.Forms.CheckBox cbxTerrain;
        private System.Windows.Forms.CheckBox cbxSatellite;
    }
}

