using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bensankulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distance;
            decimal consumption;
            decimal fuelPrice;
            decimal[] costArray = new decimal[4];
            List<decimal> costList = new List<decimal>();

            string exit = "K";

            int i = 0;
            while (exit == "K")
            {
                if (exit == "E")
                {
                    break;
                }
                else if (i >= costArray.Length)
                {
                    costArray = extendArray(costArray);
                }
                else
                { 
                    Console.Write("Anna ajetut kilometrit: ");
                    distance = decimal.Parse(Console.ReadLine());

                    Console.Write("Anna ajoneuvon polttoaineen kulutus litraa/100 km: ");
                    consumption = decimal.Parse(Console.ReadLine());

                    Console.Write("Anna polttoaineen litrahinta euroa/l: ");
                    fuelPrice = decimal.Parse(Console.ReadLine());

                    costArray[i] = fuelCost(distance, consumption, fuelPrice);
                    costList.Add(fuelCost(distance, consumption, fuelPrice));
                    i++;
                    Console.WriteLine();
                    Console.Write("Jatketaanko tallennusta K/E?");
                    exit = (Console.ReadLine());
                }
               

            }
            Console.WriteLine();
            Console.WriteLine("Annetaan kulut taulukkona: ");
            
            for (i = 0; i < costArray.Length; i++)
            {
                    Console.WriteLine($"{i+1}. matkan kustannukset yht.: {costArray[i]} euroa.");
            }

            Console.WriteLine();
            Console.WriteLine("Annetaan kulut listana: ");
            for (i = 0; i < costList.Count; i++)
            {
                Console.WriteLine($"{i+1}. matkan kustannukset yht.: {costList[i]} euroa.");
            }

            Console.WriteLine();
            Console.WriteLine("Ohjelma sulkeutuu enterillä");
            Console.ReadKey();
        }

        private static decimal fuelCost(decimal distance, decimal consumption, decimal fuelPrice)
        {
            return distance * consumption * fuelPrice / 100;
        }

        public static decimal[] extendArray(decimal[] array)
        {
            decimal[] extendedArray = new decimal[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                extendedArray[i] = array[i];
            }

            return extendedArray;
        }
    }
}
