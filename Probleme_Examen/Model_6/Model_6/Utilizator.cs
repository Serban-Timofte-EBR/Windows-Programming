using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_6
{
    public class Utilizator
    {
        private readonly int codU;
        private String nume;
        private int codB;
        private int durataUtilizare;

        public int CodU => codU;

        public string Nume { get => nume; set => nume = value; }
        public int CodB { get => codB; set => codB = value; }
        public int DurataUtilizare { get => durataUtilizare; set => durataUtilizare = value; }

        public Utilizator(int codU, string nume, int codB, int durataUtilizare)
        {
            this.codU = codU;
            this.Nume = nume;
            this.CodB = codB;
            this.DurataUtilizare = durataUtilizare;
        }

        public Utilizator()
        {
        }

        public override string ToString()
        {
            return codU + " - " + nume + " - " + codB + " - " + durataUtilizare;
        }
    }
}
