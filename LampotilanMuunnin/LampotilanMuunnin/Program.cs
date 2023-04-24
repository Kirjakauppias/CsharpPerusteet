using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampotilanMuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "E";
            string temp = "";

            while (exit == "E")
            {

                Console.Write("Anna lämpötilan yksikkö 'F' = fahrenheit, 'C' = celcius.");
                temp = (Console.ReadLine());

                Console.Write("Anna lämpötilan arvo: ");
                double tempValue = double.Parse(Console.ReadLine());


                Console.WriteLine();


                if (temp == "C")
                {
                    Console.WriteLine($"Antamasi {tempValue} fahrenheitia on {fahrenheitToCelsius(tempValue)} celciusta.");
                }
                else if (temp == "F")
                {
                    Console.WriteLine($"Antamasi {tempValue} celsiusta on {celsiusToFahrenheit(tempValue)} fahrenheitia.");
                }

                Console.WriteLine();

                Console.WriteLine("Lopetetaanko ohjelma K/E?");
                exit = Console.ReadLine();

                if (exit == "K")
                {
                    break;
                }


            }
            Console.ReadKey();
        }

        public static double fahrenheitToCelsius(double tempValue)
        {
            double fahrenheit = tempValue * 9d / 5 + 32;
            return fahrenheit;
        }

        public static double celsiusToFahrenheit(double tempValue)
        {
            double celsius = (5d / 9) * (tempValue - 32d);
            return celsius;
        }
    
    }
}
