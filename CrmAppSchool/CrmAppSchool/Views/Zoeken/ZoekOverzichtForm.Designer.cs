namespace CrmAppSchool.Views.Zoeken
{
    partial class ZoekOverzichtForm
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
            this.resultatenLvw = new System.Windows.Forms.ListView();
            this.voornaamHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.achternaamHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bedrijfHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.functieHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kwaliteitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // resultatenLvw
            // 
            this.resultatenLvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultatenLvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.voornaamHeader,
            this.achternaamHeader,
            this.bedrijfHeader,
            this.functieHeader,
            this.kwaliteitHeader});
            this.resultatenLvw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatenLvw.Location = new System.Drawing.Point(12, 65);
            this.resultatenLvw.Name = "resultatenLvw";
            this.resultatenLvw.Size = new System.Drawing.Size(608, 352);
            this.resultatenLvw.TabIndex = 15;
            this.resultatenLvw.UseCompatibleStateImageBehavior = false;
            this.resultatenLvw.View = System.Windows.Forms.View.Details;
            // 
            // voornaamHeader
            // 
            this.voornaamHeader.Text = "Voornaam";
            this.voornaamHeader.Width = 89;
            // 
            // achternaamHeader
            // 
            this.achternaamHeader.Text = "Achternaam";
            this.achternaamHeader.Width = 85;
            // 
            // bedrijfHeader
            // 
            this.bedrijfHeader.Text = "Bedrijf";
            this.bedrijfHeader.Width = 74;
            // 
            // functieHeader
            // 
            this.functieHeader.Text = "Functie";
            this.functieHeader.Width = 98;
            // 
            // kwaliteitHeader
            // 
            this.kwaliteitHeader.Text = "Kwaliteit";
            this.kwaliteitHeader.Width = 74;
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-10, -1);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(664, 50);
            this.pbHeader.TabIndex = 14;
            this.pbHeader.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHome.BackgroundImage = global::CrmAppSchool.Properties.Resources.picture_Home;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(2, -1);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(61, 50);
            this.pbHome.TabIndex = 16;
            this.pbHome.TabStop = false;
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(418, 18);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(123, 16);
            this.lblGebruiker.TabIndex = 19;
            this.lblGebruiker.Text = "U bent ingelogd als:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(100, 94);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(382, 13);
            this.errorLbl.TabIndex = 20;
            this.errorLbl.Text = "Helaas kon het systeem geen resultaten vinden die aan de zoekcriteria voldoen";
            this.errorLbl.Visible = false;
            // 
            // ZoekOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 429);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.resultatenLvw);
            this.Controls.Add(this.pbHeader);
            this.Name = "ZoekOverzichtForm";
            this.Text = "Gevonde resultaten";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.ListView resultatenLvw;
        private System.Windows.Forms.ColumnHeader voornaamHeader;
        private System.Windows.Forms.ColumnHeader achternaamHeader;
        private System.Windows.Forms.ColumnHeader bedrijfHeader;
        private System.Windows.Forms.ColumnHeader functieHeader;
        private System.Windows.Forms.ColumnHeader kwaliteitHeader;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.Label errorLbl;
    }
}