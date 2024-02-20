//Ad References before using into the project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TOATE CLASELE MOSTENESC OBJECT (si are metoda to_string pe care o apeleaza in Console.WriteLine(a1_bisu); - ToString(a1_bisu) )
            Animal a1_bisu = new Animal(4, "Bisu", 11);
            Console.WriteLine(a1_bisu);

            Animal a2_simba = new Animal(6, "Simba", 5);
            Console.WriteLine(a2_simba);
            Console.WriteLine();

            Animal a3 = a1_bisu.Clone();

            Urs martinel = new Urs(true, 10, "Martinel", 150);

            List<Animal> pets = new List<Animal>();
            pets.Add(a1_bisu);
            pets.Add(a2_simba);
            pets.Add(a3);
            pets.Add(martinel);

            a1_bisu.Nume = "Bus";

            pets.Sort();

            foreach (Animal a in pets)
            {
                Console.WriteLine(a);
            }

            Console.Read();
        }
    }
}
