using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actiuni_Portofoliu
{
    [Serializable]
    public class Actiune
    {
        public String nume;
        public String companie;
        public double pretActual;
        public int volumZi;

        public Actiune() {
            nume = String.Empty;
            companie = String.Empty;
            pretActual = 0;
            volumZi = 0;
        }

        public Actiune(String _nume, String _companie, double _pretActual, int _volumZi)
        {
            nume= _nume;
            companie= _companie;
            pretActual= _pretActual;
            volumZi= _volumZi;
        }
    }
}
