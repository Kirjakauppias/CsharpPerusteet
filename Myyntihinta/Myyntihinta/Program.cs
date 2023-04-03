using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myyntihinta
{
    class Program
    {
        static void Main(string[] args)
        {
            double uusiHinta, myyntihinta;

            Console.Write("Anna tuotteen hinta: ");

            myyntihinta = double.Parse(Console.ReadLine());

            if (myyntihinta >= 100)
            {
                uusiHinta = myyntihinta * 0.75;
            }
            else uusiHinta = myyntihinta * 0.90;

            Console.WriteLine($"Tuotteen hinta alennuksen jälkeen on {uusiHinta} €");

            Console.ReadKey();
        }
    }
}
