using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bücherliste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Buch> liste = new List<Buch>();
            liste.Add(new Buch("Zulu", "Was ist das denn", 10000, 40));
            liste.Add(new Buch("Alpha", "da schau her", 6000, 25.99));
            liste.Add(new Buch("Oskar", "jajaja", 12000, 52.99));

            // ausgabe aller Bücher auf der Liste
            for (int zaehl = 0; zaehl < liste.Count; zaehl++)
            {
                WriteLine(liste[zaehl]);
            }

            WriteLine("-----");
            ReadLine();

            foreach (Buch b in liste)
            {
                WriteLine(b);
            }
            WriteLine("-----");
            ReadLine();
            WriteLine("Anzahl vor Remove:" + liste.Count);
            WriteLine("-----");
            ReadLine();

            // In jeder Runde muss neu bestimmt werden, wie viele Elemente auf der Liste sind
            // d.h. wie oft die Schleife ausgeführt werden soll
            // da beim Löschen ein Element verschwindet und sich die Größe der Liste ändert. Deswegen: liste.Count und nicht eine feste Zahl
            /* for (int zaehl = 0; zaehl < liste.Count; zaehl++)
            {
                if(liste[zaehl].auflage < 10000)
                {
                    liste.Remove(liste[zaehl]);
                }
            }

            WriteLine("Anzahl nach Remove:" + liste.Count);
            WriteLine("-----");
            ReadLine(); */

            /* wird nicht funktionieren!
            // es ist nur zur Ausgabe, Suchen und Ausgaben, Änderungen nur bei den Objekten auf der Liste
            // nicht die Liste an sich ändern!
            foreach (Buch b in liste)
            {
                if (b.auflage < 10000)
                {
                    liste.Remove(b);    // Bauchklatscher   // InvalidOperationException
                }
            }
            WriteLine("Anzahl nach Remove:" + liste.Count);
            WriteLine("-----");
            ReadLine(); */

            // für jedes Buch muss die Bedingung gelten, damit b.auflage < 1000 entfernt wird

            liste.RemoveAll(b => b.auflage < 10000);
            WriteLine("Anzahl nach Remove:" + liste.Count);
            WriteLine("-----");
            ReadLine();
        }
    }
}
