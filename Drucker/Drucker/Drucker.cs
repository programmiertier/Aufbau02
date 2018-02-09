using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Drucker
{
    class Drucker
    {

        public Queue<Druckauftrag> pool { get; private set; }

        public int gesamtzeit { get; private set; }

        // Die Ressource Pool wird von anderen Objekten anderer Klassen genutzt
        // daher wird die erzeugte Instanz von Pool dem Konstruktor übergeben
        // nach dem Motto: ich gebe dem Drucker eine Warteschlange mit!
        public Drucker(Queue<Druckauftrag> poolhier)
        {
            pool = poolhier;
            gesamtzeit = 0;
        }

        // Methode geht evtl weg, weil das hinzufügen jemand anderes macht
        public void hinzufügen(Druckauftrag druckauf)
        {
            // es wird mit der gemeinsamen Ressource gearbeitet
            pool.Enqueue(druckauf);
        }

        public void drucken()
        {
            Druckauftrag a = null;
            // es wird mit der gemeinsamen Ressource gearbeiten
            // lock (pool)
            // {
                while (pool.Count > 0)
                {
                    // ein Auftrag wird der gemeinsamen Ressource entnommen
                    a = pool.Dequeue();
                    WriteLine("Drucke " + a.beschreibung);
                    gesamtzeit += a.zeit;

                    // etwas warten, bevor die Bedinung der Schleife erneut geprüft wird
                    Thread.Sleep(1000);
                }
            // }
        }
    }
}
