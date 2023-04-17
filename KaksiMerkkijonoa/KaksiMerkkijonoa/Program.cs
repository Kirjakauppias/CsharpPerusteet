using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Tee ohjelma, jossa käyttäjältä kysytään 2 merkkijonoa. Ohjelma laskee kuinka monta kertaa ensimmäisen merkkijonon kirjaimia on toisessa merkkijonossa
 Tallennetaan merkit ja niiden lukumäärät 2d taulukkoon. Käytä merkissä sen int arvoa.

 Esim jos merkkijonot ovat "kuppi" ja "kauppa" ohjelma tulostaa.

 k 1 kerta

 u 1 kerta

 p 2 kertaa

 Extra osa

 Lisää ohjelmaan toiminto joka tulostaa ne merkit, jotka ovat merkkijonossa 1, mutta ei merkkijonossa 2.
*/

namespace KaksiMerkkijonoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana 1: ");
            string word1 = Console.ReadLine();      //"kuppi"

            Console.WriteLine("Syötä sana 2: ");
            string word2 = Console.ReadLine();      //"kauppa"

            // Taulukon käytön ongelmat:
            // 1. ei voi vielä tietää kuinka pitkä sana on
            // 2. ei voi tietää montako merkkiä ovat samoja

            // TODO: Luo taulukon pituus tarkalleen oikein

            // ['p', 2]
            // ['r', 1]
            // ['e', 3]

            // charsInCOmmon sisältää merkit, jotka ilmenevät molemmissa sanoissa ja montako kertaa ne ilmenee
            // Tässä datatyyppi on "Tuple", johon voi tallentaa kaksi eri datatyyppiä yhdessä.
            (char charValue, int intValue)[] charsInCommon = new (char, int)[word1.Length];

            string charsTested = "";

            // Luodaan silmukka, joka käy läpi kaikki word1 merkit ja tarkistetaan ilmeneekö se word2-muuttujassa
            for (int i = 0; i < word1.Length; i++) //word1 indeksi == i
            {
                int numberOfTimesFound = 0;
                for (int j = 0; j < word2.Length; j++)  //word2 indeksi == j
                {
                    if (word1[i] == word2[j] && charsTested.Contains(word1[i]) == false)  //Onko sanan 1 indeksissä i sama kirjain kuin sanan 2 indeksissä j
                    {                       
                        // Estetään saman kirjaimen tallennus uudestaan
                        numberOfTimesFound++;
                        charsInCommon[i] = (word1[i], numberOfTimesFound);
                    }
                }
                charsTested += word1[i];
            }

            // Silmukka, jossa käydään läpi taulukko löydetyistä kirjaimista
            foreach( (char, int) pairs in charsInCommon)
            {
                Console.WriteLine($"Merkki {pairs.Item1} löytyi {pairs.Item2} kerran/kertaa");
            }
            Console.ReadKey();

        }
    }
}

           


                       



           

