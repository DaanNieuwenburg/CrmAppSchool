namespace CrmAppSchool.Views.Login
{
    partial class InlogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InlogForm));
            this.inlogBtn = new System.Windows.Forms.Button();
            this.gebruikersnaamTxb = new System.Windows.Forms.TextBox();
            this.wachtwoordTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errordescLbl = new System.Windows.Forms.Label();
            this.errortitelLbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // inlogBtn
            // 
            this.inlogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inlogBtn.BackgroundImage")));
            this.inlogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inlogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inlogBtn.FlatAppearance.BorderSize = 0;
            this.inlogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inlogBtn.Location = new System.Drawing.Point(129, 169);
            this.inlogBtn.Name = "inlogBtn";
            this.inlogBtn.Size = new System.Drawing.Size(91, 45);
            this.inlogBtn.TabIndex = 0;
            this.inlogBtn.UseVisualStyleBackColor = true;
            this.inlogBtn.Click += new System.EventHandler(this.inlogBtn_Click);
            // 
            // gebruikersnaamTxb
            // 
            this.gebruikersnaamTxb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikersnaamTxb.Location = new System.Drawing.Point(12, 43);
            this.gebruikersnaamTxb.Name = "gebruikersnaamTxb";
            this.gebruikersnaamTxb.Size = new System.Drawing.Size(184, 29);
            this.gebruikersnaamTxb.TabIndex = 1;
            // 
            // wachtwoordTxb
            // 
            this.wachtwoordTxb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wachtwoordTxb.Location = new System.Drawing.Point(12, 122);
            this.wachtwoordTxb.Name = "wachtwoordTxb";
            this.wachtwoordTxb.Size = new System.Drawing.Size(184, 29);
            this.wachtwoordTxb.TabIndex = 2;
            this.wachtwoordTxb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachtwoord:";
            // 
            // errordescLbl
            // 
            this.errordescLbl.AutoSize = true;
            this.errordescLbl.Location = new System.Drawing.Point(12, 245);
            this.errordescLbl.Name = "errordescLbl";
            this.errordescLbl.Size = new System.Drawing.Size(238, 13);
            this.errordescLbl.TabIndex = 5;
            this.errordescLbl.Text = "Controleer uw gebruikersnaam en of wachtwoord";
            this.errordescLbl.Visible = false;
            // 
            // errortitelLbl
            // 
            this.errortitelLbl.AutoSize = true;
            this.errortitelLbl.Location = new System.Drawing.Point(12, 232);
            this.errortitelLbl.Name = "errortitelLbl";
            this.errortitelLbl.Size = new System.Drawing.Size(83, 13);
            this.errortitelLbl.TabIndex = 6;
            this.errortitelLbl.Text = "Inloggen mislukt";
            this.errortitelLbl.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            this.checkBox1.Location = new System.Drawing.Point(12, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // InlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 289);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.errortitelLbl);
            this.Controls.Add(this.errordescLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wachtwoordTxb);
            this.Controls.Add(this.gebruikersnaamTxb);
            this.Controls.Add(this.inlogBtn);
            this.Name = "InlogForm";
            this.Text = "Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inlogBtn;
        private System.Windows.Forms.TextBox gebruikersnaamTxb;
        private System.Windows.Forms.TextBox wachtwoordTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errordescLbl;
        private System.Windows.Forms.Label errortitelLbl;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

