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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voegGebruikerToeForm));
            this.voegToeBtn = new System.Windows.Forms.Button();
            this.gebruikersnaamTxb = new System.Windows.Forms.TextBox();
            this.wachtwoordTxb = new System.Windows.Forms.TextBox();
            this.gebruikersnaamLbl = new System.Windows.Forms.Label();
            this.wachtwoordLbl = new System.Windows.Forms.Label();
            this.soortGebruikerCbx = new System.Windows.Forms.ComboBox();
            this.gebruikerLbl = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // voegToeBtn
            // 
            this.voegToeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.voegToeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voegToeBtn.BackgroundImage")));
            this.voegToeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.voegToeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voegToeBtn.FlatAppearance.BorderSize = 0;
            this.voegToeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voegToeBtn.Location = new System.Drawing.Point(199, 2);
            this.voegToeBtn.Name = "voegToeBtn";
            this.voegToeBtn.Size = new System.Drawing.Size(59, 50);
            this.voegToeBtn.TabIndex = 0;
            this.voegToeBtn.UseVisualStyleBackColor = false;
            this.voegToeBtn.Click += new System.EventHandler(this.voegToeBtn_Click);
            // 
            // gebruikersnaamTxb
            // 
            this.gebruikersnaamTxb.Font = new System.Drawing.Font("Arial", 10F);
            this.gebruikersnaamTxb.Location = new System.Drawing.Point(12, 86);
            this.gebruikersnaamTxb.Name = "gebruikersnaamTxb";
            this.gebruikersnaamTxb.Size = new System.Drawing.Size(148, 23);
            this.gebruikersnaamTxb.TabIndex = 1;
            // 
            // wachtwoordTxb
            // 
            this.wachtwoordTxb.Font = new System.Drawing.Font("Arial", 10F);
            this.wachtwoordTxb.Location = new System.Drawing.Point(12, 141);
            this.wachtwoordTxb.Name = "wachtwoordTxb";
            this.wachtwoordTxb.Size = new System.Drawing.Size(148, 23);
            this.wachtwoordTxb.TabIndex = 2;
            // 
            // gebruikersnaamLbl
            // 
            this.gebruikersnaamLbl.AutoSize = true;
            this.gebruikersnaamLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikersnaamLbl.Location = new System.Drawing.Point(12, 60);
            this.gebruikersnaamLbl.Name = "gebruikersnaamLbl";
            this.gebruikersnaamLbl.Size = new System.Drawing.Size(107, 16);
            this.gebruikersnaamLbl.TabIndex = 3;
            this.gebruikersnaamLbl.Text = "Gebruikersnaam:";
            this.gebruikersnaamLbl.Click += new System.EventHandler(this.gebruikersnaamLbl_Click);
            // 
            // wachtwoordLbl
            // 
            this.wachtwoordLbl.AutoSize = true;
            this.wachtwoordLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wachtwoordLbl.Location = new System.Drawing.Point(12, 118);
            this.wachtwoordLbl.Name = "wachtwoordLbl";
            this.wachtwoordLbl.Size = new System.Drawing.Size(84, 16);
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
            this.soortGebruikerCbx.Location = new System.Drawing.Point(182, 86);
            this.soortGebruikerCbx.Name = "soortGebruikerCbx";
            this.soortGebruikerCbx.Size = new System.Drawing.Size(100, 21);
            this.soortGebruikerCbx.TabIndex = 6;
            // 
            // gebruikerLbl
            // 
            this.gebruikerLbl.AutoSize = true;
            this.gebruikerLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikerLbl.Location = new System.Drawing.Point(181, 59);
            this.gebruikerLbl.Name = "gebruikerLbl";
            this.gebruikerLbl.Size = new System.Drawing.Size(100, 16);
            this.gebruikerLbl.TabIndex = 7;
            this.gebruikerLbl.Text = "Soort gebruiker:";
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHome.BackgroundImage = global::CrmAppSchool.Properties.Resources.picture_Home;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(-2, 2);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(61, 50);
            this.pbHome.TabIndex = 10;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "U bent ingelogd als:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-2, 2);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(519, 50);
            this.pbHeader.TabIndex = 9;
            this.pbHeader.TabStop = false;
            // 
            // voegGebruikerToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 213);
            this.Controls.Add(this.voegToeBtn);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.gebruikerLbl);
            this.Controls.Add(this.soortGebruikerCbx);
            this.Controls.Add(this.wachtwoordLbl);
            this.Controls.Add(this.gebruikersnaamLbl);
            this.Controls.Add(this.wachtwoordTxb);
            this.Controls.Add(this.gebruikersnaamTxb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "voegGebruikerToeForm";
            this.Text = "Voeg gebruiker toe";
            this.Load += new System.EventHandler(this.voegGebruikerToeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
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
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHeader;
    }
}