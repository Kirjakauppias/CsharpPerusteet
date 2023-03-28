using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietokonerekisteri
{
    class Program
    {
        string id;
        string merkki;
        string malli;
        string omistus;

        public Tietokone(String id, String merkki, String malli, String omistus)
        {
            this.id = id;
            this.merkki = merkki;
            this.malli = malli;
            this.omistus = omistus;
        }

        public Varasto()
        {

        }
        static void Main(string[] args)
        {

        }
    }
}
