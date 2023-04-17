using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 34D2 C# String: Etsi kirjaimia merkkijonosta Listaan
/*
 * 
 */
namespace MerkkijonoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana 1: ");
            string word1 = Console.ReadLine();      //"kuppi"

            Console.WriteLine("Syötä sana 2: ");
            string word2 = Console.ReadLine();      //"kaappi"

            List<(char charValue, int intValue)> charsInCommon = new List<(char, int)>();

            foreach (char c in word1)
            {
                if (!charsInCommon.Any(x => x.charValue == c)) // "The lambda expression checks if the charValue field of x is equal to the character c."
                {
                    int count = word2.Count(x => x == c);
                    charsInCommon.Add((c, count));
                }
            }

            foreach ((char c, int count) in charsInCommon)
            {
                Console.WriteLine($"Merkki {c} löytyi {count} kerran/kertaa");
            }

            Console.ReadKey();
        }
    }
}


