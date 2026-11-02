using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] homersekletek = { 12, 8, -1, 5, 14, 7, 2 };

            Console.WriteLine("A heti hőmérsékletek:");
            Console.WriteLine(String.Join(" ",homersekletek));

            Console.WriteLine();

            Array.Sort(homersekletek);
            Console.WriteLine($"A legalacsonyabb hőmérséklet: {homersekletek[0]} Celsius");
            Array.Reverse(homersekletek);
            Console.WriteLine($"A legmagasabb hőmérséklet: {homersekletek[0]} Celsius");
            Console.WriteLine($"A heti átlag hőmérséklet: {homersekletek.Average():f1}");
            Console.ReadKey();
        }
    }
}
