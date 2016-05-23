﻿namespace CrmAppSchool.Views.Hoofdmenu
{
    partial class HoofdmenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoofdmenuForm));
            this.gebruikerLbl = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.btnOpdrachten = new System.Windows.Forms.Button();
            this.btnProfiel = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnContacten = new System.Windows.Forms.Button();
            this.voegGebruikerToeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // gebruikerLbl
            // 
            this.gebruikerLbl.AutoSize = true;
            this.gebruikerLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.gebruikerLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikerLbl.ForeColor = System.Drawing.Color.White;
            this.gebruikerLbl.Location = new System.Drawing.Point(615, 20);
            this.gebruikerLbl.Name = "gebruikerLbl";
            this.gebruikerLbl.Size = new System.Drawing.Size(123, 16);
            this.gebruikerLbl.TabIndex = 0;
            this.gebruikerLbl.Text = "U bent ingelogd als:";
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHome.BackgroundImage = global::CrmAppSchool.Properties.Resources.picture_Home;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(1, 0);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(61, 50);
            this.pbHome.TabIndex = 7;
            this.pbHome.TabStop = false;
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(1, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(839, 50);
            this.pbHeader.TabIndex = 6;
            this.pbHeader.TabStop = false;
            // 
            // btnOpdrachten
            // 
            this.btnOpdrachten.BackgroundImage = global::CrmAppSchool.Properties.Resources.btnOpdrachten;
            this.btnOpdrachten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpdrachten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpdrachten.FlatAppearance.BorderSize = 0;
            this.btnOpdrachten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpdrachten.Location = new System.Drawing.Point(184, 231);
            this.btnOpdrachten.Name = "btnOpdrachten";
            this.btnOpdrachten.Size = new System.Drawing.Size(139, 115);
            this.btnOpdrachten.TabIndex = 5;
            this.btnOpdrachten.UseVisualStyleBackColor = true;
            // 
            // btnProfiel
            // 
            this.btnProfiel.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Profiel;
            this.btnProfiel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfiel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfiel.FlatAppearance.BorderSize = 0;
            this.btnProfiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiel.Location = new System.Drawing.Point(24, 231);
            this.btnProfiel.Name = "btnProfiel";
            this.btnProfiel.Size = new System.Drawing.Size(139, 115);
            this.btnProfiel.TabIndex = 4;
            this.btnProfiel.UseVisualStyleBackColor = true;
            this.btnProfiel.Click += new System.EventHandler(this.btnProfiel_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Zoeken;
            this.btnZoeken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoeken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoeken.FlatAppearance.BorderSize = 0;
            this.btnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoeken.Location = new System.Drawing.Point(184, 97);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(139, 115);
            this.btnZoeken.TabIndex = 3;
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnContacten
            // 
            this.btnContacten.BackColor = System.Drawing.Color.Transparent;
            this.btnContacten.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Contacten2;
            this.btnContacten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContacten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacten.FlatAppearance.BorderSize = 0;
            this.btnContacten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacten.Location = new System.Drawing.Point(24, 97);
            this.btnContacten.Name = "btnContacten";
            this.btnContacten.Size = new System.Drawing.Size(139, 115);
            this.btnContacten.TabIndex = 2;
            this.btnContacten.UseVisualStyleBackColor = false;
            this.btnContacten.Click += new System.EventHandler(this.btnContacten_Click);
            // 
            // voegGebruikerToeBtn
            // 
            this.voegGebruikerToeBtn.BackColor = System.Drawing.Color.Transparent;
            this.voegGebruikerToeBtn.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_RegistreerPersoon;
            this.voegGebruikerToeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.voegGebruikerToeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voegGebruikerToeBtn.FlatAppearance.BorderSize = 0;
            this.voegGebruikerToeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voegGebruikerToeBtn.Location = new System.Drawing.Point(338, 97);
            this.voegGebruikerToeBtn.Name = "voegGebruikerToeBtn";
            this.voegGebruikerToeBtn.Size = new System.Drawing.Size(140, 115);
            this.voegGebruikerToeBtn.TabIndex = 1;
            this.voegGebruikerToeBtn.UseVisualStyleBackColor = false;
            this.voegGebruikerToeBtn.Click += new System.EventHandler(this.voegGebruikerToeBtn_Click);
            // 
            // HoofdmenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 428);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.gebruikerLbl);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.btnOpdrachten);
            this.Controls.Add(this.btnProfiel);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnContacten);
            this.Controls.Add(this.voegGebruikerToeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoofdmenuForm";
            this.Text = "Hoofdmenu";
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gebruikerLbl;
        private System.Windows.Forms.Button voegGebruikerToeBtn;
        private System.Windows.Forms.Button btnContacten;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Button btnProfiel;
        private System.Windows.Forms.Button btnOpdrachten;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.PictureBox pbHome;
    }
}