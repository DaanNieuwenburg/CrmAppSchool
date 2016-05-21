namespace CrmAppSchool.Views.Hoofdmenu
{
    partial class voegGebruikerToeForm
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
            this.voegToeBtn = new System.Windows.Forms.Button();
            this.gebruikersnaamTxb = new System.Windows.Forms.TextBox();
            this.wachtwoordTxb = new System.Windows.Forms.TextBox();
            this.gebruikersnaamLbl = new System.Windows.Forms.Label();
            this.wachtwoordLbl = new System.Windows.Forms.Label();
            this.soortGebruikerCbx = new System.Windows.Forms.ComboBox();
            this.gebruikerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voegToeBtn
            // 
            this.voegToeBtn.Location = new System.Drawing.Point(197, 226);
            this.voegToeBtn.Name = "voegToeBtn";
            this.voegToeBtn.Size = new System.Drawing.Size(75, 23);
            this.voegToeBtn.TabIndex = 0;
            this.voegToeBtn.Text = "Voeg toe";
            this.voegToeBtn.UseVisualStyleBackColor = true;
            this.voegToeBtn.Click += new System.EventHandler(this.voegToeBtn_Click);
            // 
            // gebruikersnaamTxb
            // 
            this.gebruikersnaamTxb.Location = new System.Drawing.Point(172, 114);
            this.gebruikersnaamTxb.Name = "gebruikersnaamTxb";
            this.gebruikersnaamTxb.Size = new System.Drawing.Size(100, 20);
            this.gebruikersnaamTxb.TabIndex = 1;
            // 
            // wachtwoordTxb
            // 
            this.wachtwoordTxb.Location = new System.Drawing.Point(172, 140);
            this.wachtwoordTxb.Name = "wachtwoordTxb";
            this.wachtwoordTxb.Size = new System.Drawing.Size(100, 20);
            this.wachtwoordTxb.TabIndex = 2;
            // 
            // gebruikersnaamLbl
            // 
            this.gebruikersnaamLbl.AutoSize = true;
            this.gebruikersnaamLbl.Location = new System.Drawing.Point(79, 117);
            this.gebruikersnaamLbl.Name = "gebruikersnaamLbl";
            this.gebruikersnaamLbl.Size = new System.Drawing.Size(87, 13);
            this.gebruikersnaamLbl.TabIndex = 3;
            this.gebruikersnaamLbl.Text = "Gebruikersnaam:";
            // 
            // wachtwoordLbl
            // 
            this.wachtwoordLbl.AutoSize = true;
            this.wachtwoordLbl.Location = new System.Drawing.Point(79, 143);
            this.wachtwoordLbl.Name = "wachtwoordLbl";
            this.wachtwoordLbl.Size = new System.Drawing.Size(71, 13);
            this.wachtwoordLbl.TabIndex = 4;
            this.wachtwoordLbl.Text = "Wachtwoord:";
            // 
            // soortGebruikerCbx
            // 
            this.soortGebruikerCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soortGebruikerCbx.FormattingEnabled = true;
            this.soortGebruikerCbx.Items.AddRange(new object[] {
            "Docent",
            "Student"});
            this.soortGebruikerCbx.Location = new System.Drawing.Point(172, 166);
            this.soortGebruikerCbx.Name = "soortGebruikerCbx";
            this.soortGebruikerCbx.Size = new System.Drawing.Size(100, 21);
            this.soortGebruikerCbx.TabIndex = 6;
            // 
            // gebruikerLbl
            // 
            this.gebruikerLbl.AutoSize = true;
            this.gebruikerLbl.Location = new System.Drawing.Point(79, 169);
            this.gebruikerLbl.Name = "gebruikerLbl";
            this.gebruikerLbl.Size = new System.Drawing.Size(82, 13);
            this.gebruikerLbl.TabIndex = 7;
            this.gebruikerLbl.Text = "Soort gebruiker:";
            // 
            // voegGebruikerToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gebruikerLbl);
            this.Controls.Add(this.soortGebruikerCbx);
            this.Controls.Add(this.wachtwoordLbl);
            this.Controls.Add(this.gebruikersnaamLbl);
            this.Controls.Add(this.wachtwoordTxb);
            this.Controls.Add(this.gebruikersnaamTxb);
            this.Controls.Add(this.voegToeBtn);
            this.Name = "voegGebruikerToeForm";
            this.Text = "Voeg gebruiker toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voegToeBtn;
        private System.Windows.Forms.TextBox gebruikersnaamTxb;
        private System.Windows.Forms.TextBox wachtwoordTxb;
        private System.Windows.Forms.Label gebruikersnaamLbl;
        private System.Windows.Forms.Label wachtwoordLbl;
        private System.Windows.Forms.ComboBox soortGebruikerCbx;
        private System.Windows.Forms.Label gebruikerLbl;
    }
}