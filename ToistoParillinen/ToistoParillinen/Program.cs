﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 28 C# Toisto: Parillinen Pariton
Tee ohjelma joka kysyy mihin lukuun saakka tulostetaan lukuja.

Käyttäjältä myös kysytään, tulostetaanko parilliset vai parittomat.

Sovellus lopuksi tulostaa joko parittomat tai parilliset luvut, nollasta alkaen.

Tekijä - Mikko Lepistö
 */
namespace ToistoParillinen
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 0;  //Aloitusnumero kun tarkoitus on aloittaa nollasta lukujen tulostaminen.
          
            string answer;           //Muuttuja johon varastoidaan käyttäjän antama vastaus.
            
            Console.Write("Anna joku kokonaisluku mihin asti numeroita luetellaan: ");
            int endNumber = int.Parse(Console.ReadLine());

            Console.Write("Kummat numerot luetellaan? \"Pariton\" on parittomat luvut, \"Parillinen\" on parilliset luvut: ");
            answer = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Tulostetaan {answer} luvut: ");

            if (answer == "Pariton")    //Jos käyttäjä haluaa tulostaa parittomat luvut.
            {
                while (startingNumber < endNumber + 1)
                {
                    if (startingNumber % 2 != 0)
                    {
                        Console.WriteLine(startingNumber);
                    }
                    else
                    {

                    }
                    startingNumber++;
                }
            }
            else if (answer == "Parillinen")    //Jos käyttäjä haluaa tulostaa parilliset luvut.
            {
                while (startingNumber < endNumber + 1)
                {
                    if (startingNumber % 2 == 0)
                    {
                        Console.WriteLine(startingNumber);
                    }
                    else
                    {

                    }
                    startingNumber++;
                }
            }
            else
            {
                Console.WriteLine("Annoit väärän syötteen!");   //Antaa virheilmoituksen jos käyttäjä ei kirjoita oikein.
            }
            
            Console.ReadKey();
            
        }
    }
}
