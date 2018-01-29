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
            // mehrere Bienen in einem Programm
            // Array
            Biene[] bienen = new Biene[3];
            Biene b1 = new Biene(1, 15, Biene.egeschlecht.weiblich);
            // bienen[0] = b1;

            // Vorteil ich habe zwei Zugriffspunkte für Arbeit mit b1
            // b1.feiernGeburtstag();
            // bienen[0].feiernGeburtstag();

            bienen[0] = new Biene(1, 15, Biene.egeschlecht.weiblich);
            bienen[1] = new Biene(2, 10, Biene.egeschlecht.maennlich);
            bienen[2] = new Biene(6, 25, Biene.egeschlecht.weiblich);

            for (int zaehl = 0; zaehl < bienen.Length; zaehl++)
            {
                WriteLine(bienen[zaehl]);
            }
            ReadLine();
            WriteLine("-----");

            foreach (Biene b in bienen)
            {
                WriteLine(b);
            }
            ReadLine();
            WriteLine("-----");

            for (int zaehl = 0; zaehl < bienen.Length; zaehl++)
            {
                WriteLine("Blumenzahl vor Änderung " + bienen[zaehl].blumenzahl);
                bienen[zaehl].blumenzahl = 42;
            }

            // Blumenanzahl hat sich dauerhaft geändert
            for (int zaehl = 0; zaehl < bienen.Length; zaehl++)
            {
                WriteLine("Blumenzahl nach der Änderung "+ bienen[zaehl].blumenzahl);
            }
            WriteLine("-----");

            ReadLine();
            WriteLine("-----");
            foreach (Biene b in bienen)
            {
                WriteLine("Blumenzahl vor Änderung " + b.blumenzahl);
                b.blumenzahl = 666;
            }

            foreach (Biene b in bienen)
            {
                WriteLine("Blumenzahl nach Änderung " + b.blumenzahl);
            }
            ReadLine();
            WriteLine("-----");
            for (int zaehl = 0; zaehl < bienen.Length; zaehl++)
            {
                WriteLine("Vor Änderung" + bienen[zaehl]);
                bienen[zaehl] = new Biene(42, 666, Biene.egeschlecht.maennlich);
            }
            for (int zaehl = 0; zaehl < bienen.Length; zaehl++)
            {
                WriteLine("nach Änderung" + bienen[zaehl]);
            }
            ReadLine();
            WriteLine("-----");
            
            foreach (Biene b in bienen)
            {
                // Fehler, keine Neureferenzierung möglich in der foreach!
                // foreach nur für Ausgabe gedacht
                //   b = new Biene(666, 42, Biene.egeschlecht.weiblich);
            }

            // Diese Biene kämpft gegen andere
            Biene ninja = new Biene(3, 20, Biene.egeschlecht.weiblich);
            
            Biene maja = new Biene(2, 15, Biene.egeschlecht.weiblich);
            // Achtung! call-by-value VS call-by-reference
            ninja.kaempfen(maja);

            
            if (maja == null)
            {
                WriteLine("Maja ist tot");
            }
            else
            {
                WriteLine("Lang lebe Maja");
            }

                ReadLine();
        }
    }
}
