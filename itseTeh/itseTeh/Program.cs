using System;

namespace itseTeh
{
    class Program
    {
        static void Main(string[] args)
        {
            double leveys;
            double korkeus;
            double pintaAla;
            


            Console.WriteLine("Anna leveys metreinä: ");

            String userInput = Console.ReadLine(); 
            leveys = double.Parse(userInput);


            Console.WriteLine("Anna korkeus metreinä: ");

            String userInput2 = Console.ReadLine();
            korkeus = double.Parse(userInput2);

            pintaAla = leveys * korkeus;

            Console.WriteLine($"Leveys: {leveys} metriä\nKorkeus: {korkeus} metriä");
            Console.WriteLine($"Pinta-Ala: {pintaAla} neliötä.");
        }
    }
}

