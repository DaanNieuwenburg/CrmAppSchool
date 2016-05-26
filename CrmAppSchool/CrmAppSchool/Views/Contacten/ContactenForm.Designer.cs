namespace CrmAppSchool.Views.Contacten
{
    partial class ContactenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactenForm));
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnVoegtoe = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contactSoortCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bedrijfPnl = new System.Windows.Forms.Panel();
            this.bedrijfsnaamLbl = new System.Windows.Forms.Label();
            this.bedrijfsnaamTxb = new System.Windows.Forms.TextBox();
            this.persoonPnl = new System.Windows.Forms.Panel();
            this.voegPersoonToeBtn = new System.Windows.Forms.Button();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.locatieLbl = new System.Windows.Forms.Label();
            this.locatieTxb = new System.Windows.Forms.TextBox();
            this.achternaamTxb = new System.Windows.Forms.TextBox();
            this.achternaamLbl = new System.Windows.Forms.Label();
            this.voornaamLbl = new System.Windows.Forms.Label();
            this.voornaamTxb = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.bedrijfPnl.SuspendLayout();
            this.persoonPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(400, 19);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(123, 16);
            this.lblGebruiker.TabIndex = 12;
            this.lblGebruiker.Text = "U bent ingelogd als:";
            // 
            // btnZoeken
            // 
            this.btnZoeken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoeken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnZoeken.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Zoeken_Wit;
            this.btnZoeken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoeken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoeken.FlatAppearance.BorderSize = 0;
            this.btnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoeken.Location = new System.Drawing.Point(277, 1);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(59, 50);
            this.btnZoeken.TabIndex = 16;
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoegtoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnVoegtoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoegtoe.BackgroundImage")));
            this.btnVoegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoegtoe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoegtoe.FlatAppearance.BorderSize = 0;
            this.btnVoegtoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoegtoe.Location = new System.Drawing.Point(212, 1);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(59, 50);
            this.btnVoegtoe.TabIndex = 15;
            this.btnVoegtoe.UseVisualStyleBackColor = false;
            this.btnVoegtoe.Click += new System.EventHandler(this.btnVoegtoe_Click);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHome.BackgroundImage = global::CrmAppSchool.Properties.Resources.picture_Home;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(0, 1);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(61, 50);
            this.pbHome.TabIndex = 14;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(596, 50);
            this.pbHeader.TabIndex = 13;
            this.pbHeader.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(96, 15);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(175, 25);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.Text = "Zoeken...";
            this.tbSearch.Visible = false;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnCancel.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Annuleren_Wit;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(335, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 50);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 434);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // contactSoortCbx
            // 
            this.contactSoortCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactSoortCbx.FormattingEnabled = true;
            this.contactSoortCbx.Items.AddRange(new object[] {
            "Bedrijf",
            "Stagebegeleider",
            "Gastdocent",
            "Gastspreker"});
            this.contactSoortCbx.Location = new System.Drawing.Point(121, 95);
            this.contactSoortCbx.Name = "contactSoortCbx";
            this.contactSoortCbx.Size = new System.Drawing.Size(121, 21);
            this.contactSoortCbx.TabIndex = 20;
            this.contactSoortCbx.SelectedValueChanged += new System.EventHandler(this.toonContactenInvoer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(118, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Selecteer het soort contact";
            // 
            // bedrijfPnl
            // 
            this.bedrijfPnl.BackColor = System.Drawing.SystemColors.Window;
            this.bedrijfPnl.Controls.Add(this.bedrijfsnaamLbl);
            this.bedrijfPnl.Controls.Add(this.bedrijfsnaamTxb);
            this.bedrijfPnl.Location = new System.Drawing.Point(121, 145);
            this.bedrijfPnl.Name = "bedrijfPnl";
            this.bedrijfPnl.Size = new System.Drawing.Size(200, 105);
            this.bedrijfPnl.TabIndex = 22;
            this.bedrijfPnl.Visible = false;
            // 
            // bedrijfsnaamLbl
            // 
            this.bedrijfsnaamLbl.AutoSize = true;
            this.bedrijfsnaamLbl.Location = new System.Drawing.Point(15, 49);
            this.bedrijfsnaamLbl.Name = "bedrijfsnaamLbl";
            this.bedrijfsnaamLbl.Size = new System.Drawing.Size(70, 13);
            this.bedrijfsnaamLbl.TabIndex = 1;
            this.bedrijfsnaamLbl.Text = "Bedrijfsnaam:";
            // 
            // bedrijfsnaamTxb
            // 
            this.bedrijfsnaamTxb.Location = new System.Drawing.Point(91, 46);
            this.bedrijfsnaamTxb.Name = "bedrijfsnaamTxb";
            this.bedrijfsnaamTxb.Size = new System.Drawing.Size(100, 20);
            this.bedrijfsnaamTxb.TabIndex = 0;
            // 
            // persoonPnl
            // 
            this.persoonPnl.BackColor = System.Drawing.SystemColors.Window;
            this.persoonPnl.Controls.Add(this.voegPersoonToeBtn);
            this.persoonPnl.Controls.Add(this.emailLbl);
            this.persoonPnl.Controls.Add(this.emailTxb);
            this.persoonPnl.Controls.Add(this.locatieLbl);
            this.persoonPnl.Controls.Add(this.locatieTxb);
            this.persoonPnl.Controls.Add(this.achternaamTxb);
            this.persoonPnl.Controls.Add(this.achternaamLbl);
            this.persoonPnl.Controls.Add(this.voornaamLbl);
            this.persoonPnl.Controls.Add(this.voornaamTxb);
            this.persoonPnl.Location = new System.Drawing.Point(121, 145);
            this.persoonPnl.Name = "persoonPnl";
            this.persoonPnl.Size = new System.Drawing.Size(200, 292);
            this.persoonPnl.TabIndex = 23;
            this.persoonPnl.Visible = false;
            // 
            // voegPersoonToeBtn
            // 
            this.voegPersoonToeBtn.Location = new System.Drawing.Point(106, 266);
            this.voegPersoonToeBtn.Name = "voegPersoonToeBtn";
            this.voegPersoonToeBtn.Size = new System.Drawing.Size(75, 23);
            this.voegPersoonToeBtn.TabIndex = 8;
            this.voegPersoonToeBtn.Text = "Voeg toe";
            this.voegPersoonToeBtn.UseVisualStyleBackColor = true;
            this.voegPersoonToeBtn.Click += new System.EventHandler(this.voegPersoonToeBtn_Click);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(15, 128);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 7;
            this.emailLbl.Text = "Email:";
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(91, 125);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(100, 20);
            this.emailTxb.TabIndex = 6;
            // 
            // locatieLbl
            // 
            this.locatieLbl.AutoSize = true;
            this.locatieLbl.Location = new System.Drawing.Point(15, 102);
            this.locatieLbl.Name = "locatieLbl";
            this.locatieLbl.Size = new System.Drawing.Size(45, 13);
            this.locatieLbl.TabIndex = 5;
            this.locatieLbl.Text = "Locatie:";
            // 
            // locatieTxb
            // 
            this.locatieTxb.Location = new System.Drawing.Point(91, 99);
            this.locatieTxb.Name = "locatieTxb";
            this.locatieTxb.Size = new System.Drawing.Size(100, 20);
            this.locatieTxb.TabIndex = 4;
            // 
            // achternaamTxb
            // 
            this.achternaamTxb.Location = new System.Drawing.Point(91, 73);
            this.achternaamTxb.Name = "achternaamTxb";
            this.achternaamTxb.Size = new System.Drawing.Size(100, 20);
            this.achternaamTxb.TabIndex = 3;
            // 
            // achternaamLbl
            // 
            this.achternaamLbl.AutoSize = true;
            this.achternaamLbl.Location = new System.Drawing.Point(15, 76);
            this.achternaamLbl.Name = "achternaamLbl";
            this.achternaamLbl.Size = new System.Drawing.Size(67, 13);
            this.achternaamLbl.TabIndex = 2;
            this.achternaamLbl.Text = "Achternaam:";
            // 
            // voornaamLbl
            // 
            this.voornaamLbl.AutoSize = true;
            this.voornaamLbl.Location = new System.Drawing.Point(15, 49);
            this.voornaamLbl.Name = "voornaamLbl";
            this.voornaamLbl.Size = new System.Drawing.Size(58, 13);
            this.voornaamLbl.TabIndex = 1;
            this.voornaamLbl.Text = "Voornaam:";
            // 
            // voornaamTxb
            // 
            this.voornaamTxb.Location = new System.Drawing.Point(91, 46);
            this.voornaamTxb.Name = "voornaamTxb";
            this.voornaamTxb.Size = new System.Drawing.Size(100, 20);
            this.voornaamTxb.TabIndex = 0;
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
            this.btnOpslaan.Location = new System.Drawing.Point(335, 1);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(63, 49);
            this.btnOpslaan.TabIndex = 30;
            this.btnOpslaan.UseVisualStyleBackColor = false;
            this.btnOpslaan.Visible = false;
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
            this.btnAnnuleer.Location = new System.Drawing.Point(267, 0);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(63, 49);
            this.btnAnnuleer.TabIndex = 29;
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Visible = false;
            // 
            // ContactenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 484);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.persoonPnl);
            this.Controls.Add(this.bedrijfPnl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactSoortCbx);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactenForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.bedrijfPnl.ResumeLayout(false);
            this.bedrijfPnl.PerformLayout();
            this.persoonPnl.ResumeLayout(false);
            this.persoonPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Button btnVoegtoe;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox contactSoortCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bedrijfPnl;
        private System.Windows.Forms.Label bedrijfsnaamLbl;
        private System.Windows.Forms.TextBox bedrijfsnaamTxb;
        private System.Windows.Forms.Panel persoonPnl;
        private System.Windows.Forms.Label voornaamLbl;
        private System.Windows.Forms.TextBox voornaamTxb;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.Label locatieLbl;
        private System.Windows.Forms.TextBox locatieTxb;
        private System.Windows.Forms.TextBox achternaamTxb;
        private System.Windows.Forms.Label achternaamLbl;
        private System.Windows.Forms.Button voegPersoonToeBtn;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAnnuleer;
    }
}