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
            this.lvContacten = new System.Windows.Forms.ListView();
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactSoortCbx = new System.Windows.Forms.ComboBox();
            this.lblSoort = new System.Windows.Forms.Label();
            this.bedrijfPnl = new System.Windows.Forms.Panel();
            this.bedrijfsnaamLbl = new System.Windows.Forms.Label();
            this.bedrijfsnaamTxb = new System.Windows.Forms.TextBox();
            this.persoonPnl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBedrijf = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.achternaamLbl = new System.Windows.Forms.Label();
            this.voornaamLbl = new System.Windows.Forms.Label();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.locatieLbl = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.pnOptioneel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPriveMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFunctie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMobiel = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEadres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelefoon = new System.Windows.Forms.TextBox();
            this.pnbedrijf2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbKwaliteiten = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHoofdlocatie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.bedrijfPnl.SuspendLayout();
            this.persoonPnl.SuspendLayout();
            this.pnOptioneel.SuspendLayout();
            this.pnbedrijf2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(592, 19);
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
            this.btnZoeken.Location = new System.Drawing.Point(528, 1);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(59, 50);
            this.btnZoeken.TabIndex = 16;
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoegtoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnVoegtoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoegtoe.BackgroundImage")));
            this.btnVoegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoegtoe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoegtoe.FlatAppearance.BorderSize = 0;
            this.btnVoegtoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoegtoe.Location = new System.Drawing.Point(259, 1);
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
            this.pbHeader.Size = new System.Drawing.Size(788, 50);
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
            this.tbSearch.Location = new System.Drawing.Point(293, 14);
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
            this.btnCancel.Location = new System.Drawing.Point(527, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 50);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lvContacten
            // 
            this.lvContacten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contact});
            this.lvContacten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvContacten.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvContacten.Location = new System.Drawing.Point(0, 50);
            this.lvContacten.Name = "lvContacten";
            this.lvContacten.Size = new System.Drawing.Size(788, 434);
            this.lvContacten.TabIndex = 19;
            this.lvContacten.UseCompatibleStateImageBehavior = false;
            this.lvContacten.View = System.Windows.Forms.View.List;
            // 
            // Contact
            // 
            this.Contact.Text = "";
            // 
            // contactSoortCbx
            // 
            this.contactSoortCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactSoortCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactSoortCbx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactSoortCbx.FormattingEnabled = true;
            this.contactSoortCbx.Items.AddRange(new object[] {
            "Bedrijf",
            "Stagebegeleider",
            "Gastdocent",
            "Gastspreker"});
            this.contactSoortCbx.Location = new System.Drawing.Point(39, 83);
            this.contactSoortCbx.Name = "contactSoortCbx";
            this.contactSoortCbx.Size = new System.Drawing.Size(121, 24);
            this.contactSoortCbx.TabIndex = 20;
            this.contactSoortCbx.Visible = false;
            this.contactSoortCbx.SelectedValueChanged += new System.EventHandler(this.toonContactenInvoer);
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSoort.Font = new System.Drawing.Font("Arial", 9F);
            this.lblSoort.Location = new System.Drawing.Point(36, 63);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(152, 15);
            this.lblSoort.TabIndex = 21;
            this.lblSoort.Text = "Selecteer het soort contact";
            this.lblSoort.Visible = false;
            // 
            // bedrijfPnl
            // 
            this.bedrijfPnl.BackColor = System.Drawing.SystemColors.Window;
            this.bedrijfPnl.Controls.Add(this.label8);
            this.bedrijfPnl.Controls.Add(this.tbTelefoon);
            this.bedrijfPnl.Controls.Add(this.label7);
            this.bedrijfPnl.Controls.Add(this.tbEadres);
            this.bedrijfPnl.Controls.Add(this.label6);
            this.bedrijfPnl.Controls.Add(this.tbContact);
            this.bedrijfPnl.Controls.Add(this.bedrijfsnaamLbl);
            this.bedrijfPnl.Controls.Add(this.bedrijfsnaamTxb);
            this.bedrijfPnl.Location = new System.Drawing.Point(32, 123);
            this.bedrijfPnl.Name = "bedrijfPnl";
            this.bedrijfPnl.Size = new System.Drawing.Size(325, 148);
            this.bedrijfPnl.TabIndex = 22;
            this.bedrijfPnl.Visible = false;
            // 
            // bedrijfsnaamLbl
            // 
            this.bedrijfsnaamLbl.AutoSize = true;
            this.bedrijfsnaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.bedrijfsnaamLbl.Location = new System.Drawing.Point(15, 27);
            this.bedrijfsnaamLbl.Name = "bedrijfsnaamLbl";
            this.bedrijfsnaamLbl.Size = new System.Drawing.Size(94, 16);
            this.bedrijfsnaamLbl.TabIndex = 1;
            this.bedrijfsnaamLbl.Text = "Bedrijfsnaam:";
            // 
            // bedrijfsnaamTxb
            // 
            this.bedrijfsnaamTxb.Font = new System.Drawing.Font("Arial", 10F);
            this.bedrijfsnaamTxb.Location = new System.Drawing.Point(128, 24);
            this.bedrijfsnaamTxb.Name = "bedrijfsnaamTxb";
            this.bedrijfsnaamTxb.Size = new System.Drawing.Size(149, 23);
            this.bedrijfsnaamTxb.TabIndex = 0;
            // 
            // persoonPnl
            // 
            this.persoonPnl.BackColor = System.Drawing.SystemColors.Window;
            this.persoonPnl.Controls.Add(this.label5);
            this.persoonPnl.Controls.Add(this.emailLbl);
            this.persoonPnl.Controls.Add(this.tbEmail);
            this.persoonPnl.Controls.Add(this.label3);
            this.persoonPnl.Controls.Add(this.tbBedrijf);
            this.persoonPnl.Controls.Add(this.tbAchternaam);
            this.persoonPnl.Controls.Add(this.achternaamLbl);
            this.persoonPnl.Controls.Add(this.voornaamLbl);
            this.persoonPnl.Controls.Add(this.tbVoornaam);
            this.persoonPnl.Location = new System.Drawing.Point(32, 123);
            this.persoonPnl.Name = "persoonPnl";
            this.persoonPnl.Size = new System.Drawing.Size(273, 292);
            this.persoonPnl.TabIndex = 23;
            this.persoonPnl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "* Verplichte velden";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.emailLbl.Location = new System.Drawing.Point(3, 128);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(55, 16);
            this.emailLbl.TabIndex = 7;
            this.emailLbl.Text = "* Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.tbEmail.Location = new System.Drawing.Point(106, 125);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(149, 23);
            this.tbEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Bedrijf:";
            // 
            // tbBedrijf
            // 
            this.tbBedrijf.Font = new System.Drawing.Font("Arial", 10F);
            this.tbBedrijf.Location = new System.Drawing.Point(106, 99);
            this.tbBedrijf.Name = "tbBedrijf";
            this.tbBedrijf.Size = new System.Drawing.Size(149, 23);
            this.tbBedrijf.TabIndex = 2;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Font = new System.Drawing.Font("Arial", 10F);
            this.tbAchternaam.Location = new System.Drawing.Point(106, 73);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(149, 23);
            this.tbAchternaam.TabIndex = 1;
            // 
            // achternaamLbl
            // 
            this.achternaamLbl.AutoSize = true;
            this.achternaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.achternaamLbl.Location = new System.Drawing.Point(3, 76);
            this.achternaamLbl.Name = "achternaamLbl";
            this.achternaamLbl.Size = new System.Drawing.Size(96, 16);
            this.achternaamLbl.TabIndex = 2;
            this.achternaamLbl.Text = "* Achternaam:";
            // 
            // voornaamLbl
            // 
            this.voornaamLbl.AutoSize = true;
            this.voornaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.voornaamLbl.Location = new System.Drawing.Point(3, 49);
            this.voornaamLbl.Name = "voornaamLbl";
            this.voornaamLbl.Size = new System.Drawing.Size(85, 16);
            this.voornaamLbl.TabIndex = 1;
            this.voornaamLbl.Text = "* Voornaam:";
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Font = new System.Drawing.Font("Arial", 10F);
            this.tbVoornaam.Location = new System.Drawing.Point(106, 46);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(149, 23);
            this.tbVoornaam.TabIndex = 0;
            // 
            // locatieLbl
            // 
            this.locatieLbl.AutoSize = true;
            this.locatieLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.locatieLbl.Location = new System.Drawing.Point(15, 76);
            this.locatieLbl.Name = "locatieLbl";
            this.locatieLbl.Size = new System.Drawing.Size(58, 16);
            this.locatieLbl.TabIndex = 5;
            this.locatieLbl.Text = "Locatie:";
            // 
            // tbLocatie
            // 
            this.tbLocatie.Font = new System.Drawing.Font("Arial", 10F);
            this.tbLocatie.Location = new System.Drawing.Point(106, 73);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(152, 23);
            this.tbLocatie.TabIndex = 5;
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
            this.btnOpslaan.Location = new System.Drawing.Point(431, 1);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(63, 49);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.UseVisualStyleBackColor = false;
            this.btnOpslaan.Visible = false;
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
            this.btnAnnuleer.Location = new System.Drawing.Point(363, 0);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(63, 49);
            this.btnAnnuleer.TabIndex = 9;
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Visible = false;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // pnOptioneel
            // 
            this.pnOptioneel.BackColor = System.Drawing.SystemColors.Window;
            this.pnOptioneel.Controls.Add(this.label1);
            this.pnOptioneel.Controls.Add(this.tbPriveMail);
            this.pnOptioneel.Controls.Add(this.label2);
            this.pnOptioneel.Controls.Add(this.locatieLbl);
            this.pnOptioneel.Controls.Add(this.tbFunctie);
            this.pnOptioneel.Controls.Add(this.tbLocatie);
            this.pnOptioneel.Controls.Add(this.label4);
            this.pnOptioneel.Controls.Add(this.tbMobiel);
            this.pnOptioneel.Location = new System.Drawing.Point(306, 123);
            this.pnOptioneel.Name = "pnOptioneel";
            this.pnOptioneel.Size = new System.Drawing.Size(273, 292);
            this.pnOptioneel.TabIndex = 24;
            this.pnOptioneel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Privé mail:";
            // 
            // tbPriveMail
            // 
            this.tbPriveMail.Font = new System.Drawing.Font("Arial", 10F);
            this.tbPriveMail.Location = new System.Drawing.Point(106, 125);
            this.tbPriveMail.Name = "tbPriveMail";
            this.tbPriveMail.Size = new System.Drawing.Size(152, 23);
            this.tbPriveMail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Functie:";
            // 
            // tbFunctie
            // 
            this.tbFunctie.Font = new System.Drawing.Font("Arial", 10F);
            this.tbFunctie.Location = new System.Drawing.Point(106, 99);
            this.tbFunctie.Name = "tbFunctie";
            this.tbFunctie.Size = new System.Drawing.Size(152, 23);
            this.tbFunctie.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mobiel:";
            // 
            // tbMobiel
            // 
            this.tbMobiel.Font = new System.Drawing.Font("Arial", 10F);
            this.tbMobiel.Location = new System.Drawing.Point(106, 46);
            this.tbMobiel.Name = "tbMobiel";
            this.tbMobiel.Size = new System.Drawing.Size(152, 23);
            this.tbMobiel.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnDelete.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Delete_Wit;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(378, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 50);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnWijzig
            // 
            this.btnWijzig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWijzig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnWijzig.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Bewerken_Wit;
            this.btnWijzig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWijzig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWijzig.FlatAppearance.BorderSize = 0;
            this.btnWijzig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWijzig.Location = new System.Drawing.Point(313, 1);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(59, 50);
            this.btnWijzig.TabIndex = 25;
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contactpersoon:";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Arial", 10F);
            this.tbContact.Location = new System.Drawing.Point(128, 53);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(149, 23);
            this.tbContact.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(15, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Emailadres:";
            // 
            // tbEadres
            // 
            this.tbEadres.Font = new System.Drawing.Font("Arial", 10F);
            this.tbEadres.Location = new System.Drawing.Point(128, 82);
            this.tbEadres.Name = "tbEadres";
            this.tbEadres.Size = new System.Drawing.Size(149, 23);
            this.tbEadres.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(15, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefoonnr:";
            // 
            // tbTelefoon
            // 
            this.tbTelefoon.Font = new System.Drawing.Font("Arial", 10F);
            this.tbTelefoon.Location = new System.Drawing.Point(128, 111);
            this.tbTelefoon.Name = "tbTelefoon";
            this.tbTelefoon.Size = new System.Drawing.Size(149, 23);
            this.tbTelefoon.TabIndex = 6;
            // 
            // pnbedrijf2
            // 
            this.pnbedrijf2.BackColor = System.Drawing.SystemColors.Window;
            this.pnbedrijf2.Controls.Add(this.label10);
            this.pnbedrijf2.Controls.Add(this.tbWebsite);
            this.pnbedrijf2.Controls.Add(this.label9);
            this.pnbedrijf2.Controls.Add(this.tbHoofdlocatie);
            this.pnbedrijf2.Controls.Add(this.label11);
            this.pnbedrijf2.Controls.Add(this.tbKwaliteiten);
            this.pnbedrijf2.Location = new System.Drawing.Point(343, 123);
            this.pnbedrijf2.Name = "pnbedrijf2";
            this.pnbedrijf2.Size = new System.Drawing.Size(351, 268);
            this.pnbedrijf2.TabIndex = 23;
            this.pnbedrijf2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.Location = new System.Drawing.Point(15, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Kwaliteiten:";
            // 
            // tbKwaliteiten
            // 
            this.tbKwaliteiten.Font = new System.Drawing.Font("Arial", 10F);
            this.tbKwaliteiten.Location = new System.Drawing.Point(108, 119);
            this.tbKwaliteiten.Multiline = true;
            this.tbKwaliteiten.Name = "tbKwaliteiten";
            this.tbKwaliteiten.Size = new System.Drawing.Size(198, 88);
            this.tbKwaliteiten.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(15, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Hoofdlocatie:";
            // 
            // tbHoofdlocatie
            // 
            this.tbHoofdlocatie.Font = new System.Drawing.Font("Arial", 10F);
            this.tbHoofdlocatie.Location = new System.Drawing.Point(108, 21);
            this.tbHoofdlocatie.Name = "tbHoofdlocatie";
            this.tbHoofdlocatie.Size = new System.Drawing.Size(198, 23);
            this.tbHoofdlocatie.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(15, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Website:";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Font = new System.Drawing.Font("Arial", 10F);
            this.tbWebsite.Location = new System.Drawing.Point(108, 50);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(198, 23);
            this.tbWebsite.TabIndex = 6;
            // 
            // ContactenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 484);
            this.Controls.Add(this.persoonPnl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.pnOptioneel);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.lblSoort);
            this.Controls.Add(this.contactSoortCbx);
            this.Controls.Add(this.lvContacten);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.bedrijfPnl);
            this.Controls.Add(this.pnbedrijf2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacten";
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.bedrijfPnl.ResumeLayout(false);
            this.bedrijfPnl.PerformLayout();
            this.persoonPnl.ResumeLayout(false);
            this.persoonPnl.PerformLayout();
            this.pnOptioneel.ResumeLayout(false);
            this.pnOptioneel.PerformLayout();
            this.pnbedrijf2.ResumeLayout(false);
            this.pnbedrijf2.PerformLayout();
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
        private System.Windows.Forms.ListView lvContacten;
        private System.Windows.Forms.ComboBox contactSoortCbx;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.Panel bedrijfPnl;
        private System.Windows.Forms.Label bedrijfsnaamLbl;
        private System.Windows.Forms.TextBox bedrijfsnaamTxb;
        private System.Windows.Forms.Panel persoonPnl;
        private System.Windows.Forms.Label voornaamLbl;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label locatieLbl;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.Label achternaamLbl;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnOptioneel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPriveMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFunctie;
        private System.Windows.Forms.TextBox tbBedrijf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMobiel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEadres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTelefoon;
        private System.Windows.Forms.Panel pnbedrijf2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbKwaliteiten;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHoofdlocatie;
    }
}