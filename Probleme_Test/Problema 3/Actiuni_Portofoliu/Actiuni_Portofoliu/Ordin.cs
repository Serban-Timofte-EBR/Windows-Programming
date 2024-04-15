using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actiuni_Portofoliu
{
    public class Ordin
    {
        public int id;
        public String owner;
        public int ziPlasare;

        public Ordin()
        {
            id = 0;
            owner = String.Empty; 
            ziPlasare = 0;
        }

        public Ordin(int _id,String _owner,int _ziPlasare)
        {
            id= _id;
            owner= _owner;
            ziPlasare= _ziPlasare;
        }
    }
}
