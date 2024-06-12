using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_1
{
    [Serializable]
    public class ExtrasCont : ITranzactie, ICloneable
    {
        public String numeClient { get; set; }
        public String adresa { get; set; }
        public List<Tranzactie> tranzactii;

        public ExtrasCont(string numeClient, String adresa, List<Tranzactie> tranzactii)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.tranzactii = tranzactii;
        }

        public ExtrasCont() { }

        public Tranzactie this[int index]
        {
            get { return tranzactii[index]; }
            set { tranzactii[index] = value; }
        }

        public void afisareTranzactie()
        {
            foreach (Tranzactie tranzactie in this.tranzactii)
            {
                Console.WriteLine("ID: " + tranzactie.idTranzactie + ", IBAN: " + tranzactie.contIban + 
                    ", Detalii: " + tranzactie.detaliiTranzactie + ", Suma:" + tranzactie.suma + ", Data: " + tranzactie.dataTranzactie);
            }
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public ExtrasCont Clone()
        {
            ExtrasCont nou = (ExtrasCont) ((ICloneable)this).Clone();

            List<Tranzactie> copy = new List<Tranzactie>();
            foreach(Tranzactie tranzactie in this.tranzactii)
            {
                copy.Add(tranzactie);
            }

            nou.tranzactii = copy;

            return nou;
        }

        public static explicit operator double(ExtrasCont extrasCont)
        {
            double sumaTotala = 0;
            int nrTranzactii = 0;

            foreach(Tranzactie tranzactie in extrasCont.tranzactii)
            {
                sumaTotala += tranzactie.suma;
                nrTranzactii++;
            }

            return sumaTotala / nrTranzactii;
        }

        public static explicit operator int(ExtrasCont extrasCont)
        {
            int nrTranzactii = 0;
            foreach(Tranzactie tranzactie in extrasCont.tranzactii)
            {
                nrTranzactii++;
            }
            return nrTranzactii;
        }
    }
}
