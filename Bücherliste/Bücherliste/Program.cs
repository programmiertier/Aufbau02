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
            liste.Add(new Buch("Berta", "da schau her", 33000, 77.99));
            liste.Add(new Buch("Dora", "da", 16000, 38.99));
            liste.Add(new Buch("Gustav", "schau her", 20000, 39.99));
            liste.Add(new Buch("Unicorn", "schau", 17000, 99.99));

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
            // Sortieren der Liste
            // Achtung InvalidOperationException
            // Objekte auf der Liste bzw deren Klasse muss das Interface IComparable implementieren
            // Interface hat Methode CompareTo, die von Sort() verwandt wird
            // Sort() verlangt eine Liste mit Objekten vom Typ IComparable
            liste.Sort();
            foreach(Buch b in liste)
            {
                WriteLine(b);
            }
            WriteLine("-----");
            ReadLine();

            // Die Methode Sort() hat eine Überladung
            // Parameter: Objekt vom Typ IComparer<>

            // zeigt Liste aufsteigend an... wenn absteigend, x und y tauschen
            liste.Sort(new BuchVergleich());
            foreach (Buch b in liste)
            {
                WriteLine(b);
            }
            WriteLine("***");
            ReadLine();

            // alle Bücher, deren Preis größer 34.99 ist
            foreach (Buch b in liste)
            {
                if (b.preis > 34.99)
                {
                    WriteLine(b);
                }
            }
            WriteLine("-----");
            ReadLine();

            foreach (Buch bu in liste.FindAll(b => b.preis > 34.99))
            {
                WriteLine(bu);
            }
            WriteLine("-----");
            ReadLine();

            // Binäre Suche nach einem Buch
            // Verlgeich auf Gleichheit mit Equals
            // Wichtig! bei Verwendung von BinarySearch vorher soriteren

            // wenn Gleichheit bei Autor, dann Sortieren aufsteigend nach Autor
            liste.Sort();
            int index = liste.BinarySearch(new Buch("Unicorn", "schau", 17000, 99.99));

            WriteLine(index);
            WriteLine("-----");
            ReadLine();
        }
    }
}
