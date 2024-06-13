namespace Model_5
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
            this.tvCalatorii = new System.Windows.Forms.TreeView();
            this.tbMultiCalatorie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoldTotal = new System.Windows.Forms.TextBox();
            this.btSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvCalatorii
            // 
            this.tvCalatorii.Location = new System.Drawing.Point(2, 29);
            this.tvCalatorii.Name = "tvCalatorii";
            this.tvCalatorii.Size = new System.Drawing.Size(358, 249);
            this.tvCalatorii.TabIndex = 0;
            this.tvCalatorii.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCalatorii_AfterSelect);
            this.tvCalatorii.DoubleClick += new System.EventHandler(this.tvCalatorii_DoubleClick);
            // 
            // tbMultiCalatorie
            // 
            this.tbMultiCalatorie.Location = new System.Drawing.Point(2, 328);
            this.tbMultiCalatorie.Multiline = true;
            this.tbMultiCalatorie.Name = "tbMultiCalatorie";
            this.tbMultiCalatorie.Size = new System.Drawing.Size(358, 59);
            this.tbMultiCalatorie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Calatorie Selectat";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(5, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 27);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Card";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carduri si calatorii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valoarea calatoriilor de pe un card";
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(611, 29);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(142, 22);
            this.tbValoare.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sold total";
            // 
            // tbSoldTotal
            // 
            this.tbSoldTotal.Location = new System.Drawing.Point(480, 67);
            this.tbSoldTotal.Name = "tbSoldTotal";
            this.tbSoldTotal.Size = new System.Drawing.Size(273, 22);
            this.tbSoldTotal.TabIndex = 9;
            // 
            // btSalveaza
            // 
            this.btSalveaza.BackColor = System.Drawing.Color.GreenYellow;
            this.btSalveaza.Location = new System.Drawing.Point(380, 110);
            this.btSalveaza.Name = "btSalveaza";
            this.btSalveaza.Size = new System.Drawing.Size(121, 39);
            this.btSalveaza.TabIndex = 10;
            this.btSalveaza.Text = "Salveaza in DB";
            this.btSalveaza.UseVisualStyleBackColor = false;
            this.btSalveaza.Click += new System.EventHandler(this.btSalveaza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalveaza);
            this.Controls.Add(this.tbSoldTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMultiCalatorie);
            this.Controls.Add(this.tvCalatorii);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCalatorii;
        private System.Windows.Forms.TextBox tbMultiCalatorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoldTotal;
        private System.Windows.Forms.Button btSalveaza;
    }
}

