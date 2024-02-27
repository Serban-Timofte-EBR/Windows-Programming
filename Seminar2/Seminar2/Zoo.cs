using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Zoo : ICloneable
    {
        private String denumire;
        private String adresa;
        private List<Animal> lista = new List<Animal>();

        public string Denumire { 
            get { return denumire; }
            set { 
                if(value.Length > 3){
                    this.denumire = value;
              }
            } 
        }

        public string Adresa
        {
            get { return adresa; }
            set
            {
                if (value.Length > 3)
                {
                    this.adresa = value;
                }
            }
        }

        public List<Animal> Lista { 
            get { return lista; }
            set { lista = value; }   //shallow copy
        }


        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public Zoo Clone()  //deep copy
        {
            Zoo nou = (Zoo)((ICloneable)this).Clone();

            List<Animal> copy = new List<Animal>();
            foreach(Animal a in this.lista) 
                copy.Add(a.Clone());                //fac copie pentru fiecare animal

            nou.lista = copy;

            return nou;
        }

    }
}
