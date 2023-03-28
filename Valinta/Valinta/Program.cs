using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku! ");

            int luku = int.Parse(Console.ReadLine());

            if (luku > 0)
            {
                Console.WriteLine("Antamasi luku on suurempi kuin nolla.");
            }
            else if (luku == 0)
            {
                Console.WriteLine("Antamasi luku on nolla.");
            }
            else
            {
                Console.WriteLine("Antamasi luku on pienempi kuin nolla.");
            }
            Console.ReadKey();
        }
    }
}
