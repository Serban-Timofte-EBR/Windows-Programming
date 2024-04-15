namespace Actiuni_Portofoliu
{
    partial class AdaugaActiune
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
            this.tbCompanie = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.cbVolum = new System.Windows.Forms.ComboBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Companie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Volum";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(191, 51);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(288, 31);
            this.tbNume.TabIndex = 4;
            // 
            // tbCompanie
            // 
            this.tbCompanie.Location = new System.Drawing.Point(191, 120);
            this.tbCompanie.Name = "tbCompanie";
            this.tbCompanie.Size = new System.Drawing.Size(288, 31);
            this.tbCompanie.TabIndex = 5;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(191, 186);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(288, 31);
            this.tbPret.TabIndex = 6;
            // 
            // cbVolum
            // 
            this.cbVolum.FormattingEnabled = true;
            this.cbVolum.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000"});
            this.cbVolum.Location = new System.Drawing.Point(191, 250);
            this.cbVolum.Name = "cbVolum";
            this.cbVolum.Size = new System.Drawing.Size(288, 33);
            this.cbVolum.TabIndex = 7;
            // 
            // btSubmit
            // 
            this.btSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSubmit.Location = new System.Drawing.Point(97, 324);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(149, 64);
            this.btSubmit.TabIndex = 8;
            this.btSubmit.Text = "button1";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(285, 324);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(149, 64);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Renunta";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // AdaugaActiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.cbVolum);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbCompanie);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaActiune";
            this.Text = "AdaugaActiune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCompanie;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.ComboBox cbVolum;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btCancel;
    }
}