using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal(10, "Agrivei", 7.6f);
            Animal a2 = a1.Clone();

            Pinguin p1 = new Pinguin(true, 15, "Flipper", 25);

            Urs u1 = new Urs(false, 20, "Baloo", 145.2f);

            //List<Animal> lista = new List<Animal>();
            //lista.Add(u1);
            //lista.Add(a2);
            //lista.Add(p1);
            //lista.Add(a1);

            //foreach ( Animal a in lista )
            //{
            //    Console.WriteLine(a.ToString() );
            //}

            //lista.Sort();

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Sortarea a avut loc!");
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach(Animal a in lista)
            //{
            //    Console.WriteLine (a.ToString());
            //}

            Zoo z1 = new Zoo();

            z1.Lista.Add(a1);
            z1.Lista.Add(a2);
            z1.Lista.Add(p1);
            z1.Lista.Add(u1);

            foreach (var a in z1.Lista)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine();

            Zoo z2 = z1.Clone();
            u1.Nume = "URS MODIFICAT CU CAP CA SA VEZI!";

            foreach (var a in z2.Lista)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();

        }
    }
}
