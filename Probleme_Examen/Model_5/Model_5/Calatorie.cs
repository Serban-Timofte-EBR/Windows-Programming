using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_5
{
    public class Calatorie : ICloneable, IComparable<Calatorie>
    {
        private int codCard;
        private float valoare;
        private int numarAutobuz;

        public int CodCard { get => codCard; set => codCard = value; }
        public float Valoare { get => valoare; set => valoare = value; }
        public int NumarAutobuz { get => numarAutobuz; set => numarAutobuz = value; }

        public Calatorie(int codCard, float valoare, int numarAutobuz)
        {
            this.codCard = codCard;
            this.valoare = valoare;
            this.numarAutobuz = numarAutobuz;
        }

        public Calatorie()
        {
        }

        public override string ToString()
        {
            return codCard + " - " + valoare + " - " + numarAutobuz;
        }

        public object Clone()
        {
            return new Calatorie(codCard, valoare, numarAutobuz);
        }

        public int CompareTo(Calatorie other)
        {
            return valoare.CompareTo(other.valoare);
        }

        public static Double operator +(Calatorie a, Double val)
        {
            return a.valoare + val;
        }
    }
}
