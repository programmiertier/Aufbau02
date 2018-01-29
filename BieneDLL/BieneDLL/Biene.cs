using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BieneDLL
{
    public class Biene
    {
        // Klasseneigenschaft
        private static string _farbe = "gelb-schwarz gestreift";

        // Objekteigenschaften = properties
        // schreibender Zugriff: private        lesender Zugriff: öffentlich
        public int alter { get; private set; }
        public double gewicht { get; private set; }
        public egeschlecht geschlecht { get; private set; }

        // für die schleife
        public int blumenzahl;

        // Konstruktor
        public Biene() { }
        public Biene(int alter, double gewicht, egeschlecht was)
        {
            this.alter = alter;
            this.gewicht = gewicht;
            this.geschlecht = was;

            getFarbe();
        }

        // die Methoden zum ändern der Objekteigenschaften
        // wenn eine Biene Geburtstag hat, dann wird sie genau ein Jahr älter
        public void feiernGeburtstag()
        {
            this.alter++;
        }

        // fliegen ändert das Gewicht
        public string fliegen(double strecke)
        {
            // pro 100m 1g weniger
            double aenderung = strecke / 100;   // 1km wären 10g weniger
            if (this.gewicht >= aenderung)
            {
                this.gewicht -= aenderung;
                return "Ich hab es geschafft";
            }
            else
            {
                return "Das wird nix";
            }
        }

        // futtern ändert auch das Gewicht
        public string futtern(double gramm)
        {
            // jedes Gramm Honig, führt dazu, dass sie 0,5g zunimmt
            double aenderung = gramm / 2;
            this.gewicht += aenderung;
            return "Jetzt bin ich satt, ich rolle in meine Wabe";
        }

        // Geschlechtsumwandlung
        public string umwandlungGeschlecht()
        {
            // es wird immer das Gegenteil vom aktuellen Geschlecht
            if (this.geschlecht == egeschlecht.maennlich)
            {
                this.geschlecht = egeschlecht.weiblich;
                return "Nun bin ich weiblich";
            }
            else
            {
                this.geschlecht = egeschlecht.maennlich;
                return "Nun bin ich männlich";
            }
        }

        // Klassenmethode
        public static String getFarbe()
        {
            return _farbe;
        }

        // für das Geschlecht eine Auflistung möglicher Werte
        public enum egeschlecht
        {
            maennlich, weiblich
        }

        // Biene soll Blume bestäuben
        public String gehbestaeuben(Blume welche)
        {
            String result = welche.bestaeuben();
            return "Auftrag ausgeführt.Blume sagt:" + result;
        }

        public override string ToString()
        {
            return alter + "|" + gewicht + "|" + geschlecht + "|" + _farbe;
        }

        // aus der Oberklasse für den Verlgiech von Objekten
        // wir überschreiben die Basisimplementierung
        public override bool Equals(object obj)
        {
            // ACHTUNG: casting ohne Prüfung!
            Biene vergleich = (Biene)obj;

            WriteLine(this);
            WriteLine(vergleich);
            if (this.alter == vergleich.alter && this.geschlecht == vergleich.geschlecht)
            {
                WriteLine("RICHTIG");
                return true;
            }
            return false;
        }

        // wenn Equals überschrieben wird, sollte auch HashCode überschrieben werden
        // darauf achten, dass hier Eigenschaften verändert werden, die nicht verändert werden
        // bei der Biene... wird das Geschlecht aber verändert... mah
        public override int GetHashCode()
        {
            if (this.geschlecht == egeschlecht.weiblich)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Für Demonstration für Dereferenzierung
        public void kaempfen(Biene opfer)
        {
            // opfer ist eine Referenz die auf nix zeigt
            // Wir haben eine Leiche im RAM
            opfer = null;
        }
    }
}
