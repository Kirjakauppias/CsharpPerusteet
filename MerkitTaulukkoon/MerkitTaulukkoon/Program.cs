using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  34D3 C# String: Merkit taulukkoon ja listaan
  Tekijä: Mikko Lepistö

1. Pyydä käyttäjältä sana.
2. Luo taulukko ja lista sanan merkkejä varten.
3. Luo silmukka, jossa käydään läpi kaikki sanan merkit.
4. Silmukan sisällä tallenna merkkejä yksi kerrallaan taulukkoon ja listaan

Lisää taulukon ja listan merkkien tulostus.

5. Luo silmukka taulukolle ja toinen silmukka listalle. Silmukoissa merkit tulostetaan peräkkäin yhdelle riville.

5a. Taulukon silmukka tulostaa parittomat merkit isolla. Esim: "kuppi" => "KUppI" (Oletetaan, että käyttäjä syöttää sanaan vain pieniä aakkosia)
c % 2 != 0  <= c viittaa taulukon char arvoon
(char)(c-32)   <= kun pienen aakkosen numero arvosta vähennentään 32, siitä tulee iso aakkonen. Lopuksi pitää alustaa se merkiksi (char) syktaksilla. ASCII-taulukko malliksi  a == 97 ja A == 65

5b. Listan silmukassa tulostetaan parilliset merkit isolla. Esim: "kauppa" => "kauPPa"
*/

namespace MerkitTaulukkoon
{
    class Program
    {
        static void Main(string[] args)
        {
            char merkki;

            Console.Write("Anna jokin sana: ");     // 1. Pyydetään käyttäjältä sana.
            string word = Console.ReadLine();

            char[] chars = new char[word.Length];   // 2. Luodaan taulukko sanan merkkejä varten.
            
            for(int i = 0; i < word.Length; i++)    // 3. Luodaan silmukka jossa käydään läpi kaikki sanan merkit.
            {
                merkki = word[i];                   // 4. Silmukan sisällä tallennetaan merkkejä yksi kerrallaan taulukkoon. Tässä merkki saa arvoksi word -taulukon indeksissä olevan kirjaimen.  
                chars[i] = merkki;                  //    Tässä chars -taulukon indeksi saa arvon merkki.
                Console.Write(chars[i]);            // 5. Merkit tulostetaan peräkkäin yhdelle riville.
            }

            Console.WriteLine();
            Console.WriteLine("Alle tulostuu taulukko jossa parittomat merkit ovat isolla.");                    

            for (int i = 0; i < word.Length; i++)   // 5a. Taulukon silmukka tulostaa parittomat merkit isolla.
            {
                
                if(word[i] % 2 != 0)                // Tarkistetaan että onko merkki pariton.  
                {
                    merkki = (char)(word[i] - 32);  // Tässä merkki saa arvoksi word -taulukon indeksissä olevan ISON kirjaimen.  
                    chars[i] = merkki;              // Tässä chars -taulukon indeksi saa arvon merkki.
                }
                else
                {
                    merkki = word[i];               // Else -osiossa normaali taulukkoon tallentaminen.
                    chars[i] = merkki;
                }
                Console.Write(chars[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Alle tulostuu lista.");

            // TEHDÄÄN LISTAVERSIO
            List<char> charList = new List<char>(); // 2. Luodaan lista sanan merkkejä varten.

            foreach(char kirjain in word)           // 3. Luo silmukka, jossa käydään läpi kaikki sanan merkit.
            {
                charList.Add(kirjain);
            }

            for (int i = 0; i < charList.Count; i++)// 4. Silmukan sisällä tallennetaan merkkejä yksi kerrallaan
            {
                char kirjain = charList[i];
                Console.Write(kirjain);
            }

            Console.WriteLine();
            Console.WriteLine("Alle tulostuu lista jossa parilliset merkit tulostuvat isolla.");

            for (int i = 0; i < charList.Count; i++) // 5. 5b. Listan silmukassa tulostetaan parilliset merkit isolla. Esim: "kauppa" => "kauPPa"
            {
                char kirjain = charList[i];
                if (word[i] % 2 == 0)
                {
                    Console.Write(Char.ToUpper(kirjain));
                }
                else
                {
                    Console.Write(kirjain);
                }
            }

                Console.ReadKey();
        }
    }
}
                
                
