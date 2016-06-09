namespace CrmAppSchool.Views.Opdrachten
{
    partial class opdrachtEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opdrachtEditForm));
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbOmschrijving = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.bedrijfCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.BackColor = System.Drawing.Color.White;
            this.tbNaam.Font = new System.Drawing.Font("Arial", 12F);
            this.tbNaam.Location = new System.Drawing.Point(139, 76);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(372, 30);
            this.tbNaam.TabIndex = 0;
            // 
            // tbOmschrijving
            // 
            this.tbOmschrijving.BackColor = System.Drawing.Color.White;
            this.tbOmschrijving.Font = new System.Drawing.Font("Arial", 10F);
            this.tbOmschrijving.Location = new System.Drawing.Point(139, 145);
            this.tbOmschrijving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOmschrijving.Multiline = true;
            this.tbOmschrijving.Name = "tbOmschrijving";
            this.tbOmschrijving.Size = new System.Drawing.Size(372, 127);
            this.tbOmschrijving.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Arial", 11F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(139, 313);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(188, 29);
            this.cbStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "naam";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "omschrijving";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "status";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(307, 17);
            this.lblGebruiker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(152, 19);
            this.lblGebruiker.TabIndex = 11;
            this.lblGebruiker.Text = "U bent ingelogd als:";
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
            this.btnOpslaan.Location = new System.Drawing.Point(139, -4);
            this.btnOpslaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(79, 62);
            this.btnOpslaan.TabIndex = 13;
            this.btnOpslaan.UseVisualStyleBackColor = false;
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
            this.btnAnnuleer.Location = new System.Drawing.Point(220, -4);
            this.btnAnnuleer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(79, 62);
            this.btnAnnuleer.TabIndex = 10;
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-99, -4);
            this.pbHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(827, 62);
            this.pbHeader.TabIndex = 12;
            this.pbHeader.TabStop = false;
            // 
            // bedrijfCbx
            // 
            this.bedrijfCbx.FormattingEnabled = true;
            this.bedrijfCbx.Location = new System.Drawing.Point(139, 387);
            this.bedrijfCbx.Name = "bedrijfCbx";
            this.bedrijfCbx.Size = new System.Drawing.Size(188, 24);
            this.bedrijfCbx.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bedrijf";
            // 
            // opdrachtEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bedrijfCbx);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbOmschrijving);
            this.Controls.Add(this.tbNaam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "opdrachtEditForm";
            this.Text = "Bewerk Opdracht";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbOmschrijving;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.ComboBox bedrijfCbx;
        private System.Windows.Forms.Label label4;
    }
}