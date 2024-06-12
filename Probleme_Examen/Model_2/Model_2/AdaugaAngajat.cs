using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_2
{
    public partial class AdaugaAngajat : Form
    {
        public Angajat cAngajat;
        public AdaugaAngajat(Angajat angajat)
        {
            InitializeComponent();
            if(angajat == null )
            {
                angajat = new Angajat();
                btnAdauga.Text = "Adauga";
            }
            else
            {
                tbNume.Text = angajat.Nume;
                dtpDataNasterii.Value = angajat.DataNasterii;
                btnAdauga.Text = "Editeaza";
            }
            cAngajat = angajat;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Companie c1 = new Companie(21, "Microsoft");
            Companie c2 = new Companie(31, "Google");
            Companie c3 = new Companie(98, "NTT Data");
            List<Companie> companii = new List<Companie>();
            companii.Add(c1);
            companii.Add(c2);
            companii.Add(c3);

            cAngajat.Nume = tbNume.Text;
            cAngajat.DataNasterii = Convert.ToDateTime(dtpDataNasterii.Text);

            if (cbCompanie.SelectedIndex != -1)
            {
                String companie = cbCompanie.SelectedItem.ToString();
                int idCompanie = companii.Find(c => c.Name == companie).Id;
                cAngajat.IDCompanie = idCompanie;
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            String nume = tbNume.Text;
            if(nume.Length < 3)
            {
                errorProviderNume.SetError(tbNume, "Numele trebuie sa aiba mai mult de 2 caractere");
                e.Cancel = true;
            } 
            else
            {
                errorProviderNume.SetError(tbNume, "");
            }
        }

        private void dtpDataNasterii_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dtpDataNasterii.Text);
            int age = DateTime.Now.Year - dt.Year;

            if(age < 20)
            {
                errorProviderDataNasterii.SetError(dtpDataNasterii, "Angajatul nu poate avea mai putin de 20 de ani");
                e.Cancel = true;
            }
            else
            {
                errorProviderDataNasterii.SetError(dtpDataNasterii, "");
            }
        }
    }
}
