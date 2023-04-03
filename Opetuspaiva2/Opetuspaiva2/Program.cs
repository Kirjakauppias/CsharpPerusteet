using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspaiva2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput; // Tallennetaan käyttäjän syöttämä arvo

            Console.Write("Anna pituus metreinä: "); //Antaa syöttäjän arvo heti kaksoispisteen jälkeen.
                                                    //Console.WriteLine laittaa aina rivinvaihdon!
            userInput = Console.ReadLine();
            double pituus = double.Parse(userInput); //Muokataan string arvo double dataksi.

            Console.Write("Anna leveys metreinä: ");
            userInput = Console.ReadLine();         // Tässä userInput voidaan ylikirjoittaa
            double leveys = double.Parse(userInput);

            double alue = pituus * leveys;

            Console.WriteLine($"Alueen pinta-ala {alue}");

            Console.ReadKey();
        }
    }
}
