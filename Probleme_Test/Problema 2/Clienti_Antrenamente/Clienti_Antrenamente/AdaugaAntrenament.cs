using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clienti_Antrenamente
{
    public partial class AdaugaAntrenament : Form
    {
        public Antrenamnet cFormAntrenament;
        public AdaugaAntrenament(Antrenamnet antrenamnet)
        {
            InitializeComponent();
            if( antrenamnet == null ) 
            {
                antrenamnet = new Antrenamnet();
                btSubmit.Text = "Adauga";
            }
            else
            {
                tbZi.Text = antrenamnet.zi;
                tbOra.Text = antrenamnet.ora.ToString();
                cbAntrenor.Text = antrenamnet.antrenor;
                cbSala.Text = antrenamnet.sala;
                btSubmit.Text = "Editeaza";
            }
            cFormAntrenament = antrenamnet;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            cFormAntrenament.zi = tbZi.Text;
            cFormAntrenament.ora = Convert.ToInt32(tbOra.Text);
            cFormAntrenament.sala = cbSala.Text;
            cFormAntrenament.antrenor = cbAntrenor.Text;
        }
    }
}
