using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_3
{
    public partial class AdaugareComandaPizza : Form
    {
        public ComandaPizza cComandaPizza;
        public AdaugareComandaPizza(ComandaPizza comanda)
        {
            InitializeComponent();
            if(comanda == null )
            {
                List<Topping> toppings = new List<Topping>();
                comanda = new ComandaPizza("N|A", "N|A", 0, toppings);
                btnOk.Text = "Adauga";
            }
            cComandaPizza = comanda;
        }

        private void AdaugareComandaPizza_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Topping t1 = new Topping(21, "Masline", 5.76, 10);
            Topping t2 = new Topping(45, "Ciuperci", 8.56, 15);
            Topping t3 = new Topping(89, "Porumb", 10.21, 20);
            Topping t4 = new Topping(56, "Pepperoni", 14.21, 34);
            Topping t5 = new Topping(20, "Gorgonzola", 10.21, 21);
            List<Topping> toppingsAccesibile = new List<Topping>();
            toppingsAccesibile.Add(t1);
            toppingsAccesibile.Add(t2);
            toppingsAccesibile.Add(t3);
            toppingsAccesibile.Add(t4);
            toppingsAccesibile.Add(t5);

            cComandaPizza.nume = tbNume.Text;
            cComandaPizza.blat = cbBlat.SelectedText;
            cComandaPizza.durataRealizare = Convert.ToInt32(tbDurataRealizare.Text);
            
            List<Topping> toppinguriComanda = new List<Topping>();
            foreach(String topp in checkListToppinguri.CheckedItems)
            {
                Topping topping = toppingsAccesibile.Find(t => t.denumire.Equals(topp));
                toppinguriComanda.Add(topping);
            }

            cComandaPizza.topping = toppinguriComanda;
        }
    }
}
