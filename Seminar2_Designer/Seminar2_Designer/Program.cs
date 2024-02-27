using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespaces for designer
using System.Windows.Forms;
using System.Drawing;


//Windows forms is single threading !!!
namespace Seminar2_Designer
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initializare nou form
            Form f1 = new Form();

            //setare proprietati
            f1.StartPosition = FormStartPosition.Manual;
            f1.FormBorderStyle = FormBorderStyle.Sizable;
            f1.Text = "Starting Form (C# Generated)! Good Morning!";

            TextBox t1 = new TextBox();
            t1.Text = "TextBox";
            t1.Location = new System.Drawing.Point(50, 90); //from left up corner - the left up corner of the element
            t1.Size = new System.Drawing.Size(150, 30); //counting from left up corner of the element

            Label lb1 = new Label();
            lb1.Text = "Label 1";
            lb1.Location = new Point(30, 60);

            f1.SuspendLayout();     //daca sunt mai multe elemente, nu vrem sa se randeze pe rand
            f1.Controls.Add(t1); // se leaga textboxul t1 de formularul f1
            f1.Controls.Add(lb1);
            f1.ResumeLayout();      //in pachet cu SuspendLayout

            Application.Run(f1);    //randeaza formularul f1
        }
    }
}
