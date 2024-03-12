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
            this.SuspendLayout();
            // 
            // lbMedici
            // 
            this.lbMedici.FormattingEnabled = true;
            this.lbMedici.ItemHeight = 25;
            this.lbMedici.Items.AddRange(new object[] {
            "Medic Ionescu",
            "Medic Popescu"});
            this.lbMedici.Location = new System.Drawing.Point(48, 49);
            this.lbMedici.Name = "lbMedici";
            this.lbMedici.Size = new System.Drawing.Size(273, 329);
            this.lbMedici.TabIndex = 0;
            this.lbMedici.SelectedIndexChanged += new System.EventHandler(this.lbMedici_SelectedIndexChanged);
            // 
            // tbMedic
            // 
            this.tbMedic.Location = new System.Drawing.Point(48, 435);
            this.tbMedic.Name = "tbMedic";
            this.tbMedic.Size = new System.Drawing.Size(273, 31);
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
            this.lwMedici.Location = new System.Drawing.Point(446, 49);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 862);
            this.Controls.Add(this.lwMedici);
            this.Controls.Add(this.tbMedic);
            this.Controls.Add(this.lbMedici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

