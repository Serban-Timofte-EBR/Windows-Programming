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

            Antrenamnet a1 = new Antrenamnet("Luni", 13, "Sala C", "Marius");
            Antrenamnet a2 = new Antrenamnet("Miercuri", 10, "Sala A", "Vali");
            Antrenamnet a3 = new Antrenamnet("Vineri", 19, "Sala A", "Vali");

            ListViewItem lva1 = new ListViewItem(new string[]
            {
                a1.zi, a1.ora.ToString(),  a1.sala, a1.antrenor
            });
            lva1.Tag = a1;

            ListViewItem lva2 = new ListViewItem(new string[]
            {
                a2.zi, a2.ora.ToString(), a2.sala, a2.antrenor
            });
            lva2.Tag = a2;

            ListViewItem lva3 = new ListViewItem(new string[]
            {
                a3.zi, a3.ora.ToString(), a3.sala, a3.antrenor
            });
            lva3.Tag = a3;

            lvAntrenamente.Items.Add(lva1);
            lvAntrenamente.Items.Add (lva2);
            lvAntrenamente.Items.Add(lva3);
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

        private void lvAntrenamente_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvAntrenamente.SelectedItems.Count > 0)
            {
                lvAntrenamente.DoDragDrop(lvAntrenamente.SelectedItems[0].Tag as Antrenamnet, DragDropEffects.Copy);
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Antrenamnet)) || e.Data.GetDataPresent(typeof(Client)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect= DragDropEffects.None;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Effect == DragDropEffects.Copy && 
                e.Data.GetDataPresent(typeof(Antrenamnet)))
            {
                Antrenamnet twAntrenament = e.Data.GetData(typeof(Antrenamnet)) as Antrenamnet;
                TreeNode tNou = new TreeNode(twAntrenament.zi + " - " + twAntrenament.ora + " - " + 
                    twAntrenament.sala + " - " + twAntrenament.antrenor);
                tNou.Tag = twAntrenament;
                treeView1.Nodes.Add(tNou);
            }
            else if(e.Effect == DragDropEffects.Copy &&
                e.Data.GetDataPresent(typeof(Client)))
            {
                Point punct = new Point(e.X, e.Y);
                Point treePoint = treeView1.PointToClient(punct);
                TreeNode selectedTreeNode = treeView1.GetNodeAt(treePoint);

                if(!(selectedTreeNode == null))
                {
                    Client client = e.Data.GetData(typeof(Client)) as Client;
                    TreeNode nod = new TreeNode(client.Nume + " " + client.Prenume + " - " + client.Varsta + " ani");
                    selectedTreeNode.Nodes.Add(nod);
                    selectedTreeNode.Expand();
                }
            }
        }

        private void lvClienti_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvClienti.SelectedItems.Count > 0)
            {
                lvClienti.DoDragDrop(lvClienti.SelectedItems[0].Tag as Client, DragDropEffects.Copy);
            }
        }

        private void adaugaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Antrenamnet antrenamnet = null;
            AdaugaAntrenament formAdauga = new AdaugaAntrenament(antrenamnet);

            if(formAdauga.ShowDialog() == DialogResult.OK )
            {
                antrenamnet = formAdauga.cFormAntrenament;
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    antrenamnet.zi, antrenamnet.ora.ToString(), antrenamnet.sala, antrenamnet.antrenor
                });
                lvi.Tag = antrenamnet;
                lvAntrenamente.Items.Add(lvi);
            }
        }

        private void editeazaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvAntrenamente.SelectedItems.Count > 0)
            {
                Antrenamnet antrenamentSelectat = new Antrenamnet();
                antrenamentSelectat = lvAntrenamente.SelectedItems[0].Tag as Antrenamnet;
                AdaugaAntrenament formEdit = new AdaugaAntrenament(antrenamentSelectat);

                if(formEdit.ShowDialog() == DialogResult.OK )
                {
                    antrenamentSelectat = formEdit.cFormAntrenament;
                    ListViewItem item = lvAntrenamente.SelectedItems[0] as ListViewItem;
                    item.SubItems[0].Text = antrenamentSelectat.zi;
                    item.SubItems[1].Text = antrenamentSelectat.ora.ToString();
                    item.SubItems[2].Text = antrenamentSelectat.sala;
                    item.SubItems[3].Text = antrenamentSelectat.antrenor;
                }
            }
        }

        private void stergeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(lvAntrenamente.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Esti sigur ca vrei sa stergi antrenamentul selectat?", "Warning",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvAntrenamente.SelectedItems[0].Remove();
                }
            }
        }

        private void adaugaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            adaugaToolStripMenuItem2_Click(sender, e);
        }

        private void editeazaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            editeazaToolStripMenuItem2_Click(sender, e);
        }

        private void stergeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            stergeToolStripMenuItem2_Click(sender, e);
        }

        private void contextMenuStripAntrenamente_Opening(object sender, CancelEventArgs e)
        {
            if (lvAntrenamente.SelectedItems.Count > 0)
            {
                adaugaToolStripMenuItem3.Enabled = true;
                editeazaToolStripMenuItem3.Enabled = true;
                stergeToolStripMenuItem3.Enabled = true;
            }
            else
            {
                adaugaToolStripMenuItem3.Enabled = true;
                editeazaToolStripMenuItem3.Enabled = false;
                stergeToolStripMenuItem3.Enabled = false;
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere antrenamente binare | *.antrenament";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Antrenamnet> listaListView = new List<Antrenamnet>();
                foreach(ListViewItem item in lvAntrenamente.Items )
                {
                    listaListView.Add(item.Tag as Antrenamnet);
                }

                BinaryFormatter serializer = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize( fisier, listaListView );
                fisier.Close();
            }
        }

        private void restaureazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere antrenamente binar | *.antrenament";
            fd.CheckFileExists = true;

            if(fd .ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.OpenRead(fd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                List<Antrenamnet> listaFisier = (List<Antrenamnet>)serializer.Deserialize(fisier);

                if(lvAntrenamente.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi antrenamentele existente?", "Warning",
                        MessageBoxButtons.YesNo)  == DialogResult.Yes)
                    {
                        lvAntrenamente.Items.Clear();
                    }
                }

                foreach(Antrenamnet antrenamnet in listaFisier)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        antrenamnet.zi, antrenamnet.ora.ToString(), antrenamnet.sala, antrenamnet.antrenor
                    });
                    lvi.Tag = antrenamnet;
                    lvAntrenamente.Items.Add(lvi);
                }
            }
        }

        private void salveazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere antrenamente xml | *.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Antrenamnet> listView = new List<Antrenamnet>();
                foreach(ListViewItem lvi in lvAntrenamente.Items)
                {
                    listView.Add(lvi.Tag as Antrenamnet);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Antrenamnet>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listView);
                fisier.Close();
            }
        }

        private void restaureazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fiser antrenamente xml | *.xml";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK) 
            {
                Stream fisier = File.OpenRead(fd.FileName);
                XmlSerializer serializer = new XmlSerializer (typeof(List<Antrenamnet>));
                List<Antrenamnet> listaFiser = (List<Antrenamnet>)serializer.Deserialize(fisier);

                if(lvAntrenamente.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi antrenamentele existente?", "Warning", 
                        MessageBoxButtons.YesNo)  == DialogResult.Yes)
                    {
                        lvAntrenamente.Items.Clear();
                    }
                }

                foreach(Antrenamnet antrenamnet in listaFiser)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        antrenamnet.zi, antrenamnet.ora.ToString(), antrenamnet.sala, antrenamnet.antrenor
                    });
                    lvi.Tag = antrenamnet;
                    lvAntrenamente.Items.Add(lvi);
                }
            }
        }

        private void treeView2_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Client)) || e.Data.GetDataPresent(typeof(Antrenamnet)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect= DragDropEffects.None;
            }
        }

        private void treeView2_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Effect == DragDropEffects.Copy
                && e.Data.GetDataPresent(typeof(Client))) 
            {
                Client client = (Client)e.Data.GetData(typeof(Client));
                TreeNode nodNou = new TreeNode(client.Nume + " " + client.Prenume + " - " + client.Varsta.ToString() + " ani");
                nodNou.Tag = client;
                treeView2.Nodes.Add(nodNou);
            }
            else if(e.Effect == DragDropEffects.Copy &&
                e.Data.GetDataPresent(typeof(Antrenamnet)))
            {
                Point punct = new Point(e.X, e.Y);
                Point treePoint = treeView2.PointToClient(punct);
                TreeNode selectedNode = treeView2.GetNodeAt(treePoint);

                if(selectedNode != null)
                {
                    Antrenamnet antrenamnet = e.Data.GetData(typeof(Antrenamnet)) as Antrenamnet;
                    TreeNode treeNode = new TreeNode(antrenamnet.zi + " - " + antrenamnet.ora);
                    treeNode.Tag = antrenamnet;
                    selectedNode.Nodes.Add(treeNode);
                    selectedNode.Expand();
                }
            }
        }
    }
}
