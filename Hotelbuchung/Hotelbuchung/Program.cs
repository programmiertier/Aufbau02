using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiboHotel;

namespace Hotelbuchung
{
    class Program
    {
        static void Main(string[] args)
        {
            Buchung buu = new Buchung();
            Console.WriteLine(buu);

            Hotel ho = new Hotel();
            Console.WriteLine(ho.ausgebenAlle());
            Console.WriteLine(ho.ausgebenNamen("fr") + "\t" + ho.ausgebenZimmer().ToString() + "\t" + ho.ausgebenZimmerBuchung(1));
            Console.WriteLine(buu);
            

        }
    }
}
