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
            /*
            Console.Write("Anna joku kokonaisluku: ");       // Pyydetään käyttäjää antamaan kokonaisluku.
            int number = int.Parse(Console.ReadLine());
            
            if (number % 2 == 0)                           //Tämä korjaa nolla -ja negatiivisluvut                                  
            {
                Console.WriteLine($"Antamasi numero {number} on parillinen");
            }
            else
            {
                Console.WriteLine($"Antamasi numero {number} on pariton");

            }
            */

            /*
            Console.Write("Anna joku kokonaisluku: ");       // Pyydetään käyttäjää antamaan kokonaisluku.
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber % 2) // Suoritetaan jakojäännöksen laskeminen
            {
                case 0:     // Jakojäännös on 0 eli parillinen
                    Console.WriteLine($"Antamasi numero {userNumber} on parillinen");
                    break;
                case 1:     // Jakojäännös on 1 eli pariton
                    //default - voi käyttää myös defaulttia, koska luku on pariton, jos se ei ole parillinen
                    Console.WriteLine($"Antamasi numero {userNumber} on pariton");
                    break;
            }
            */


            //TERNARY
            Console.Write("Anna joku kokonaisluku: ");       // Pyydetään käyttäjää antamaan kokonaisluku.
            int userNumber = int.Parse(Console.ReadLine());

            string message = (userNumber % 2 == 0) ? $"Antamasi numero {userNumber}on parillinen" : $"Antamasi numero {userNumber} on pariton";
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
           
                                                             
