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
            this.inlogBtn = new System.Windows.Forms.Button();
            this.gebruikersnaamTxb = new System.Windows.Forms.TextBox();
            this.wachtwoordTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inlogBtn
            // 
            this.inlogBtn.Location = new System.Drawing.Point(253, 145);
            this.inlogBtn.Name = "inlogBtn";
            this.inlogBtn.Size = new System.Drawing.Size(75, 23);
            this.inlogBtn.TabIndex = 0;
            this.inlogBtn.Text = "Inloggen";
            this.inlogBtn.UseVisualStyleBackColor = true;
            // 
            // gebruikersnaamTxb
            // 
            this.gebruikersnaamTxb.Location = new System.Drawing.Point(242, 71);
            this.gebruikersnaamTxb.Name = "gebruikersnaamTxb";
            this.gebruikersnaamTxb.Size = new System.Drawing.Size(100, 20);
            this.gebruikersnaamTxb.TabIndex = 1;
            // 
            // wachtwoordTxb
            // 
            this.wachtwoordTxb.Location = new System.Drawing.Point(242, 97);
            this.wachtwoordTxb.Name = "wachtwoordTxb";
            this.wachtwoordTxb.Size = new System.Drawing.Size(100, 20);
            this.wachtwoordTxb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachtwoord:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wachtwoordTxb);
            this.Controls.Add(this.gebruikersnaamTxb);
            this.Controls.Add(this.inlogBtn);
            this.Name = "Form1";
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
    }
}

