using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanTarkistus
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ageCorrect = false; //Silmukkaa jatketaan niin pitkään kunnes ikä on 0-120
                                     //Oletetaan että ikä ei ole oikein

            while (ageCorrect == false)     //
            {
                Console.Write("Kerro ikäsi: ");
                int age = int.Parse(Console.ReadLine());
                int minAge = 0;
                int maxAge = 120;

                if (age >= minAge && age <= maxAge)
                {
                    ageCorrect = true;
                    Console.WriteLine("Ikä on järkevä");
                }
                else


                {
                    Console.WriteLine("Arvo ei ole " + "hyväksyttävällä välillä" + $" ({minAge}-{maxAge})");
                }

            }
            
            
            Console.ReadKey();
        }

    }
}
