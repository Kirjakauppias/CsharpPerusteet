using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintaAla
{
    class Program
    {
        static void Main(string[] args)
        {
            double kanta, korkeus, pintaAla;

            Console.WriteLine("Kolmion pinta-alan laskeminen.");

            Console.Write("Anna kolmion kannan pituus CM: ");
            kanta = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmion korkeus CM: ");
            korkeus = double.Parse(Console.ReadLine());


            // Lasketaan kolmion pinta-ala:
            pintaAla = (kanta*korkeus)/2;

            Console.WriteLine($"Kolmion pinta-ala on {pintaAla}");

            Console.ReadKey();

        }
    }
}
