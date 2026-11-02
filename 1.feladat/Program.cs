using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
                szamok[i] = rnd.Next(1,100);

            Console.WriteLine("A tömb elemei: ");
            Console.WriteLine(String.Join(" ", szamok));

            int paros = 0;
            int paratlan = 0;

            foreach (int i in szamok) 
            {
                if (i % 2 == 0)
                    paros++;
                else
                    paratlan++;
            }

            Console.WriteLine();

            Console.WriteLine($"Páros számok száma: {paros}");
            Console.WriteLine($"Páratlan számok száma: {paratlan}");

            Console.ReadKey();

        }
    }
}
