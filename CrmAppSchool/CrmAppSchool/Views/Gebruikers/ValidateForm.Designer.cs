namespace CrmAppSchool.Views.Gebruikers
{
    partial class ValidateForm
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
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Location = new System.Drawing.Point(34, 109);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleer.TabIndex = 1;
            this.btnAnnuleer.Text = "Annuleer";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(176, 109);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(12, 18);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(287, 28);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "Om de veiligheid van de gebruikers te waarborgen vragen\r\nwij u nogmaals uw wachtw" +
    "oord in te voeren.";
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(34, 71);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(217, 20);
            this.tbWachtwoord.TabIndex = 3;
            // 
            // ValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 177);
            this.ControlBox = false;
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuleer);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ValidateForm";
            this.Text = "ValidateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbWachtwoord;
    }
}