﻿namespace Medici_Pacienti
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
            this.lbMedici = new System.Windows.Forms.ListBox();
            this.tbMedic = new System.Windows.Forms.TextBox();
            this.lvMedici = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpecializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDatan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuAplicatie = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAplicatie.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMedici
            // 
            this.lbMedici.FormattingEnabled = true;
            this.lbMedici.ItemHeight = 25;
            this.lbMedici.Items.AddRange(new object[] {
            "Medic Ionescu",
            "Medic Popescu"});
            this.lbMedici.Location = new System.Drawing.Point(1212, 583);
            this.lbMedici.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbMedici.MultiColumn = true;
            this.lbMedici.Name = "lbMedici";
            this.lbMedici.Size = new System.Drawing.Size(262, 129);
            this.lbMedici.TabIndex = 0;
            this.lbMedici.SelectedIndexChanged += new System.EventHandler(this.lbMedici_SelectedIndexChanged);
            // 
            // tbMedic
            // 
            this.tbMedic.Location = new System.Drawing.Point(142, 463);
            this.tbMedic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMedic.Name = "tbMedic";
            this.tbMedic.Size = new System.Drawing.Size(868, 31);
            this.tbMedic.TabIndex = 1;
            // 
            // lvMedici
            // 
            this.lvMedici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chCNP,
            this.chAn,
            this.chSpecializare,
            this.chDatan});
            this.lvMedici.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMedici.FullRowSelect = true;
            this.lvMedici.HideSelection = false;
            this.lvMedici.Location = new System.Drawing.Point(142, 92);
            this.lvMedici.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvMedici.MultiSelect = false;
            this.lvMedici.Name = "lvMedici";
            this.lvMedici.Size = new System.Drawing.Size(868, 317);
            this.lvMedici.TabIndex = 2;
            this.lvMedici.UseCompatibleStateImageBehavior = false;
            this.lvMedici.View = System.Windows.Forms.View.Details;
            this.lvMedici.SelectedIndexChanged += new System.EventHandler(this.lvMedici_SelectedIndexChanged);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            // 
            // chCNP
            // 
            this.chCNP.Text = "CNP";
            // 
            // chAn
            // 
            this.chAn.Text = "An absolvire";
            // 
            // chSpecializare
            // 
            this.chSpecializare.Text = "Specilizare";
            // 
            // chDatan
            // 
            this.chDatan.Text = "DataNasterii";
            // 
            // menuAplicatie
            // 
            this.menuAplicatie.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuAplicatie.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuAplicatie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.mediciToolStripMenuItem,
            this.despreAplicatieToolStripMenuItem});
            this.menuAplicatie.Location = new System.Drawing.Point(0, 0);
            this.menuAplicatie.Name = "menuAplicatie";
            this.menuAplicatie.Size = new System.Drawing.Size(1502, 46);
            this.menuAplicatie.TabIndex = 3;
            this.menuAplicatie.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem,
            this.salvareBinaraToolStripMenuItem,
            this.restaurareBinaraToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(102, 38);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            this.fisiereToolStripMenuItem.Click += new System.EventHandler(this.fisiereToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(203, 44);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.mediciToolStripMenuItem.Text = "Medici";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(240, 44);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(240, 44);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(240, 44);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // despreAplicatieToolStripMenuItem
            // 
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.despreAplicatieToolStripMenuItem.Text = "Despre aplicatie";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.modificaToolStripMenuItem1,
            this.stergeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 118);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(300, 38);
            this.adaugaToolStripMenuItem1.Text = "Adauga";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // modificaToolStripMenuItem1
            // 
            this.modificaToolStripMenuItem1.Name = "modificaToolStripMenuItem1";
            this.modificaToolStripMenuItem1.Size = new System.Drawing.Size(300, 38);
            this.modificaToolStripMenuItem1.Text = "Modifica";
            this.modificaToolStripMenuItem1.Click += new System.EventHandler(this.modificaToolStripMenuItem1_Click);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(300, 38);
            this.stergeToolStripMenuItem1.Text = "Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
            // 
            // salvareBinaraToolStripMenuItem
            // 
            this.salvareBinaraToolStripMenuItem.Name = "salvareBinaraToolStripMenuItem";
            this.salvareBinaraToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salvareBinaraToolStripMenuItem.Text = "Salvare Binara";
            this.salvareBinaraToolStripMenuItem.Click += new System.EventHandler(this.salvareBinaraToolStripMenuItem_Click);
            // 
            // restaurareBinaraToolStripMenuItem
            // 
            this.restaurareBinaraToolStripMenuItem.Name = "restaurareBinaraToolStripMenuItem";
            this.restaurareBinaraToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.restaurareBinaraToolStripMenuItem.Text = "&Restaurare Binara";
            this.restaurareBinaraToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinaraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 865);
            this.Controls.Add(this.lvMedici);
            this.Controls.Add(this.tbMedic);
            this.Controls.Add(this.lbMedici);
            this.Controls.Add(this.menuAplicatie);
            this.MainMenuStrip = this.menuAplicatie;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuAplicatie.ResumeLayout(false);
            this.menuAplicatie.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMedici;
        private System.Windows.Forms.TextBox tbMedic;
        private System.Windows.Forms.ListView lvMedici;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chCNP;
        private System.Windows.Forms.ColumnHeader chAn;
        private System.Windows.Forms.ColumnHeader chSpecializare;
        private System.Windows.Forms.ColumnHeader chDatan;
        private System.Windows.Forms.MenuStrip menuAplicatie;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreAplicatieToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinaraToolStripMenuItem;
    }
}

