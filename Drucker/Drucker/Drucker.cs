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

        public Queue<Druckauftrag> pool { get; private set; }

        public int gesamtzeit { get; private set; }

        public void hinzufügen(Druckauftrag druckauf)
        {
            pool.Enqueue(druckauf);
        }

        public Drucker()
        {
            pool = new Queue<Druckauftrag>();
            gesamtzeit = 0;
        }

        public void drucken()
        {
            Druckauftrag a = null;
            while (pool.Count > 0)
            {
                a = pool.Dequeue();
                WriteLine("Drucke " + a.beschreibung);
                gesamtzeit += a.zeit;
            }
            
        }

    }
}
