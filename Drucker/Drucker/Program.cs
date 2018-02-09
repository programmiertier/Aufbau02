using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Drucker
{
    class Program
    {

        static void Main(string[] args)
        {
            /* ablauf01();
            WriteLine("-----");
            ablauf02(); */
            // variante1();
            variante2();
            WriteLine("-----");
        }

        static void variante2()
        {
            // wir erstellen die gemeinsam zu nutzende Ressource
            Queue<Druckauftrag> pool = new Queue<Druckauftrag>();

            // wir weisen diese Ressource einem Drucker zu
            Drucker print = new Drucker(pool);

            // wir weisen die gleiche Ressource dem Arbeiter (Variante2) zu
            Variante02 arbeiter = new Variante02(pool);


            // wir erstellen zwei Threads
            // die Methode zum erstellen von Aufträgen und zum Drucken von diesen sollen
            // parallel ablaufen
            Thread t1 = new Thread(arbeiter.generierenAufträge);
            Thread t2 = new Thread(print.drucken);

            t1.Start();
            t2.Start();

        }

        static void variante1()
        {
            Variante01 v1 = new Variante01();
            // die beiden Methoden aus v1 müssen parallel ausgeführt werden
            // diese Methode thread01() hat eine Schleife, hier wird ruch den Nutzer etwas gemacht
            // nicht der Nutzer bestimmt, wann die Schleife vorbei ist, sondern jemand anderes
            Thread t1 = new Thread(v1.thread01);

            // diese Methode ändert den Wert einer Variablen, die bestimmt, wie oft die Schleife
            // aus der anderen Methode ausgeführt wird
            Thread t2 = new Thread(v1.thread01_clock);

            // ob jetzt t1 oder t2 zuerst, ist egal. ist alles in einem pool!
            t1.Start();
            t2.Start();
        }

        

        static void ablauf01()
        {
            Drucker d = new Drucker(null);
            d.hinzufügen(new Druckauftrag("Schaukelpferd", 34));
            d.hinzufügen(new Druckauftrag("Bömmel", 10));
            d.hinzufügen(new Druckauftrag("Kaffeebohne", 42));

            d.drucken();

            WriteLine("Gesamtzeit: " + d.gesamtzeit);
            ReadLine();
        }

        static void ablauf02()
        {
            Drucker d = new Drucker(null);
            Random rnd = new Random();
            String was = null;

            WriteLine("geben sie an, was gedruck werden soll, beenden mit Leerzeile");
            do
            {
                was = ReadLine();
                if (was.Length > 0)
                {
                                                    // bereich zwischen 30 und 60
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
