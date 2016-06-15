namespace CrmAppSchool.Views.Gebruikers
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
            this.gebruikersnaamTxb = new System.Windows.Forms.TextBox();
            this.wachtwoordTxb = new System.Windows.Forms.TextBox();
            this.gebruikersnaamLbl = new System.Windows.Forms.Label();
            this.wachtwoordLbl = new System.Windows.Forms.Label();
            this.soortGebruikerCbx = new System.Windows.Forms.ComboBox();
            this.gebruikerLbl = new System.Windows.Forms.Label();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.gebruikerLvw = new System.Windows.Forms.ListView();
            this.gebruikersnaamHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soortGebruikerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voegToeBtn = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_achternaam = new System.Windows.Forms.TextBox();
            this.tb_voornaam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // gebruikersnaamTxb
            // 
            this.gebruikersnaamTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gebruikersnaamTxb.Font = new System.Drawing.Font("Arial", 10F);
            this.gebruikersnaamTxb.Location = new System.Drawing.Point(12, 86);
            this.gebruikersnaamTxb.MaxLength = 25;
            this.gebruikersnaamTxb.Name = "gebruikersnaamTxb";
            this.gebruikersnaamTxb.Size = new System.Drawing.Size(148, 23);
            this.gebruikersnaamTxb.TabIndex = 1;
            // 
            // wachtwoordTxb
            // 
            this.wachtwoordTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.soortGebruikerCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soortGebruikerCbx.Font = new System.Drawing.Font("Arial", 10F);
            this.soortGebruikerCbx.FormattingEnabled = true;
            this.soortGebruikerCbx.Items.AddRange(new object[] {
            "Docent",
            "Student"});
            this.soortGebruikerCbx.Location = new System.Drawing.Point(340, 85);
            this.soortGebruikerCbx.Name = "soortGebruikerCbx";
            this.soortGebruikerCbx.Size = new System.Drawing.Size(132, 24);
            this.soortGebruikerCbx.TabIndex = 3;
            this.soortGebruikerCbx.SelectedIndexChanged += new System.EventHandler(this.soortGebruikerCbx_SelectedIndexChanged);
            // 
            // gebruikerLbl
            // 
            this.gebruikerLbl.AutoSize = true;
            this.gebruikerLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikerLbl.Location = new System.Drawing.Point(337, 60);
            this.gebruikerLbl.Name = "gebruikerLbl";
            this.gebruikerLbl.Size = new System.Drawing.Size(100, 16);
            this.gebruikerLbl.TabIndex = 7;
            this.gebruikerLbl.Text = "Soort gebruiker:";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(293, 20);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(123, 16);
            this.lblGebruiker.TabIndex = 8;
            this.lblGebruiker.Text = "U bent ingelogd als:";
            // 
            // gebruikerLvw
            // 
            this.gebruikerLvw.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.gebruikerLvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gebruikerLvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gebruikersnaamHeader,
            this.soortGebruikerHeader});
            this.gebruikerLvw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gebruikerLvw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikerLvw.Location = new System.Drawing.Point(12, 200);
            this.gebruikerLvw.MultiSelect = false;
            this.gebruikerLvw.Name = "gebruikerLvw";
            this.gebruikerLvw.Size = new System.Drawing.Size(503, 276);
            this.gebruikerLvw.TabIndex = 12;
            this.gebruikerLvw.UseCompatibleStateImageBehavior = false;
            this.gebruikerLvw.View = System.Windows.Forms.View.Details;
            this.gebruikerLvw.ItemActivate += new System.EventHandler(this.gebruikerLvw_ItemActivate);
            // 
            // gebruikersnaamHeader
            // 
            this.gebruikersnaamHeader.Text = "Gebruikersnaam";
            this.gebruikersnaamHeader.Width = 223;
            // 
            // soortGebruikerHeader
            // 
            this.soortGebruikerHeader.Text = "Soort gebruiker";
            this.soortGebruikerHeader.Width = 100;
            // 
            // voegToeBtn
            // 
            this.voegToeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.voegToeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.voegToeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voegToeBtn.BackgroundImage")));
            this.voegToeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.voegToeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voegToeBtn.FlatAppearance.BorderSize = 0;
            this.voegToeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voegToeBtn.Location = new System.Drawing.Point(199, 0);
            this.voegToeBtn.Name = "voegToeBtn";
            this.voegToeBtn.Size = new System.Drawing.Size(59, 50);
            this.voegToeBtn.TabIndex = 0;
            this.voegToeBtn.UseVisualStyleBackColor = false;
            this.voegToeBtn.Click += new System.EventHandler(this.voegToeBtn_Click);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHome.BackgroundImage = global::CrmAppSchool.Properties.Resources.picture_Home;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(-2, -1);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(61, 50);
            this.pbHome.TabIndex = 10;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbHeader.Location = new System.Drawing.Point(0, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(515, 50);
            this.pbHeader.TabIndex = 9;
            this.pbHeader.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Achternaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Voornaam:";
            // 
            // tb_achternaam
            // 
            this.tb_achternaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_achternaam.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_achternaam.Location = new System.Drawing.Point(177, 142);
            this.tb_achternaam.Name = "tb_achternaam";
            this.tb_achternaam.Size = new System.Drawing.Size(148, 23);
            this.tb_achternaam.TabIndex = 14;
            // 
            // tb_voornaam
            // 
            this.tb_voornaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_voornaam.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_voornaam.Location = new System.Drawing.Point(177, 86);
            this.tb_voornaam.MaxLength = 25;
            this.tb_voornaam.Name = "tb_voornaam";
            this.tb_voornaam.Size = new System.Drawing.Size(148, 23);
            this.tb_voornaam.TabIndex = 13;
            // 
            // voegGebruikerToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_achternaam);
            this.Controls.Add(this.tb_voornaam);
            this.Controls.Add(this.gebruikerLvw);
            this.Controls.Add(this.voegToeBtn);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "voegGebruikerToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gebruikersbeheer";
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
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.ListView gebruikerLvw;
        private System.Windows.Forms.ColumnHeader gebruikersnaamHeader;
        private System.Windows.Forms.ColumnHeader soortGebruikerHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_achternaam;
        private System.Windows.Forms.TextBox tb_voornaam;
    }
}