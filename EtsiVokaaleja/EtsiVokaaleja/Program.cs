using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtsiVokaaleja
{
    class Program
    {
        static void Main(string[] args)
        {
            string sana;                                // Etsittävä sana
            int vokaaliCount = 0;                       // Vokaali-laskuri (alussa nolla)

            Console.WriteLine("Syötä sana:");
            sana = Console.ReadLine();

            char[] vokaalit = new char[sana.Length];    // Luodaan taulukko johon kerätään vokaalit
            

            for (int i = 0; i < sana.Length; i++)
            {
                char kirjain = sana[i];
                if (kirjain == 'a' || kirjain == 'e' || kirjain == 'i' || kirjain == 'o' || kirjain == 'u' ||
                    kirjain == 'A' || kirjain == 'E' || kirjain == 'I' || kirjain == 'O' || kirjain == 'U')
                {
                    vokaalit[vokaaliCount] = kirjain;
                    vokaaliCount++;
                }
            }

            Console.WriteLine("Sanan vokaalit ovat:");
            for (int i = 0; i < vokaaliCount; i++)
            {
                Console.Write(vokaalit[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
