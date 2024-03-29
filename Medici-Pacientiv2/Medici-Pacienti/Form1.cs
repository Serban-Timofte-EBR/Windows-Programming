﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medici_Pacienti
{
    public partial class Form1 : Form
    {
        Medic m1, m2;
        public Form1()
        {
            InitializeComponent();
            m1 = new Medic("5039217190278", "Marian",
                2020, "Chirurgie Plastica", new DateTime(1980,05,25));
            m2 = new Medic("6273817263782", "Ana",
                2015, "Neurologie", new DateTime(1978, 08, 15));
            lbMedici.Items.Add(m1.Nume);
            lbMedici.Items.Add(m2.Nume);

            ListViewItem lv = new ListViewItem(m1.Nume);
            lv.SubItems.Add(m1.Cnp);
            lv.SubItems.Add(m1.AnAbsolvire.ToString());
            lv.SubItems.Add(m1.Specializare);
            lv.SubItems.Add(m1.DataNastere.ToString());
            lv.Tag= m1;
            lvMedici.Items.Add(lv);

            ListViewItem lv2 = new ListViewItem(new string[]
                {m2.Nume,m2.Cnp,m2.AnAbsolvire.ToString(),
                m2.Specializare,m2.DataNastere.ToString()});
            lv2.Tag = m2;
            lvMedici.Items.Add(lv2);



             
        }

        private void lvMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems.Count > 0)
            {
                tbMedic.Text = "";
                //foreach(ListViewItem lv in lvMedici.SelectedItems)
                ListViewItem lv = lvMedici.SelectedItems[0];
                tbMedic.Text += lv.Text
                    +","+ lv.SubItems[1].Text + "," + lv.SubItems[2].Text+
                    ","+lv.SubItems[3].Text+","+lv.SubItems[4].Text;
            }    
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medic m = null;
            FormMedic form = new FormMedic(m);
            if (form.ShowDialog() == DialogResult.OK)
            {
                m = form.mFormMedic;
                ListViewItem lv3 = new ListViewItem(new string[]
              {m.Nume,m.Cnp,m.AnAbsolvire.ToString(),
                m.Specializare,m.DataNastere.ToString()});
                lv3.Tag = m;
                lvMedici.Items.Add(lv3);
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems.Count > 0)
            {
                Medic m = lvMedici.SelectedItems[0].Tag as Medic;
                FormMedic form = new FormMedic(m);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lv = lvMedici.SelectedItems[0] as ListViewItem;
                    lv.SubItems[0].Text = m.Nume;
                    lv.SubItems[1].Text = m.Cnp;
                    lv.SubItems[2].Text = m.AnAbsolvire.ToString();
                    lv.SubItems[3].Text = m.Specializare;
                    lv.SubItems[4].Text = m.DataNastere.ToString();
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi medicul selectat?",
                    "Confirmare",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                lvMedici.SelectedItems[0].Remove();
            }

            }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(lvMedici.SelectedItems.Count>0)
            {
                modificaToolStripMenuItem1.Enabled = true;
                stergeToolStripMenuItem1.Enabled = true;
            }
            else
            {
                modificaToolStripMenuItem1.Enabled = false;
                stergeToolStripMenuItem1.Enabled = false;
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugaToolStripMenuItem_Click(sender, e);
        }

        private void modificaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modificaToolStripMenuItem_Click(sender, e);
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stergeToolStripMenuItem_Click(sender, e);
        }

        private void fisiereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Fisier medic (*.med)|*.med";
            fd.CheckPathExists = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Medic> medici = new List<Medic>();
                foreach(ListViewItem lvi in lvMedici.Items)
                {
                    medici.Add(lvi.Tag as Medic);
                }
                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serializator.Serialize(fisier, medici);
                fisier.Close();
            }
        }

        private void restaurareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Fisier medic (*.med)|*.med";
            fd.CheckFileExists = true;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Medic> lista = new List<Medic>();
                Stream fisier = File.OpenRead(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();

                lista.AddRange((List<Medic>)serializator.Deserialize(fisier));
                fisier.Close();

                lvMedici.Items.Clear();
                foreach(Medic m in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                        { m.Nume, m.Cnp, m.AnAbsolvire.ToString(), 
                            m.Specializare, m.DataNastere.ToString() });
                    lvi.Tag = m;
                    lvMedici.Items.Add(lvi);
                    fisier.Close();
                }
            }
        }

        private void lbMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (lbMedici.SelectedItem!=null)
            tbMedic.Text = lbMedici.SelectedItem.ToString();
        }
    }
}
