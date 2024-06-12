namespace Model_2
{
    partial class AdaugaAngajat
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.dtpDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.cbCompanie = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.errorProviderNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDataNasterii = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataNasterii)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nasterii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Companie";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(276, 146);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(388, 31);
            this.tbNume.TabIndex = 3;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // dtpDataNasterii
            // 
            this.dtpDataNasterii.Location = new System.Drawing.Point(276, 228);
            this.dtpDataNasterii.Name = "dtpDataNasterii";
            this.dtpDataNasterii.Size = new System.Drawing.Size(388, 31);
            this.dtpDataNasterii.TabIndex = 4;
            this.dtpDataNasterii.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataNasterii_Validating);
            // 
            // cbCompanie
            // 
            this.cbCompanie.FormattingEnabled = true;
            this.cbCompanie.Items.AddRange(new object[] {
            "Microsoft",
            "Google",
            "NTT Data"});
            this.cbCompanie.Location = new System.Drawing.Point(276, 306);
            this.cbCompanie.Name = "cbCompanie";
            this.cbCompanie.Size = new System.Drawing.Size(388, 33);
            this.cbCompanie.TabIndex = 5;
            // 
            // btnAdauga
            // 
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(85, 409);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(221, 56);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "button1";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // errorProviderNume
            // 
            this.errorProviderNume.ContainerControl = this;
            // 
            // errorProviderDataNasterii
            // 
            this.errorProviderDataNasterii.ContainerControl = this;
            // 
            // AdaugaAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 897);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cbCompanie);
            this.Controls.Add(this.dtpDataNasterii);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaAngajat";
            this.Text = "AdaugaAngajat";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataNasterii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.DateTimePicker dtpDataNasterii;
        private System.Windows.Forms.ComboBox cbCompanie;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ErrorProvider errorProviderNume;
        private System.Windows.Forms.ErrorProvider errorProviderDataNasterii;
    }
}