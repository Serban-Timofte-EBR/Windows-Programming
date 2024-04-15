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

namespace Actiuni_Portofoliu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Actiune actiuneCode = new Actiune("CODE", "Softbinator", 2.5, 100);
            Actiune actiuneBT = new Actiune("BTV", "Banca Transilvania", 134, 10000);
            Actiune actiuneOMV = new Actiune("OMV", "OMV Petrom", 25.3, 450);

            ListViewItem itemCode = new ListViewItem(new string[]
            {
                actiuneCode.nume, actiuneCode.companie, 
                actiuneCode.pretActual.ToString(), actiuneCode.volumZi.ToString()
            });
            itemCode.Tag = actiuneCode;

            ListViewItem itemBT = new ListViewItem(new string[]
            {
                actiuneBT.nume, actiuneBT.companie, actiuneBT.pretActual.ToString(),
                actiuneBT.volumZi.ToString()
            });
            itemBT.Tag = actiuneBT;

            ListViewItem itemOMV = new ListViewItem(new string[]
            {
                actiuneOMV.nume, actiuneOMV.companie, actiuneOMV.pretActual.ToString(),
                actiuneOMV.volumZi.ToString()
            });
            itemOMV.Tag = actiuneOMV;

            lvActiuni.Items.Add(itemCode);
            lvActiuni.Items.Add(itemBT);
            lvActiuni.Items.Add(itemOMV);

            Ordin ordin1 = new Ordin(2132, "Serban Timofte", 12);
            Ordin ordin2 = new Ordin(121, "Ion Popescu", 01);
            Ordin ordin3 = new Ordin(433, "Gabriel Manuleascu", 29);

            ListViewItem item1 = new ListViewItem(new string[]
            {
                ordin1.id.ToString(), ordin1.owner, ordin1.ziPlasare.ToString()
            });
            item1.Tag = ordin1;

            ListViewItem item2 = new ListViewItem(new string[]
            {
                ordin2.id.ToString(), ordin2.owner, ordin2.ziPlasare.ToString()
            });
            item2.Tag = ordin2;

            ListViewItem item3 = new ListViewItem(new string[]
            {
                ordin3.id.ToString(), ordin3.owner, ordin3.ziPlasare.ToString()
            });
            item3.Tag = ordin3;

            lvOrdine.Items.Add(item1);
            lvOrdine.Items.Add(item2);
            lvOrdine.Items.Add(item3);
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actiune actiune = null;
            AdaugaActiune formActiune = new AdaugaActiune(actiune);

            if(formActiune.ShowDialog() == DialogResult.OK)
            {
                actiune = formActiune.cFormActiune;
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    actiune.nume, actiune.companie, actiune.pretActual.ToString(),
                    actiune.volumZi.ToString()
                });
                lvi.Tag = actiune;
                lvActiuni.Items.Add (lvi);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvActiuni.SelectedItems.Count > 0)
            {
                Actiune actiuneSelectata = lvActiuni.SelectedItems[0].Tag as Actiune;
                AdaugaActiune formAdauga = new AdaugaActiune (actiuneSelectata);
                if(formAdauga.ShowDialog() == DialogResult.OK)
                {
                    actiuneSelectata = formAdauga.cFormActiune;
                    ListViewItem lvi = lvActiuni.SelectedItems[0] as ListViewItem;
                    lvi.SubItems[0].Text = actiuneSelectata.nume;
                    lvi.SubItems[1].Text = actiuneSelectata.companie;
                    lvi.SubItems[2].Text = actiuneSelectata.pretActual.ToString();
                    lvi.SubItems[3].Text = actiuneSelectata.volumZi.ToString();
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvActiuni.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Esti sigur ca vrei sa stergi inregistrare?", "Warning",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvActiuni.SelectedItems[0].Remove();
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

        private void contextMenuStripActiuni_Opening(object sender, CancelEventArgs e)
        {
            if(lvActiuni.SelectedItems.Count > 0)
            {
                adaugaToolStripMenuItem1.Enabled = true;
                editeazaToolStripMenuItem1.Enabled = true;
                stergeToolStripMenuItem1.Enabled = true;
            }
            else
            {
                adaugaToolStripMenuItem1.Enabled = true;
                editeazaToolStripMenuItem1 .Enabled = false;
                stergeToolStripMenuItem1.Enabled = false;
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisere binare *actiuni | *.actiuni";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK )
            {
                List<Actiune> listLV = new List<Actiune>();
                foreach(ListViewItem item in lvActiuni.Items)
                {
                    listLV.Add(item.Tag as Actiune);
                }

                BinaryFormatter serializer = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listLV);
                fisier.Close();
            }
        }

        private void restaureazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere binare *actiuni | *.actiuni";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK ) 
            { 
                List<Actiune> actiuniDinFisier = new List<Actiune>();
                Stream fisier = File.OpenRead(fd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();

                actiuniDinFisier = (List<Actiune>)serializer.Deserialize(fisier);

                if(lvActiuni.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi actiunile din lista?", "Warning",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvActiuni.Items.Clear();
                    }
                }

                foreach(Actiune act in actiuniDinFisier)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        act.nume, act.companie, act.pretActual.ToString(), act.volumZi.ToString()
                    });
                    lvi.Tag = act;
                    lvActiuni.Items.Add(lvi);
                }
            }
        }

        private void salveazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisere xml actiuni | *.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Actiune> listLV = new List<Actiune>();
                foreach(ListViewItem item in lvActiuni.Items) 
                {
                    listLV.Add(item.Tag as Actiune);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Actiune>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listLV);
                fisier.Close();
            }
        }

        private void restaureazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere xml actiuni | *.xml";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.OpenRead(fd.FileName);
                XmlSerializer serializer = new XmlSerializer (typeof(List<Actiune>));
                List<Actiune> actiuniFisier = (List<Actiune>)serializer.Deserialize(fisier);

                if(lvActiuni.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi inregistrarile existente?", "Warning", 
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvActiuni.Items.Clear();
                    }
                }

                foreach(Actiune act in actiuniFisier)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        act.nume, act.companie, act.pretActual.ToString(), act.volumZi.ToString()
                    });
                    lvi.Tag = act;
                    lvActiuni.Items.Add(lvi);
                }
            }
        }

        private void lvActiuni_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvActiuni.SelectedItems.Count > 0)
            {
                lvActiuni.DoDragDrop(lvActiuni.SelectedItems[0].Tag as Actiune,
                    DragDropEffects.Copy);
            }
        }

        private void lvOrdine_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvOrdine.SelectedItems.Count > 0)
            {
                lvOrdine.DoDragDrop(lvOrdine.SelectedItems[0].Tag as Ordin, DragDropEffects.Copy);
            }
        }

        private void tvOrdineActiuni_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Ordin)) || e.Data.GetDataPresent(typeof(Actiune)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect= DragDropEffects.None;
            }
        }

        private void tvOrdineActiuni_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof (Ordin)) && e.Effect == DragDropEffects.Copy)
            {
                Ordin ordin = e.Data.GetData(typeof (Ordin)) as Ordin;
                TreeNode nodNou = new TreeNode(ordin.id + " - " + ordin.owner);
                nodNou.Tag = ordin;
                tvOrdineActiuni.Nodes.Add(nodNou);
            }
            else if (e.Data.GetDataPresent(typeof(Actiune)) || e.Effect == DragDropEffects.Copy)
            {
                Point punct = new Point(e.X, e.Y);
                Point punctTree = tvOrdineActiuni.PointToClient(punct);
                TreeNode nodTree = tvOrdineActiuni.GetNodeAt(punctTree);

                if(nodTree != null)
                {
                    Actiune act = e.Data.GetData(typeof(Actiune)) as Actiune;
                    TreeNode nod = new TreeNode(act.nume + " - " + act.pretActual);
                    nodTree.Nodes.Add(nod);
                    nodTree.Expand();
                }
            }
        }
    }
}
