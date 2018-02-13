using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using SQL_Bibliothek;


namespace Sprachqualifikation
{
    class Program
    {
        static void Main(string[] args)
        {

            AbfragePool pool = null;
            try
            {
                pool = new AbfragePool();
                ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Keine Verbindung zur DB", e);
                return;
            }
            
            WriteLine("Liste aller Personen");
            foreach (Person p in pool.getPersonen())
            {
                WriteLine(p.persNr + " - " + p.name + " - " + p.vorname);
            }

            WriteLine("*** \n Person mit unbekannter Nummer ");
            Person per = pool.getPerson("0815");
            if (per == null)
            {
                WriteLine("Person gibt es nicht");
            }
            WriteLine("*** \n Person mit Nummer 0234 ");
            per = pool.getPerson("0234");
            WriteLine(per.persNr + " - " + per.name + " - " + per.vorname);
     
            WriteLine("*** \n Alle Personen, deren Nachname mit h beginnt");
            foreach (Person p in pool.getPersonen('h'))
            {
                WriteLine(p.persNr + " - " + p.name + " - " + p.vorname);
            }

            WriteLine("***\nAusgabe aller Sprachen");
            foreach (String s in pool.getSprachen())
            {
                WriteLine(s);
            }

            WriteLine("*** \n Ausgabe aller Sprachen für Person 0105");
            foreach (Sprachen s in pool.getSprachen("01015").Distinct(new Vergleich()))
            {
                WriteLine(s.sprache);
            }
            WriteLine("***\nAusgabe Grad, den Nummer 0325 in fr spricht");
            int? grad = pool.getGrad("0325", "französisch");
            if (grad != null)
            {
                WriteLine(grad);
            }
            else
            {
                WriteLine("Diese Kombi gibt es nicht");
            }

            WriteLine("***\nDurchschnittl. Grad für fr");
            double? avg = pool.getAvgGrad("französisch");
            if (avg != null)
            {
                WriteLine(avg);
            }
            else
            {
                WriteLine("Diese Sprache wird nicht gesprochen");
            }
            WriteLine("***\n Gesamtübersicht");
            foreach (Person p in pool.getGesamt())
            {
                WriteLine(p.persNr + " - " + p.name + " - " + p.vorname);
                foreach (Sprachen s in p.sprachen)
                {
                    WriteLine("\t" + s.sprache + " - " + s.grad);
                }
            }
            

            //pool.einfügen(new Person { persNr = "0815", name = "Walter", vorname = "Otto" });

            //pool.einfügen("0815", "mandarin", 2);

            //pool.aktualisieren(new Person { persNr = "0815", name = "Heinrich", vorname = "Otto" });

            // pool.aktualisieren("0815", "mandarin", 3);


            pool.loeschen(new Person { persNr = "0815" });

            ReadLine();
        }

        class Vergleich : IEqualityComparer<Sprachen>
        {
            public bool Equals(Sprachen x, Sprachen y)
            {
                return x.sprache == y.sprache;
            }

            public int GetHashCode(Sprachen obj)
            {
                return obj.sprache.Length;
            }
        }
    }
}
