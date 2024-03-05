using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Seminar3
{
    internal class Program
    {
        [STAThread] //clasa care anunta ca procesul este single thread
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Definire formular si elemente
            Form formular = new Form(); 
            formular.SuspendLayout();
            formular.StartPosition = FormStartPosition.Manual;  //se refera fata de fereastra
            formular.FormBorderStyle = FormBorderStyle.Sizable;
            formular.Text = "Windows Forms";    //pana aici nu se vede formularul

            formular.SetBounds(10, 10, 500, 500);   //seteaza marginile fata de  locatie
        
            Label lb1 = new Label();
            lb1.Text = "label1";
            lb1.Location = new Point(50, 50);   //se refera fata de stanga sus a formularului
            lb1.Size = new Size(100, 50);   //pana aici nu se vede formularul si nici elementele

            TextBox tb1 = new TextBox();
            tb1.Location = new Point(150, 150);
            tb1.Size = new Size(100, 100);

            Button btn1 = new Button()
            {
                Size = new Size(70, 40),
                Location = new Point(50, 150),
                Text = "Afiseaza"
            };

            btn1.Click += (obj, s) =>
            {
                DialogResult raspuns = MessageBox.Show("Text Afisat", "Fereastra Mesaj",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                if (raspuns == DialogResult.Cancel)
                {
                    MessageBox.Show("Raspunsul este super gresit!");
                }
            };

            //Adaugare elemente in formular
            formular.Controls.Add(btn1);
            formular.Controls.Add(lb1);
            formular.Controls.Add(tb1);
            formular.ResumeLayout();

            //Pornire efectiv formularul ca formular principal
            Application.Run(formular);
        }
    }
}
