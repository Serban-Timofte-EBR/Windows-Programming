using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Model_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Angajat angajat = null;
            AdaugaAngajat formAdauga = new AdaugaAngajat(angajat);

            if (formAdauga.ShowDialog() == DialogResult.OK)
            {
                Companie c1 = new Companie(21, "Microsoft");
                Companie c2 = new Companie(31, "Google");
                Companie c3 = new Companie(98, "NTT Data");

                List<Companie> companii = new List<Companie>();
                companii.Add(c1);
                companii.Add(c2);
                companii.Add(c3);

                angajat = formAdauga.cAngajat;

                String companie = "";
                if (angajat.idCompanie > 0)
                {
                    companie = companii.Find(c => c.id == angajat.idCompanie).name;
                }

                ListViewItem item = new ListViewItem(new string[]
                {
                    angajat.Nume, angajat.DataNasterii.ToString(), companie
                });
                item.Tag = angajat;
                lvAngajati.Items.Add(item);
            }
        }

        private void lvAngajati_DoubleClick(object sender, EventArgs e)
        {
            if (lvAngajati.SelectedItems.Count > 0)
            {
                Angajat angajat = lvAngajati.SelectedItems[0].Tag as Angajat;
                AdaugaAngajat formEditeaza = new AdaugaAngajat(angajat);

                if(formEditeaza.ShowDialog() == DialogResult.OK)
                {
                    angajat = formEditeaza.cAngajat;

                    String comapanie = "";

                    if (angajat.idCompanie > 0)
                    {
                        Companie c1 = new Companie(21, "Microsoft");
                        Companie c2 = new Companie(31, "Google");
                        Companie c3 = new Companie(98, "NTT Data");
                        List<Companie> companii = new List<Companie>();
                        companii.Add(c1);
                        companii.Add(c2);
                        companii.Add(c3);

                        comapanie = companii.Find(c => c.id == angajat.idCompanie).Name;
                    }
                    ListViewItem item = lvAngajati.SelectedItems[0] as ListViewItem;
                    item.SubItems[0].Text = angajat.Nume;
                    item.SubItems[1].Text = angajat.dataNasterii.ToString();
                    item.SubItems[2].Text = comapanie;
                }
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esti sigur ca vrei sa stergi toati angajatii?", 
                "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lvAngajati.Items.Clear();
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere XML - angajati | *.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Angajat> lista = new List<Angajat>();
                foreach(ListViewItem item in lvAngajati.Items)
                {
                    lista.Add(item.Tag as Angajat);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Angajat>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, lista);
                fisier.Close();
            }
        }
    }
}
