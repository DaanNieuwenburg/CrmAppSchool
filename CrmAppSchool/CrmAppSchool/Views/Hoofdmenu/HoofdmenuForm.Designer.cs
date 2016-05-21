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
            this.SuspendLayout();
            // 
            // gebruikerLbl
            // 
            this.gebruikerLbl.AutoSize = true;
            this.gebruikerLbl.Location = new System.Drawing.Point(12, 484);
            this.gebruikerLbl.Name = "gebruikerLbl";
            this.gebruikerLbl.Size = new System.Drawing.Size(101, 13);
            this.gebruikerLbl.TabIndex = 0;
            this.gebruikerLbl.Text = "U bent ingelogd als:";
            // 
            // voegGebruikerToeBtn
            // 
            this.voegGebruikerToeBtn.Location = new System.Drawing.Point(121, 313);
            this.voegGebruikerToeBtn.Name = "voegGebruikerToeBtn";
            this.voegGebruikerToeBtn.Size = new System.Drawing.Size(123, 23);
            this.voegGebruikerToeBtn.TabIndex = 1;
            this.voegGebruikerToeBtn.Text = "Voeg gebruiker toe";
            this.voegGebruikerToeBtn.UseVisualStyleBackColor = true;
            this.voegGebruikerToeBtn.Click += new System.EventHandler(this.voegGebruikerToeBtn_Click);
            // 
            // HoofdmenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 506);
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
    }
}