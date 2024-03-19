namespace Seminar4
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
            this.lbMedici = new System.Windows.Forms.ListBox();
            this.tbMedic = new System.Windows.Forms.TextBox();
            this.lwMedici = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpecializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataNastere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuAplicatie = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAplicatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMedici
            // 
            this.lbMedici.FormattingEnabled = true;
            this.lbMedici.ItemHeight = 25;
            this.lbMedici.Items.AddRange(new object[] {
            "Medic Ionescu",
            "Medic Popescu"});
            this.lbMedici.Location = new System.Drawing.Point(48, 140);
            this.lbMedici.Name = "lbMedici";
            this.lbMedici.Size = new System.Drawing.Size(273, 329);
            this.lbMedici.TabIndex = 0;
            this.lbMedici.SelectedIndexChanged += new System.EventHandler(this.lbMedici_SelectedIndexChanged);
            // 
            // tbMedic
            // 
            this.tbMedic.Location = new System.Drawing.Point(48, 595);
            this.tbMedic.Name = "tbMedic";
            this.tbMedic.Size = new System.Drawing.Size(1240, 31);
            this.tbMedic.TabIndex = 2;
            this.tbMedic.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lwMedici
            // 
            this.lwMedici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chCNP,
            this.chAn,
            this.chSpecializare,
            this.chDataNastere});
            this.lwMedici.FullRowSelect = true;
            this.lwMedici.HideSelection = false;
            this.lwMedici.Location = new System.Drawing.Point(434, 140);
            this.lwMedici.Name = "lwMedici";
            this.lwMedici.Size = new System.Drawing.Size(854, 329);
            this.lwMedici.TabIndex = 3;
            this.lwMedici.UseCompatibleStateImageBehavior = false;
            this.lwMedici.View = System.Windows.Forms.View.Details;
            this.lwMedici.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 166;
            // 
            // chCNP
            // 
            this.chCNP.Text = "CNP";
            this.chCNP.Width = 182;
            // 
            // chAn
            // 
            this.chAn.Text = "An Absolvire";
            this.chAn.Width = 149;
            // 
            // chSpecializare
            // 
            this.chSpecializare.Text = "Specializare";
            this.chSpecializare.Width = 198;
            // 
            // chDataNastere
            // 
            this.chDataNastere.Text = "Data Nasterii";
            this.chDataNastere.Width = 156;
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
            this.menuAplicatie.Size = new System.Drawing.Size(1519, 42);
            this.menuAplicatie.TabIndex = 4;
            this.menuAplicatie.Text = "menuStrip1";
            this.menuAplicatie.UseWaitCursor = true;
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inchidereToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(102, 38);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // inchidereToolStripMenuItem
            // 
            this.inchidereToolStripMenuItem.Name = "inchidereToolStripMenuItem";
            this.inchidereToolStripMenuItem.Size = new System.Drawing.Size(246, 44);
            this.inchidereToolStripMenuItem.Text = "Inchidere";
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            this.mediciToolStripMenuItem.Text = "Medici";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.stergeToolStripMenuItem.Text = "Sterge";
            // 
            // despreAplicatieToolStripMenuItem
            // 
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.despreAplicatieToolStripMenuItem.Text = "Despre Aplicatie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 862);
            this.Controls.Add(this.lwMedici);
            this.Controls.Add(this.tbMedic);
            this.Controls.Add(this.lbMedici);
            this.Controls.Add(this.menuAplicatie);
            this.MainMenuStrip = this.menuAplicatie;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuAplicatie.ResumeLayout(false);
            this.menuAplicatie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMedici;
        private System.Windows.Forms.TextBox tbMedic;
        private System.Windows.Forms.ListView lwMedici;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chCNP;
        private System.Windows.Forms.ColumnHeader chAn;
        private System.Windows.Forms.ColumnHeader chSpecializare;
        private System.Windows.Forms.ColumnHeader chDataNastere;
        private System.Windows.Forms.MenuStrip menuAplicatie;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchidereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreAplicatieToolStripMenuItem;
    }
}

