namespace Clienti_Antrenamente
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
            this.textBoxTitluClient = new System.Windows.Forms.TextBox();
            this.lvClienti = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Varsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abonament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripClienti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lvAntrenamente = new System.Windows.Forms.ListView();
            this.Zi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Antrenor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.antrenamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripAntrenamente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.contextMenuStripClienti.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripAntrenamente.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTitluClient
            // 
            this.textBoxTitluClient.Location = new System.Drawing.Point(13, 60);
            this.textBoxTitluClient.Name = "textBoxTitluClient";
            this.textBoxTitluClient.Size = new System.Drawing.Size(570, 31);
            this.textBoxTitluClient.TabIndex = 0;
            this.textBoxTitluClient.Text = "Lista Clienti";
            // 
            // lvClienti
            // 
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Varsta,
            this.Abonament});
            this.lvClienti.ContextMenuStrip = this.contextMenuStripClienti;
            this.lvClienti.FullRowSelect = true;
            this.lvClienti.HideSelection = false;
            this.lvClienti.Location = new System.Drawing.Point(13, 97);
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(570, 222);
            this.lvClienti.TabIndex = 1;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            this.lvClienti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvClienti_MouseDown);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            // 
            // Varsta
            // 
            this.Varsta.Text = "Varsta";
            // 
            // Abonament
            // 
            this.Abonament.Text = "Status Abonament";
            // 
            // contextMenuStripClienti
            // 
            this.contextMenuStripClienti.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripClienti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.editeazaToolStripMenuItem1,
            this.stergeToolStripMenuItem1});
            this.contextMenuStripClienti.Name = "contextMenuStripClienti";
            this.contextMenuStripClienti.Size = new System.Drawing.Size(177, 118);
            this.contextMenuStripClienti.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripClienti_Opening);
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(176, 38);
            this.adaugaToolStripMenuItem1.Text = "Adauga";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // editeazaToolStripMenuItem1
            // 
            this.editeazaToolStripMenuItem1.Name = "editeazaToolStripMenuItem1";
            this.editeazaToolStripMenuItem1.Size = new System.Drawing.Size(176, 38);
            this.editeazaToolStripMenuItem1.Text = "Editeaza";
            this.editeazaToolStripMenuItem1.Click += new System.EventHandler(this.editeazaToolStripMenuItem1_Click);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(176, 38);
            this.stergeToolStripMenuItem1.Text = "Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiToolStripMenuItem,
            this.antrenamenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.fisiereToolStripMenuItem});
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(235, 44);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(235, 44);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(235, 44);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(235, 44);
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
            this.salvareToolStripMenuItem1,
            this.restaurareToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(201, 44);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(258, 44);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // restaurareToolStripMenuItem1
            // 
            this.restaurareToolStripMenuItem1.Name = "restaurareToolStripMenuItem1";
            this.restaurareToolStripMenuItem1.Size = new System.Drawing.Size(258, 44);
            this.restaurareToolStripMenuItem1.Text = "Restaurare";
            this.restaurareToolStripMenuItem1.Click += new System.EventHandler(this.restaurareToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(570, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Lista Antrenamente";
            // 
            // lvAntrenamente
            // 
            this.lvAntrenamente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Zi,
            this.Ora,
            this.Sala,
            this.Antrenor});
            this.lvAntrenamente.ContextMenuStrip = this.contextMenuStripAntrenamente;
            this.lvAntrenamente.FullRowSelect = true;
            this.lvAntrenamente.HideSelection = false;
            this.lvAntrenamente.Location = new System.Drawing.Point(13, 470);
            this.lvAntrenamente.Name = "lvAntrenamente";
            this.lvAntrenamente.Size = new System.Drawing.Size(570, 281);
            this.lvAntrenamente.TabIndex = 4;
            this.lvAntrenamente.UseCompatibleStateImageBehavior = false;
            this.lvAntrenamente.View = System.Windows.Forms.View.Details;
            this.lvAntrenamente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvAntrenamente_MouseDown);
            // 
            // Zi
            // 
            this.Zi.Text = "Zi";
            // 
            // Ora
            // 
            this.Ora.Text = "Ora";
            // 
            // Sala
            // 
            this.Sala.Text = "Sala";
            // 
            // Antrenor
            // 
            this.Antrenor.Text = "Antrenor";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(785, 131);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(502, 381);
            this.treeView1.TabIndex = 5;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // antrenamenteToolStripMenuItem
            // 
            this.antrenamenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem2,
            this.editeazaToolStripMenuItem2,
            this.stergeToolStripMenuItem2,
            this.fisiereToolStripMenuItem1});
            this.antrenamenteToolStripMenuItem.Name = "antrenamenteToolStripMenuItem";
            this.antrenamenteToolStripMenuItem.Size = new System.Drawing.Size(187, 38);
            this.antrenamenteToolStripMenuItem.Text = "Antrenamente";
            // 
            // adaugaToolStripMenuItem2
            // 
            this.adaugaToolStripMenuItem2.Name = "adaugaToolStripMenuItem2";
            this.adaugaToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.adaugaToolStripMenuItem2.Text = "Adauga";
            this.adaugaToolStripMenuItem2.Click += new System.EventHandler(this.adaugaToolStripMenuItem2_Click);
            // 
            // editeazaToolStripMenuItem2
            // 
            this.editeazaToolStripMenuItem2.Name = "editeazaToolStripMenuItem2";
            this.editeazaToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.editeazaToolStripMenuItem2.Text = "Editeaza";
            this.editeazaToolStripMenuItem2.Click += new System.EventHandler(this.editeazaToolStripMenuItem2_Click);
            // 
            // stergeToolStripMenuItem2
            // 
            this.stergeToolStripMenuItem2.Name = "stergeToolStripMenuItem2";
            this.stergeToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.stergeToolStripMenuItem2.Text = "Sterge";
            this.stergeToolStripMenuItem2.Click += new System.EventHandler(this.stergeToolStripMenuItem2_Click);
            // 
            // fisiereToolStripMenuItem1
            // 
            this.fisiereToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.fisiereToolStripMenuItem1.Name = "fisiereToolStripMenuItem1";
            this.fisiereToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.fisiereToolStripMenuItem1.Text = "Fisiere";
            // 
            // binarToolStripMenuItem1
            // 
            this.binarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.restaureazaToolStripMenuItem});
            this.binarToolStripMenuItem1.Name = "binarToolStripMenuItem1";
            this.binarToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.binarToolStripMenuItem1.Text = "Binar";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem1,
            this.restaureazaToolStripMenuItem1});
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // restaureazaToolStripMenuItem
            // 
            this.restaureazaToolStripMenuItem.Name = "restaureazaToolStripMenuItem";
            this.restaureazaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.restaureazaToolStripMenuItem.Text = "Restaureaza";
            this.restaureazaToolStripMenuItem.Click += new System.EventHandler(this.restaureazaToolStripMenuItem_Click);
            // 
            // salveazaToolStripMenuItem1
            // 
            this.salveazaToolStripMenuItem1.Name = "salveazaToolStripMenuItem1";
            this.salveazaToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.salveazaToolStripMenuItem1.Text = "Salveaza ";
            this.salveazaToolStripMenuItem1.Click += new System.EventHandler(this.salveazaToolStripMenuItem1_Click);
            // 
            // restaureazaToolStripMenuItem1
            // 
            this.restaureazaToolStripMenuItem1.Name = "restaureazaToolStripMenuItem1";
            this.restaureazaToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.restaureazaToolStripMenuItem1.Text = "Restaureaza";
            this.restaureazaToolStripMenuItem1.Click += new System.EventHandler(this.restaureazaToolStripMenuItem1_Click);
            // 
            // contextMenuStripAntrenamente
            // 
            this.contextMenuStripAntrenamente.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripAntrenamente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem3,
            this.editeazaToolStripMenuItem3,
            this.stergeToolStripMenuItem3});
            this.contextMenuStripAntrenamente.Name = "contextMenuStripAntrenamente";
            this.contextMenuStripAntrenamente.Size = new System.Drawing.Size(177, 118);
            this.contextMenuStripAntrenamente.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripAntrenamente_Opening);
            // 
            // adaugaToolStripMenuItem3
            // 
            this.adaugaToolStripMenuItem3.Name = "adaugaToolStripMenuItem3";
            this.adaugaToolStripMenuItem3.Size = new System.Drawing.Size(300, 38);
            this.adaugaToolStripMenuItem3.Text = "Adauga";
            this.adaugaToolStripMenuItem3.Click += new System.EventHandler(this.adaugaToolStripMenuItem3_Click);
            // 
            // editeazaToolStripMenuItem3
            // 
            this.editeazaToolStripMenuItem3.Name = "editeazaToolStripMenuItem3";
            this.editeazaToolStripMenuItem3.Size = new System.Drawing.Size(300, 38);
            this.editeazaToolStripMenuItem3.Text = "Editeaza";
            this.editeazaToolStripMenuItem3.Click += new System.EventHandler(this.editeazaToolStripMenuItem3_Click);
            // 
            // stergeToolStripMenuItem3
            // 
            this.stergeToolStripMenuItem3.Name = "stergeToolStripMenuItem3";
            this.stergeToolStripMenuItem3.Size = new System.Drawing.Size(300, 38);
            this.stergeToolStripMenuItem3.Text = "Sterge";
            this.stergeToolStripMenuItem3.Click += new System.EventHandler(this.stergeToolStripMenuItem3_Click);
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Location = new System.Drawing.Point(785, 598);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(502, 205);
            this.treeView2.TabIndex = 7;
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView2_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 986);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lvAntrenamente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvClienti);
            this.Controls.Add(this.textBoxTitluClient);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStripClienti.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripAntrenamente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitluClient;
        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Varsta;
        private System.Windows.Forms.ColumnHeader Abonament;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClienti;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lvAntrenamente;
        private System.Windows.Forms.ColumnHeader Zi;
        private System.Windows.Forms.ColumnHeader Ora;
        private System.Windows.Forms.ColumnHeader Sala;
        private System.Windows.Forms.ColumnHeader Antrenor;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem antrenamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaureazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaureazaToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAntrenamente;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem3;
        private System.Windows.Forms.TreeView treeView2;
    }
}

