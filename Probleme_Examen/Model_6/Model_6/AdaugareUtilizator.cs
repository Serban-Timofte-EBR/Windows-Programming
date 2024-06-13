using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_6
{
    public partial class AdaugareUtilizator : Form
    {
        public Utilizator cUtilizator;
        public AdaugareUtilizator(Utilizator utilizator)
        {
            InitializeComponent();

            if(utilizator != null)
            {
                tbCodUtilizator.Text = utilizator.CodU.ToString();
                tbNumeUtilizator.Text = utilizator.Nume;
                List<Bicicleta> list = Form1.lstBiciclete;
                foreach(Bicicleta b in list )
                {
                    cbCodBicicleta.Items.Add(b.CodB);
                }
                cbCodBicicleta.Text = utilizator.CodB.ToString();
                tbDistanta.Text = utilizator.DurataUtilizare.ToString();
                btnOK.Text = "Editeaza";
            }
            cUtilizator = utilizator;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cUtilizator.Nume = tbNumeUtilizator.Text;
            cUtilizator.CodB = Convert.ToInt32(cbCodBicicleta.SelectedItem);
            cUtilizator.DurataUtilizare = Convert.ToInt32(tbDistanta.Text);
        }

        private void tbDistanta_Validating(object sender, CancelEventArgs e)
        {
            int durata = Convert.ToInt32(tbDistanta.Text);
            if(durata < 0) 
            {
                errorProviderDurata.SetError(tbDistanta, "Durata nu poate fi negativa!");
                e.Cancel = true;
            }
            else if(durata > 1000)
            {
                errorProviderDurata.SetError(tbDistanta, "Durata nu poate fi mai mare de 1000");
                e.Cancel= true;
            }
            else
            {
                errorProviderDurata.SetError(tbDistanta, "");
            }
        }
    }
}
