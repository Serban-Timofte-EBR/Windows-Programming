using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Urs : Animal
    {
        private bool hiberneaza;

        public bool Hiberneaza
        {
            get { return this.hiberneaza; }
            set { if(this.hiberneaza != value) this.hiberneaza = value; }
        }

        public Urs(bool h, int v, string n, float g) : base(v, n, g)
        {
            this.hiberneaza = h;
        }

        public override string ToString()
        {
            return base.ToString() + " si " + (hiberneaza? "hiberneaza" : "nu hiberneaza!");
        }
    }
}
