using System;
using System.Windows.Forms;

namespace Seminar3_DesignerIntro
{
    partial class Form1
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
            this.LBIntro = new System.Windows.Forms.Label();
            this.TBIntro = new System.Windows.Forms.TextBox();
            this.afiseaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBIntro
            // 
            this.LBIntro.AutoSize = true;
            this.LBIntro.Location = new System.Drawing.Point(88, 81);
            this.LBIntro.Name = "LBIntro";
            this.LBIntro.Size = new System.Drawing.Size(113, 25);
            this.LBIntro.TabIndex = 0;
            this.LBIntro.Text = "Label Intro";
            this.LBIntro.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBIntro
            // 
            this.TBIntro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TBIntro.Location = new System.Drawing.Point(233, 78);
            this.TBIntro.Name = "TBIntro";
            this.TBIntro.Size = new System.Drawing.Size(100, 31);
            this.TBIntro.TabIndex = 1;
            this.TBIntro.Text = "Text";
            this.TBIntro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // afiseaza
            // 
            this.afiseaza.Location = new System.Drawing.Point(93, 222);
            this.afiseaza.Name = "afiseaza";
            this.afiseaza.Size = new System.Drawing.Size(113, 37);
            this.afiseaza.TabIndex = 3;
            this.afiseaza.Text = "Afiseaza";
            this.afiseaza.UseVisualStyleBackColor = true;
            this.afiseaza.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 858);
            this.Controls.Add(this.afiseaza);
            this.Controls.Add(this.TBIntro);
            this.Controls.Add(this.LBIntro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label LBIntro;
        private System.Windows.Forms.TextBox TBIntro;
        private System.Windows.Forms.Button afiseaza;
    }
}

