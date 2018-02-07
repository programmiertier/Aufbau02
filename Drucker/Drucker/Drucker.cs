using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Drucker
{
    class Drucker
    {

        public Queue<Druckauftrag> auftrag { get; private set; }

        public int gesamtzeit { get; private set; }

        public void hinzufügen(Druckauftrag druckauf)
        {
            auftrag.Enqueue(druckauf);
        }

        public Drucker()
        {
            auftrag = new Queue<Druckauftrag>();
            gesamtzeit = 0;
        }

        public void drucken()
        {
            Druckauftrag a = null;
            while (auftrag.Count > 0)
            {
                a = auftrag.Dequeue();
                WriteLine("Drucke " + a.beschreibung);
                gesamtzeit += a.zeit;
            }
            
        }

    }
}
