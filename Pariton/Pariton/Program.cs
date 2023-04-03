/*
 14 C# Valinta: Parillinen vai pariton
Tee ohjelma, joka ilmoittaa onko käyttäjän antama luku parillinen vai pariton

Tekijä - Mikko Lepistö
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna joku kokonaisluku: ");       // Pyydetään käyttäjää antamaan kokonaisluku.
            int number = int.Parse(Console.ReadLine());

            //int divider = 2;                                 // int muuttuja pitää olla

            //if (number / (number - (number / 2)) != divider) // Varmistaa että onko annettu luku jaollinen kahdella, ongelma on nolla ja miinusluvut
              if (number % 2 == 0)                           //Tämä korjaa nolla -ja negatiivisluvut                                  
                                                             
            {
                Console.WriteLine("Antamasi numero on parillinen");
            }
            else
            {
                Console.WriteLine("Antamasi numero on pariton" +
                    "");

            }

            Console.ReadKey();
        }
    }
}
