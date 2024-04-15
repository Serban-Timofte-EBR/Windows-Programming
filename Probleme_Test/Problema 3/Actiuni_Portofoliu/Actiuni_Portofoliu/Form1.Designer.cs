namespace Actiuni_Portofoliu
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
            this.lbTitluActiuni = new System.Windows.Forms.Label();
            this.lvActiuni = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Companie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripActiuni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lvOrdine = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvOrdineActiuni = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripActiuni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitluActiuni
            // 
            this.lbTitluActiuni.AutoSize = true;
            this.lbTitluActiuni.Location = new System.Drawing.Point(12, 57);
            this.lbTitluActiuni.Name = "lbTitluActiuni";
            this.lbTitluActiuni.Size = new System.Drawing.Size(206, 25);
            this.lbTitluActiuni.TabIndex = 0;
            this.lbTitluActiuni.Text = "Actiunile Disponibile";
            // 
            // lvActiuni
            // 
            this.lvActiuni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Companie,
            this.Pret,
            this.Volum});
            this.lvActiuni.ContextMenuStrip = this.contextMenuStripActiuni;
            this.lvActiuni.FullRowSelect = true;
            this.lvActiuni.GridLines = true;
            this.lvActiuni.HideSelection = false;
            this.lvActiuni.Location = new System.Drawing.Point(12, 85);
            this.lvActiuni.Name = "lvActiuni";
            this.lvActiuni.Size = new System.Drawing.Size(530, 240);
            this.lvActiuni.TabIndex = 1;
            this.lvActiuni.UseCompatibleStateImageBehavior = false;
            this.lvActiuni.View = System.Windows.Forms.View.Details;
            this.lvActiuni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvActiuni_MouseDown);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Companie
            // 
            this.Companie.Text = "Companie";
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            // 
            // Volum
            // 
            this.Volum.Text = "Volum";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actiuniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1383, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actiuniToolStripMenuItem
            // 
            this.actiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.fisiereToolStripMenuItem});
            this.actiuniToolStripMenuItem.Name = "actiuniToolStripMenuItem";
            this.actiuniToolStripMenuItem.Size = new System.Drawing.Size(108, 44);
            this.actiuniToolStripMenuItem.Text = "Actiuni";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.restaureazaToolStripMenuItem});
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.binarToolStripMenuItem.Text = "Binar";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem1,
            this.restaureazaToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.xMLToolStripMenuItem.Text = "XML";
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
            this.salveazaToolStripMenuItem1.Text = "Salveaza";
            this.salveazaToolStripMenuItem1.Click += new System.EventHandler(this.salveazaToolStripMenuItem1_Click);
            // 
            // restaureazaToolStripMenuItem1
            // 
            this.restaureazaToolStripMenuItem1.Name = "restaureazaToolStripMenuItem1";
            this.restaureazaToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.restaureazaToolStripMenuItem1.Text = "Restaureaza";
            this.restaureazaToolStripMenuItem1.Click += new System.EventHandler(this.restaureazaToolStripMenuItem1_Click);
            // 
            // contextMenuStripActiuni
            // 
            this.contextMenuStripActiuni.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripActiuni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.editeazaToolStripMenuItem1,
            this.stergeToolStripMenuItem1});
            this.contextMenuStripActiuni.Name = "contextMenuStripActiuni";
            this.contextMenuStripActiuni.Size = new System.Drawing.Size(177, 118);
            this.contextMenuStripActiuni.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripActiuni_Opening);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordine Deschise";
            // 
            // lvOrdine
            // 
            this.lvOrdine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Owner,
            this.Zi});
            this.lvOrdine.FullRowSelect = true;
            this.lvOrdine.HideSelection = false;
            this.lvOrdine.Location = new System.Drawing.Point(17, 396);
            this.lvOrdine.Name = "lvOrdine";
            this.lvOrdine.Size = new System.Drawing.Size(530, 235);
            this.lvOrdine.TabIndex = 5;
            this.lvOrdine.UseCompatibleStateImageBehavior = false;
            this.lvOrdine.View = System.Windows.Forms.View.Details;
            this.lvOrdine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvOrdine_MouseDown);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Owner
            // 
            this.Owner.Text = "Owner";
            // 
            // Zi
            // 
            this.Zi.Text = "Zi Plasare";
            // 
            // tvOrdineActiuni
            // 
            this.tvOrdineActiuni.AllowDrop = true;
            this.tvOrdineActiuni.Location = new System.Drawing.Point(653, 217);
            this.tvOrdineActiuni.Name = "tvOrdineActiuni";
            this.tvOrdineActiuni.Size = new System.Drawing.Size(379, 252);
            this.tvOrdineActiuni.TabIndex = 6;
            this.tvOrdineActiuni.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvOrdineActiuni_DragDrop);
            this.tvOrdineActiuni.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvOrdineActiuni_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ordine - Actiuni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvOrdineActiuni);
            this.Controls.Add(this.lvOrdine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvActiuni);
            this.Controls.Add(this.lbTitluActiuni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripActiuni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitluActiuni;
        private System.Windows.Forms.ListView lvActiuni;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Companie;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Volum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaureazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaureazaToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActiuni;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOrdine;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Owner;
        private System.Windows.Forms.ColumnHeader Zi;
        private System.Windows.Forms.TreeView tvOrdineActiuni;
        private System.Windows.Forms.Label label2;
    }
}

