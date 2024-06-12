using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_3
{
    public class ComandaPizza : ICustomizabil, ICloneable
    {
        public String nume;
        public String blat;
        public int durataRealizare;
        public List<Topping> topping;

        public static readonly double COST_DE_BAZA = 10.0;

        public String Nume {  get { return nume; } }
        public int DuraRealizare { get {  return durataRealizare; } }

        public Topping this[int index]
        {
            get { return topping[index]; }
        }

        public ComandaPizza(String nume, String blat, int durataRealizare, List<Topping> toppings)
        {
            this.nume = nume;
            this.blat = blat;
            this.durataRealizare = durataRealizare;
            foreach(Topping topp in toppings) { this.topping.Add(topp); }
        }

        public double CalculPizza()
        {
            return COST_DE_BAZA + topping.Sum(t => t.pret * t.cantitate);
        }

        public object Clone()
        {
            return new ComandaPizza(this.nume, this.blat, this.durataRealizare, this.topping);
        }

        public static Boolean operator <(ComandaPizza a, ComandaPizza b)
        {
            return a.CalculPizza() < b.CalculPizza();
        }

        public static Boolean operator >(ComandaPizza a, ComandaPizza b)
        {
            return a.CalculPizza() > b.CalculPizza();
        }
    }
}
