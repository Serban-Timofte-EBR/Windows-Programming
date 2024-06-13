using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    public class Medic
    { 
        public readonly int codM;
        public String nume;
        public String specializare;

        public Medic()
        {
        }

        public int CodM
        {
            get { return codM; }
        }

        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public String Specializare
        {
            get { return specializare; }
            set { specializare = value; }
        }

        public Medic(int codM, string nume, string specializare)
        {
            this.codM = codM;
            this.nume = nume;
            this.specializare = specializare;
        }

        public override string ToString()
        {
            return codM + " - " + nume + " - " + specializare;
        }
    }
}
