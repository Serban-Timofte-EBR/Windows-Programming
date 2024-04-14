using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clienti_Antrenamente
{
    [Serializable]
    public class Antrenamnet
    {
        public String zi;
        public int ora;
        public String sala;
        public String antrenor;

        public Antrenamnet()
        {
            zi = string.Empty;
            ora = 0;
            sala = string.Empty;
            antrenor = string.Empty;
        }
        
        public Antrenamnet(String zi, int ora, String sala, String antrenor)
        {
            this.zi = zi;
            this.ora = ora;
            this.sala = sala;
            this.antrenor = antrenor;
        }
    }
}
