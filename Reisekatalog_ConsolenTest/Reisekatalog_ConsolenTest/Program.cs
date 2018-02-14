using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothek_Reisekatalog;

namespace Reisekatalog_ConsolenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Katalog kat = new Katalog();
            kat.log += Console.WriteLine;

            foreach (Reiseziel r in kat.getZiele())
            {
                Console.WriteLine(r.Land + " - " + r.Ort);
            }


            foreach (Hotel h in kat.getHotels("GR", "Athen"))
            {
                Console.WriteLine(h.Name);
            }

            foreach (Hotel h in kat.getHotels("ES", "Barcelona", 2))
            {
                Console.WriteLine(h.Name + " - " + h.Bewertung);
            }

            foreach (Hotel h in kat.getHotels("GR"))
            {
                Console.WriteLine(h.Name);
            }
        }
    }
}
