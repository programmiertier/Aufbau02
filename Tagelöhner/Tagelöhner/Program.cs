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

            ReadLine();
        }
    }
}
