namespace Clienti_Antrenamente
{
    partial class AdaugaAntrenament
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
            this.tbZi = new System.Windows.Forms.TextBox();
            this.tbOra = new System.Windows.Forms.TextBox();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.cbAntrenor = new System.Windows.Forms.ComboBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Antrenor";
            // 
            // tbZi
            // 
            this.tbZi.Location = new System.Drawing.Point(177, 84);
            this.tbZi.Name = "tbZi";
            this.tbZi.Size = new System.Drawing.Size(218, 31);
            this.tbZi.TabIndex = 4;
            // 
            // tbOra
            // 
            this.tbOra.Location = new System.Drawing.Point(177, 132);
            this.tbOra.Name = "tbOra";
            this.tbOra.Size = new System.Drawing.Size(218, 31);
            this.tbOra.TabIndex = 5;
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Items.AddRange(new object[] {
            "Sala A",
            "Sala B",
            "Sala C",
            "Sala D"});
            this.cbSala.Location = new System.Drawing.Point(177, 184);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(218, 33);
            this.cbSala.TabIndex = 6;
            // 
            // cbAntrenor
            // 
            this.cbAntrenor.FormattingEnabled = true;
            this.cbAntrenor.Items.AddRange(new object[] {
            "Marius",
            "Vali",
            "Andrei"});
            this.cbAntrenor.Location = new System.Drawing.Point(177, 238);
            this.cbAntrenor.Name = "cbAntrenor";
            this.cbAntrenor.Size = new System.Drawing.Size(217, 33);
            this.cbAntrenor.TabIndex = 7;
            // 
            // btSubmit
            // 
            this.btSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSubmit.Location = new System.Drawing.Point(101, 346);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(121, 67);
            this.btSubmit.TabIndex = 8;
            this.btSubmit.Text = "button1";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(274, 346);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 67);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Renunta";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // AdaugaAntrenament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 480);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.cbAntrenor);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.tbOra);
            this.Controls.Add(this.tbZi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaAntrenament";
            this.Text = "AdaugaAntrenament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZi;
        private System.Windows.Forms.TextBox tbOra;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.ComboBox cbAntrenor;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btCancel;
    }
}