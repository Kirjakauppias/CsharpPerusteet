using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 26 C# Toisto: Tulosta luvut 1 ...n
Tee ohjelma, joka tulostaa luvut 1:stä käyttäjän antamaan lukuun saakka.
Tekijä - Mikko Lepistö
 */

namespace LuvunToisto
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber;
            int startingNumber = 1;

            Console.Write("Anna joku kokonaisluku: ");
            givenNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tulostetaan luvut 1-{givenNumber}. ");

            while (startingNumber < givenNumber+1)        //Niin kauan kun aloitusluku on pienempi kuin annettu luku + 1 (saadaan myös annettu luku tulostettua).
            {
                Console.Write($"{startingNumber} ");
                startingNumber++;                         //Aloitusluku kasvaa joka iteraatiolla yhden lisää.
            }


            Console.ReadKey();
        }
    }
}
