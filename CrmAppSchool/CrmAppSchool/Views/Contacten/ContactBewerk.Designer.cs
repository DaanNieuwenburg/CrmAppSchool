namespace CrmAppSchool.Views.Bedrijven
{
    partial class ContactBewerk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedrijfBewerk));
            this.lblContactnaam = new System.Windows.Forms.Label();
            this.persoonPnl = new System.Windows.Forms.Panel();
            this.bedrijfCbx = new System.Windows.Forms.ComboBox();
            this.mobielTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.locatieTb = new System.Windows.Forms.TextBox();
            this.functieTb = new System.Windows.Forms.TextBox();
            this.achternaamTb = new System.Windows.Forms.TextBox();
            this.voornaamTb = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.achternaamLbl = new System.Windows.Forms.Label();
            this.voornaamLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locatieLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.pbRate5 = new System.Windows.Forms.PictureBox();
            this.pbRate4 = new System.Windows.Forms.PictureBox();
            this.pbRate3 = new System.Windows.Forms.PictureBox();
            this.pbRate2 = new System.Windows.Forms.PictureBox();
            this.pbRate1 = new System.Windows.Forms.PictureBox();
            this.tbOmschrijving = new System.Windows.Forms.TextBox();
            this.persoonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContactnaam
            // 
            this.lblContactnaam.AutoSize = true;
            this.lblContactnaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblContactnaam.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactnaam.ForeColor = System.Drawing.Color.White;
            this.lblContactnaam.Location = new System.Drawing.Point(10, 9);
            this.lblContactnaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactnaam.Name = "lblContactnaam";
            this.lblContactnaam.Size = new System.Drawing.Size(185, 32);
            this.lblContactnaam.TabIndex = 33;
            this.lblContactnaam.Text = "Contactnaam";
            // 
            // persoonPnl
            // 
            this.persoonPnl.Controls.Add(this.bedrijfCbx);
            this.persoonPnl.Controls.Add(this.mobielTb);
            this.persoonPnl.Controls.Add(this.emailTb);
            this.persoonPnl.Controls.Add(this.locatieTb);
            this.persoonPnl.Controls.Add(this.functieTb);
            this.persoonPnl.Controls.Add(this.achternaamTb);
            this.persoonPnl.Controls.Add(this.voornaamTb);
            this.persoonPnl.Controls.Add(this.emailLbl);
            this.persoonPnl.Controls.Add(this.label3);
            this.persoonPnl.Controls.Add(this.achternaamLbl);
            this.persoonPnl.Controls.Add(this.voornaamLbl);
            this.persoonPnl.Controls.Add(this.label2);
            this.persoonPnl.Controls.Add(this.locatieLbl);
            this.persoonPnl.Controls.Add(this.label4);
            this.persoonPnl.Location = new System.Drawing.Point(16, 95);
            this.persoonPnl.Margin = new System.Windows.Forms.Padding(2);
            this.persoonPnl.Name = "persoonPnl";
            this.persoonPnl.Size = new System.Drawing.Size(573, 202);
            this.persoonPnl.TabIndex = 34;
            // 
            // bedrijfCbx
            // 
            this.bedrijfCbx.Font = new System.Drawing.Font("Arial", 10F);
            this.bedrijfCbx.FormattingEnabled = true;
            this.bedrijfCbx.Location = new System.Drawing.Point(113, 98);
            this.bedrijfCbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bedrijfCbx.Name = "bedrijfCbx";
            this.bedrijfCbx.Size = new System.Drawing.Size(165, 24);
            this.bedrijfCbx.TabIndex = 41;
            // 
            // mobielTb
            // 
            this.mobielTb.Font = new System.Drawing.Font("Arial", 10F);
            this.mobielTb.Location = new System.Drawing.Point(390, 14);
            this.mobielTb.Margin = new System.Windows.Forms.Padding(2);
            this.mobielTb.MaxLength = 10;
            this.mobielTb.Name = "mobielTb";
            this.mobielTb.Size = new System.Drawing.Size(178, 23);
            this.mobielTb.TabIndex = 39;
            this.mobielTb.Enter += new System.EventHandler(this.mobielTb_Enter);
            this.mobielTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobielTb_KeyPress);
            this.mobielTb.Leave += new System.EventHandler(this.mobielTb_Leave);
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Arial", 10F);
            this.emailTb.Location = new System.Drawing.Point(390, 46);
            this.emailTb.Margin = new System.Windows.Forms.Padding(2);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(178, 23);
            this.emailTb.TabIndex = 38;
            this.emailTb.Enter += new System.EventHandler(this.emailTb_Enter);
            this.emailTb.Leave += new System.EventHandler(this.emailTb_Leave);
            // 
            // locatieTb
            // 
            this.locatieTb.Font = new System.Drawing.Font("Arial", 10F);
            this.locatieTb.Location = new System.Drawing.Point(113, 158);
            this.locatieTb.Margin = new System.Windows.Forms.Padding(2);
            this.locatieTb.Name = "locatieTb";
            this.locatieTb.Size = new System.Drawing.Size(165, 23);
            this.locatieTb.TabIndex = 36;
            // 
            // functieTb
            // 
            this.functieTb.Font = new System.Drawing.Font("Arial", 10F);
            this.functieTb.Location = new System.Drawing.Point(113, 130);
            this.functieTb.Margin = new System.Windows.Forms.Padding(2);
            this.functieTb.Name = "functieTb";
            this.functieTb.Size = new System.Drawing.Size(165, 23);
            this.functieTb.TabIndex = 35;
            // 
            // achternaamTb
            // 
            this.achternaamTb.Font = new System.Drawing.Font("Arial", 10F);
            this.achternaamTb.Location = new System.Drawing.Point(113, 46);
            this.achternaamTb.Margin = new System.Windows.Forms.Padding(2);
            this.achternaamTb.Name = "achternaamTb";
            this.achternaamTb.Size = new System.Drawing.Size(165, 23);
            this.achternaamTb.TabIndex = 33;
            // 
            // voornaamTb
            // 
            this.voornaamTb.Font = new System.Drawing.Font("Arial", 10F);
            this.voornaamTb.Location = new System.Drawing.Point(113, 15);
            this.voornaamTb.Margin = new System.Windows.Forms.Padding(2);
            this.voornaamTb.Name = "voornaamTb";
            this.voornaamTb.Size = new System.Drawing.Size(165, 23);
            this.voornaamTb.TabIndex = 32;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.emailLbl.Location = new System.Drawing.Point(296, 47);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(46, 16);
            this.emailLbl.TabIndex = 30;
            this.emailLbl.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bedrijf:";
            // 
            // achternaamLbl
            // 
            this.achternaamLbl.AutoSize = true;
            this.achternaamLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.achternaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.achternaamLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.achternaamLbl.Location = new System.Drawing.Point(12, 47);
            this.achternaamLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.achternaamLbl.Name = "achternaamLbl";
            this.achternaamLbl.Size = new System.Drawing.Size(88, 16);
            this.achternaamLbl.TabIndex = 27;
            this.achternaamLbl.Text = "Achternaam:";
            // 
            // voornaamLbl
            // 
            this.voornaamLbl.AutoSize = true;
            this.voornaamLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voornaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.voornaamLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.voornaamLbl.Location = new System.Drawing.Point(12, 15);
            this.voornaamLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voornaamLbl.Name = "voornaamLbl";
            this.voornaamLbl.Size = new System.Drawing.Size(76, 16);
            this.voornaamLbl.TabIndex = 24;
            this.voornaamLbl.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Functie:";
            // 
            // locatieLbl
            // 
            this.locatieLbl.AutoSize = true;
            this.locatieLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locatieLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.locatieLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.locatieLbl.Location = new System.Drawing.Point(12, 161);
            this.locatieLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locatieLbl.Name = "locatieLbl";
            this.locatieLbl.Size = new System.Drawing.Size(58, 16);
            this.locatieLbl.TabIndex = 29;
            this.locatieLbl.Text = "Locatie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(296, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mobiel:";
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(624, 54);
            this.pbHeader.TabIndex = 15;
            this.pbHeader.TabStop = false;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpslaan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnOpslaan.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Opslaan2_Wit;
            this.btnOpslaan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpslaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpslaan.FlatAppearance.BorderSize = 0;
            this.btnOpslaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpslaan.Location = new System.Drawing.Point(446, 0);
            this.btnOpslaan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(59, 54);
            this.btnOpslaan.TabIndex = 36;
            this.btnOpslaan.UseVisualStyleBackColor = false;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnnuleer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnAnnuleer.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Annuleren_Wit;
            this.btnAnnuleer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnnuleer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuleer.FlatAppearance.BorderSize = 0;
            this.btnAnnuleer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleer.Location = new System.Drawing.Point(366, 0);
            this.btnAnnuleer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(59, 54);
            this.btnAnnuleer.TabIndex = 35;
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // pbRate5
            // 
            this.pbRate5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRate5.BackgroundImage")));
            this.pbRate5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRate5.Location = new System.Drawing.Point(144, 316);
            this.pbRate5.Name = "pbRate5";
            this.pbRate5.Size = new System.Drawing.Size(30, 29);
            this.pbRate5.TabIndex = 44;
            this.pbRate5.TabStop = false;
            this.pbRate5.Click += new System.EventHandler(this.pbRate5_Click);
            this.pbRate5.MouseEnter += new System.EventHandler(this.pbRate5_MouseEnter);
            this.pbRate5.MouseLeave += new System.EventHandler(this.pbRating_MouseLeave);
            // 
            // pbRate4
            // 
            this.pbRate4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRate4.BackgroundImage")));
            this.pbRate4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRate4.Location = new System.Drawing.Point(113, 316);
            this.pbRate4.Name = "pbRate4";
            this.pbRate4.Size = new System.Drawing.Size(30, 29);
            this.pbRate4.TabIndex = 43;
            this.pbRate4.TabStop = false;
            this.pbRate4.Click += new System.EventHandler(this.pbRate4_Click);
            this.pbRate4.MouseEnter += new System.EventHandler(this.pbRate4_MouseEnter);
            this.pbRate4.MouseLeave += new System.EventHandler(this.pbRating_MouseLeave);
            // 
            // pbRate3
            // 
            this.pbRate3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRate3.BackgroundImage")));
            this.pbRate3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRate3.Location = new System.Drawing.Point(82, 316);
            this.pbRate3.Name = "pbRate3";
            this.pbRate3.Size = new System.Drawing.Size(30, 29);
            this.pbRate3.TabIndex = 42;
            this.pbRate3.TabStop = false;
            this.pbRate3.Click += new System.EventHandler(this.pbRate3_Click);
            this.pbRate3.MouseEnter += new System.EventHandler(this.pbRate3_MouseEnter);
            this.pbRate3.MouseLeave += new System.EventHandler(this.pbRating_MouseLeave);
            // 
            // pbRate2
            // 
            this.pbRate2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRate2.BackgroundImage")));
            this.pbRate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRate2.Location = new System.Drawing.Point(50, 316);
            this.pbRate2.Name = "pbRate2";
            this.pbRate2.Size = new System.Drawing.Size(30, 29);
            this.pbRate2.TabIndex = 41;
            this.pbRate2.TabStop = false;
            this.pbRate2.Click += new System.EventHandler(this.pbRate2_Click);
            this.pbRate2.MouseEnter += new System.EventHandler(this.pbRate2_MouseEnter);
            this.pbRate2.MouseLeave += new System.EventHandler(this.pbRating_MouseLeave);
            // 
            // pbRate1
            // 
            this.pbRate1.BackgroundImage = global::CrmAppSchool.Properties.Resources.Afbeelding_Ster_vol;
            this.pbRate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRate1.Location = new System.Drawing.Point(19, 316);
            this.pbRate1.Name = "pbRate1";
            this.pbRate1.Size = new System.Drawing.Size(30, 29);
            this.pbRate1.TabIndex = 40;
            this.pbRate1.TabStop = false;
            this.pbRate1.Click += new System.EventHandler(this.pbRate1_Click);
            this.pbRate1.MouseEnter += new System.EventHandler(this.pbRate1_MouseEnter);
            this.pbRate1.MouseLeave += new System.EventHandler(this.pbRating_MouseLeave);
            // 
            // tbOmschrijving
            // 
            this.tbOmschrijving.Font = new System.Drawing.Font("Arial", 10F);
            this.tbOmschrijving.Location = new System.Drawing.Point(16, 359);
            this.tbOmschrijving.Margin = new System.Windows.Forms.Padding(2);
            this.tbOmschrijving.MaxLength = 400;
            this.tbOmschrijving.Multiline = true;
            this.tbOmschrijving.Name = "tbOmschrijving";
            this.tbOmschrijving.Size = new System.Drawing.Size(573, 120);
            this.tbOmschrijving.TabIndex = 42;
            // 
            // ContactBewerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 490);
            this.Controls.Add(this.tbOmschrijving);
            this.Controls.Add(this.pbRate5);
            this.Controls.Add(this.pbRate4);
            this.Controls.Add(this.pbRate3);
            this.Controls.Add(this.pbRate2);
            this.Controls.Add(this.pbRate1);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.persoonPnl);
            this.Controls.Add(this.lblContactnaam);
            this.Controls.Add(this.pbHeader);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContactBewerk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.persoonPnl.ResumeLayout(false);
            this.persoonPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Label lblContactnaam;
        private System.Windows.Forms.Panel persoonPnl;
        private System.Windows.Forms.TextBox mobielTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox locatieTb;
        private System.Windows.Forms.TextBox functieTb;
        private System.Windows.Forms.TextBox achternaamTb;
        private System.Windows.Forms.TextBox voornaamTb;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label achternaamLbl;
        private System.Windows.Forms.Label voornaamLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label locatieLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bedrijfCbx;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.PictureBox pbRate5;
        private System.Windows.Forms.PictureBox pbRate4;
        private System.Windows.Forms.PictureBox pbRate3;
        private System.Windows.Forms.PictureBox pbRate2;
        private System.Windows.Forms.PictureBox pbRate1;
        private System.Windows.Forms.TextBox tbOmschrijving;
    }
}