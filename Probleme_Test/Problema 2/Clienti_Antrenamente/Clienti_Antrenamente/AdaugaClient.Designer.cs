namespace Clienti_Antrenamente
{
    partial class AdaugaClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.cbAbonament = new System.Windows.Forms.ComboBox();
            this.btAdauga = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.errorProviderVarsta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAbonament = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVarsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAbonament)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status Abonament";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(290, 70);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(328, 31);
            this.tbNume.TabIndex = 4;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(290, 139);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(328, 31);
            this.tbPrenume.TabIndex = 5;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(290, 203);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(328, 31);
            this.tbVarsta.TabIndex = 6;
            this.tbVarsta.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarsta_Validating);
            // 
            // cbAbonament
            // 
            this.cbAbonament.FormattingEnabled = true;
            this.cbAbonament.Items.AddRange(new object[] {
            "ACTIV",
            "INACTIV"});
            this.cbAbonament.Location = new System.Drawing.Point(290, 278);
            this.cbAbonament.Name = "cbAbonament";
            this.cbAbonament.Size = new System.Drawing.Size(328, 33);
            this.cbAbonament.TabIndex = 7;
            this.cbAbonament.Validating += new System.ComponentModel.CancelEventHandler(this.AdaugaClient_Validating);
            // 
            // btAdauga
            // 
            this.btAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAdauga.Location = new System.Drawing.Point(129, 365);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(168, 79);
            this.btAdauga.TabIndex = 8;
            this.btAdauga.Text = "button1";
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRenunta.Location = new System.Drawing.Point(354, 365);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(168, 79);
            this.btRenunta.TabIndex = 9;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.UseVisualStyleBackColor = false;
            // 
            // errorProviderVarsta
            // 
            this.errorProviderVarsta.ContainerControl = this;
            // 
            // errorProviderAbonament
            // 
            this.errorProviderAbonament.ContainerControl = this;
            // 
            // AdaugaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 503);
            this.Controls.Add(this.btRenunta);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.cbAbonament);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaClient";
            this.Text = "AdaugaClient";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVarsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAbonament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.ComboBox cbAbonament;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.ErrorProvider errorProviderVarsta;
        private System.Windows.Forms.ErrorProvider errorProviderAbonament;
    }
}