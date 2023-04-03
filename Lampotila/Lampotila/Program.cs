/*
 19 C# Valinta: Lämpötila muunnin
 Tee ohjelma, joka kysyy käyttäjältä lämpötilan Fahrenheit-asteet ja muuntaa sen Celsius-asteiksi ja tulostaa näyttöön.
 Tekijä - Mikko Lepistö
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampotila
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius, temperature; 
            char celOrFah;

            Console.Write("Anna lämpötila Fahrenheit -asteella: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit-32) * (5/9d);                                                             //Muunnetaan asteet.

            Console.WriteLine($"Antamasi Fahrenheit -lämpötila on {celsius} Celsiusta.");
            Console.WriteLine();

            Console.Write("Anna lämpötila: ");                                                              //Pyydetään joku lämpötila (ilmeisesti ei ollut väliä tässä että mikä muoto)?
            temperature = double.Parse(Console.ReadLine());
            
            Console.WriteLine();
            
            Console.Write("Kerro, mihin muotoon lämpötila muutetaan. 'F' = Fahrenheit 'C' = Celsius: ");    //Otetaan talteen tieto että onko Fahrenheit vai Celsius char muuttujaan.
            celOrFah = char.Parse(Console.ReadLine());

            if (celOrFah == 'F')                                                                            //Ehtolause.
            {
                fahrenheit = temperature * (5 / 9d) + 32;                                                   //Muutetaan annettu arvo Fahrenheit -asteikkoon.
                Console.WriteLine($"Antamasi lämpötila on {fahrenheit} Fahrenheitia");
            }
            else if (celOrFah == 'C')
            {
                celsius = (temperature - 32) * (5 / 9d);                                                    //Muutetaan annettu arvo Celsius -asteikkoon.
                Console.WriteLine($"Antamasi Fahrenheit -lämpötila on {celsius} Celsiusta.");
            }
            else
            {
                Console.WriteLine("Et antanut oikeaa syötettä!");                                           //Virhe-ilmoitus.
            }

            Console.ReadKey();
        }  

    }
}
