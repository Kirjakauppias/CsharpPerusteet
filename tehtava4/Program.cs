using System;

namespace tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {
           
          

            // Tässä käyttäjä näppäilee ikänsä
            // string userInput = Console.ReadLine();
            // int ika = int.Parse(userInput);

            Console.Write("Kerro tuntipalkkasi ");
            string userInput = Console.ReadLine();
            double tuntipalkka = double.Parse(userInput);

            Console.Write("Kerro työtuntisi määrä.");
            string juserInput = Console.ReadLine();
            double tunnit = double.Parse(juserInput);
     

            Console.Write("Kerro 50% korotetut tunnit ");
          
            string luserInput = Console.ReadLine();
            double puoliKorotetut = double.Parse(luserInput);

            Console.Write("Kerro 100% korotetut tunnit ");

            string muserInput = Console.ReadLine();
            double taysKorotetut = double.Parse(muserInput);

            double perusPalkka = (tuntipalkka * tunnit);

            double puolikorotettuPalkka = ((puoliKorotetut*(tuntipalkka*1.50)));
            double tayskorotettuPalkka = ((taysKorotetut*tuntipalkka)*2);

            double palkka = (perusPalkka + puolikorotettuPalkka + tayskorotettuPalkka);

            Console.WriteLine($"Palkkasi on {palkka} euroa");

            //Console.WriteLine($"{tuntipalkka} {tunnit} {puoliKorotetut} {taysKorotetut}");




        }
    }
}
