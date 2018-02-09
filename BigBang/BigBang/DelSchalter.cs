using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBang
{
    // der Delegate definiert, wie eine Methode aufgebaut sein muss
    // DelEin ist der Name des Delegaten (Wie eine Klassenbezeichnung)
    // Es ist nicht der Name einer Methode!
    delegate void DelEin();
    delegate void DelAus();
    class DelSchalter
    {
        // eine Methode, die ausgeführt wird, wenn das Licht eingeschlatet wird
        public DelEin methodEin = null;
        public DelAus methodAus = null;
        public void ein()
        {
            // Hier wird die Methode ausgeführt!
            if (methodEin != null)
                methodEin();
        }

        public void aus()
        {
            if (methodAus != null)
                methodAus();
        }
    }
}
