using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class AdaugaMedic : Form
    {
        public Medic mFormMedic;
        public AdaugaMedic(Medic m)
        {
            InitializeComponent();
            if(m == null)
            {
                m = new Medic();
                btnAdauga.Text = "Adauga";
            }
            else
            {
                btnAdauga.Text = "Editeaza";
                mFormMedic = m;
                tbCnp.Text = m.Cnp;
                tbNume.Text = m.Nume;
                tbAnAbs.Text = m.AnAbsolvire.ToString();
                cbSpecializare.Text = m.Specializare;
                dateDataNasterii.Value = m.DataNastere;
            }
            mFormMedic = m;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            mFormMedic.Cnp = tbCnp.Text;
            mFormMedic.Nume = tbNume.Text;
            mFormMedic.Specializare = cbSpecializare.SelectedItem.ToString();
            mFormMedic.AnAbsolvire = Convert.ToInt32(tbAnAbs.Text);
            mFormMedic.DataNastere = dateDataNasterii.Value;
        }
    }
}
