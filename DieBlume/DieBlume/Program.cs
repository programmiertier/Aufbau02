using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BieneDLL;
using static System.Console;

namespace DieBiene
{
    class Program
    {
        static void Main(string[] args)
        {
            Biene summ = new Biene(2, 15, Biene.egeschlecht.weiblich);
            Biene willi = new Biene(3, 25, Biene.egeschlecht.maennlich);
            Biene summtwin = new Biene(2, 15, Biene.egeschlecht.weiblich);

            WriteLine(summ.alter);
            WriteLine(summ.gewicht);
            WriteLine(summ.geschlecht);

            String result = summ.fliegen(450);
            WriteLine(result);
            WriteLine(summ.gewicht);

            result = summ.umwandlungGeschlecht();
            WriteLine(result);
            WriteLine(summ.geschlecht);

            Blume pinkeRose = new Blume("pink", "Rose");
            result = summ.gehbestaeuben(pinkeRose);
            WriteLine(result);

            WriteLine(summ);
            WriteLine("-----");

            if (summ == willi)
            {
                WriteLine("Summ und Willi sind identisch");

            }
            else
            {
                WriteLine("Summ ist nich Willi");
            }
            WriteLine("-----");
            if (summ == summtwin)
            {
                WriteLine("Summ und SummTwin sind identisch");

            }
            else
            {
                WriteLine("Summ ist nich SummTwin");
            }

            if (summ.Equals(summtwin))
            {
                WriteLine("Summ und SummTwin sind gleich");
            }
            else
            {
                WriteLine("Summ und SummTwin sich unterschiedlich");
            }

            ReadLine();
        }
    }
}
