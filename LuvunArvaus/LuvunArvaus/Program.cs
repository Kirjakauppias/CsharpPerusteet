using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuvunArvaus
{
    class Program
    {
        static void Main(string[] args)
        {
            int rightNumber = 10;
            int guessedNumber;
            bool loopHole = false;

            while (loopHole == false)
            {

                Console.Write("Arvaa oikea kokonaisluku: ");

                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber == rightNumber)
                {
                    loopHole = true;
                    Console.WriteLine("Arvasit oikein!");
                }
                else
                    if (guessedNumber >= rightNumber)
                {
                    Console.WriteLine("Arvaus oli liian suuri.");
                }
                else
                {
                    Console.WriteLine("Arvaus oli liian pieni");
                }

            }

            Console.ReadKey();
        }
    }
}
