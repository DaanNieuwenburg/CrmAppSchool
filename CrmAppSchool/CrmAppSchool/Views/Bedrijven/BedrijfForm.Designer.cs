namespace CrmAppSchool.Views.Bedrijven
{
    partial class BedrijfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedrijfForm));
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lvBedrijven = new System.Windows.Forms.ListView();
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnVoegtoe = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.bedrijfPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHoofdlocatie = new System.Windows.Forms.TextBox();
            this.tbTelefoon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEadres = new System.Windows.Forms.TextBox();
            this.bedrijfsnaamLbl = new System.Windows.Forms.Label();
            this.tbBedrijfsnaam = new System.Windows.Forms.TextBox();
            this.pnbedrijf2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKwaliteiten = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.bedrijfPnl.SuspendLayout();
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
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(291, 14);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(175, 25);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.Text = "Zoeken...";
            this.tbSearch.Visible = false;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lvBedrijven
            // 
            this.lvBedrijven.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvBedrijven.BackColor = System.Drawing.Color.White;
            this.lvBedrijven.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contact});
            this.lvBedrijven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBedrijven.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBedrijven.Location = new System.Drawing.Point(0, 50);
            this.lvBedrijven.Name = "lvBedrijven";
            this.lvBedrijven.Size = new System.Drawing.Size(788, 434);
            this.lvBedrijven.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvBedrijven.TabIndex = 19;
            this.lvBedrijven.UseCompatibleStateImageBehavior = false;
            this.lvBedrijven.View = System.Windows.Forms.View.Tile;
            this.lvBedrijven.ItemActivate += new System.EventHandler(this.lvContacten_ItemActivate);
            // 
            // Contact
            // 
            this.Contact.Text = "";
            this.Contact.Width = this.lvBedrijven.Width;
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
            this.btnDelete.Visible = false;
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
            // bedrijfPnl
            // 
            this.bedrijfPnl.BackColor = System.Drawing.SystemColors.Window;
            this.bedrijfPnl.Controls.Add(this.label1);
            this.bedrijfPnl.Controls.Add(this.label8);
            this.bedrijfPnl.Controls.Add(this.label9);
            this.bedrijfPnl.Controls.Add(this.tbHoofdlocatie);
            this.bedrijfPnl.Controls.Add(this.tbTelefoon);
            this.bedrijfPnl.Controls.Add(this.label7);
            this.bedrijfPnl.Controls.Add(this.tbEadres);
            this.bedrijfPnl.Controls.Add(this.bedrijfsnaamLbl);
            this.bedrijfPnl.Controls.Add(this.tbBedrijfsnaam);
            this.bedrijfPnl.Location = new System.Drawing.Point(39, 128);
            this.bedrijfPnl.Name = "bedrijfPnl";
            this.bedrijfPnl.Size = new System.Drawing.Size(325, 182);
            this.bedrijfPnl.TabIndex = 27;
            this.bedrijfPnl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "*  Verplichte velden\r\n** Een van de velden verplicht";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(15, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "** Telefoonnr:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "* Hoofdlocatie:";
            // 
            // tbHoofdlocatie
            // 
            this.tbHoofdlocatie.Font = new System.Drawing.Font("Arial", 10F);
            this.tbHoofdlocatie.Location = new System.Drawing.Point(128, 52);
            this.tbHoofdlocatie.Name = "tbHoofdlocatie";
            this.tbHoofdlocatie.Size = new System.Drawing.Size(149, 23);
            this.tbHoofdlocatie.TabIndex = 4;
            // 
            // tbTelefoon
            // 
            this.tbTelefoon.Font = new System.Drawing.Font("Arial", 10F);
            this.tbTelefoon.Location = new System.Drawing.Point(128, 111);
            this.tbTelefoon.MaxLength = 10;
            this.tbTelefoon.Name = "tbTelefoon";
            this.tbTelefoon.Size = new System.Drawing.Size(149, 23);
            this.tbTelefoon.TabIndex = 6;
            this.tbTelefoon.Enter += new System.EventHandler(this.tbTelefoon_Enter);
            this.tbTelefoon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefoon_KeyPress);
            this.tbTelefoon.Leave += new System.EventHandler(this.tbTelefoon_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(15, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "** Emailadres:";
            // 
            // tbEadres
            // 
            this.tbEadres.Font = new System.Drawing.Font("Arial", 10F);
            this.tbEadres.Location = new System.Drawing.Point(128, 82);
            this.tbEadres.Name = "tbEadres";
            this.tbEadres.Size = new System.Drawing.Size(149, 23);
            this.tbEadres.TabIndex = 4;
            this.tbEadres.Enter += new System.EventHandler(this.tbEadres_Enter);
            this.tbEadres.Leave += new System.EventHandler(this.tbEadres_Leave);
            // 
            // bedrijfsnaamLbl
            // 
            this.bedrijfsnaamLbl.AutoSize = true;
            this.bedrijfsnaamLbl.Font = new System.Drawing.Font("Arial", 10F);
            this.bedrijfsnaamLbl.Location = new System.Drawing.Point(15, 27);
            this.bedrijfsnaamLbl.Name = "bedrijfsnaamLbl";
            this.bedrijfsnaamLbl.Size = new System.Drawing.Size(103, 16);
            this.bedrijfsnaamLbl.TabIndex = 1;
            this.bedrijfsnaamLbl.Text = "* Bedrijfsnaam:";
            // 
            // tbBedrijfsnaam
            // 
            this.tbBedrijfsnaam.Font = new System.Drawing.Font("Arial", 10F);
            this.tbBedrijfsnaam.Location = new System.Drawing.Point(128, 24);
            this.tbBedrijfsnaam.Name = "tbBedrijfsnaam";
            this.tbBedrijfsnaam.Size = new System.Drawing.Size(149, 23);
            this.tbBedrijfsnaam.TabIndex = 0;
            // 
            // pnbedrijf2
            // 
            this.pnbedrijf2.BackColor = System.Drawing.SystemColors.Window;
            this.pnbedrijf2.Controls.Add(this.label10);
            this.pnbedrijf2.Controls.Add(this.tbWebsite);
            this.pnbedrijf2.Controls.Add(this.label11);
            this.pnbedrijf2.Controls.Add(this.label6);
            this.pnbedrijf2.Controls.Add(this.tbKwaliteiten);
            this.pnbedrijf2.Controls.Add(this.tbContact);
            this.pnbedrijf2.Location = new System.Drawing.Point(378, 128);
            this.pnbedrijf2.Name = "pnbedrijf2";
            this.pnbedrijf2.Size = new System.Drawing.Size(351, 268);
            this.pnbedrijf2.TabIndex = 28;
            this.pnbedrijf2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(15, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Website:";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Font = new System.Drawing.Font("Arial", 10F);
            this.tbWebsite.Location = new System.Drawing.Point(126, 24);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(198, 23);
            this.tbWebsite.TabIndex = 6;
            this.tbWebsite.Enter += new System.EventHandler(this.tbWebsite_Enter);
            this.tbWebsite.Leave += new System.EventHandler(this.tbWebsite_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.Location = new System.Drawing.Point(15, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Kwaliteiten:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(13, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contactpersoon:";
            // 
            // tbKwaliteiten
            // 
            this.tbKwaliteiten.Font = new System.Drawing.Font("Arial", 10F);
            this.tbKwaliteiten.Location = new System.Drawing.Point(126, 85);
            this.tbKwaliteiten.Multiline = true;
            this.tbKwaliteiten.Name = "tbKwaliteiten";
            this.tbKwaliteiten.Size = new System.Drawing.Size(198, 111);
            this.tbKwaliteiten.TabIndex = 2;
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Arial", 10F);
            this.tbContact.Location = new System.Drawing.Point(126, 52);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(198, 23);
            this.tbContact.TabIndex = 2;
            // 
            // BedrijfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 484);
            this.Controls.Add(this.pnbedrijf2);
            this.Controls.Add(this.bedrijfPnl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.lvBedrijven);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BedrijfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bedrijven";
            this.Load += new System.EventHandler(this.ContactenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.bedrijfPnl.ResumeLayout(false);
            this.bedrijfPnl.PerformLayout();
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
        private System.Windows.Forms.ListView lvBedrijven;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.Panel bedrijfPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHoofdlocatie;
        private System.Windows.Forms.TextBox tbTelefoon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEadres;
        private System.Windows.Forms.Label bedrijfsnaamLbl;
        private System.Windows.Forms.TextBox tbBedrijfsnaam;
        private System.Windows.Forms.Panel pnbedrijf2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKwaliteiten;
        private System.Windows.Forms.TextBox tbContact;
    }
}