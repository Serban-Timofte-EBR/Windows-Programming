using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actiuni_Portofoliu
{
    public partial class AdaugaActiune : Form
    {
        public Actiune cFormActiune;
        public AdaugaActiune(Actiune actiune)
        {
            InitializeComponent();
            if(actiune == null)
            {
                actiune = new Actiune();
                btSubmit.Text = "Adauga";
            }
            else
            { 
                tbNume.Text = actiune.nume;
                tbCompanie.Text = actiune.companie;
                tbPret.Text = actiune.pretActual.ToString();
                cbVolum.Text = actiune.volumZi.ToString();
                btSubmit.Text = "Editeaza";
            }
            cFormActiune = actiune;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            cFormActiune.nume = tbNume.Text;
            cFormActiune.companie = tbCompanie.Text;
            cFormActiune.pretActual = Convert.ToDouble(tbPret.Text);
            cFormActiune.volumZi = Convert.ToInt32(cbVolum.Text);
        }
    }
}
