using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Drucker
{
    // eine Klasse, die Druckaufträge erstellt und dem Pool von Aufträgen für den Drucker hinzufügt
    // das ist der Arbeitgeber!
    class Variante02
    {
        public Queue<Druckauftrag> pool { get; private set; }

        public Variante02(Queue<Druckauftrag> poolhier)
        {
            pool = poolhier;
        }

        // die in einem eigenen Thread auszuführende Methode

        public void generierenAufträge()
        {
            // es sollen 20 Aufträge generiert werden
            for (int zaehl = 0; zaehl < 20; zaehl++)
            {
                pool.Enqueue(new Druckauftrag("Eimer", 45));
                // nach jedem generierten Auftrag warten
                // Testausgabe, damit wir sehen, wann welcher Thread etwas macht
                WriteLine ("ein neuer Auftrag für den Drucker");
                Thread.Sleep(800);
            }
        }
    }
}
