using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_4
{
    public partial class Form1 : Form
    {
        public Medic[] vectMedic = new Medic[50];
        public Pacient[] vectPacienti = new Pacient[50];
        private int indexVectMedic = 0;
        private int indexVectPacienti = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDeDateDataSet.Pacineti' table. You can move, or remove it, as needed.
            this.pacinetiTableAdapter.Fill(this.bazaDeDateDataSet.Pacineti);

        }

        private void btnAdaugaMedic_Click(object sender, EventArgs e)
        {
            try
            {
                int codMedic = Convert.ToInt32(tbCodMedic.Text);
                String nume = tbNume.Text;
                String specializare = cbSpecializare.SelectedItem.ToString();

                Medic medic = new Medic(codMedic, nume, specializare);
                TreeNode node = new TreeNode(codMedic.ToString() +
                    " - " + nume + " - " + specializare);
                node.Tag = medic;
                tvMedicPacienti.Nodes.Add(node);
                vectMedic[indexVectMedic] = medic;
                indexVectMedic++;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"A aparut o eroare {ex}", "Eroare",
                    MessageBoxButtons.OK);
            }
        }

        private void btnAdaugaPacient_Click(object sender, EventArgs e)
        {
            try
            {
                int codPacient = Convert.ToInt32(tbCodPacient.Text);
                String nume = tbNumePacient.Text;
                int codMedic = Convert.ToInt32(cbCodMedic.Text);
                double tarif = Convert.ToDouble(tbTarif.Text);

                Pacient pacient = new Pacient(codPacient, nume, codMedic, (float)tarif);
                TreeNode nodePacient = new TreeNode(codPacient.ToString() + " - " +
                    nume + " - " + tarif.ToString());
                nodePacient.Tag = pacient;

                foreach(TreeNode node in tvMedicPacienti.Nodes)
                {
                    Medic medic = node.Tag as Medic;
                    if(medic.codM == codMedic)
                    {
                        node.Nodes.Add(nodePacient);
                        node.Expand();
                    }
                }

                vectPacienti[indexVectPacienti] = pacient;
                indexVectPacienti++;
            } 
            catch
            {

            }
        }

        private void cbCodMedic_Click(object sender, EventArgs e)
        {
            cbCodMedic.Items.Clear();
            foreach (TreeNode node in tvMedicPacienti.Nodes)
            {
                Medic medicNode = node.Tag as Medic;
                cbCodMedic.Items.Add(medicNode.codM.ToString());
            }
        }

        private void tvMedicPacienti_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvMedicPacienti.SelectedNode == null)
                {
                    MessageBox.Show("Te rog selectează un medic.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Medic medicSelectat = tvMedicPacienti.SelectedNode.Tag as Medic;
                float suma = 0;

                // Iterează prin subnodurile nodului selectat pentru a calcula suma tarifelor consultațiilor
                foreach (TreeNode nodePacient in tvMedicPacienti.SelectedNode.Nodes)
                {
                    Pacient pac = nodePacient.Tag as Pacient;
                    if (pac != null)
                    {
                        suma += pac.tarif_consultatie;
                    }
                }

                tbSumaMedic.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\serba\\Desktop\\Windows-Programming\\Probleme_Examen\\Model_4\\bazaDeDate.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                for (int i = 0; i<indexVectPacienti; i++)
                {
                    string insertQuery = "INSERT INTO Pacineti (Nume, CodM, Tarif) VALUES (" +
                        "'" + vectPacienti[i].nume + "', " +
                        vectPacienti[i].codM + ", " +
                        vectPacienti[i].tarif_consultatie + ")";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Pacientii au fost salvati cu succes", 
                            "Message", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            PacientiRepo repo = new PacientiRepo();
            List<Pacient> pacients = repo.pacientiRepo;

            foreach(Pacient pacient in pacients)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    pacient.Nume, pacient.codM.ToString(), pacient.tarif_consultatie.ToString(),
                });
                lvi.Tag = pacient;
                lvPacienti.Items.Add(lvi);
            }
        }

        private void lvPacienti_MouseDown(object sender, MouseEventArgs e)
        {
            PacientiRepo repo = new PacientiRepo();
            List<Pacient> pacients = repo.pacientiRepo;
            pacients.Sort((p1, p2) => p2.tarif_consultatie.CompareTo(p1.tarif_consultatie));
            foreach (Pacient pacient in pacients)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    pacient.Nume, pacient.codM.ToString(), pacient.tarif_consultatie.ToString(),
                });
                lvi.Tag = pacient;
                lvPacienti.Items.Add(lvi);
            }

        }
    }
}
