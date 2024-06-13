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

namespace Model_6
{
    public partial class Form1 : Form
    {
        public static List<Bicicleta> lstBiciclete;
        public static List<Utilizator> lstUtilizatori;
        public Form1()
        {
            InitializeComponent();
            lstBiciclete = citireBicicleteTXT();
            lstUtilizatori = citireUtilizatoriTXT();

            foreach(Bicicleta bicicleta in lstBiciclete)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    bicicleta.CodB.ToString(), bicicleta.DenumireStatieParcare,
                    bicicleta.KmParcursi.ToString()
                });
                item.Tag = bicicleta;
                lvBiciclete.Items.Add(item);
            }

            foreach(Utilizator utilizator in lstUtilizatori)
            {
                lbUtilizatori.Items.Add(utilizator);
            }
        }

        private List<Bicicleta> citireBicicleteTXT()
        {
            List<Bicicleta> lista = new List<Bicicleta> ();

            using(StreamReader reader = new StreamReader("C:\\Users\\serba\\Desktop\\Windows-Programming\\Probleme_Examen\\Model_6\\biciclete.txt"))
            {
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] values = line.Split(',');
                    
                    int codB = Convert.ToInt32(values[0].Trim());
                    String statie = values[1].Trim();
                    int distanta = Convert.ToInt32(values[2].Trim());

                    Bicicleta bicicleta = new Bicicleta (codB, statie, distanta);
                    lista.Add (bicicleta);

                    line = reader.ReadLine();
                }
            }

            return lista;
        }

        private List<Utilizator> citireUtilizatoriTXT()
        {
            List<Utilizator> lista = new List<Utilizator> ();

            using (StreamReader reader = new StreamReader("C:\\Users\\serba\\Desktop\\Windows-Programming\\Probleme_Examen\\Model_6\\utilizatori.txt"))
            {
                String line = reader.ReadLine();
                while(line != null)
                {
                    String[] values = line.Split(',');

                    int codU = Convert.ToInt32(values[0].Trim());
                    String nume = values[1].Trim();
                    int codB = Convert.ToInt32(values[2].Trim());
                    int distanta = Convert.ToInt32(values[3].Trim());

                    Utilizator utilizator = new Utilizator(codU, nume, codB, distanta);
                    lista.Add (utilizator);

                    line = reader.ReadLine();
                }
            }

            return lista;
        }

        private void lbUtilizatori_DoubleClick(object sender, EventArgs e)
        {
            Utilizator utilizator = lbUtilizatori.SelectedItem as Utilizator;
            AdaugareUtilizator formAdauga = new AdaugareUtilizator(utilizator);

            if(formAdauga.ShowDialog() == DialogResult.OK)
            {
                utilizator = formAdauga.cUtilizator;

                int index = lbUtilizatori.SelectedIndex;
                lbUtilizatori.Items[index] = utilizator;
            }
            else
            {
                return;
            }
        }

        private void calculeazaVenitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bicicleta bicicleta = lvBiciclete.SelectedItems[0].Tag as Bicicleta;
            int venit = 0;

            foreach(Utilizator utilizator in lbUtilizatori.Items)
            {
                if (utilizator.CodB == bicicleta.CodB)
                {
                    if (utilizator.DurataUtilizare <= 30)
                    {
                        venit += 0;
                    } 
                    else
                    {
                        int durataFacturabila = utilizator.DurataUtilizare - 30;
                        venit += durataFacturabila / 10 * 2;
                    }
                }
            }

            tbVenit.Text = venit.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grafic formGrafic = new Grafic();
            formGrafic.ShowDialog();
        }
    }
}
