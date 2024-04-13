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

namespace Carti_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Carte c1 = new Carte("Amintiri din Copilarie", "Ion Creanga", 2000);
            Carte c2 = new Carte("Praslea cel voinic", "Petre Ispirescu", 2010);
            Carte c3 = new Carte("Enigma Otiliei", "George Calinescu", 1975);

            ListViewItem lvC1 = new ListViewItem(new String[]
            {
                c1.Titlu, c1.Autor, c1.AnPublicare.ToString(),
            });
            lvC1.Tag = c1;
            lvCarti.Items.Add(lvC1);

            ListViewItem lvC2 = new ListViewItem(new String[]
            {
                c2.Titlu, c2.Autor, c2.AnPublicare.ToString(),
            });
            lvC2.Tag = c2;
            lvCarti.Items.Add(lvC2);

            ListViewItem lvC3 = new ListViewItem(new String[]
            {
                c3.Titlu, c3.Autor, c3.AnPublicare.ToString(),
            });
            lvC3.Tag = c3;
            lvCarti.Items.Add(lvC3);

            TreeNode tc1 = new TreeNode(c1.Titlu + " - " + c1.AnPublicare);
            treeView1.Nodes.Add(tc1);

            TreeNode tc2 = new TreeNode(c2.Titlu + " - " + c2.AnPublicare);
            treeView1.Nodes.Add(tc2);
        }

        private void adaugaCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carte c = null;
            AdaugaCarte formCarte = new AdaugaCarte(c);
            if(formCarte.ShowDialog() == DialogResult.OK)
            {
                c = formCarte.cFormCarte;
                ListViewItem carteNoua = new ListViewItem(new string[]
                {
                    c.Titlu, c.Autor, c.AnPublicare.ToString(),
                });
                carteNoua.Tag = c;
                lvCarti.Items.Add(carteNoua);
            }
        }

        private void editeazaCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvCarti.Items.Count > 0)
            {
                Carte c = lvCarti.SelectedItems[0].Tag as Carte;
                AdaugaCarte formCarte = new AdaugaCarte(c);
                if (formCarte.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem carte = lvCarti.SelectedItems[0] as ListViewItem;
                    carte.SubItems[0].Text = c.Titlu;
                    carte.SubItems[1].Text = c.Autor;
                    carte.SubItems[2].Text = c.AnPublicare.ToString();
                }
            }
        }

        private void stergeCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvCarti.Items.Count > 0)
            {
                if(MessageBox.Show("Esti sigur ca vrei sa stergi inregistrare?", "Warning", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    lvCarti.SelectedItems[0].Remove();
                }
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugaCarteToolStripMenuItem_Click(sender, e);
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editeazaCarteToolStripMenuItem_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stergeCarteToolStripMenuItem_Click(sender, e);
        }

        private void contextMenuStripCarti_Opening(object sender, CancelEventArgs e)
        {
            if (lvCarti.SelectedItems.Count > 0)
            {
                adaugaCarteToolStripMenuItem.Enabled = true;
                editeazaToolStripMenuItem.Enabled = true;
                stergeCarteToolStripMenuItem.Enabled = true;
            }
            else
            {
                adaugaCarteToolStripMenuItem.Enabled = true;
                editeazaToolStripMenuItem.Enabled = false;
                stergeToolStripMenuItem.Enabled = false;
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisier carti bin | *.stud";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Carte> listaBiblioteca = new List<Carte>();
                foreach(ListViewItem item in lvCarti.Items)
                {
                    listaBiblioteca.Add(item.Tag as Carte);
                }
                BinaryFormatter serializer = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listaBiblioteca);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "fisiere carti binare | *.stud";
            ofd.CheckFileExists = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                List<Carte> listaCartiFisier = new List<Carte>();

                BinaryFormatter serializer = new BinaryFormatter();
                Stream fisier = File.OpenRead(ofd.FileName);
                listaCartiFisier = (List<Carte>)serializer.Deserialize(fisier);

                if(lvCarti.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi cartile din lista?", "Warning", MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        lvCarti.Items.Clear();
                    }
                }
                
                foreach(Carte c in listaCartiFisier)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        c.Titlu, c.Autor, c.AnPublicare.ToString()
                    });
                    lvi.Tag = c;
                    lvCarti.Items.Add(lvi);
                }
            }
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisier carti xml | *.xml";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK) { 
                List<Carte> listaBibilioteca = new List<Carte>();
                foreach(ListViewItem item in lvCarti.Items)
                {
                    listaBibilioteca.Add(item.Tag as Carte);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Carte>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, listaBibilioteca);
                fisier.Close();
            }
        }

        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "fisiere carti xml | *.xml";
            ofd.CheckFileExists = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer (typeof(List<Carte>));
                Stream fisier = File.OpenRead(ofd.FileName);
                List<Carte> listCartiFisier = new List<Carte>();
                listCartiFisier = (List<Carte>)serializer.Deserialize(fisier);

                if(lvCarti.Items.Count > 0)
                {
                    if(MessageBox.Show("Vrei sa stergi inregistrarile existente?", "Warning", 
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvCarti.Items.Clear();
                    }
                }

                foreach(Carte carte in listCartiFisier)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                        carte.Titlu, carte.Autor, carte.AnPublicare.ToString()
                    });
                    lvi.Tag = carte;
                    lvCarti.Items.Add(lvi);
                }
            }
        }

        private void lvCarti_Click(object sender, EventArgs e)
        {
            if (lvCarti.SelectedItems.Count > 0)
            {
                Carte c = lvCarti.SelectedItems[0].Tag as Carte;
                Clipboard.SetText(c.Titlu + " - " + c.AnPublicare);
            }
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'v' || e.KeyChar == 'V')
            {
                String copiedText = Clipboard.GetText();
                TreeNode nodNou = new TreeNode(copiedText);
                treeView1.Nodes.Add(nodNou);
            }
        }

        private void lvCarti_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvCarti.SelectedItems.Count > 0)
            {
                lvCarti.DoDragDrop(lvCarti.SelectedItems[0].Tag, DragDropEffects.Copy);
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Carte))){
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Effect == DragDropEffects.Copy &&
                e.Data.GetDataPresent(typeof(Carte))) 
            {
                Carte c = (Carte)e.Data.GetData(typeof(Carte));
                TreeNode tNou = new TreeNode(c.Titlu + " - " + c.AnPublicare);
                treeView1.Nodes.Add (tNou);
            }
        }
    }
}
