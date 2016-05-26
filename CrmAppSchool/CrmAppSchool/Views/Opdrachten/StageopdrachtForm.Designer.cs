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
            this.SuspendLayout();
            // 
            // bZoek
            // 
            this.bZoek.Location = new System.Drawing.Point(232, 32);
            this.bZoek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bZoek.Name = "bZoek";
            this.bZoek.Size = new System.Drawing.Size(56, 19);
            this.bZoek.TabIndex = 0;
            this.bZoek.Text = "Zoek";
            this.bZoek.UseVisualStyleBackColor = true;
            this.bZoek.Click += new System.EventHandler(this.bZoek_Click);
            // 
            // tbZoek
            // 
            this.tbZoek.Location = new System.Drawing.Point(26, 32);
            this.tbZoek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbZoek.Name = "tbZoek";
            this.tbZoek.Size = new System.Drawing.Size(187, 20);
            this.tbZoek.TabIndex = 1;
            // 
            // lbStage
            // 
            this.lbStage.FormattingEnabled = true;
            this.lbStage.Location = new System.Drawing.Point(26, 81);
            this.lbStage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(187, 160);
            this.lbStage.TabIndex = 2;
            this.lbStage.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StageopdrachtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 372);
            this.Controls.Add(this.lbStage);
            this.Controls.Add(this.tbZoek);
            this.Controls.Add(this.bZoek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StageopdrachtForm";
            this.Text = "StageopdrachtForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bZoek;
        private System.Windows.Forms.TextBox tbZoek;
        private System.Windows.Forms.ListBox lbStage;
    }
}