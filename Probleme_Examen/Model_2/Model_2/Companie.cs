using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_2
{
    public class Companie
    {
        public int id;
        public string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name { get { return name; } set {  name = value; } }

        public Companie() { }

        public Companie(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override String ToString()
        {
            return id + " - " + name;
        }
    }
}
