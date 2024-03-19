namespace Seminar4
{
    partial class AdaugaMedic
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCnp = new System.Windows.Forms.TextBox();
            this.tbAnAbs = new System.Windows.Forms.TextBox();
            this.cbSpecializare = new System.Windows.Forms.ComboBox();
            this.dateDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "An Absolvire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specializare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Nasterii";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(269, 52);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(387, 31);
            this.tbNume.TabIndex = 5;
            // 
            // tbCnp
            // 
            this.tbCnp.Location = new System.Drawing.Point(269, 139);
            this.tbCnp.Name = "tbCnp";
            this.tbCnp.Size = new System.Drawing.Size(387, 31);
            this.tbCnp.TabIndex = 6;
            // 
            // tbAnAbs
            // 
            this.tbAnAbs.Location = new System.Drawing.Point(269, 233);
            this.tbAnAbs.Name = "tbAnAbs";
            this.tbAnAbs.Size = new System.Drawing.Size(387, 31);
            this.tbAnAbs.TabIndex = 7;
            // 
            // cbSpecializare
            // 
            this.cbSpecializare.FormattingEnabled = true;
            this.cbSpecializare.Items.AddRange(new object[] {
            "Cardiologie",
            "Neurologie",
            "Pediatrie",
            "Boli infectioase"});
            this.cbSpecializare.Location = new System.Drawing.Point(269, 321);
            this.cbSpecializare.Name = "cbSpecializare";
            this.cbSpecializare.Size = new System.Drawing.Size(387, 33);
            this.cbSpecializare.TabIndex = 8;
            // 
            // dateDataNasterii
            // 
            this.dateDataNasterii.Location = new System.Drawing.Point(269, 416);
            this.dateDataNasterii.Name = "dateDataNasterii";
            this.dateDataNasterii.Size = new System.Drawing.Size(387, 31);
            this.dateDataNasterii.TabIndex = 9;
            // 
            // btnAdauga
            // 
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(100, 554);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(143, 52);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRenunta.Location = new System.Drawing.Point(302, 555);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(143, 51);
            this.btnRenunta.TabIndex = 11;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = false;
            // 
            // AdaugaMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 670);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dateDataNasterii);
            this.Controls.Add(this.cbSpecializare);
            this.Controls.Add(this.tbAnAbs);
            this.Controls.Add(this.tbCnp);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaMedic";
            this.Text = "AdaugaMedic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCnp;
        private System.Windows.Forms.TextBox tbAnAbs;
        private System.Windows.Forms.ComboBox cbSpecializare;
        private System.Windows.Forms.DateTimePicker dateDataNasterii;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnRenunta;
    }
}