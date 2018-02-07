using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Drucker
{
    class Variante01
    {
        // eine Variable, auf die mehrere Methoden zugreifen werden!
        bool isOver = false;

        // wir geben Druckaufträge ein, bis eine Zeitspanne abgelaufen ist
        // Eingabe eines Druckauftrags entspricht einer Arbeit, die gemacht wird
        // Der Ablauf einer Zeitspanne entspricht dem Ende des Arbeitstages
        public void thread01()
        {
            String zeile;
            do
            {
                // steht für die Arbeitsaufgabe, die wiederholt gemacht werden soll
                zeile = ReadLine();
            }
            // während nicht over
            while (!isOver);        // wann isOver == true ist, bestimmt Chef nicht Arbeiter
            WriteLine("Is Over");
        }

        // zum Thread gehörend: eine Methode, die bestimmt, wann isOver den Wert ändert

        public void thread01_clock()
        {
            // wir simulieren eine Zeitverzögerung, indem wir eine Uhr implementieren
            // wir lassen eine zufällige Zeitspanne generieren (in sec)
            Random rnd = new Random();
                            // zwischen 5 und 25
            int zufall = rnd.Next(5, 25);

            // für die Zeitspanne wird nun sekundenweise auf 0 heruntergezählt
            for (int zaehl = zufall; zaehl > 0; zaehl--)
            {
                // wir warten eine sec, bevor wir i-- machen
                Thread.Sleep(1000);         // 1000 millisek = 1sek
            }
            isOver = true;
        }
    }
}
