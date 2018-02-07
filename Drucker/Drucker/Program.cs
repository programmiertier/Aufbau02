using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Drucker
{
    class Program
    {
        static void Main(string[] args)
        {
            ablauf01();
            WriteLine("-----");
            ablauf02();
            ReadLine();
        }

        // wir geben Druckaufträge ein
        

        static void ablauf01()
        {
            Drucker d = new Drucker();
            d.hinzufügen(new Druckauftrag("Schaukelpferd", 34));
            d.hinzufügen(new Druckauftrag("Bömmel", 10));
            d.hinzufügen(new Druckauftrag("Kaffeebohne", 42));

            d.drucken();

            WriteLine("Gesamtzeit: " + d.gesamtzeit);
            ReadLine();
        }

        static void ablauf02()
        {
            Drucker d = new Drucker();
            Random rnd = new Random();
            String was = null;

            WriteLine("geben sie an, was gedruck werden soll, beenden mit Leerzeile");
            do
            {
                was = ReadLine();
                if (was.Length > 0)
                {
                    d.hinzufügen(new Druckauftrag(was, rnd.Next(30, 60)));
                }
            }
            while (was.Length > 0);

            WriteLine("es wird gedruckt");

            d.drucken();

            WriteLine("Gesamtzeit: " + d.gesamtzeit);
        }
    }
}
