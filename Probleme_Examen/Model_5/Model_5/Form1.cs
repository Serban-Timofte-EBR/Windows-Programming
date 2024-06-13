using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_5
{
    public partial class Form1 : Form
    {
        public static CardTransport[] carduri = new CardTransport[20];
        private Calatorie[] calatoriiVect = new Calatorie[20];
        public static int indexCarduri = 0;
        int indexCalatorii = 0;

        public Form1()
        {
            InitializeComponent();
            List<CardTransport> cardTransports = citireCardTranspoturiTXT();
            foreach (CardTransport cardTransport in cardTransports)
            {
                TreeNode node = new TreeNode("Card: " + cardTransport.CodCard.ToString() + 
                    " - " + cardTransport.NumeUtilizator + " - " + 
                    cardTransport.Sold.ToString());
                node.Tag = cardTransport;
                tvCalatorii.Nodes.Add(node);
                carduri[indexCarduri] = cardTransport;
                indexCarduri++;
            }

            List<Calatorie> calatorii = citireCalatoriiTXT();
            foreach(Calatorie calatorie in calatorii)
            {
                foreach(TreeNode node in tvCalatorii.Nodes)
                {
                    var cardNode = node.Tag as CardTransport;
                    if(cardNode.CodCard == calatorie.CodCard)
                    {
                        TreeNode nodeCopil = new TreeNode(calatorie.CodCard.ToString() +
                            " - " + calatorie.Valoare + " - " + calatorie.NumarAutobuz);
                        nodeCopil.Tag = calatorie;
                        node.Nodes.Add(nodeCopil);
                        node.Expand();
                        calatoriiVect[indexCalatorii] = calatorie;
                        indexCalatorii++;
                    }
                }
            }

            float soldTotal = carduri[0] + 1;
            tbSoldTotal.Text = soldTotal.ToString();
        }

        private List<CardTransport> citireCardTranspoturiTXT()
        {
            List<CardTransport> lista = new List<CardTransport>();
            using (StreamReader reader = new StreamReader("C:\\Users\\serba\\Desktop\\Windows-Programming\\Probleme_Examen\\Model_5\\cardTransporturi.txt.txt"))
            {
                String line = reader.ReadLine();
                while (line != null)
                {
                    try
                    {
                        String[] values = line.Split(',');
                        int codCard = Convert.ToInt32(values[0].Trim());
                        String numeUtilizator = values[1].Trim();
                        float sold = (float)Convert.ToDouble(values[2].Trim());

                        CardTransport card = new CardTransport(codCard, numeUtilizator, sold);
                        lista.Add(card);

                        line = reader.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A aparuta o eroare:\n {ex}", "Eroare", MessageBoxButtons.OK);
                    }
                }
                return lista;
            }
        }
    
        private List<Calatorie> citireCalatoriiTXT()
        {
            List<Calatorie> lista = new List<Calatorie>();

            using(StreamReader reader = new StreamReader("C:\\Users\\serba\\Desktop\\Windows-Programming\\Probleme_Examen\\Model_5\\calatorii.txt.txt"))
            {
                try
                {
                    String line = reader.ReadLine();
                    while(line != null)
                    {
                        String[] values = line.Split(',');
                        int cod = Convert.ToInt32(values[0].Trim());
                        float valoare = (float)Convert.ToDouble(values[1].Trim());
                        int nrAutobuz = Convert.ToInt32(values[2].Trim());

                        Calatorie calatorie = new Calatorie(cod, valoare, nrAutobuz);
                        lista.Add(calatorie);

                        line = reader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A aparut o eroare la citirea unei calatorii: {ex}", 
                        "Eroare", MessageBoxButtons.OK );
                }
            }

            return lista;
        }

        private void tvCalatorii_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(tvCalatorii.SelectedNode != null)
            {
                CardTransport card = tvCalatorii.SelectedNode.Tag as CardTransport;
                if(card != null)
                {
                    String info = card.CodCard + Environment.NewLine +
                        card.NumeUtilizator + Environment.NewLine +
                        card.Sold + Environment.NewLine;

                    tbMultiCalatorie.Text = info;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tvCalatorii.SelectedNode != null)
            {
                CardTransport card = tvCalatorii.SelectedNode.Tag as CardTransport;
                if(card != null)
                {
                    String text = tbMultiCalatorie.Text;
                    String[] values = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    
                    int cod = Convert.ToInt32(values[0].Trim());
                    String numeUtilizator = values[1].Trim();
                    float sold = (float)Convert.ToDouble(values[2].Trim());

                    tvCalatorii.SelectedNode.Text = "Card: " + cod + " - " + numeUtilizator
                        + " - " + sold;
                }
            }
        }

        private void tvCalatorii_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TreeNode nodeSelectat = tvCalatorii.SelectedNode;
                float valoarea = 0;
                foreach (TreeNode node in nodeSelectat.Nodes)
                {
                    var calatorie = node.Tag as Calatorie;
                    valoarea += calatorie.Valoare;
                }

                tbValoare.Text = valoarea.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A aparut o eroare la calcularea valorii calatoriilor unui card: {ex}",
                    "Eroare", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSalveaza_Click(object sender, EventArgs e)
        {
            using(var conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\serba\\Desktop\\Windows-Programming\\Probleme_Examen\\Model_5\\bazaDeDate.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();

                foreach(TreeNode node in tvCalatorii.Nodes)
                {
                    CardTransport card = node.Tag as CardTransport;

                    String insertCard = "INSERT INTO Carduri (numeUtilizator, sold, codCard) VALUES(" +
                        "'" + card.NumeUtilizator + "', " +
                        card.Sold + ", " + card.CodCard + ")";

                    using (var cmd = new SqlCommand(insertCard, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    foreach (TreeNode childNode in tvCalatorii.Nodes)
                    {
                        Calatorie calatorie  = childNode.Tag as Calatorie;
                        if (calatorie != null)
                        {
                            String inserCalatorie = "INSERT INTO Calatorii (codCardCalatorie, valoare, numarAutobuz) VALUES(" +
                                calatorie.CodCard + ", " + calatorie.Valoare
                                + ", " + calatorie.NumarAutobuz + ")";

                            using (var cmd2 = new SqlCommand(inserCalatorie, conn))
                            {
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Cardurile si calatoriile au fost salvate in baza de date!",
                    "Success", MessageBoxButtons.OK);
            }
        }
    }
}
