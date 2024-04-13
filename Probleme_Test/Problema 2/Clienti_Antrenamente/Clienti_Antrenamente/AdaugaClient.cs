using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Clienti_Antrenamente
{
    public partial class AdaugaClient : Form
    {
        public Client cFormClient;
        public AdaugaClient(Client client)
        {
            InitializeComponent();
            if(client == null)
            {
                client = new Client();
                btAdauga.Text = "Adauga";
            }
            else
            {
                tbNume.Text = client.Nume;
                tbPrenume.Text = client.Prenume;
                tbVarsta.Text = client.Varsta.ToString();
                cbAbonament.Text = client.Abonament;
                btAdauga.Text = "Editeaza";
            }
            cFormClient = client;
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            cFormClient.Nume = tbNume.Text;
            cFormClient.Prenume = tbPrenume.Text;
            cFormClient.Varsta = Convert.ToInt32(tbVarsta.Text);
            cFormClient.Abonament = cbAbonament.Text;
        }

        private void AdaugaClient_Validating(object sender, CancelEventArgs e)
        {
          
            if (cbAbonament.TabIndex != 0 && cbAbonament.TabIndex != 1) 
            {
                errorProviderAbonament.SetError(cbAbonament, "Selecteaza statusul abonamentului");
                e.Cancel = true;
            }
            else
            {
                errorProviderVarsta.SetError(tbVarsta, "");
                errorProviderAbonament.SetError(cbAbonament, "");
                e.Cancel = false;
            }
        }

        private void tbVarsta_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbVarsta.Text, out int varsta) || varsta < 18)
            {
                errorProviderVarsta.SetError(tbVarsta, "Nu sunt acceptati clienti sub 18 ani");
                e.Cancel = true;
            }
            else
            {
                errorProviderVarsta.SetError(tbVarsta, "");
                errorProviderAbonament.SetError(cbAbonament, "");
                e.Cancel = false;
            }
        }
    }
}
