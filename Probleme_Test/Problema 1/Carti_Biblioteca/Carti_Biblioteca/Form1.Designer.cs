namespace Carti_Biblioteca
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
            this.lvCarti = new System.Windows.Forms.ListView();
            this.titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.an = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTitluListaCarti = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCarti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tbTreeView = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripCarti.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCarti
            // 
            this.lvCarti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titlu,
            this.autor,
            this.an});
            this.lvCarti.ContextMenuStrip = this.contextMenuStripCarti;
            this.lvCarti.FullRowSelect = true;
            this.lvCarti.HideSelection = false;
            this.lvCarti.Location = new System.Drawing.Point(44, 86);
            this.lvCarti.Name = "lvCarti";
            this.lvCarti.Size = new System.Drawing.Size(762, 376);
            this.lvCarti.TabIndex = 0;
            this.lvCarti.UseCompatibleStateImageBehavior = false;
            this.lvCarti.View = System.Windows.Forms.View.Details;
            this.lvCarti.Click += new System.EventHandler(this.lvCarti_Click);
            this.lvCarti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvCarti_MouseDown);
            // 
            // titlu
            // 
            this.titlu.Text = "Titlu";
            // 
            // autor
            // 
            this.autor.Text = "Autor";
            // 
            // an
            // 
            this.an.Text = "An Publicare";
            // 
            // tbTitluListaCarti
            // 
            this.tbTitluListaCarti.Location = new System.Drawing.Point(44, 49);
            this.tbTitluListaCarti.Name = "tbTitluListaCarti";
            this.tbTitluListaCarti.Size = new System.Drawing.Size(762, 31);
            this.tbTitluListaCarti.TabIndex = 1;
            this.tbTitluListaCarti.Text = "Lista de Carti";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteToolStripMenuItem,
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1850, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carteToolStripMenuItem
            // 
            this.carteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaCarteToolStripMenuItem,
            this.editeazaCarteToolStripMenuItem,
            this.stergeCarteToolStripMenuItem});
            this.carteToolStripMenuItem.Name = "carteToolStripMenuItem";
            this.carteToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.carteToolStripMenuItem.Text = "Carte";
            // 
            // adaugaCarteToolStripMenuItem
            // 
            this.adaugaCarteToolStripMenuItem.Name = "adaugaCarteToolStripMenuItem";
            this.adaugaCarteToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.adaugaCarteToolStripMenuItem.Text = "Adauga Carte";
            this.adaugaCarteToolStripMenuItem.Click += new System.EventHandler(this.adaugaCarteToolStripMenuItem_Click);
            // 
            // editeazaCarteToolStripMenuItem
            // 
            this.editeazaCarteToolStripMenuItem.Name = "editeazaCarteToolStripMenuItem";
            this.editeazaCarteToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.editeazaCarteToolStripMenuItem.Text = "Editeaza Carte";
            this.editeazaCarteToolStripMenuItem.Click += new System.EventHandler(this.editeazaCarteToolStripMenuItem_Click);
            // 
            // stergeCarteToolStripMenuItem
            // 
            this.stergeCarteToolStripMenuItem.Name = "stergeCarteToolStripMenuItem";
            this.stergeCarteToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.stergeCarteToolStripMenuItem.Text = "Sterge Carte";
            this.stergeCarteToolStripMenuItem.Click += new System.EventHandler(this.stergeCarteToolStripMenuItem_Click);
            // 
            // contextMenuStripCarti
            // 
            this.contextMenuStripCarti.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripCarti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStripCarti.Name = "contextMenuStripCarti";
            this.contextMenuStripCarti.Size = new System.Drawing.Size(177, 118);
            this.contextMenuStripCarti.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCarti_Opening);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(176, 38);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
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
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem});
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.binarToolStripMenuItem.Text = "Binar";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1,
            this.restaurareToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // restaurareToolStripMenuItem1
            // 
            this.restaurareToolStripMenuItem1.Name = "restaurareToolStripMenuItem1";
            this.restaurareToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.restaurareToolStripMenuItem1.Text = "Restaurare";
            this.restaurareToolStripMenuItem1.Click += new System.EventHandler(this.restaurareToolStripMenuItem1_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(854, 86);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(564, 376);
            this.treeView1.TabIndex = 4;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // tbTreeView
            // 
            this.tbTreeView.Location = new System.Drawing.Point(854, 49);
            this.tbTreeView.Name = "tbTreeView";
            this.tbTreeView.Size = new System.Drawing.Size(564, 31);
            this.tbTreeView.TabIndex = 5;
            this.tbTreeView.Text = "TreeView";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 1158);
            this.Controls.Add(this.tbTreeView);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tbTitluListaCarti);
            this.Controls.Add(this.lvCarti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripCarti.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCarti;
        private System.Windows.Forms.TextBox tbTitluListaCarti;
        private System.Windows.Forms.ColumnHeader titlu;
        private System.Windows.Forms.ColumnHeader autor;
        private System.Windows.Forms.ColumnHeader an;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeCarteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCarti;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbTreeView;
    }
}

