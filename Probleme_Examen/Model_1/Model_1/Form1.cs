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

namespace Model_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Tranzactie t1 = new Tranzactie(21, "RO24INGB34343", "Plata facturi", 452.31, "21.10.2021");
            Tranzactie t2 = new Tranzactie(45, "RO21BRDB21323", "Bani de mancare", 110, "21.12.2022");
            Tranzactie t3 = new Tranzactie(89, "RO45RAIF31212", "Transfer", 432.21, "12.11.2023");
            Tranzactie t4 = new Tranzactie(90, "RO43INGB21332", "Plata bilete", 21.21, "12.01.2023");
            Tranzactie t5 = new Tranzactie(100, "RO21BCR21323", "Plata restaurant", 100.21, "22.07.2023");

            ListViewItem lvT1 = new ListViewItem(new string[]
            {
                t1.idTranzactie.ToString(), t1.contIban, t1.detaliiTranzactie, t1.suma.ToString()
            });
            lvT1.Tag = t1;
            lvTranzactii.Items.Add(lvT1);

            ListViewItem lvT2 = new ListViewItem(new string[]
            {
                t2.idTranzactie.ToString(), t2.ContIban, t2.detaliiTranzactie, t2.suma.ToString()
            });
            lvT2.Tag = t2;
            lvTranzactii.Items.Add(lvT2);

            ListViewItem lvT3 = new ListViewItem(new string[]
            {
                t3.idTranzactie.ToString(), t3.ContIban, t3.detaliiTranzactie, t3.suma.ToString()
            });
            lvT3.Tag = t3;
            lvTranzactii.Items.Add (lvT3);

            ListViewItem lvT4 = new ListViewItem(new string[]
            {
                t4.idTranzactie.ToString(), t4.ContIban, t4.detaliiTranzactie, t4.suma.ToString()
            });
            lvT4.Tag = t4;
            lvTranzactii.Items.Add(lvT4);

            ListViewItem lvT5 = new ListViewItem(new string[]
            {
                t5.idTranzactie.ToString(), t5.ContIban, t5.detaliiTranzactie, t5.suma.ToString()
            });
            lvT5.Tag = t5;
            lvTranzactii.Items.Add(lvT5);

            List<Tranzactie> l1 = new List<Tranzactie>();
            l1.Add(t1);
            l1.Add(t2);
            l1.Add(t3);
            String tranzactiiL1 = "";
            foreach(Tranzactie t in l1)
            {
                tranzactiiL1 = tranzactiiL1 + "  " + t.idTranzactie.ToString();
            }

            List<Tranzactie> l2 = new List<Tranzactie>();
            l2.Add(t4);
            l2.Add(t5);
            String tranzactiiL2 = "";
            foreach(Tranzactie t in l2)
            {
                tranzactiiL2 = tranzactiiL2 + " " + t.idTranzactie.ToString();
            }

            List<Tranzactie> l3 = new List<Tranzactie>();
            l3.Add(t5);
            l3.Add(t2);
            String tranzactiiL3 = "";
            foreach(Tranzactie t in l3)
            {
                tranzactiiL3 = tranzactiiL3 + " " + t.idTranzactie.ToString();
            }

            ExtrasCont ex1 = new ExtrasCont("Gabriel Popescu", "Bld. Unirii 89", l1);
            ExtrasCont ex2 = new ExtrasCont("Maria Andonescu", "Calea Victoriei 78", l2);
            ExtrasCont ex3 = new ExtrasCont("Vasile Iulius", "Strada Izvor 90", l3);

            ListViewItem lv1 = new ListViewItem(new string[]
            {
                ex1.numeClient, ex2.adresa, tranzactiiL1
            });
            lv1.Tag = ex1;
            lvExtraseCont.Items.Add(lv1);

            ListViewItem lv2 = new ListViewItem(new string[]
            {
                ex2.numeClient, ex2.adresa,tranzactiiL2
            });
            lv2.Tag = ex2;
            lvExtraseCont.Items.Add (lv2);

            ListViewItem lv3 = new ListViewItem(new string[]
            {
                ex3.numeClient, ex3.adresa, tranzactiiL3
            });
            lv3.Tag = ex3;
            lvExtraseCont.Items.Add(lv3);

            TreeNode node1 = new TreeNode(ex1.numeClient + " - " + ex2.adresa);
            node1.Tag = ex1;

            TreeNode node2 = new TreeNode(ex2.numeClient + " - " + ex2.adresa);
            node2.Tag = ex2;

            TreeNode node3 = new TreeNode(ex3.numeClient + " - " + ex3.adresa);
            node3.Tag = ex3;

            tvExtrasTranzactii.Nodes.Add(node1);
            tvExtrasTranzactii.Nodes.Add(node2);
            tvExtrasTranzactii.Nodes.Add(node3);
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtrasCont extras = null;
            AdaugaExtras formAdauga = new AdaugaExtras(extras);

            if (formAdauga.ShowDialog() == DialogResult.OK) {
                extras = formAdauga.cExtrasCont;
                String tranzactii = "";
                foreach(Tranzactie tranzactie in extras.tranzactii) {
                    tranzactii += tranzactie.idTranzactie + "  ";
                }
                ListViewItem nou = new ListViewItem(new string[]
                {
                    extras.numeClient, extras.adresa, tranzactii
                });
                nou.Tag = extras;
                lvExtraseCont.Items.Add(nou);
            }
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvExtraseCont.SelectedItems.Count > 0)
            {
                ExtrasCont extras = lvExtraseCont.SelectedItems[0].Tag as ExtrasCont;
                AdaugaExtras adaugaExtras = new AdaugaExtras(extras);
                if (adaugaExtras.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = lvExtraseCont.SelectedItems[0] as ListViewItem;
                    item.SubItems[0].Text = extras.numeClient;
                    item.SubItems[1].Text = extras.adresa;
                    item.SubItems[2].Text += "  " + extras.tranzactii[extras.tranzactii.Count - 1].idTranzactie.ToString();
                }
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvExtraseCont.SelectedItems.Count > 0)
            {
                if( MessageBox.Show("Esti sigur ca vrei sa stergi extrasul?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK )
                {
                    lvExtraseCont.SelectedItems[0].Remove();
                }
            }
        }

        private void lvExtraseCont_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareToolStripMenuItem_Click(sender, e);
        }

        private void editareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editareToolStripMenuItem_Click(sender, e);
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stergereToolStripMenuItem_Click(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lvExtraseCont.Items.Count > 0)
            {
                adaugareToolStripMenuItem.Enabled = true;
                editareToolStripMenuItem.Enabled = true;
                stergereToolStripMenuItem.Enabled = true;
            } 
            else
            {
                adaugareToolStripMenuItem.Enabled = true;
                editareToolStripMenuItem.Enabled = false;
                stergereToolStripMenuItem.Enabled = false;
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere extrase cont | *.excont";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<ExtrasCont> list = new List<ExtrasCont>();
                foreach(ListViewItem item in lvExtraseCont.Items)
                {
                    list.Add(item.Tag as ExtrasCont);
                }

                BinaryFormatter formatter = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                formatter.Serialize(fisier, list);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere extrase cont | *.excont";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<ExtrasCont> list = new List<ExtrasCont>();

                BinaryFormatter formatter = new BinaryFormatter();
                Stream fiser = File.OpenRead(fd.FileName);
                list = (List<ExtrasCont>)formatter.Deserialize(fiser);

                if(lvExtraseCont.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi lista actuala de extase de cont?", 
                        "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lvExtraseCont.Items.Clear();
                    }
                }

                foreach(ExtrasCont extrasCont in list)
                {
                    String tranzactii = "";
                    foreach(Tranzactie tranzactie in extrasCont.tranzactii)
                    {
                        tranzactii += " " + tranzactie.idTranzactie;
                    }

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        extrasCont.numeClient, extrasCont.adresa, tranzactii
                    });
                    item.Tag = extrasCont;

                    lvExtraseCont.Items.Add(item);
                }
            }
        }

        private void salvareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere XM: extrase cont | *.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<ExtrasCont> listaLV = new List<ExtrasCont>();
                foreach(ListViewItem item in lvExtraseCont.Items)
                {
                    listaLV.Add(item.Tag as ExtrasCont);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<ExtrasCont>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listaLV);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisere XML estras cont | *.xml";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<ExtrasCont> listaFisier = new List<ExtrasCont>();
                XmlSerializer serializer = new XmlSerializer (typeof(List<ExtrasCont>));
                Stream fiser = File.OpenRead(fd.FileName);
                listaFisier = (List<ExtrasCont>)serializer.Deserialize(fiser);

                if(lvExtraseCont.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi extrasele existente?", 
                        "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lvExtraseCont.Items.Clear();
                    }
                }

                foreach(ExtrasCont extras in listaFisier)
                {
                    String tranzactii = "";
                    foreach(Tranzactie tranzactie in extras.tranzactii)
                    {
                        tranzactii += " " + tranzactie.idTranzactie;
                    }

                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        extras.numeClient, extras.adresa, tranzactii
                    });
                    lvi.Tag = extras;
                    lvExtraseCont.Items.Add(lvi);
                }
            }
        }

        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tranzactie tranzactie = null;
            AdaugareTranzactie formAdauga = new AdaugareTranzactie(tranzactie);
            
            if(formAdauga.ShowDialog() == DialogResult.OK)
            {
                tranzactie = formAdauga.cTranzatie;
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    tranzactie.idTranzactie.ToString(),
                    tranzactie.contIban,
                    tranzactie.detaliiTranzactie,
                    tranzactie.suma.ToString(),
                });
                lvi.Tag = tranzactie;
                lvTranzactii.Items.Add(lvi);
            }
        }

        private void editareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(lvTranzactii.SelectedItems.Count > 0)
            {
                Tranzactie tranzactie = lvTranzactii.SelectedItems[0].Tag as Tranzactie;
                AdaugareTranzactie formAdauga = new AdaugareTranzactie(tranzactie);

                if(formAdauga.ShowDialog() == DialogResult.OK)
                {
                    tranzactie = formAdauga.cTranzatie;

                    ListViewItem lvi = lvTranzactii.SelectedItems[0] as ListViewItem;
                    lvi.SubItems[0].Text = tranzactie.idTranzactie.ToString();
                    lvi.SubItems[1].Text = tranzactie.contIban;
                    lvi.SubItems[2].Text = tranzactie.detaliiTranzactie;
                    lvi.SubItems[3].Text = tranzactie.suma.ToString();
                }
            }
        }

        private void stergereToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(lvTranzactii.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Esti sigur ca vrei sa stergi tranzactia?", "Warning", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    lvTranzactii.SelectedItems[0].Remove();
                }
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugareToolStripMenuItem1_Click(sender, e);
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editareToolStripMenuItem2_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stergereToolStripMenuItem2_Click(sender, e);
        }

        private void contextMenuStripTranzactii_Opening(object sender, CancelEventArgs e)
        {
            if(lvTranzactii.SelectedItems.Count > 0)
            {
                adaugareToolStripMenuItem1.Enabled = true;
                editareToolStripMenuItem1.Enabled = true;
                stergereToolStripMenuItem1.Enabled =true;
            } 
            else
            {
                adaugareToolStripMenuItem1.Enabled = true;
                editareToolStripMenuItem1.Enabled = false;
                stergereToolStripMenuItem1.Enabled = false;
            }
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisere tranzactii binare | *.trans";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Tranzactie> tranzactii = new List<Tranzactie>();
                foreach(ListViewItem lvi in lvTranzactii.Items )
                {
                    tranzactii.Add(lvi.Tag as Tranzactie);
                }

                BinaryFormatter serializer = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, tranzactii);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere tranzactii binare | *.trans";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Tranzactie> lista = new List<Tranzactie>();

                BinaryFormatter serializer = new BinaryFormatter();
                Stream fiser = File.OpenRead(fd.FileName);
                lista = (List<Tranzactie>) serializer.Deserialize(fiser);

                if(lvTranzactii.Items.Count > 0 )
                {
                    if(MessageBox.Show("Vrei sa stergi tranzactiile existente?", "Warning",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lvTranzactii.Items.Clear();
                    }
                }

                foreach (Tranzactie tranzactie in lista)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[]
                    {
                        tranzactie.idTranzactie.ToString(),
                        tranzactie.contIban,
                        tranzactie.detaliiTranzactie,
                        tranzactie.suma.ToString()
                    });
                    listViewItem.Tag = tranzactie;
                    lvTranzactii.Items.Add(listViewItem);
                }
            }
        }

        private void salvareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd  = new SaveFileDialog();
            fd.Filter = "fisiere tranzactii XML | *.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Tranzactie> tranzacties  = new List<Tranzactie>();
                foreach(ListViewItem lvi in lvTranzactii.Items)
                {
                    tranzacties.Add(lvi.Tag as Tranzactie);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Tranzactie>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, tranzacties);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere tranzactii XML | *.xml";
            fd.CheckFileExists = true;

            if(fd.ShowDialog()== DialogResult.OK)
            {
                List<Tranzactie> lista = new List<Tranzactie>();

                XmlSerializer serializer = new XmlSerializer (typeof(List<Tranzactie>));
                Stream fisier = File.OpenRead(fd.FileName);
                lista = (List<Tranzactie>)serializer.Deserialize(fisier);

                if(lvTranzactii.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi tranzactiile din List View?", "Warning",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvTranzactii.Items.Clear();
                    }
                }

                foreach(Tranzactie t in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        t.idTranzactie.ToString(),
                        t.contIban,
                        t.detaliiTranzactie,
                        t.suma.ToString()
                    });
                    lvi.Tag = t;
                    lvTranzactii.Items.Add(lvi);
                }
            }
        }

        private void lvExtraseCont_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvExtraseCont.SelectedItems.Count > 0)
            {
                lvExtraseCont.DoDragDrop(lvExtraseCont.SelectedItems[0].Tag, DragDropEffects.Copy);
            }
        }

        private void tvExtrasTranzactii_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(ExtrasCont)))
            {
                e.Effect = DragDropEffects.Copy;
            } 
            
            else if(e.Data.GetDataPresent(typeof(Tranzactie)))
            {
                e.Effect = DragDropEffects.Copy;
            }

            else
            {
                e.Effect= DragDropEffects.None;
            }
        }

        private void tvExtrasTranzactii_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof (ExtrasCont)) && e.Effect == DragDropEffects.Copy)
            {
                ExtrasCont extrasCont = (ExtrasCont) e.Data.GetData(typeof(ExtrasCont));
                TreeNode node = new TreeNode(extrasCont.numeClient + " - " + extrasCont.adresa);
                node.Tag = extrasCont;
                tvExtrasTranzactii.Nodes.Add(node);
            }

            else if(e.Data.GetDataPresent(typeof(Tranzactie)) && e.Effect == DragDropEffects.Copy)
            {
                Point point = new Point(e.X, e.Y);
                Point treePoint = tvExtrasTranzactii.PointToClient(point);
                TreeNode node = tvExtrasTranzactii.GetNodeAt(treePoint);

                if(node != null)
                {
                    Tranzactie tranzactie = (Tranzactie)e.Data.GetData(typeof(Tranzactie));
                    TreeNode nodeChild = new TreeNode(tranzactie.idTranzactie.ToString() + 
                        " - " + tranzactie.detaliiTranzactie + " - " + tranzactie.suma.ToString());
                    nodeChild.Tag = tranzactie;
                    node.Nodes.Add(nodeChild);
                    node.Expand();
                }
            }
        }

        private void lvTranzactii_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvTranzactii.SelectedItems.Count > 0)
            {
                lvTranzactii.DoDragDrop(lvTranzactii.SelectedItems[0].Tag, DragDropEffects.Copy);
            }
        }
    }
}
