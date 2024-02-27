using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Pinguin : Animal
    {
        private bool areIglu;
        public bool AreIglu
        {
            get { return areIglu; }
            set
            {
                if(areIglu != value)
                {
                    areIglu = value;
                }
            } 
        }

        public Pinguin(bool a, int v, string n, float g) : base(v, n, g) {
            areIglu=a;
        }

        public override string ToString()
        {
            return base.ToString() + " si are iglo: " + this.areIglu;
        }
    }
}
