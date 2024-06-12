using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_3
{
    public class Topping
    {
        public String denumire;
        public double pret;
        public int cantitate;
        public readonly int cod;

        public Topping() { }
        public Topping(int cod, String denumire, double pret, int cantitate)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public override string ToString()
        {
            return cod + " " + denumire + " " + pret + " " + cantitate;
        }
    }
}
