using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarGmbH_Console
{
    class SolarVerwaltung
    {
        static void Main(string[] args)
        {
            Investor hans = new Investor("Hans", "Sonnenschein", "0221/12345", "sonnenschein@sonne.de");
            Console.WriteLine(hans.vorname + "\t|\t" + hans.zuname + "\t|\t" + hans.telefonnummer + "\t|\t" + hans.email);

            Console.ReadLine();
            
        }
    }
}
