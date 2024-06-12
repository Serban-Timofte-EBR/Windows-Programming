namespace Model_1
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
            this.lvExtraseCont = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tranzactii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.extrasDeContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiere2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvTranzactii = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IBAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detalii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripTranzactii = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tvExtrasTranzactii = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripTranzactii.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvExtraseCont
            // 
            this.lvExtraseCont.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvExtraseCont.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Adresa,
            this.Tranzactii});
            this.lvExtraseCont.ContextMenuStrip = this.contextMenuStrip1;
            this.lvExtraseCont.FullRowSelect = true;
            this.lvExtraseCont.HideSelection = false;
            this.lvExtraseCont.Location = new System.Drawing.Point(23, 81);
            this.lvExtraseCont.Name = "lvExtraseCont";
            this.lvExtraseCont.Size = new System.Drawing.Size(657, 323);
            this.lvExtraseCont.TabIndex = 0;
            this.lvExtraseCont.UseCompatibleStateImageBehavior = false;
            this.lvExtraseCont.View = System.Windows.Forms.View.Details;
            this.lvExtraseCont.SelectedIndexChanged += new System.EventHandler(this.lvExtraseCont_SelectedIndexChanged);
            this.lvExtraseCont.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvExtraseCont_MouseDown);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            // 
            // Tranzactii
            // 
            this.Tranzactii.Text = "Tranzactie";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editareToolStripMenuItem1,
            this.stergereToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 118);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(177, 38);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem1
            // 
            this.editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
            this.editareToolStripMenuItem1.Size = new System.Drawing.Size(177, 38);
            this.editareToolStripMenuItem1.Text = "Editare";
            this.editareToolStripMenuItem1.Click += new System.EventHandler(this.editareToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(177, 38);
            this.stergereToolStripMenuItem1.Text = "Stergere";
            this.stergereToolStripMenuItem1.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "List View Extrase Cont";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrasDeContToolStripMenuItem,
            this.fisiereToolStripMenuItem,
            this.tranzactiiToolStripMenuItem,
            this.fisiere2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1822, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // extrasDeContToolStripMenuItem
            // 
            this.extrasDeContToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.extrasDeContToolStripMenuItem.Name = "extrasDeContToolStripMenuItem";
            this.extrasDeContToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.extrasDeContToolStripMenuItem.Text = "Extras de Cont";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(249, 44);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(249, 44);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(249, 44);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem});
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(201, 44);
            this.binarToolStripMenuItem.Text = "Binar";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(258, 44);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(258, 44);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareaToolStripMenuItem,
            this.restaurareToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(201, 44);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // salvareaToolStripMenuItem
            // 
            this.salvareaToolStripMenuItem.Name = "salvareaToolStripMenuItem";
            this.salvareaToolStripMenuItem.Size = new System.Drawing.Size(258, 44);
            this.salvareaToolStripMenuItem.Text = "Salvarea";
            this.salvareaToolStripMenuItem.Click += new System.EventHandler(this.salvareaToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem1
            // 
            this.restaurareToolStripMenuItem1.Name = "restaurareToolStripMenuItem1";
            this.restaurareToolStripMenuItem1.Size = new System.Drawing.Size(258, 44);
            this.restaurareToolStripMenuItem1.Text = "Restaurare";
            this.restaurareToolStripMenuItem1.Click += new System.EventHandler(this.restaurareToolStripMenuItem1_Click);
            // 
            // tranzactiiToolStripMenuItem
            // 
            this.tranzactiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem1,
            this.editareToolStripMenuItem2,
            this.stergereToolStripMenuItem2});
            this.tranzactiiToolStripMenuItem.Name = "tranzactiiToolStripMenuItem";
            this.tranzactiiToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.tranzactiiToolStripMenuItem.Text = "Tranzactii";
            // 
            // adaugareToolStripMenuItem1
            // 
            this.adaugareToolStripMenuItem1.Name = "adaugareToolStripMenuItem1";
            this.adaugareToolStripMenuItem1.Size = new System.Drawing.Size(249, 44);
            this.adaugareToolStripMenuItem1.Text = "Adaugare";
            this.adaugareToolStripMenuItem1.Click += new System.EventHandler(this.adaugareToolStripMenuItem1_Click);
            // 
            // editareToolStripMenuItem2
            // 
            this.editareToolStripMenuItem2.Name = "editareToolStripMenuItem2";
            this.editareToolStripMenuItem2.Size = new System.Drawing.Size(249, 44);
            this.editareToolStripMenuItem2.Text = "Editare";
            this.editareToolStripMenuItem2.Click += new System.EventHandler(this.editareToolStripMenuItem2_Click);
            // 
            // stergereToolStripMenuItem2
            // 
            this.stergereToolStripMenuItem2.Name = "stergereToolStripMenuItem2";
            this.stergereToolStripMenuItem2.Size = new System.Drawing.Size(249, 44);
            this.stergereToolStripMenuItem2.Text = "Stergere";
            this.stergereToolStripMenuItem2.Click += new System.EventHandler(this.stergereToolStripMenuItem2_Click);
            // 
            // fisiere2ToolStripMenuItem
            // 
            this.fisiere2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.fisiere2ToolStripMenuItem.Name = "fisiere2ToolStripMenuItem";
            this.fisiere2ToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.fisiere2ToolStripMenuItem.Text = "Fisiere 2";
            // 
            // binarToolStripMenuItem1
            // 
            this.binarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1,
            this.restaurareToolStripMenuItem2});
            this.binarToolStripMenuItem1.Name = "binarToolStripMenuItem1";
            this.binarToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.binarToolStripMenuItem1.Text = "Binar";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(258, 44);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // restaurareToolStripMenuItem2
            // 
            this.restaurareToolStripMenuItem2.Name = "restaurareToolStripMenuItem2";
            this.restaurareToolStripMenuItem2.Size = new System.Drawing.Size(258, 44);
            this.restaurareToolStripMenuItem2.Text = "Restaurare";
            this.restaurareToolStripMenuItem2.Click += new System.EventHandler(this.restaurareToolStripMenuItem2_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem2,
            this.restaurareToolStripMenuItem3});
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // salvareToolStripMenuItem2
            // 
            this.salvareToolStripMenuItem2.Name = "salvareToolStripMenuItem2";
            this.salvareToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.salvareToolStripMenuItem2.Text = "Salvare";
            this.salvareToolStripMenuItem2.Click += new System.EventHandler(this.salvareToolStripMenuItem2_Click);
            // 
            // restaurareToolStripMenuItem3
            // 
            this.restaurareToolStripMenuItem3.Name = "restaurareToolStripMenuItem3";
            this.restaurareToolStripMenuItem3.Size = new System.Drawing.Size(359, 44);
            this.restaurareToolStripMenuItem3.Text = "Restaurare";
            this.restaurareToolStripMenuItem3.Click += new System.EventHandler(this.restaurareToolStripMenuItem3_Click);
            // 
            // lvTranzactii
            // 
            this.lvTranzactii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.IBAN,
            this.Detalii,
            this.Suma});
            this.lvTranzactii.ContextMenuStrip = this.contextMenuStripTranzactii;
            this.lvTranzactii.FullRowSelect = true;
            this.lvTranzactii.HideSelection = false;
            this.lvTranzactii.Location = new System.Drawing.Point(23, 519);
            this.lvTranzactii.Name = "lvTranzactii";
            this.lvTranzactii.Size = new System.Drawing.Size(657, 286);
            this.lvTranzactii.TabIndex = 4;
            this.lvTranzactii.UseCompatibleStateImageBehavior = false;
            this.lvTranzactii.View = System.Windows.Forms.View.Details;
            this.lvTranzactii.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvTranzactii_MouseDown);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // IBAN
            // 
            this.IBAN.Text = "IBAN";
            // 
            // Detalii
            // 
            this.Detalii.Text = "Detalii";
            // 
            // Suma
            // 
            this.Suma.Text = "Suma";
            // 
            // contextMenuStripTranzactii
            // 
            this.contextMenuStripTranzactii.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripTranzactii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStripTranzactii.Name = "contextMenuStripTranzactii";
            this.contextMenuStripTranzactii.Size = new System.Drawing.Size(177, 118);
            this.contextMenuStripTranzactii.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTranzactii_Opening);
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(176, 38);
            this.adaugaToolStripMenuItem1.Text = "Adauga";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(176, 38);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(176, 38);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "List View Tranzactii";
            // 
            // tvExtrasTranzactii
            // 
            this.tvExtrasTranzactii.AllowDrop = true;
            this.tvExtrasTranzactii.Location = new System.Drawing.Point(945, 251);
            this.tvExtrasTranzactii.Name = "tvExtrasTranzactii";
            this.tvExtrasTranzactii.Size = new System.Drawing.Size(609, 378);
            this.tvExtrasTranzactii.TabIndex = 6;
            this.tvExtrasTranzactii.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvExtrasTranzactii_DragDrop);
            this.tvExtrasTranzactii.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvExtrasTranzactii_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 919);
            this.Controls.Add(this.tvExtrasTranzactii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvTranzactii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvExtraseCont);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripTranzactii.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvExtraseCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Tranzactii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extrasDeContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem1;
        private System.Windows.Forms.ListView lvTranzactii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader IBAN;
        private System.Windows.Forms.ColumnHeader Detalii;
        private System.Windows.Forms.ColumnHeader Suma;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTranzactii;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiere2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem3;
        private System.Windows.Forms.TreeView tvExtrasTranzactii;
    }
}

