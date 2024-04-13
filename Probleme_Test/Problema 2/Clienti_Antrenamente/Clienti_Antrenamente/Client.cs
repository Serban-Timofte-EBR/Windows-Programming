using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clienti_Antrenamente
{
    [Serializable]
    public class Client
    {
        private String nume;
        private String prenume;
        private int varsta;
        private String abonament;

        public String Nume 
        {
            get { return nume; }
            set { nume = value; }
        }

        public String Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public int Varsta
        {
            get { return varsta; }
            set {  varsta = value; }
        }

        public String Abonament
        {
            get { return abonament; }
            set { if (value == "ACTIV" || value == "INACTIV")
                {
                    abonament = value;
                }
                else
                {
                    abonament = string.Empty;
                }
            }
        }

        public Client() 
        {
            nume = String.Empty;
            prenume = String.Empty;
            varsta = 0;
            abonament = String.Empty;
        }

        public Client(String _nume, String _prenume, int _varsta, String _abonament) 
        { 
            nume = _nume;
            prenume = _prenume;
            varsta = _varsta;
            abonament = _abonament;
        }
    }
}
