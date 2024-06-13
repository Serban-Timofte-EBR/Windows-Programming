namespace Model_4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodMedic = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbSpecializare = new System.Windows.Forms.ComboBox();
            this.btnAdaugaMedic = new System.Windows.Forms.Button();
            this.tvMedicPacienti = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumePacient = new System.Windows.Forms.TextBox();
            this.tbCodPacient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTarif = new System.Windows.Forms.TextBox();
            this.btnAdaugaPacient = new System.Windows.Forms.Button();
            this.cbCodMedic = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSumaMedic = new System.Windows.Forms.TextBox();
            this.btnUploadDB = new System.Windows.Forms.Button();
            this.bazaDeDateDataSet = new Model_4.bazaDeDateDataSet();
            this.pacinetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacinetiTableAdapter = new Model_4.bazaDeDateDataSetTableAdapters.PacinetiTableAdapter();
            this.lvPacienti = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacinetiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod Medic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Specializarea";
            // 
            // tbCodMedic
            // 
            this.tbCodMedic.Location = new System.Drawing.Point(130, 71);
            this.tbCodMedic.Name = "tbCodMedic";
            this.tbCodMedic.Size = new System.Drawing.Size(144, 22);
            this.tbCodMedic.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(130, 105);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(144, 22);
            this.tbNume.TabIndex = 6;
            // 
            // cbSpecializare
            // 
            this.cbSpecializare.FormattingEnabled = true;
            this.cbSpecializare.Items.AddRange(new object[] {
            "Cardiologie",
            "Neurologie",
            "Diabet",
            "Oncologie",
            "Medicina de familie"});
            this.cbSpecializare.Location = new System.Drawing.Point(130, 144);
            this.cbSpecializare.Name = "cbSpecializare";
            this.cbSpecializare.Size = new System.Drawing.Size(144, 24);
            this.cbSpecializare.TabIndex = 7;
            // 
            // btnAdaugaMedic
            // 
            this.btnAdaugaMedic.Location = new System.Drawing.Point(48, 188);
            this.btnAdaugaMedic.Name = "btnAdaugaMedic";
            this.btnAdaugaMedic.Size = new System.Drawing.Size(135, 38);
            this.btnAdaugaMedic.TabIndex = 8;
            this.btnAdaugaMedic.Text = "Adauga";
            this.btnAdaugaMedic.UseVisualStyleBackColor = true;
            this.btnAdaugaMedic.Click += new System.EventHandler(this.btnAdaugaMedic_Click);
            // 
            // tvMedicPacienti
            // 
            this.tvMedicPacienti.Location = new System.Drawing.Point(355, 166);
            this.tvMedicPacienti.Name = "tvMedicPacienti";
            this.tvMedicPacienti.Size = new System.Drawing.Size(325, 199);
            this.tvMedicPacienti.TabIndex = 9;
            this.tvMedicPacienti.Click += new System.EventHandler(this.tvMedicPacienti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Medic - Pacienti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pacient";
            // 
            // tbNumePacient
            // 
            this.tbNumePacient.Location = new System.Drawing.Point(130, 329);
            this.tbNumePacient.Name = "tbNumePacient";
            this.tbNumePacient.Size = new System.Drawing.Size(144, 22);
            this.tbNumePacient.TabIndex = 15;
            // 
            // tbCodPacient
            // 
            this.tbCodPacient.Location = new System.Drawing.Point(130, 295);
            this.tbCodPacient.Name = "tbCodPacient";
            this.tbCodPacient.Size = new System.Drawing.Size(144, 22);
            this.tbCodPacient.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cod Pacient";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cod Medic";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tarif";
            // 
            // tbTarif
            // 
            this.tbTarif.Location = new System.Drawing.Point(130, 403);
            this.tbTarif.Name = "tbTarif";
            this.tbTarif.Size = new System.Drawing.Size(144, 22);
            this.tbTarif.TabIndex = 19;
            // 
            // btnAdaugaPacient
            // 
            this.btnAdaugaPacient.Location = new System.Drawing.Point(48, 451);
            this.btnAdaugaPacient.Name = "btnAdaugaPacient";
            this.btnAdaugaPacient.Size = new System.Drawing.Size(135, 38);
            this.btnAdaugaPacient.TabIndex = 20;
            this.btnAdaugaPacient.Text = "Adauga";
            this.btnAdaugaPacient.UseVisualStyleBackColor = true;
            this.btnAdaugaPacient.Click += new System.EventHandler(this.btnAdaugaPacient_Click);
            // 
            // cbCodMedic
            // 
            this.cbCodMedic.FormattingEnabled = true;
            this.cbCodMedic.Items.AddRange(new object[] {
            "Cardiologie",
            "Neurologie",
            "Diabet",
            "Oncologie",
            "Medicina de familie"});
            this.cbCodMedic.Location = new System.Drawing.Point(130, 366);
            this.cbCodMedic.Name = "cbCodMedic";
            this.cbCodMedic.Size = new System.Drawing.Size(144, 24);
            this.cbCodMedic.TabIndex = 21;
            this.cbCodMedic.Click += new System.EventHandler(this.cbCodMedic_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Suma totala a medicului";
            // 
            // tbSumaMedic
            // 
            this.tbSumaMedic.Location = new System.Drawing.Point(528, 384);
            this.tbSumaMedic.Name = "tbSumaMedic";
            this.tbSumaMedic.Size = new System.Drawing.Size(152, 22);
            this.tbSumaMedic.TabIndex = 23;
            // 
            // btnUploadDB
            // 
            this.btnUploadDB.BackColor = System.Drawing.Color.IndianRed;
            this.btnUploadDB.Location = new System.Drawing.Point(355, 425);
            this.btnUploadDB.Name = "btnUploadDB";
            this.btnUploadDB.Size = new System.Drawing.Size(146, 37);
            this.btnUploadDB.TabIndex = 24;
            this.btnUploadDB.Text = "Upload DB";
            this.btnUploadDB.UseVisualStyleBackColor = false;
            this.btnUploadDB.Click += new System.EventHandler(this.btnUploadDB_Click);
            // 
            // bazaDeDateDataSet
            // 
            this.bazaDeDateDataSet.DataSetName = "bazaDeDateDataSet";
            this.bazaDeDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacinetiBindingSource
            // 
            this.pacinetiBindingSource.DataMember = "Pacineti";
            this.pacinetiBindingSource.DataSource = this.bazaDeDateDataSet;
            // 
            // pacinetiTableAdapter
            // 
            this.pacinetiTableAdapter.ClearBeforeFill = true;
            // 
            // lvPacienti
            // 
            this.lvPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.CodM,
            this.Tarif});
            this.lvPacienti.HideSelection = false;
            this.lvPacienti.Location = new System.Drawing.Point(716, 199);
            this.lvPacienti.Name = "lvPacienti";
            this.lvPacienti.Size = new System.Drawing.Size(292, 131);
            this.lvPacienti.TabIndex = 25;
            this.lvPacienti.UseCompatibleStateImageBehavior = false;
            this.lvPacienti.View = System.Windows.Forms.View.Details;
            this.lvPacienti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.lvPacienti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvPacienti_MouseDown);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // CodM
            // 
            this.CodM.Text = "Cod Medic";
            // 
            // Tarif
            // 
            this.Tarif.Text = "Tarif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 501);
            this.Controls.Add(this.lvPacienti);
            this.Controls.Add(this.btnUploadDB);
            this.Controls.Add(this.tbSumaMedic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbCodMedic);
            this.Controls.Add(this.btnAdaugaPacient);
            this.Controls.Add(this.tbTarif);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNumePacient);
            this.Controls.Add(this.tbCodPacient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tvMedicPacienti);
            this.Controls.Add(this.btnAdaugaMedic);
            this.Controls.Add(this.cbSpecializare);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbCodMedic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDeDateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacinetiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodMedic;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.ComboBox cbSpecializare;
        private System.Windows.Forms.Button btnAdaugaMedic;
        private System.Windows.Forms.TreeView tvMedicPacienti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumePacient;
        private System.Windows.Forms.TextBox tbCodPacient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTarif;
        private System.Windows.Forms.Button btnAdaugaPacient;
        private System.Windows.Forms.ComboBox cbCodMedic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSumaMedic;
        private System.Windows.Forms.Button btnUploadDB;
        private bazaDeDateDataSet bazaDeDateDataSet;
        private System.Windows.Forms.BindingSource pacinetiBindingSource;
        private bazaDeDateDataSetTableAdapters.PacinetiTableAdapter pacinetiTableAdapter;
        private System.Windows.Forms.ListView lvPacienti;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader CodM;
        private System.Windows.Forms.ColumnHeader Tarif;
    }
}

