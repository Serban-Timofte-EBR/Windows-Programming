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
    public partial class Grafic : Form
    {
        public Grafic()
        {
            InitializeComponent();

            panelGrafic = new Panel
            {
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(panelGrafic);

            
        }
    }
}
