namespace CrmAppSchool.Views.Gebruikers
{
    partial class BewerkGebruikerForm
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
            this.veranderBtn = new System.Windows.Forms.Button();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.nieuwWachtwoordTxb = new System.Windows.Forms.TextBox();
            this.wachtwoordTitelLbl = new System.Windows.Forms.Label();
            this.verwijderBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // veranderBtn
            // 
            this.veranderBtn.Location = new System.Drawing.Point(71, 92);
            this.veranderBtn.Name = "veranderBtn";
            this.veranderBtn.Size = new System.Drawing.Size(75, 23);
            this.veranderBtn.TabIndex = 0;
            this.veranderBtn.Text = "Verander";
            this.veranderBtn.UseVisualStyleBackColor = true;
            this.veranderBtn.Click += new System.EventHandler(this.veranderBtn_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-80, -3);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(620, 50);
            this.pbHeader.TabIndex = 13;
            this.pbHeader.TabStop = false;
            // 
            // nieuwWachtwoordTxb
            // 
            this.nieuwWachtwoordTxb.Location = new System.Drawing.Point(71, 66);
            this.nieuwWachtwoordTxb.Name = "nieuwWachtwoordTxb";
            this.nieuwWachtwoordTxb.Size = new System.Drawing.Size(100, 20);
            this.nieuwWachtwoordTxb.TabIndex = 14;
            this.nieuwWachtwoordTxb.UseSystemPasswordChar = true;
            // 
            // wachtwoordTitelLbl
            // 
            this.wachtwoordTitelLbl.AutoSize = true;
            this.wachtwoordTitelLbl.Location = new System.Drawing.Point(68, 50);
            this.wachtwoordTitelLbl.Name = "wachtwoordTitelLbl";
            this.wachtwoordTitelLbl.Size = new System.Drawing.Size(111, 13);
            this.wachtwoordTitelLbl.TabIndex = 15;
            this.wachtwoordTitelLbl.Text = "Verander wachtwoord";
            // 
            // verwijderBtn
            // 
            this.verwijderBtn.Location = new System.Drawing.Point(71, 205);
            this.verwijderBtn.Name = "verwijderBtn";
            this.verwijderBtn.Size = new System.Drawing.Size(75, 23);
            this.verwijderBtn.TabIndex = 16;
            this.verwijderBtn.Text = "Verwijder";
            this.verwijderBtn.UseVisualStyleBackColor = true;
            this.verwijderBtn.Click += new System.EventHandler(this.verwijderBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(71, 235);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 17;
            this.errorLbl.Visible = false;
            // 
            // BewerkGebruikerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.verwijderBtn);
            this.Controls.Add(this.wachtwoordTitelLbl);
            this.Controls.Add(this.nieuwWachtwoordTxb);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.veranderBtn);
            this.Name = "BewerkGebruikerForm";
            this.Text = "BewerkGebruikerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button veranderBtn;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.TextBox nieuwWachtwoordTxb;
        private System.Windows.Forms.Label wachtwoordTitelLbl;
        private System.Windows.Forms.Button verwijderBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}