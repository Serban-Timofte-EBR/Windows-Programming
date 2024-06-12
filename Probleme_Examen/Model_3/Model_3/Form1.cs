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

namespace Model_3
{
    public partial class Form1 : Form
    {
        public List<ComandaPizza> comenziForm = new List<ComandaPizza>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComandaPizza comanda = null;
            AdaugareComandaPizza formAdauga = new AdaugareComandaPizza(comanda);
            if(formAdauga.ShowDialog() == DialogResult.OK)
            {
                comanda = formAdauga.cComandaPizza;
                TreeNode nodePrincipal = new TreeNode(comanda.nume + " - " + comanda.blat + 
                    " - " + comanda.durataRealizare);
                nodePrincipal.Tag = comanda;
                comenziForm.Add(comanda);
                foreach(Topping topping in comanda.topping)
                {
                    TreeNode nodeTopp = new TreeNode(topping.denumire + " - " + topping.cantitate + " - " + topping.pret);
                    nodeTopp.Tag = topping;
                    nodePrincipal.Nodes.Add(nodeTopp);
                }

                tvComenziPizza.Nodes.Add(nodePrincipal);
                nodePrincipal.Expand();
            }
        }

        private void citireXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere comenzi txt | *.txt";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(fd.FileName);
                String line = streamReader.ReadLine();
                while(line != null)
                {
                    String[] values = line.Split(',');
                    String denumireComanda = values[0].Trim();
                    String blat = values[1].Trim();
                    int durata = Convert.ToInt32(values[2].Trim());
                    List<Topping> toppings = new List<Topping>(); 
                    ComandaPizza comanda = new ComandaPizza(denumireComanda, blat, durata, toppings);

                    TreeNode node = new TreeNode(denumireComanda
                        + " - " + blat + " - " + durata.ToString());
                    node.Tag = comanda;
                    tvComenziPizza.Nodes.Add (node);

                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
