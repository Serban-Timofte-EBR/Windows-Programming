using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Animal : ICloneable, IComparable //intefata de clonare, de comparare
    {   //fiecare metoda, data membra are specificator de vizibilitate (private by default)
        private int varsta;
        private string nume;
        private float greutate;

        //proprietati
        //parametrul value este implicit pentru prorietati
        //value preia tipul proprietatii
        //daca folosim Varsta(tip value) avem functie, nu proprietate => nu putem folosi get si set

        public int Varsta
        {
            get { return this.varsta; }
            set { if (value > 0) this.varsta = value; }
        }

        public string Nume
        {
            get { return this.nume; }
            set
            {
                if (value.Length > 2)    //Length este o proprietate a clasei string
                    this.nume = value;
            }
        }

        public float Greutate
        {
            get { return this.greutate; }
            set
            {
                if (value > 0)
                    this.greutate = value;
            }
        }

        public Animal(int v, string n, float g)
        {
            nume = n;       //Nume = n va trece din proprietati, in varianta actuala initializeaza date membre
            varsta = v;
            greutate = g;
        }

        //Pentru Console.WriteLine(a1_bisu);
        public override string ToString()
        {
            return "Animalul " + nume + " are varsta de " + varsta +
                " ani si are greutatea de " + greutate + " kg ";
        }

        //Interfete
        //de clonare

            //shallow copy pentru obiect, copiaza cu egal si valorile si pointerii
        object ICloneable.Clone() { return this.MemberwiseClone(); }

        public Animal Clone()
        {
            return (Animal) ((ICloneable)this).Clone(); 
                    //cast       //this se schimba la interfata pentru a apela Iclonable.Clone cu MemberwiseClone
        }

        public int CompareTo(object obj)
        {
            Animal a_local = obj as Animal;
            if (this.greutate > a_local.greutate)
                return 1;
            else if (this.greutate < a_local.greutate)
                return -1;
            else return this.nume.CompareTo(a_local.nume);  //stringurile se compara cu CompareTo
                       //string.Compare(this.nume, a_local.nume);
        }
    }
}
