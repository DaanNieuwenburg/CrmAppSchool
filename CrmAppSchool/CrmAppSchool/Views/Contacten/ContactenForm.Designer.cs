namespace CrmAppSchool.Views.Contacten
{
    partial class ContactenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactenForm));
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnVoegtoe = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(400, 19);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(123, 16);
            this.lblGebruiker.TabIndex = 12;
            this.lblGebruiker.Text = "U bent ingelogd als:";
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
            this.btnZoeken.Location = new System.Drawing.Point(277, 1);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(59, 50);
            this.btnZoeken.TabIndex = 16;
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoegtoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnVoegtoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoegtoe.BackgroundImage")));
            this.btnVoegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoegtoe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoegtoe.FlatAppearance.BorderSize = 0;
            this.btnVoegtoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoegtoe.Location = new System.Drawing.Point(212, 1);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(59, 50);
            this.btnVoegtoe.TabIndex = 15;
            this.btnVoegtoe.UseVisualStyleBackColor = false;
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
            this.pbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(0, 1);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(595, 50);
            this.pbHeader.TabIndex = 13;
            this.pbHeader.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(96, 15);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(175, 25);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.Text = "Zoeken...";
            this.tbSearch.Visible = false;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(335, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 50);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ContactenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactenForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
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
    }
}