namespace CrmAppSchool.Views.Bedrijven
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
            this.persoonPnl = new System.Windows.Forms.Panel();
            this.bedrijfCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.achternaamLbl = new System.Windows.Forms.Label();
            this.voornaamLbl = new System.Windows.Forms.Label();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.locatieLbl = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.pnOptioneel = new System.Windows.Forms.Panel();
            this.afdelingLbl = new System.Windows.Forms.Label();
            this.tbAfdeling = new System.Windows.Forms.TextBox();
            this.kwaliteitLbl = new System.Windows.Forms.Label();
            this.tbKwaliteitenP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFunctie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMobiel = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.contactSoortCbx = new System.Windows.Forms.ComboBox();
            this.lblSoort = new System.Windows.Forms.Label();
            this.Hachternaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.persoonPnl.SuspendLayout();
            this.pnOptioneel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(789, 23);
            this.lblGebruiker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(152, 19);
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
            this.btnZoeken.Location = new System.Drawing.Point(704, 1);
            this.btnZoeken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(79, 62);
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
            this.btnVoegtoe.Location = new System.Drawing.Point(345, 1);
            this.btnVoegtoe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(79, 62);
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
            this.pbHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(81, 62);
            this.pbHome.TabIndex = 14;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1051, 62);
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
            this.tbSearch.Location = new System.Drawing.Point(388, 17);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(233, 29);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.Text = "Zoeken...";
            this.tbSearch.Visible = false;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
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
            this.btnCancel.Location = new System.Drawing.Point(703, 1);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 62);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lvContacten
            // 
            this.lvContacten.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvContacten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contact,
            this.Hachternaam});
            this.lvContacten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvContacten.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvContacten.Location = new System.Drawing.Point(0, 62);
            this.lvContacten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvContacten.Name = "lvContacten";
            this.lvContacten.Size = new System.Drawing.Size(1051, 534);
            this.lvContacten.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvContacten.TabIndex = 19;
            this.lvContacten.UseCompatibleStateImageBehavior = false;
            this.lvContacten.View = System.Windows.Forms.View.Tile;
            this.lvContacten.ItemActivate += new System.EventHandler(this.lvContacten_ItemActivate);
            // 
            // Contact
            // 
            this.Contact.Text = "";
            this.Contact.Width = this.lvContacten.Width;
            // 
            // persoonPnl
            // 
            this.persoonPnl.BackColor = System.Drawing.SystemColors.Window;
            this.persoonPnl.Controls.Add(this.bedrijfCbx);
            this.persoonPnl.Controls.Add(this.label5);
            this.persoonPnl.Controls.Add(this.emailLbl);
            this.persoonPnl.Controls.Add(this.tbEmail);
            this.persoonPnl.Controls.Add(this.label3);
            this.persoonPnl.Controls.Add(this.tbAchternaam);
            this.persoonPnl.Controls.Add(this.achternaamLbl);
            this.persoonPnl.Controls.Add(this.voornaamLbl);
            this.persoonPnl.Controls.Add(this.tbVoornaam);
            this.persoonPnl.Location = new System.Drawing.Point(43, 151);
            this.persoonPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.persoonPnl.Name = "persoonPnl";
            this.persoonPnl.Size = new System.Drawing.Size(364, 359);
            this.persoonPnl.TabIndex = 23;
            this.persoonPnl.Visible = false;
            // 
            // bedrijfCbx
            // 
            this.bedrijfCbx.FormattingEnabled = true;
            this.bedrijfCbx.Location = new System.Drawing.Point(141, 122);
            this.bedrijfCbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bedrijfCbx.Name = "bedrijfCbx";
            this.bedrijfCbx.Size = new System.Drawing.Size(197, 24);
            this.bedrijfCbx.Sorted = true;
            this.bedrijfCbx.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "* Verplichte velden";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.emailLbl.Location = new System.Drawing.Point(4, 158);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(66, 19);
            this.emailLbl.TabIndex = 7;
            this.emailLbl.Text = "* Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.tbEmail.Location = new System.Drawing.Point(141, 154);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 27);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(4, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Bedrijf:";
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Font = new System.Drawing.Font("Arial", 10F);
            this.tbAchternaam.Location = new System.Drawing.Point(141, 90);
            this.tbAchternaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(197, 27);
            this.tbAchternaam.TabIndex = 1;
            this.tbAchternaam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVoornaam_KeyPress);
            // 
            // achternaamLbl
            // 
            this.achternaamLbl.AutoSize = true;
            this.achternaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.achternaamLbl.Location = new System.Drawing.Point(4, 94);
            this.achternaamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.achternaamLbl.Name = "achternaamLbl";
            this.achternaamLbl.Size = new System.Drawing.Size(113, 19);
            this.achternaamLbl.TabIndex = 2;
            this.achternaamLbl.Text = "* Achternaam:";
            // 
            // voornaamLbl
            // 
            this.voornaamLbl.AutoSize = true;
            this.voornaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.voornaamLbl.Location = new System.Drawing.Point(4, 60);
            this.voornaamLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voornaamLbl.Name = "voornaamLbl";
            this.voornaamLbl.Size = new System.Drawing.Size(100, 19);
            this.voornaamLbl.TabIndex = 1;
            this.voornaamLbl.Text = "* Voornaam:";
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Font = new System.Drawing.Font("Arial", 10F);
            this.tbVoornaam.Location = new System.Drawing.Point(141, 57);
            this.tbVoornaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(197, 27);
            this.tbVoornaam.TabIndex = 0;
            this.tbVoornaam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVoornaam_KeyPress);
            // 
            // locatieLbl
            // 
            this.locatieLbl.AutoSize = true;
            this.locatieLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.locatieLbl.Location = new System.Drawing.Point(20, 94);
            this.locatieLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locatieLbl.Name = "locatieLbl";
            this.locatieLbl.Size = new System.Drawing.Size(67, 19);
            this.locatieLbl.TabIndex = 5;
            this.locatieLbl.Text = "Locatie:";
            // 
            // tbLocatie
            // 
            this.tbLocatie.Font = new System.Drawing.Font("Arial", 10F);
            this.tbLocatie.Location = new System.Drawing.Point(141, 90);
            this.tbLocatie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(201, 27);
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
            this.btnOpslaan.Location = new System.Drawing.Point(575, 1);
            this.btnOpslaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(84, 60);
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
            this.btnAnnuleer.Location = new System.Drawing.Point(484, 0);
            this.btnAnnuleer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(84, 60);
            this.btnAnnuleer.TabIndex = 9;
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Visible = false;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // pnOptioneel
            // 
            this.pnOptioneel.BackColor = System.Drawing.SystemColors.Window;
            this.pnOptioneel.Controls.Add(this.afdelingLbl);
            this.pnOptioneel.Controls.Add(this.tbAfdeling);
            this.pnOptioneel.Controls.Add(this.kwaliteitLbl);
            this.pnOptioneel.Controls.Add(this.tbKwaliteitenP);
            this.pnOptioneel.Controls.Add(this.label2);
            this.pnOptioneel.Controls.Add(this.locatieLbl);
            this.pnOptioneel.Controls.Add(this.tbFunctie);
            this.pnOptioneel.Controls.Add(this.tbLocatie);
            this.pnOptioneel.Controls.Add(this.label4);
            this.pnOptioneel.Controls.Add(this.tbMobiel);
            this.pnOptioneel.Location = new System.Drawing.Point(408, 151);
            this.pnOptioneel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnOptioneel.Name = "pnOptioneel";
            this.pnOptioneel.Size = new System.Drawing.Size(364, 359);
            this.pnOptioneel.TabIndex = 24;
            this.pnOptioneel.Visible = false;
            // 
            // afdelingLbl
            // 
            this.afdelingLbl.AutoSize = true;
            this.afdelingLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.afdelingLbl.Location = new System.Drawing.Point(20, 161);
            this.afdelingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.afdelingLbl.Name = "afdelingLbl";
            this.afdelingLbl.Size = new System.Drawing.Size(73, 19);
            this.afdelingLbl.TabIndex = 9;
            this.afdelingLbl.Text = "Afdeling:";
            // 
            // tbAfdeling
            // 
            this.tbAfdeling.Font = new System.Drawing.Font("Arial", 10F);
            this.tbAfdeling.Location = new System.Drawing.Point(141, 158);
            this.tbAfdeling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAfdeling.Name = "tbAfdeling";
            this.tbAfdeling.Size = new System.Drawing.Size(201, 27);
            this.tbAfdeling.TabIndex = 8;
            // 
            // kwaliteitLbl
            // 
            this.kwaliteitLbl.AutoSize = true;
            this.kwaliteitLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.kwaliteitLbl.Location = new System.Drawing.Point(20, 193);
            this.kwaliteitLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kwaliteitLbl.Name = "kwaliteitLbl";
            this.kwaliteitLbl.Size = new System.Drawing.Size(91, 19);
            this.kwaliteitLbl.TabIndex = 7;
            this.kwaliteitLbl.Text = "Kwaliteiten:";
            // 
            // tbKwaliteitenP
            // 
            this.tbKwaliteitenP.Font = new System.Drawing.Font("Arial", 10F);
            this.tbKwaliteitenP.Location = new System.Drawing.Point(141, 193);
            this.tbKwaliteitenP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKwaliteitenP.Multiline = true;
            this.tbKwaliteitenP.Name = "tbKwaliteitenP";
            this.tbKwaliteitenP.Size = new System.Drawing.Size(201, 89);
            this.tbKwaliteitenP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Functie:";
            // 
            // tbFunctie
            // 
            this.tbFunctie.Font = new System.Drawing.Font("Arial", 10F);
            this.tbFunctie.Location = new System.Drawing.Point(141, 122);
            this.tbFunctie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFunctie.Name = "tbFunctie";
            this.tbFunctie.Size = new System.Drawing.Size(201, 27);
            this.tbFunctie.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(20, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mobiel:";
            // 
            // tbMobiel
            // 
            this.tbMobiel.Font = new System.Drawing.Font("Arial", 10F);
            this.tbMobiel.Location = new System.Drawing.Point(141, 57);
            this.tbMobiel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMobiel.MaxLength = 10;
            this.tbMobiel.Name = "tbMobiel";
            this.tbMobiel.Size = new System.Drawing.Size(201, 27);
            this.tbMobiel.TabIndex = 4;
            this.tbMobiel.Enter += new System.EventHandler(this.tbMobiel_Enter);
            this.tbMobiel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMobiel_KeyPress);
            this.tbMobiel.Leave += new System.EventHandler(this.tbMobiel_Leave);
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
            this.btnDelete.Location = new System.Drawing.Point(504, 1);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 62);
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
            this.btnWijzig.Location = new System.Drawing.Point(417, 1);
            this.btnWijzig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(79, 62);
            this.btnWijzig.TabIndex = 25;
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // contactSoortCbx
            // 
            this.contactSoortCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactSoortCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactSoortCbx.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactSoortCbx.FormattingEnabled = true;
            this.contactSoortCbx.Items.AddRange(new object[] {
            "Stagebegeleider",
            "Gastdocent",
            "Gastspreker"});
            this.contactSoortCbx.Location = new System.Drawing.Point(52, 102);
            this.contactSoortCbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contactSoortCbx.Name = "contactSoortCbx";
            this.contactSoortCbx.Size = new System.Drawing.Size(160, 26);
            this.contactSoortCbx.TabIndex = 20;
            this.contactSoortCbx.Visible = false;
            this.contactSoortCbx.SelectedValueChanged += new System.EventHandler(this.toonContactenInvoer);
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSoort.Font = new System.Drawing.Font("Arial", 9F);
            this.lblSoort.Location = new System.Drawing.Point(48, 78);
            this.lblSoort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(183, 17);
            this.lblSoort.TabIndex = 21;
            this.lblSoort.Text = "Selecteer het soort contact";
            this.lblSoort.Visible = false;
            // 
            // Hachternaam
            // 
            this.Hachternaam.Text = "Achternaam";
            // 
            // ContactenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 596);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContactenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ik";
            this.Load += new System.EventHandler(this.ContactenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.persoonPnl.ResumeLayout(false);
            this.persoonPnl.PerformLayout();
            this.pnOptioneel.ResumeLayout(false);
            this.pnOptioneel.PerformLayout();
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
        private System.Windows.Forms.Label kwaliteitLbl;
        private System.Windows.Forms.TextBox tbKwaliteitenP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFunctie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMobiel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ComboBox bedrijfCbx;
        private System.Windows.Forms.Label afdelingLbl;
        private System.Windows.Forms.TextBox tbAfdeling;
        private System.Windows.Forms.ComboBox contactSoortCbx;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.ColumnHeader Hachternaam;
    }
}