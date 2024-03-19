using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class Form1 : Form
    {
        Medic m1, m2;
        public Form1()
        {
            InitializeComponent();
            //lbMedici.Items.Clear();
            m1 = new Medic("5240119397705", "Marian", 2020, 
                "Chirurgie Plastica", new DateTime(1980, 05, 25));
            m2 = new Medic("6240306397081", "Ana", 2015,
                "Neurologie", new DateTime(1978, 08, 15));
            lbMedici.Items.Add(m1.Nume);
            lbMedici.Items.Add(m2.Nume);
            
            ListViewItem lv = new ListViewItem(m1.Nume);
            lv.SubItems.Add(m1.Cnp);
            lv.SubItems.Add(m1.AnAbsolvire.ToString());
            lv.SubItems.Add(m1.Specializare);
            lv.SubItems.Add(m1.DataNastere.ToString());
            lv.Tag = m1;                //To follow the clicked doctor
            lwMedici.Items.Add(lv);

            ListViewItem lv2 = new ListViewItem(new String[] {
                m2.Nume, m2.Cnp, m2.AnAbsolvire.ToString(), 
                m2.Specializare, m2.DataNastere.ToString()});
            lv2.Tag = m2;
            lwMedici.Items.Add(lv2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lv = lwMedici.SelectedItems[0];
            tbMedic.Text += lv.Text + ", " + lv.SubItems[1].Text +
                ", " + lv.SubItems[2].Text + ", " + lv.SubItems[3].Text +
                ", " + lv.SubItems[4].Text;
            //if(lwMedici.SelectedItems.Count > 0)
            //{
            //    tbMedic.Text = lwMedici.SelectedItems[0].Text;
            //}
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medic m = null;
            AdaugaMedic form = new AdaugaMedic(m);
            if(form.ShowDialog() == DialogResult.OK)
            {
                m = form.mFormMedic;
                ListViewItem lv3 = new ListViewItem(new string[]
                { m.Nume, m.Cnp, m.AnAbsolvire.ToString(),
                m.Specializare, m.DataNastere.ToString() }
                );
                lv3.Tag = m;
                lwMedici.Items.Add(lv3);
            }

        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medic m = lwMedici.SelectedItems[0].Tag as Medic;
            AdaugaMedic form = new AdaugaMedic(m);
            if (form.ShowDialog() == DialogResult.OK ) {
                ListViewItem lv3 = lwMedici.SelectedItems[0] as ListViewItem;
                lv3.SubItems[0].Text = m.Nume;
                lv3.SubItems[0].Text = m.Cnp;
                lv3.SubItems[0].Text = m.AnAbsolvire.ToString();
                lv3.SubItems[0].Text = m.Specializare;
                lv3.SubItems[0].Text = m.DataNastere.ToString();
            }
        }

        private void lbMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbMedici.SelectedItem != null)
            {
                tbMedic.Text = lbMedici.SelectedItem.ToString();
            }
        }
    }
}
