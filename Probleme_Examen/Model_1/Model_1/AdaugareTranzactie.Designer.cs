namespace Model_1
{
    partial class AdaugareTranzactie
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.tbDetalii = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.btAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "IBAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suma";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(230, 166);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(409, 31);
            this.tbID.TabIndex = 4;
            // 
            // tbIBAN
            // 
            this.tbIBAN.Location = new System.Drawing.Point(230, 252);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.Size = new System.Drawing.Size(409, 31);
            this.tbIBAN.TabIndex = 5;
            // 
            // tbDetalii
            // 
            this.tbDetalii.Location = new System.Drawing.Point(230, 326);
            this.tbDetalii.Name = "tbDetalii";
            this.tbDetalii.Size = new System.Drawing.Size(409, 31);
            this.tbDetalii.TabIndex = 6;
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(230, 411);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(409, 31);
            this.tbSuma.TabIndex = 7;
            // 
            // btAdauga
            // 
            this.btAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAdauga.Location = new System.Drawing.Point(68, 514);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(178, 92);
            this.btAdauga.TabIndex = 8;
            this.btAdauga.Text = "Adauga";
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // AdaugareTranzactie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 1074);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbDetalii);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareTranzactie";
            this.Text = "AdaugareTranzactie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.TextBox tbDetalii;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Button btAdauga;
    }
}