namespace CrmAppSchool.Views.Zoeken
{
    partial class ZoekenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoekenForm));
            this.zoekcriteriaTxb = new System.Windows.Forms.TextBox();
            this.filterLbl = new System.Windows.Forms.Label();
            this.zoekfilterCbx = new System.Windows.Forms.ComboBox();
            this.lblgebruiker = new System.Windows.Forms.Label();
            this.cbZoeknaar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.btnZoek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // zoekcriteriaTxb
            // 
            this.zoekcriteriaTxb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoekcriteriaTxb.Location = new System.Drawing.Point(52, 118);
            this.zoekcriteriaTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zoekcriteriaTxb.Name = "zoekcriteriaTxb";
            this.zoekcriteriaTxb.Size = new System.Drawing.Size(348, 29);
            this.zoekcriteriaTxb.TabIndex = 1;
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.filterLbl.Location = new System.Drawing.Point(276, 170);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(63, 17);
            this.filterLbl.TabIndex = 2;
            this.filterLbl.Text = "Zoek op:";
            this.filterLbl.Visible = false;
            // 
            // zoekfilterCbx
            // 
            this.zoekfilterCbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.zoekfilterCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoekfilterCbx.Font = new System.Drawing.Font("Arial", 10F);
            this.zoekfilterCbx.FormattingEnabled = true;
            this.zoekfilterCbx.Items.AddRange(new object[] {
            "Voornaam",
            "Achternaam",
            "Kwaliteit",
            "Organisatie",
            "Locatie",
            "Functie"});
            this.zoekfilterCbx.Location = new System.Drawing.Point(276, 202);
            this.zoekfilterCbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zoekfilterCbx.Name = "zoekfilterCbx";
            this.zoekfilterCbx.Size = new System.Drawing.Size(160, 27);
            this.zoekfilterCbx.TabIndex = 3;
            this.zoekfilterCbx.Visible = false;
            // 
            // lblgebruiker
            // 
            this.lblgebruiker.AutoSize = true;
            this.lblgebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblgebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgebruiker.ForeColor = System.Drawing.Color.White;
            this.lblgebruiker.Location = new System.Drawing.Point(311, 26);
            this.lblgebruiker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgebruiker.Name = "lblgebruiker";
            this.lblgebruiker.Size = new System.Drawing.Size(152, 19);
            this.lblgebruiker.TabIndex = 12;
            this.lblgebruiker.Text = "U bent ingelogd als:";
            // 
            // cbZoeknaar
            // 
            this.cbZoeknaar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbZoeknaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbZoeknaar.Font = new System.Drawing.Font("Arial", 10F);
            this.cbZoeknaar.FormattingEnabled = true;
            this.cbZoeknaar.Items.AddRange(new object[] {
            "Gebruiker",
            "Bedrijf",
            "Stagebegeleider",
            "Gastdocent",
            "Gastspreker"});
            this.cbZoeknaar.Location = new System.Drawing.Point(52, 202);
            this.cbZoeknaar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbZoeknaar.Name = "cbZoeknaar";
            this.cbZoeknaar.Size = new System.Drawing.Size(160, 27);
            this.cbZoeknaar.TabIndex = 16;
            this.cbZoeknaar.SelectedIndexChanged += new System.EventHandler(this.cbZoeknaar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(52, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Zoek naar:";
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHome.BackgroundImage = global::CrmAppSchool.Properties.Resources.picture_Home;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(3, 2);
            this.pbHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(85, 62);
            this.pbHome.TabIndex = 14;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-36, -10);
            this.pbHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(692, 74);
            this.pbHeader.TabIndex = 13;
            this.pbHeader.TabStop = false;
            // 
            // btnZoek
            // 
            this.btnZoek.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Zoeken2;
            this.btnZoek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoek.FlatAppearance.BorderSize = 0;
            this.btnZoek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoek.Location = new System.Drawing.Point(455, 98);
            this.btnZoek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(100, 70);
            this.btnZoek.TabIndex = 0;
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // ZoekenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 256);
            this.Controls.Add(this.cbZoeknaar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblgebruiker);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.zoekfilterCbx);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.zoekcriteriaTxb);
            this.Controls.Add(this.btnZoek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ZoekenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoeken";
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.TextBox zoekcriteriaTxb;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.ComboBox zoekfilterCbx;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblgebruiker;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.ComboBox cbZoeknaar;
        private System.Windows.Forms.Label label1;
    }
}