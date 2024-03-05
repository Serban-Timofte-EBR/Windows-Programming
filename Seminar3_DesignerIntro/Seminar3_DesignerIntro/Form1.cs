using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar3_DesignerIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rezultat;

            rezultat = MessageBox.Show("Test afisat", "Fereastra mesaj",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            
            if(rezultat == DialogResult.No)
            {
                MessageBox.Show("Ai apasat", "Titlul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
