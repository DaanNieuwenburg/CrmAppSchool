﻿namespace CrmAppSchool.Views.Gebruikers
{
    partial class BewerkGebruikerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BewerkGebruikerForm));
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.nieuwWachtwoordTxb = new System.Windows.Forms.TextBox();
            this.wachtwoordTitelLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBevestig = new System.Windows.Forms.TextBox();
            this.lblWachtwoordhead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHeader
            // 
            this.pbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-80, -3);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(636, 50);
            this.pbHeader.TabIndex = 13;
            this.pbHeader.TabStop = false;
            // 
            // nieuwWachtwoordTxb
            // 
            this.nieuwWachtwoordTxb.Font = new System.Drawing.Font("Arial", 11F);
            this.nieuwWachtwoordTxb.Location = new System.Drawing.Point(86, 97);
            this.nieuwWachtwoordTxb.Name = "nieuwWachtwoordTxb";
            this.nieuwWachtwoordTxb.Size = new System.Drawing.Size(161, 24);
            this.nieuwWachtwoordTxb.TabIndex = 14;
            this.nieuwWachtwoordTxb.UseSystemPasswordChar = true;
            // 
            // wachtwoordTitelLbl
            // 
            this.wachtwoordTitelLbl.AutoSize = true;
            this.wachtwoordTitelLbl.Font = new System.Drawing.Font("Arial", 11F);
            this.wachtwoordTitelLbl.Location = new System.Drawing.Point(12, 100);
            this.wachtwoordTitelLbl.Name = "wachtwoordTitelLbl";
            this.wachtwoordTitelLbl.Size = new System.Drawing.Size(52, 17);
            this.wachtwoordTitelLbl.TabIndex = 15;
            this.wachtwoordTitelLbl.Text = "Nieuw:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(71, 287);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 17;
            this.errorLbl.Visible = false;
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
            this.btnDelete.Location = new System.Drawing.Point(205, -1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 48);
            this.btnDelete.TabIndex = 17;
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
            this.btnWijzig.Location = new System.Drawing.Point(140, -1);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(59, 48);
            this.btnWijzig.TabIndex = 16;
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F);
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bevestig:";
            // 
            // tbBevestig
            // 
            this.tbBevestig.Font = new System.Drawing.Font("Arial", 11F);
            this.tbBevestig.Location = new System.Drawing.Point(86, 135);
            this.tbBevestig.Name = "tbBevestig";
            this.tbBevestig.Size = new System.Drawing.Size(161, 24);
            this.tbBevestig.TabIndex = 15;
            this.tbBevestig.UseSystemPasswordChar = true;
            // 
            // lblWachtwoordhead
            // 
            this.lblWachtwoordhead.AutoSize = true;
            this.lblWachtwoordhead.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWachtwoordhead.Location = new System.Drawing.Point(11, 67);
            this.lblWachtwoordhead.Name = "lblWachtwoordhead";
            this.lblWachtwoordhead.Size = new System.Drawing.Size(109, 19);
            this.lblWachtwoordhead.TabIndex = 22;
            this.lblWachtwoordhead.Text = "Wachtwoord";
            // 
            // BewerkGebruikerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.lblWachtwoordhead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBevestig);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.wachtwoordTitelLbl);
            this.Controls.Add(this.nieuwWachtwoordTxb);
            this.Controls.Add(this.pbHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 340);
            this.MinimumSize = new System.Drawing.Size(300, 340);
            this.Name = "BewerkGebruikerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BewerkGebruikerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.TextBox nieuwWachtwoordTxb;
        private System.Windows.Forms.Label wachtwoordTitelLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBevestig;
        private System.Windows.Forms.Label lblWachtwoordhead;
    }
}