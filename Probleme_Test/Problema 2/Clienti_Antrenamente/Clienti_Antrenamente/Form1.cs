using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Clienti_Antrenamente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Client c1 = new Client("Popescu", "Ion", 45, "ACTIV");
            Client c2 = new Client("Georgescu", "Vlad", 19, "ACTIV");
            Client c3 = new Client("Pamfil", "Mihai", 22, "INACTIV");

            ListViewItem lv1 = new ListViewItem(new String[]
            {
                c1.Nume, c1.Prenume, c1.Varsta.ToString(), c1.Abonament
            });
            lv1.Tag = c1;

            ListViewItem lv2 = new ListViewItem(new String[]
            {
                c2.Nume, c2.Prenume, c2.Varsta.ToString(), c2.Abonament
            });
            lv2.Tag = c2;

            ListViewItem lv3 = new ListViewItem(new String[]
            {
                c3.Nume, c3.Prenume, c3.Varsta.ToString(), c3.Abonament
            });
            lv3.Tag = c3;

            lvClienti.Items.Add(lv1);
            lvClienti.Items.Add(lv2);
            lvClienti.Items.Add(lv3);
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = null;
            AdaugaClient formAdauga = new AdaugaClient(client);
            if(formAdauga.ShowDialog() == DialogResult.OK)
            {
                client = new Client();
                client = formAdauga.cFormClient;
                ListViewItem lvi = new ListViewItem(new String[]
                {
                    client.Nume, client.Prenume, client.Varsta.ToString(), client.Abonament
                });
                lvi.Tag = client;
                lvClienti.Items.Add(lvi);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count > 0)
            {
                Client client = new Client();
                client = lvClienti.SelectedItems[0].Tag as Client;
                AdaugaClient formAdauga = new AdaugaClient(client);
                if(formAdauga.ShowDialog() == DialogResult.OK)
                {
                    client = formAdauga.cFormClient;
                    ListViewItem lvClient = lvClienti.SelectedItems[0] as ListViewItem;
                    lvClient.SubItems[0].Text = client.Nume;
                    lvClient.SubItems[1].Text = client.Prenume;
                    lvClient.SubItems[2].Text = client.Varsta.ToString();
                    lvClient.SubItems[3].Text = client.Abonament;
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvClienti.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Vrei sa stergi inregistrarea selectata?", "Warning", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvClienti.SelectedItems[0].Remove();
                }
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugaToolStripMenuItem_Click(sender, e);
        }

        private void editeazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editeazaToolStripMenuItem_Click(sender, e);
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stergeToolStripMenuItem_Click(sender, e);
        }

        private void contextMenuStripClienti_Opening(object sender, CancelEventArgs e)
        {
            if (lvClienti.SelectedItems.Count > 0)
            {
                adaugaToolStripMenuItem1.Enabled = true;
                editeazaToolStripMenuItem1.Enabled = true;
                stergeToolStripMenuItem1.Enabled=true;
            }
            else
            {
                adaugaToolStripMenuItem1.Enabled = true;
                editeazaToolStripMenuItem1.Enabled = false;
                stergeToolStripMenuItem1.Enabled = false;
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere binare cu studenti | *.stud";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Client> listaLV = new List<Client>();
                foreach(ListViewItem item in lvClienti.Items)
                {
                    listaLV.Add(item.Tag as Client);
                } 

                BinaryFormatter serializer = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listaLV);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere binare cu studenti | *.stud";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.OpenRead(fd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                List<Client> listaFisier = new List<Client>();

                listaFisier.AddRange((List<Client>)serializer.Deserialize(fisier));

                if(lvClienti.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi inregistrarile existent?", "Warning",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvClienti.Items.Clear();
                    }
                }

                foreach(Client client in listaFisier)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        client.Nume, client.Prenume, client.Varsta.ToString(), client.Abonament
                    });
                    lvi.Tag = client;
                    lvClienti.Items.Add(lvi);
                }
            }
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere xml cu clienti | *.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Client> listLV = new List<Client>();
                foreach(ListViewItem item in lvClienti.Items)
                {
                    listLV.Add(item.Tag as Client);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listLV);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere xml cu clienti | *.xml";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK) 
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                Stream fisier = File.OpenRead(fd.FileName);
                List<Client> lst = new List<Client>();
                lst = (List<Client>)serializer.Deserialize(fisier);

                if (lvClienti.Items.Count > 0)
                {
                    if (MessageBox.Show("Vrei sa stergi inregistrarile existent?", "Warning",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvClienti.Items.Clear();
                    }
                }

                foreach (Client item in lst)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        item.Nume, item.Prenume, item.Varsta.ToString(), item.Abonament
                    });
                    lvi.Tag = item;
                    lvClienti.Items.Add(lvi);
                }
            }
        }
    }
}
