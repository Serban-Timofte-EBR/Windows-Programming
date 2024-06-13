namespace Model_6
{
    partial class AdaugareUtilizator
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
            this.tbCodUtilizator = new System.Windows.Forms.TextBox();
            this.tbNumeUtilizator = new System.Windows.Forms.TextBox();
            this.cbCodBicicleta = new System.Windows.Forms.ComboBox();
            this.tbDistanta = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProviderDurata = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume Utilizator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod Bicicleta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durata de Utilizare";
            // 
            // tbCodUtilizator
            // 
            this.tbCodUtilizator.Location = new System.Drawing.Point(173, 29);
            this.tbCodUtilizator.Name = "tbCodUtilizator";
            this.tbCodUtilizator.ReadOnly = true;
            this.tbCodUtilizator.Size = new System.Drawing.Size(190, 22);
            this.tbCodUtilizator.TabIndex = 4;
            // 
            // tbNumeUtilizator
            // 
            this.tbNumeUtilizator.Location = new System.Drawing.Point(173, 68);
            this.tbNumeUtilizator.Name = "tbNumeUtilizator";
            this.tbNumeUtilizator.Size = new System.Drawing.Size(190, 22);
            this.tbNumeUtilizator.TabIndex = 5;
            // 
            // cbCodBicicleta
            // 
            this.cbCodBicicleta.FormattingEnabled = true;
            this.cbCodBicicleta.Location = new System.Drawing.Point(173, 109);
            this.cbCodBicicleta.Name = "cbCodBicicleta";
            this.cbCodBicicleta.Size = new System.Drawing.Size(190, 24);
            this.cbCodBicicleta.TabIndex = 6;
            // 
            // tbDistanta
            // 
            this.tbDistanta.Location = new System.Drawing.Point(173, 144);
            this.tbDistanta.Name = "tbDistanta";
            this.tbDistanta.Size = new System.Drawing.Size(190, 22);
            this.tbDistanta.TabIndex = 7;
            this.tbDistanta.Validating += new System.ComponentModel.CancelEventHandler(this.tbDistanta_Validating);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(49, 192);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 39);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "button1";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(193, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // errorProviderDurata
            // 
            this.errorProviderDurata.ContainerControl = this;
            // 
            // AdaugareUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 249);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbDistanta);
            this.Controls.Add(this.cbCodBicicleta);
            this.Controls.Add(this.tbNumeUtilizator);
            this.Controls.Add(this.tbCodUtilizator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareUtilizator";
            this.Text = "AdaugareUtilizator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodUtilizator;
        private System.Windows.Forms.TextBox tbNumeUtilizator;
        private System.Windows.Forms.ComboBox cbCodBicicleta;
        private System.Windows.Forms.TextBox tbDistanta;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderDurata;
    }
}