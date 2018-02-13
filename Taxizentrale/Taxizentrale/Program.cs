using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Taxizentrale
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Taxi t in TaxizentraleDB.getAlle())
            {
                WriteLine("Taxi Nummer:\t" + t.nummer + "\tist belegt:\t" + t.belegt);
            }

            WriteLine("Gesamtumsatz: " + TaxizentraleDB.getGesamtumsatz());

            ReadLine();
        }
    }
}
