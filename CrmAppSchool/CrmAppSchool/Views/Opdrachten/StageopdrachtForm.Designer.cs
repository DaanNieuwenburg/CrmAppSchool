namespace CrmAppSchool.Views.Opdrachten
{
    partial class StageopdrachtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StageopdrachtForm));
            this.bZoek = new System.Windows.Forms.Button();
            this.tbZoek = new System.Windows.Forms.TextBox();
            this.lbStage = new System.Windows.Forms.ListBox();
            this.bToevoegen = new System.Windows.Forms.Button();
            this.bVerwijderen = new System.Windows.Forms.Button();
            this.bAanpassen = new System.Windows.Forms.Button();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnVoegtoe = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.btnZoeken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // bZoek
            // 
            this.bZoek.Location = new System.Drawing.Point(695, 71);
            this.bZoek.Margin = new System.Windows.Forms.Padding(2);
            this.bZoek.Name = "bZoek";
            this.bZoek.Size = new System.Drawing.Size(56, 19);
            this.bZoek.TabIndex = 0;
            this.bZoek.Text = "Zoek";
            this.bZoek.UseVisualStyleBackColor = true;
            this.bZoek.Click += new System.EventHandler(this.bZoek_Click);
            // 
            // tbZoek
            // 
            this.tbZoek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.tbZoek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbZoek.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZoek.ForeColor = System.Drawing.Color.White;
            this.tbZoek.Location = new System.Drawing.Point(248, 11);
            this.tbZoek.Margin = new System.Windows.Forms.Padding(2);
            this.tbZoek.Name = "tbZoek";
            this.tbZoek.Size = new System.Drawing.Size(248, 25);
            this.tbZoek.TabIndex = 1;
            this.tbZoek.Visible = false;
            // 
            // lbStage
            // 
            this.lbStage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStage.FormattingEnabled = true;
            this.lbStage.Location = new System.Drawing.Point(167, 71);
            this.lbStage.Margin = new System.Windows.Forms.Padding(2);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(478, 262);
            this.lbStage.TabIndex = 2;
            this.lbStage.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bToevoegen
            // 
            this.bToevoegen.Location = new System.Drawing.Point(241, 383);
            this.bToevoegen.Margin = new System.Windows.Forms.Padding(2);
            this.bToevoegen.Name = "bToevoegen";
            this.bToevoegen.Size = new System.Drawing.Size(70, 19);
            this.bToevoegen.TabIndex = 3;
            this.bToevoegen.Text = "Toevoegen";
            this.bToevoegen.UseVisualStyleBackColor = true;
            this.bToevoegen.Click += new System.EventHandler(this.bToevoegen_Click);
            // 
            // bVerwijderen
            // 
            this.bVerwijderen.Location = new System.Drawing.Point(492, 383);
            this.bVerwijderen.Margin = new System.Windows.Forms.Padding(2);
            this.bVerwijderen.Name = "bVerwijderen";
            this.bVerwijderen.Size = new System.Drawing.Size(70, 19);
            this.bVerwijderen.TabIndex = 4;
            this.bVerwijderen.Text = "Verwijderen";
            this.bVerwijderen.UseVisualStyleBackColor = true;
            this.bVerwijderen.Click += new System.EventHandler(this.bVerwijderen_Click);
            // 
            // bAanpassen
            // 
            this.bAanpassen.Location = new System.Drawing.Point(361, 383);
            this.bAanpassen.Margin = new System.Windows.Forms.Padding(2);
            this.bAanpassen.Name = "bAanpassen";
            this.bAanpassen.Size = new System.Drawing.Size(70, 19);
            this.bAanpassen.TabIndex = 5;
            this.bAanpassen.Text = "Aanpassen";
            this.bAanpassen.UseVisualStyleBackColor = true;
            this.bAanpassen.Click += new System.EventHandler(this.bAanpassen_Click);
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblGebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.Color.White;
            this.lblGebruiker.Location = new System.Drawing.Point(655, 16);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(123, 16);
            this.lblGebruiker.TabIndex = 12;
            this.lblGebruiker.Text = "U bent ingelogd als:";
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
            this.btnDelete.Location = new System.Drawing.Point(437, -1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 50);
            this.btnDelete.TabIndex = 16;
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
            this.btnWijzig.Location = new System.Drawing.Point(372, -1);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(59, 50);
            this.btnWijzig.TabIndex = 15;
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnVoegtoe
            // 
            this.btnVoegtoe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoegtoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnVoegtoe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoegtoe.BackgroundImage")));
            this.btnVoegtoe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoegtoe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoegtoe.FlatAppearance.BorderSize = 0;
            this.btnVoegtoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoegtoe.Location = new System.Drawing.Point(303, -1);
            this.btnVoegtoe.Name = "btnVoegtoe";
            this.btnVoegtoe.Size = new System.Drawing.Size(59, 50);
            this.btnVoegtoe.TabIndex = 11;
            this.btnVoegtoe.UseVisualStyleBackColor = false;
            this.btnVoegtoe.Click += new System.EventHandler(this.btnVoegtoe_Click);
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
            this.pbHome.TabIndex = 14;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-2, -1);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(900, 50);
            this.pbHeader.TabIndex = 13;
            this.pbHeader.TabStop = false;
            // 
            // btnZoeken
            // 
            this.btnZoeken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZoeken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.btnZoeken.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Zoeken_Wit;
            this.btnZoeken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoeken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoeken.FlatAppearance.BorderSize = 0;
            this.btnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoeken.Location = new System.Drawing.Point(503, -1);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(59, 50);
            this.btnZoeken.TabIndex = 17;
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // StageopdrachtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 509);
            this.Controls.Add(this.tbZoek);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnVoegtoe);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.bAanpassen);
            this.Controls.Add(this.bVerwijderen);
            this.Controls.Add(this.bToevoegen);
            this.Controls.Add(this.lbStage);
            this.Controls.Add(this.bZoek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StageopdrachtForm";
            this.Text = "StageOpdrachten";
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bZoek;
        private System.Windows.Forms.TextBox tbZoek;
        private System.Windows.Forms.ListBox lbStage;
        private System.Windows.Forms.Button bToevoegen;
        private System.Windows.Forms.Button bVerwijderen;
        private System.Windows.Forms.Button bAanpassen;
        private System.Windows.Forms.Button btnVoegtoe;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnZoeken;
    }
}