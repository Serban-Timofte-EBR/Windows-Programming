namespace Model_3
{
    partial class AdaugareComandaPizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbBlat = new System.Windows.Forms.ComboBox();
            this.tbDurataRealizare = new System.Windows.Forms.TextBox();
            this.checkListToppinguri = new System.Windows.Forms.CheckedListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durata de realizare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toppinguri";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(250, 98);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(350, 31);
            this.tbNume.TabIndex = 4;
            // 
            // cbBlat
            // 
            this.cbBlat.FormattingEnabled = true;
            this.cbBlat.Items.AddRange(new object[] {
            "Normal",
            "Pufos",
            "Subtire",
            "Normal Extra Rumenit"});
            this.cbBlat.Location = new System.Drawing.Point(250, 159);
            this.cbBlat.Name = "cbBlat";
            this.cbBlat.Size = new System.Drawing.Size(350, 33);
            this.cbBlat.TabIndex = 5;
            // 
            // tbDurataRealizare
            // 
            this.tbDurataRealizare.Location = new System.Drawing.Point(250, 218);
            this.tbDurataRealizare.Name = "tbDurataRealizare";
            this.tbDurataRealizare.Size = new System.Drawing.Size(350, 31);
            this.tbDurataRealizare.TabIndex = 6;
            // 
            // checkListToppinguri
            // 
            this.checkListToppinguri.FormattingEnabled = true;
            this.checkListToppinguri.Items.AddRange(new object[] {
            "Masline",
            "Ciuperci",
            "Porumb",
            "Pepperoni",
            "Gorgonzola"});
            this.checkListToppinguri.Location = new System.Drawing.Point(250, 272);
            this.checkListToppinguri.Name = "checkListToppinguri";
            this.checkListToppinguri.Size = new System.Drawing.Size(350, 144);
            this.checkListToppinguri.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(49, 471);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(195, 87);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "button1";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AdaugareComandaPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 907);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkListToppinguri);
            this.Controls.Add(this.tbDurataRealizare);
            this.Controls.Add(this.cbBlat);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareComandaPizza";
            this.Text = "AdaugareComandaPizza";
            this.Load += new System.EventHandler(this.AdaugareComandaPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.ComboBox cbBlat;
        private System.Windows.Forms.TextBox tbDurataRealizare;
        private System.Windows.Forms.CheckedListBox checkListToppinguri;
        private System.Windows.Forms.Button btnOk;
    }
}