namespace Model_3
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
            this.components = new System.ComponentModel.Container();
            this.tvComenziPizza = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextComandaPizza = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextComandaPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvComenziPizza
            // 
            this.tvComenziPizza.ContextMenuStrip = this.contextComandaPizza;
            this.tvComenziPizza.FullRowSelect = true;
            this.tvComenziPizza.Location = new System.Drawing.Point(9, 78);
            this.tvComenziPizza.Name = "tvComenziPizza";
            this.tvComenziPizza.Size = new System.Drawing.Size(489, 322);
            this.tvComenziPizza.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comenzi Pizza";
            // 
            // contextComandaPizza
            // 
            this.contextComandaPizza.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextComandaPizza.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.citireXMLToolStripMenuItem});
            this.contextComandaPizza.Name = "contextComandaPizza";
            this.contextComandaPizza.Size = new System.Drawing.Size(301, 124);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // citireXMLToolStripMenuItem
            // 
            this.citireXMLToolStripMenuItem.Name = "citireXMLToolStripMenuItem";
            this.citireXMLToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.citireXMLToolStripMenuItem.Text = "Citire Text";
            this.citireXMLToolStripMenuItem.Click += new System.EventHandler(this.citireXMLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvComenziPizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextComandaPizza.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvComenziPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextComandaPizza;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireXMLToolStripMenuItem;
    }
}

