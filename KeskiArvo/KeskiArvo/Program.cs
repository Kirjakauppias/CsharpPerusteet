using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiArvo
{
    class Program
    {
        static void Main(string[] args)
        {
            double arvo1, arvo2, arvo3, keskiArvo;

            Console.WriteLine("Keskiarvon laskeminen.");

            Console.Write("Anna ensimmäinen luku: ");
            arvo1 = double.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            arvo2 = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku: ");
            arvo3 = double.Parse(Console.ReadLine());

            // Lasketaan keskiarvo:
            keskiArvo = (arvo1 + arvo2 + arvo3) / 3;

            Console.WriteLine($"Lukujen keskiarvo on {keskiArvo}");

            Console.ReadKey();


        }
    }
}
