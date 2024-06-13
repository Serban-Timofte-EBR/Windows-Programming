using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_6
{
    public class Bicicleta
    {
        private readonly int codB;
        private String denumireStatieParcare;
        private int kmParcursi;

        public int CodB => codB;

        public string DenumireStatieParcare { get => denumireStatieParcare; set => denumireStatieParcare = value; }
        public int KmParcursi { get => kmParcursi; set => kmParcursi = value; }

        public Bicicleta(int codB, string denumireStatieParcare, int kmParcursi)
        {
            this.codB = codB;
            this.DenumireStatieParcare = denumireStatieParcare;
            this.KmParcursi = kmParcursi;
        }

        public Bicicleta()
        {
        }
    }
}
