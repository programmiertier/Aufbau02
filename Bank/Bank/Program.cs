using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bank
{
    class Program
    {
        static Schließfach[] fächer = new Schließfach[] { new Schließfach(), new Schließfach(), new Schließfach(), new Schließfach() };

        static void Main(string[] args)
        {
            start();

        }

        public static void start()
        {
            char taste;
            do
            {
                WriteLine("[1] Kunde betritt Bank\n[2] Beenden\n-----");

                taste = ReadKey().KeyChar;
                WriteLine();

                switch (taste)
                {
                    case '1':
                        bedienenKunden();
                        break;
                    case '2':
                        break;
                    default:
                        continue;
                }
            }
            while (taste != '2');
        }

        private static void bedienenKunden()
        {
            char taste;
            do
            {
                WriteLine("[1] Fach mieten\n[2] Fach öffnen\n[3] Fach zurückgeben\n[4] Zurück");
                taste = ReadKey().KeyChar;
                WriteLine();

                switch (taste)
                {
                    case '1':
                        Schließfach frei = fächer.ToList().Find(fach => fach.belegt == false);
                        if (frei != null)
                        {
                            WriteLine("Sie erhalten das Fach " + frei.nummer);
                            frei.belegt = true;
                            String eingabe = "";
                            WriteLine("Reinlegen Inhalt? Leerzeile für Abbruch\n");
                            do
                            {
                                eingabe = ReadLine();
                                if (eingabe.Length != 0)
                                    frei.inhalt.Add(eingabe);
                            }
                            while (eingabe.Length != 0);
                        }
                        else
                        {
                            WriteLine("\nKeine Fächer mehr frei");
                        }
                        break;
                    case '3':
                        foreach (Schließfach fach in fächer)
                        {
                            if (fach.belegt)
                            {
                                WriteLine("\nFach Nummer " + fach.nummer + " ist belegt");
                            }
                        }
                        bool gefunden = false;

                        do
                        {
                            WriteLine("Welches soll freigegeben werden?\n");
                            int nummer = Convert.ToInt32(ReadLine());
                            Schließfach fach = fächer.ToList().Find(f => f.nummer == nummer);
                            if (fach != null)
                            {
                                fach.belegt = false;
                                fach.inhalt.Clear();
                                gefunden = true;
                            }
                        }
                        while (gefunden == false);
                        break;

                    case '2':
                        foreach (Schließfach fach in fächer)
                        {
                            if (fach.belegt)
                            {
                                WriteLine(fach.nummer + ". Fach\n");
                            }
                        }
                        bool vorhanden = false;

                        do
                        {
                            WriteLine("Welches soll geöffnet werden?");
                            int nummer = Convert.ToInt32(ReadLine());
                            Schließfach fach = fächer.ToList().Find(f => f.nummer == nummer);
                            if (fach != null)
                            {
                                foreach (String inhalt in fach.inhalt)
                                {
                                    WriteLine(inhalt);
                                }
                                vorhanden = true;
                            }
                        }
                        while (vorhanden == false);

                        break;
                }
            }
            while (taste != '4');
        }
    }
}
