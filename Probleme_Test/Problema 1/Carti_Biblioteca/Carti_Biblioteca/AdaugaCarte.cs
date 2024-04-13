using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carti_Biblioteca
{
    public partial class AdaugaCarte : Form
    {
        public Carte cFormCarte;
        public AdaugaCarte(Carte carte)
        {
            InitializeComponent();
            if(carte == null)
            {
                carte = new Carte();
                btAdauga.Text = "Adauga";
            }
            else {
                tbTitlu.Text = carte.Titlu;
                tbAutor.Text = carte.Autor;
                tbAn.Text = carte.AnPublicare.ToString();
                btAdauga.Text = "Editeaza";
            }
            cFormCarte = carte;
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            cFormCarte.Titlu = tbTitlu.Text;
            cFormCarte.Autor = tbAutor.Text;
            cFormCarte.AnPublicare = Convert.ToInt32(tbAn.Text);
        }

        private void tbAn_Validating(object sender, CancelEventArgs e)
        {
            if (tbAn.Text.Length == 2)       // 24
            {
                int an = 2000 + Convert.ToInt32(tbAn.Text);
                if(an > 2024)
                {
                    errorProviderAn.SetError(tbAn, "Anul nu poate fi mai mare de 2024");
                    e.Cancel = true;
                }
            }
            else if (tbAn.Text.Length == 4)  //2024
            {
                if(Convert.ToInt32(tbAn.Text) > 2024)
                {
                    errorProviderAn.SetError(tbAn, "Anul nu poate fi mai mare de 2024");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProviderAn.SetError(tbAn, "");
            }
        }
    }
}
