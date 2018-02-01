using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung
{
    abstract class Artikel
    {
        private static int anzahl = 0;
        public int artNr { get; private set; }
        public String bezeichnung { get; private set; }
        public double preis { get; private set; }
        public int menge { get; private set; }


        public Artikel(String bezeichnung, double preis, int menge)
        {
            this.artNr = anzahl++;
            this.bezeichnung = bezeichnung;
            this.preis = preis;
            this.menge = menge;
        }

        public override String ToString()
        {
            return artNr + " | " + bezeichnung + " | " + preis + " | " + menge;
        }
    }
}
