namespace Participation4_JexJaacob
{
    partial class LandingForm
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
            this.BtnLocalPhoneNumbers = new System.Windows.Forms.Button();
            this.BtnImportedPhoneNumbers = new System.Windows.Forms.Button();
            this.BtnOnlinePhoneNumbers = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLocalPhoneNumbers
            // 
            this.BtnLocalPhoneNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocalPhoneNumbers.Location = new System.Drawing.Point(63, 87);
            this.BtnLocalPhoneNumbers.Name = "BtnLocalPhoneNumbers";
            this.BtnLocalPhoneNumbers.Size = new System.Drawing.Size(246, 92);
            this.BtnLocalPhoneNumbers.TabIndex = 0;
            this.BtnLocalPhoneNumbers.Text = "Local Phone Numbers";
            this.BtnLocalPhoneNumbers.UseVisualStyleBackColor = true;
            this.BtnLocalPhoneNumbers.Click += new System.EventHandler(this.BtnLocalPhoneNumbers_Click);
            // 
            // BtnImportedPhoneNumbers
            // 
            this.BtnImportedPhoneNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportedPhoneNumbers.Location = new System.Drawing.Point(468, 87);
            this.BtnImportedPhoneNumbers.Name = "BtnImportedPhoneNumbers";
            this.BtnImportedPhoneNumbers.Size = new System.Drawing.Size(246, 92);
            this.BtnImportedPhoneNumbers.TabIndex = 0;
            this.BtnImportedPhoneNumbers.Text = "Imported Phone Numbers";
            this.BtnImportedPhoneNumbers.UseVisualStyleBackColor = true;
            this.BtnImportedPhoneNumbers.Click += new System.EventHandler(this.BtnImportedPhoneNumbers_Click);
            // 
            // BtnOnlinePhoneNumbers
            // 
            this.BtnOnlinePhoneNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnlinePhoneNumbers.Location = new System.Drawing.Point(63, 250);
            this.BtnOnlinePhoneNumbers.Name = "BtnOnlinePhoneNumbers";
            this.BtnOnlinePhoneNumbers.Size = new System.Drawing.Size(246, 92);
            this.BtnOnlinePhoneNumbers.TabIndex = 0;
            this.BtnOnlinePhoneNumbers.Text = "Online Phone Numbers";
            this.BtnOnlinePhoneNumbers.UseVisualStyleBackColor = true;
            this.BtnOnlinePhoneNumbers.Click += new System.EventHandler(this.BtnOnlinePhoneNumbers_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(468, 250);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(246, 92);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnImportedPhoneNumbers);
            this.Controls.Add(this.BtnOnlinePhoneNumbers);
            this.Controls.Add(this.BtnLocalPhoneNumbers);
            this.Name = "LandingForm";
            this.Text = "Landing Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLocalPhoneNumbers;
        private System.Windows.Forms.Button BtnImportedPhoneNumbers;
        private System.Windows.Forms.Button BtnOnlinePhoneNumbers;
        private System.Windows.Forms.Button BtnClose;
    }
}

