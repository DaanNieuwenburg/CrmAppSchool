﻿namespace CrmAppSchool.Views.Opdrachten
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
            this.bZoek = new System.Windows.Forms.Button();
            this.tbZoek = new System.Windows.Forms.TextBox();
            this.lbStage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bZoek
            // 
            this.bZoek.Location = new System.Drawing.Point(309, 39);
            this.bZoek.Name = "bZoek";
            this.bZoek.Size = new System.Drawing.Size(75, 23);
            this.bZoek.TabIndex = 0;
            this.bZoek.Text = "Zoek";
            this.bZoek.UseVisualStyleBackColor = true;
            this.bZoek.Click += new System.EventHandler(this.bZoek_Click);
            // 
            // tbZoek
            // 
            this.tbZoek.Location = new System.Drawing.Point(35, 40);
            this.tbZoek.Name = "tbZoek";
            this.tbZoek.Size = new System.Drawing.Size(248, 22);
            this.tbZoek.TabIndex = 1;
            // 
            // lbStage
            // 
            this.lbStage.FormattingEnabled = true;
            this.lbStage.ItemHeight = 16;
            this.lbStage.Location = new System.Drawing.Point(35, 100);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(248, 196);
            this.lbStage.TabIndex = 2;
            this.lbStage.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StageopdrachtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 458);
            this.Controls.Add(this.lbStage);
            this.Controls.Add(this.tbZoek);
            this.Controls.Add(this.bZoek);
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