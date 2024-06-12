using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_1
{
    public partial class AdaugareTranzactie : Form
    {
        public Tranzactie cTranzatie;
        public AdaugareTranzactie(Tranzactie tranzactie)
        {
            InitializeComponent();
            if(tranzactie == null)
            {
                tranzactie = new Tranzactie(999, "N|A", "N|A", 0, "N|A");
                btAdauga.Text = "Adauga";
            } 
            else
            {
                tbID.Text = tranzactie.idTranzactie.ToString();
                tbDetalii.Text = tranzactie.detaliiTranzactie;
                tbIBAN.Text = tranzactie.contIban;
                tbSuma.Text = tranzactie.suma.ToString();
                btAdauga.Text = "Editeaza";
            }
            cTranzatie = tranzactie;
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            cTranzatie.detaliiTranzactie = tbDetalii.Text;
            cTranzatie.contIban = tbIBAN.Text; 
            cTranzatie.suma = Double.Parse(tbSuma.Text);
        }
    }
}
