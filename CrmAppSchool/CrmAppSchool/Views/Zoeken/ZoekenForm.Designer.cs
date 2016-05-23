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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblgebruiker = new System.Windows.Forms.Label();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter op:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Voornaam",
            "Achternaam",
            "Kwaliteit",
            "Organisatie",
            "Locatie",
            "Functie"});
            this.comboBox1.Location = new System.Drawing.Point(36, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnZoek
            // 
            this.btnZoek.BackgroundImage = global::CrmAppSchool.Properties.Resources.button_Zoeken2;
            this.btnZoek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoek.FlatAppearance.BorderSize = 0;
            this.btnZoek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoek.Location = new System.Drawing.Point(341, 80);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 57);
            this.btnZoek.TabIndex = 0;
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHome.BackgroundImage = global::CrmAppSchool.Properties.Resources.picture_Home;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(2, 2);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(64, 50);
            this.pbHome.TabIndex = 14;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // lblgebruiker
            // 
            this.lblgebruiker.AutoSize = true;
            this.lblgebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.lblgebruiker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgebruiker.ForeColor = System.Drawing.Color.White;
            this.lblgebruiker.Location = new System.Drawing.Point(233, 21);
            this.lblgebruiker.Name = "lblgebruiker";
            this.lblgebruiker.Size = new System.Drawing.Size(123, 16);
            this.lblgebruiker.TabIndex = 12;
            this.lblgebruiker.Text = "U bent ingelogd als:";
            // 
            // pbHeader
            // 
            this.pbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.pbHeader.Location = new System.Drawing.Point(-27, -8);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(519, 60);
            this.pbHeader.TabIndex = 13;
            this.pbHeader.TabStop = false;
            // 
            // ZoekenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 208);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.lblgebruiker);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnZoek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblgebruiker;
        private System.Windows.Forms.PictureBox pbHeader;
    }
}