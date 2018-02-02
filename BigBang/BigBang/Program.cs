using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BigBang
{
    class Program
    {
        static void Main(string[] args)
        {
            Schalter button = new Schalter();
            button.hinzufügen(new Licht());
            button.hinzufügen(new Spinne());
            button.ein();
            button.aus();
            WriteLine("-----");
            ReadLine();

            DelSchalter otherButton = new DelSchalter();
            // Methoden hinzufügen, die beim Einschlaten ausgeführt werden sollen
            // Wichtig: Die Methode, die ich hinzufüge, muss die beim Delegaten hinterlgete Deklaration erfüllen
            // Die Methode einschalten ist nur vorhaden für Objekte der Klasse Licht, daher
            // Hier erst einmal eine Instanz der Klasse bilden und dann dort den Methodennamen angeben
            Licht meinLicht = new Licht();
            otherButton.methodEin += meinLicht.einschalten;
            Spinne spinne = new Spinne();
            otherButton.methodEin += spinne.einschalten;

            // ich kann jede Methode hinzufügen, diese muss nicht in einer bestimmten Klasse stehen
            // es kann sich um Objektmethoden oder auch Klassenmethoden handeln
            otherButton.methodEin += tanzen;

            // man kann auch mit lambda expressions arbeiten
            // in der Klasse List<> ist bei FindAll hinterlegt, ein Delegate --> es ist eine Methode
            // die ein Objekt entgegen nimmt (a) und einen bool-Wert zurück gibt (Vergleich: nummer)
            // liste.FindAll(a => a.ArtNr == nummer (Aus der Artikelliste vom 01.02.2018)


            // wir brauchen keine Methode mehr zu definieren in Klassen, sondern erstellen diese on-the-fly und weisen gleich zu
            // () -- ist der Übergabeparameter (der Delegate sein, es gibt keine)
            // => hier steht, was gemacht werden soll (Der Dlegate sagt void)

            otherButton.methodEin += () => WriteLine("Es regnet Blut!");

            // wenn mehrere Methoden ausgeführt werden sollen, werden diese mit += zusammengefasst
            otherButton.methodAus += meinLicht.ausschalten;
            otherButton.methodAus += spinne.ausschalten;

            otherButton.methodEin();
            otherButton.methodAus();
            WriteLine("-----");
            ReadLine();

            WriteLine("-----");
            ReadLine();
        }

        public static void tanzen()
        {
            WriteLine("peinliches tanzen hier einsetzen");
        }
    }
}
