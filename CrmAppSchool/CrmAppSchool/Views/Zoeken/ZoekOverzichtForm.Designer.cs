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
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // resultatenLvw
            // 
            this.resultatenLvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.voornaamHeader,
            this.achternaamHeader,
            this.bedrijfHeader,
            this.functieHeader,
            this.kwaliteitHeader});
            this.resultatenLvw.Location = new System.Drawing.Point(72, 65);
            this.resultatenLvw.Name = "resultatenLvw";
            this.resultatenLvw.Size = new System.Drawing.Size(484, 352);
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
            this.pbHeader.Size = new System.Drawing.Size(664, 60);
            this.pbHeader.TabIndex = 14;
            this.pbHeader.TabStop = false;
            // 
            // ZoekOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 429);
            this.Controls.Add(this.resultatenLvw);
            this.Controls.Add(this.pbHeader);
            this.Name = "ZoekOverzichtForm";
            this.Text = "Gevonde resultaten";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.ListView resultatenLvw;
        private System.Windows.Forms.ColumnHeader voornaamHeader;
        private System.Windows.Forms.ColumnHeader achternaamHeader;
        private System.Windows.Forms.ColumnHeader bedrijfHeader;
        private System.Windows.Forms.ColumnHeader functieHeader;
        private System.Windows.Forms.ColumnHeader kwaliteitHeader;
    }
}