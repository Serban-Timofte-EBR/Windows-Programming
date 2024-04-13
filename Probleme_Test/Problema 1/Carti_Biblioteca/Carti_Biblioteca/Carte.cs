using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carti_Biblioteca
{
    [Serializable]
    public class Carte
    {
        private string titlu;
        private string autor;
        private int anPublicare;
        public string Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
         
        public int AnPublicare
        {
            get { return anPublicare; }
            set { anPublicare = value; }
        }

        public Carte()
        {
            titlu = string.Empty;
            autor = string.Empty;
            anPublicare = 0;
        }

        public Carte(string titlu, string autor, int an)
        {
            this.titlu = titlu;
            this.autor = autor;
            this.anPublicare = an;
        }
    }
}
