namespace Model_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvBiciclete = new System.Windows.Forms.ListView();
            this.codB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.km = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUtilizatori = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVenit = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculeazaVenitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biciclete";
            // 
            // lvBiciclete
            // 
            this.lvBiciclete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codB,
            this.statie,
            this.km});
            this.lvBiciclete.ContextMenuStrip = this.contextMenuStrip1;
            this.lvBiciclete.FullRowSelect = true;
            this.lvBiciclete.HideSelection = false;
            this.lvBiciclete.Location = new System.Drawing.Point(12, 47);
            this.lvBiciclete.Name = "lvBiciclete";
            this.lvBiciclete.Size = new System.Drawing.Size(346, 146);
            this.lvBiciclete.TabIndex = 1;
            this.lvBiciclete.UseCompatibleStateImageBehavior = false;
            this.lvBiciclete.View = System.Windows.Forms.View.Details;
            // 
            // codB
            // 
            this.codB.Text = "Cod Bicicleta";
            // 
            // statie
            // 
            this.statie.Text = "Statie Parcare";
            // 
            // km
            // 
            this.km.Text = "KM Parcursi";
            // 
            // lbUtilizatori
            // 
            this.lbUtilizatori.FormattingEnabled = true;
            this.lbUtilizatori.ItemHeight = 16;
            this.lbUtilizatori.Location = new System.Drawing.Point(390, 47);
            this.lbUtilizatori.Name = "lbUtilizatori";
            this.lbUtilizatori.Size = new System.Drawing.Size(291, 148);
            this.lbUtilizatori.TabIndex = 2;
            this.lbUtilizatori.DoubleClick += new System.EventHandler(this.lbUtilizatori_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Utilizatori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Venitul din bicicleta selectata";
            // 
            // tbVenit
            // 
            this.tbVenit.Location = new System.Drawing.Point(208, 212);
            this.tbVenit.Name = "tbVenit";
            this.tbVenit.Size = new System.Drawing.Size(150, 22);
            this.tbVenit.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculeazaVenitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 28);
            // 
            // calculeazaVenitToolStripMenuItem
            // 
            this.calculeazaVenitToolStripMenuItem.Name = "calculeazaVenitToolStripMenuItem";
            this.calculeazaVenitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.calculeazaVenitToolStripMenuItem.Text = "Calculeaza Venit";
            this.calculeazaVenitToolStripMenuItem.Click += new System.EventHandler(this.calculeazaVenitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Genereaza Grafic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbVenit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUtilizatori);
            this.Controls.Add(this.lvBiciclete);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvBiciclete;
        private System.Windows.Forms.ColumnHeader codB;
        private System.Windows.Forms.ColumnHeader statie;
        private System.Windows.Forms.ColumnHeader km;
        private System.Windows.Forms.ListBox lbUtilizatori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVenit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculeazaVenitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

