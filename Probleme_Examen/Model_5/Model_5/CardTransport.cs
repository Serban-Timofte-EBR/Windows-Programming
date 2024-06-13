using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_5
{
    public class CardTransport : ICloneable, IComparable<CardTransport>
    {
        private readonly int codCard;
        private String numeUtilizator;
        private float sold;

        public int CodCard => codCard;
        public string NumeUtilizator { get => numeUtilizator; set => numeUtilizator = value; }
        public float Sold { get => sold; set => sold = value; }

        public CardTransport(int codCard, string numeUtilizator, float sold)
        {
            this.codCard = codCard;
            this.numeUtilizator = numeUtilizator;
            this.sold = sold;
        }

        public CardTransport()
        {
        }

        public override string ToString()
        {
            return codCard + " - " + numeUtilizator + " - " + sold;
        }

        public object Clone()
        {
            return new CardTransport(codCard, numeUtilizator, sold);
        }

        public int CompareTo(CardTransport other)
        {
            return sold.CompareTo(other.sold);
        }

        public static explicit operator String(CardTransport other)
        {
            return other.NumeUtilizator;
        }

        public static float operator +(CardTransport other, float val) {
            CardTransport[] vector = Form1.carduri;
            int nrCarduri = Form1.indexCarduri;

            float soldTotal = 0;
            for (int i = 0; i < nrCarduri; i++)
            {
                soldTotal += vector[i].sold;
            }

            return soldTotal;
        }
    }
}
