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
    }
}
