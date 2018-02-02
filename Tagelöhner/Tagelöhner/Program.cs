using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tagelöhner
{
    class Program
    {
        static void Main(string[] args)
        {
            Tagelöhner ole = new Tagelöhner();
            // Obacht! es werden alle Methoden ausgeführt, aber nur von der letzten Methode
            // wird der Rückgabewert angezeigt... es wird nicht addiert
            ole.was += new Bäcker().backenBrot;
            ole.was += new Dachdecker().dachDecken;

            // 11.50 * 5 = 57.50 backen
            // 12.45 * 5 = 62.25
            // ole macht beide Aufgaben -- 5 Stunden Brot backen und dann 5 Stunden Dach decken
            WriteLine("Insgesamt verdient: " + ole.arbeiten(5));

            ole.was = Aufgaben.kellnern;
            WriteLine("Nach Kellnern" + ole.arbeiten(3));

            ole.was = Aufgaben.bauenTrojaner;
            WriteLine("Trojaner bauen: " + ole.arbeiten(10));

            // wenn ich keine Klasse mit einer Methode habe und auch keine Klasse basteln möchte
            ole.was = (zahl) => zahl * 9.50;

            ReadLine();
            Bäcker b = new Bäcker();
            b.urteilen = beurteilen;
            Praktikant ronny = new Praktikant("Ronny", 65);
            WriteLine(b.urteilen(ronny, "Ofen putzen"));
            ReadLine();

            // in den () Variablenbezeichnungen für die Übergabeparameter
            // Dürchen NICHT im Programm anderweitig verwandt auftauchen
            b.urteilen = (p, was) => (p.moral > 100)?p.name + " hat " + was + " ganz toll gemacht":p.name + " hat " + was + " nicht so gut gemacht";
            WriteLine(b.urteilen(ronny, "Verkaufen"));
            ReadLine();
        }

        // für die Beurteilung
        // methode muss für Delegate Urteil geschaffen sein
        static String beurteilen(Praktikant p, String was)
        {
            if (p.moral < 70)
            {
                return p.name + " hat Aufgabe: " + was + " nicht erfüllt";
            }
            return p.name + " hat Aufgabe: " + was + " zur Zufriedenheit erfüllt";
        }
    }
}
