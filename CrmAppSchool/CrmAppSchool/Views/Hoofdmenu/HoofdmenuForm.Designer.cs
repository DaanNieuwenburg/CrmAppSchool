namespace CrmAppSchool.Views.Hoofdmenu
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
            this.gebruikerLbl = new System.Windows.Forms.Label();
            this.voegGebruikerToeBtn = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnProfiel = new System.Windows.Forms.Button();
            this.btnOpdrachten = new System.Windows.Forms.Button();
            this.btnContacten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gebruikerLbl
            // 
            this.gebruikerLbl.AutoSize = true;
            this.gebruikerLbl.Location = new System.Drawing.Point(25, 387);
            this.gebruikerLbl.Name = "gebruikerLbl";
            this.gebruikerLbl.Size = new System.Drawing.Size(101, 13);
            this.gebruikerLbl.TabIndex = 0;
            this.gebruikerLbl.Text = "U bent ingelogd als:";
            // 
            // voegGebruikerToeBtn
            // 
            this.voegGebruikerToeBtn.Location = new System.Drawing.Point(28, 332);
            this.voegGebruikerToeBtn.Name = "voegGebruikerToeBtn";
            this.voegGebruikerToeBtn.Size = new System.Drawing.Size(123, 23);
            this.voegGebruikerToeBtn.TabIndex = 1;
            this.voegGebruikerToeBtn.Text = "Voeg gebruiker toe";
            this.voegGebruikerToeBtn.UseVisualStyleBackColor = true;
            this.voegGebruikerToeBtn.Click += new System.EventHandler(this.voegGebruikerToeBtn_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Zoeken;
            this.btnZoeken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoeken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoeken.FlatAppearance.BorderSize = 0;
            this.btnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoeken.Location = new System.Drawing.Point(188, 39);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(139, 115);
            this.btnZoeken.TabIndex = 3;
            this.btnZoeken.UseVisualStyleBackColor = true;
            // 
            // btnProfiel
            // 
            this.btnProfiel.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Profiel;
            this.btnProfiel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfiel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfiel.FlatAppearance.BorderSize = 0;
            this.btnProfiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiel.Location = new System.Drawing.Point(28, 173);
            this.btnProfiel.Name = "btnProfiel";
            this.btnProfiel.Size = new System.Drawing.Size(139, 115);
            this.btnProfiel.TabIndex = 4;
            this.btnProfiel.UseVisualStyleBackColor = true;
            // 
            // btnOpdrachten
            // 
            this.btnOpdrachten.BackgroundImage = global::CrmAppSchool.Properties.Resources.btnOpdrachten;
            this.btnOpdrachten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpdrachten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpdrachten.FlatAppearance.BorderSize = 0;
            this.btnOpdrachten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpdrachten.Location = new System.Drawing.Point(188, 173);
            this.btnOpdrachten.Name = "btnOpdrachten";
            this.btnOpdrachten.Size = new System.Drawing.Size(139, 115);
            this.btnOpdrachten.TabIndex = 5;
            this.btnOpdrachten.UseVisualStyleBackColor = true;
            // 
            // btnContacten
            // 
            this.btnContacten.BackColor = System.Drawing.Color.Transparent;
            this.btnContacten.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Contacten2;
            this.btnContacten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContacten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacten.FlatAppearance.BorderSize = 0;
            this.btnContacten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacten.Location = new System.Drawing.Point(28, 39);
            this.btnContacten.Name = "btnContacten";
            this.btnContacten.Size = new System.Drawing.Size(139, 115);
            this.btnContacten.TabIndex = 2;
            this.btnContacten.UseVisualStyleBackColor = false;
            // 
            // HoofdmenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 428);
            this.Controls.Add(this.btnOpdrachten);
            this.Controls.Add(this.btnProfiel);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnContacten);
            this.Controls.Add(this.voegGebruikerToeBtn);
            this.Controls.Add(this.gebruikerLbl);
            this.Name = "HoofdmenuForm";
            this.Text = "Hoofdmenu";
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
    }
}