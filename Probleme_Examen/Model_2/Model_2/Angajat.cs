using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_2
{
    public class Angajat : IComparable<Angajat>
    {
        public String nume;
        public DateTime dataNasterii;
        public int idCompanie;
        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public DateTime DataNasterii
        {
            get { return dataNasterii; }
            set { dataNasterii = value; }

        }
        public int IDCompanie
        {
            get { return idCompanie; }
            set { idCompanie = value; }
        }

        public Angajat() { }
        public Angajat(String nume, DateTime dateNasterii, int idCompanie) 
        {
            this.nume = nume;
            this.dataNasterii = dateNasterii;
            this.idCompanie = idCompanie;
        }

        public override String ToString()
        {
            return nume + " - " + dataNasterii + " - " + idCompanie;
        }

        public int CompareTo(Angajat other)
        {
            if (this == other) return 0;
            if (other == null) return 1;

            int comparareNume = this.Nume.CompareTo(other.Nume);
            if(comparareNume == 0)
            {
                return this.dataNasterii.CompareTo(other.dataNasterii);
            }
            return comparareNume;
        }

        public static explicit operator Boolean(Angajat a)
        {
            if(a.idCompanie > 0) return true;
            return false;
        }
    }
}
