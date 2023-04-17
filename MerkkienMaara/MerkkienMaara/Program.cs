using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkkienMaara
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userValues = new int[3];

            // Silmukan ehto on se, että päätetään suoritus silloin,
            // kun i-muuttujan arvo on taulukon indeksien ulkopuolella
            // Jos pituus on 3, indeksit ovat 0 1 2

            Console.WriteLine("Syötä 3 lukua: ");
            
            for (int i = 0; i < userValues.Length; i++)
            {
                userValues[i] = int.Parse(Console.ReadLine());
            }

            // Myöhemmin tarvitaan summa
            // Valmis metodi Sum
            // Console.WriteLine($"{userValues.Sum()}");

            // Luodaan summa käsin
            int sum = 0;

            // Silmukassa, jossa summataan kaikkien indeksien arvot:
            for (int i = 0; i < userValues.Length; i++)
            {
                sum = sum + userValues[i];
            }

            Console.WriteLine($"Lukujen summa on: {sum}");

            // LISTAVERSIO - käyttäjä voi tallentaa niin monta lukua kuin haluaa.

            Console.WriteLine("Syötä lukuja (e to exit): ");
            List<int> values = new List<int>();
            bool userIsDone = false;

            // Silmukka jossa käyttäjä voi syöttää haluamansa verran lukuja.
            while (userIsDone != true) // tai do while
            {
                string userInput = Console.ReadLine();

                if (userInput == "e") // Tarkistetaan, jos käyttäjä lopettaa lukujen syötön
                {
                    userIsDone = true;
                }
                else
                {
                    values.Add(int.Parse(userInput));
                }
            }

            // Listan summaus
            // Console.WriteLine($"Listan lukujen summa on: {values.Sum()}");

            int sumList = 0;

            foreach(int number in values)
            {
                sumList += number;
            }

            Console.WriteLine($"Listan lukujen summa on: {sumList}");

            Console.ReadKey();
        }
    }
}
