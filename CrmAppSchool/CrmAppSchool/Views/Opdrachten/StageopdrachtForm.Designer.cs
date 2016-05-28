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
            this.SuspendLayout();
            // 
            // bZoek
            // 
            this.bZoek.Location = new System.Drawing.Point(436, 39);
            this.bZoek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bZoek.Name = "bZoek";
            this.bZoek.Size = new System.Drawing.Size(75, 23);
            this.bZoek.TabIndex = 0;
            this.bZoek.Text = "Zoek";
            this.bZoek.UseVisualStyleBackColor = true;
            this.bZoek.Click += new System.EventHandler(this.bZoek_Click);
            // 
            // tbZoek
            // 
            this.tbZoek.Location = new System.Drawing.Point(35, 39);
            this.tbZoek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbZoek.Name = "tbZoek";
            this.tbZoek.Size = new System.Drawing.Size(329, 22);
            this.tbZoek.TabIndex = 1;
            // 
            // lbStage
            // 
            this.lbStage.FormattingEnabled = true;
            this.lbStage.ItemHeight = 16;
            this.lbStage.Location = new System.Drawing.Point(35, 100);
            this.lbStage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(329, 196);
            this.lbStage.TabIndex = 2;
            this.lbStage.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bToevoegen
            // 
            this.bToevoegen.Location = new System.Drawing.Point(61, 370);
            this.bToevoegen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bToevoegen.Name = "bToevoegen";
            this.bToevoegen.Size = new System.Drawing.Size(93, 23);
            this.bToevoegen.TabIndex = 3;
            this.bToevoegen.Text = "Toevoegen";
            this.bToevoegen.UseVisualStyleBackColor = true;
            this.bToevoegen.Click += new System.EventHandler(this.bToevoegen_Click);
            // 
            // bVerwijderen
            // 
            this.bVerwijderen.Location = new System.Drawing.Point(396, 370);
            this.bVerwijderen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVerwijderen.Name = "bVerwijderen";
            this.bVerwijderen.Size = new System.Drawing.Size(93, 23);
            this.bVerwijderen.TabIndex = 4;
            this.bVerwijderen.Text = "Verwijderen";
            this.bVerwijderen.UseVisualStyleBackColor = true;
            this.bVerwijderen.Click += new System.EventHandler(this.bVerwijderen_Click);
            // 
            // bAanpassen
            // 
            this.bAanpassen.Location = new System.Drawing.Point(221, 370);
            this.bAanpassen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAanpassen.Name = "bAanpassen";
            this.bAanpassen.Size = new System.Drawing.Size(93, 23);
            this.bAanpassen.TabIndex = 5;
            this.bAanpassen.Text = "Aanpassen";
            this.bAanpassen.UseVisualStyleBackColor = true;
            this.bAanpassen.Click += new System.EventHandler(this.bAanpassen_Click);
            // 
            // StageopdrachtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 458);
            this.Controls.Add(this.bAanpassen);
            this.Controls.Add(this.bVerwijderen);
            this.Controls.Add(this.bToevoegen);
            this.Controls.Add(this.lbStage);
            this.Controls.Add(this.tbZoek);
            this.Controls.Add(this.bZoek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StageopdrachtForm";
            this.Text = "StageopdrachtForm";
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
    }
}