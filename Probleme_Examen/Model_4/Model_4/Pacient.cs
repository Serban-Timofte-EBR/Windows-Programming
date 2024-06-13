using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    public class Pacient
    {
        public readonly int codP;
        public String nume;
        public int codM;
        public float tarif_consultatie;

        public Pacient()
        {
        }

        public Pacient(int codP, string nume, int codM, float tarif_consultatie)
        {
            this.codP = codP;
            this.nume = nume;
            this.codM = codM;
            this.tarif_consultatie = tarif_consultatie;
        }

        public int CodP { get { return codP; } }
        public String Nume { get { return nume; } set { nume = value; } }
        public int CodM { get {  return codM; } set { codM = value; } }
        public float Tarif_consultatie { get {  return tarif_consultatie; } set { tarif_consultatie = value;} }

        public override string ToString()
        {
            return codP + " - " + nume + " - " + codM + " - " + tarif_consultatie;
        }
    }
}
