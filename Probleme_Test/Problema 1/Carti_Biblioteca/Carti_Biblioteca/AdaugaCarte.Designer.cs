namespace Carti_Biblioteca
{
    partial class AdaugaCarte
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
            this.lbTitlu = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbAn = new System.Windows.Forms.Label();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.btAdauga = new System.Windows.Forms.Button();
            this.btRenunta = new System.Windows.Forms.Button();
            this.errorProviderAn = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.Location = new System.Drawing.Point(174, 129);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(53, 25);
            this.lbTitlu.TabIndex = 0;
            this.lbTitlu.Text = "Titlu";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(169, 197);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(63, 25);
            this.lbAutor.TabIndex = 1;
            this.lbAutor.Text = "Autor";
            // 
            // lbAn
            // 
            this.lbAn.AutoSize = true;
            this.lbAn.Location = new System.Drawing.Point(133, 270);
            this.lbAn.Name = "lbAn";
            this.lbAn.Size = new System.Drawing.Size(134, 25);
            this.lbAn.TabIndex = 2;
            this.lbAn.Text = "An Publicare";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(317, 122);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(303, 31);
            this.tbTitlu.TabIndex = 3;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(317, 194);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(303, 31);
            this.tbAutor.TabIndex = 4;
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(317, 270);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(303, 31);
            this.tbAn.TabIndex = 5;
            this.tbAn.Validating += new System.ComponentModel.CancelEventHandler(this.tbAn_Validating);
            // 
            // btAdauga
            // 
            this.btAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAdauga.Location = new System.Drawing.Point(211, 398);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(134, 80);
            this.btAdauga.TabIndex = 6;
            this.btAdauga.Text = "Adauga";
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // btRenunta
            // 
            this.btRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRenunta.Location = new System.Drawing.Point(409, 398);
            this.btRenunta.Name = "btRenunta";
            this.btRenunta.Size = new System.Drawing.Size(134, 80);
            this.btRenunta.TabIndex = 7;
            this.btRenunta.Text = "Renunta";
            this.btRenunta.UseVisualStyleBackColor = false;
            // 
            // errorProviderAn
            // 
            this.errorProviderAn.ContainerControl = this;
            // 
            // AdaugaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 939);
            this.Controls.Add(this.btRenunta);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.lbAn);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbTitlu);
            this.Name = "AdaugaCarte";
            this.Text = "AdaugaCarte";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbAn;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.Button btRenunta;
        private System.Windows.Forms.ErrorProvider errorProviderAn;
    }
}