using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tee ohjelma, johon syötetään päivän lämpötilat. 
 * Lämpötilat mitataan kello 6, 12, 18 ja 24. 
 * Kun arvot on syötetty ohjelma laskee päivän suurimman, pienimmän ja keskilämpötilan.
*/

namespace LampotilanSeuranta
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lampotilat = new int[5];
            List<int> lampoLista = new List<int>();

            for (int i = 0; i < lampotilat.Length; i++)
            {
                Console.WriteLine($"Anna lämpötila {i + 1}:");
                int value = int.Parse(Console.ReadLine());
                lampotilat[i] = value;
                lampoLista.Add(value);
            }

            int maxValue = lampotilat.Max();
            int minValue = lampotilat.Min();
            double averageValue = lampotilat.Average();

            Console.WriteLine($"Suurin arvo: {maxValue}");
            Console.WriteLine($"Pienin arvo: {minValue}");
            Console.WriteLine($"Keskiarvo: {averageValue}");

            int minVal = lampotilat[0];
            for (int i = 1; i < lampotilat.Length; i++)
            {
                if (lampotilat[i] < minVal)
                {
                    minVal = lampotilat[i];
                }
            }
            Console.WriteLine($"Pienin arvo (omalla koodilla): {minVal}");

            Console.ReadKey();
        }
    
    }
}
