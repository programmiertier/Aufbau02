using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bücherliste
{
    class Buch
    {
        public String autor { get; private set; }
        public String titel { get; private set; }
        public int auflage { get; private set; }
        public double preis { get; private set; }


        public Buch(String autor, String titel, int auflage, double preis)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = auflage;
            this.preis = preis;
        }

        // gleicher Autor, gleicher Titel -- Die Bücher sind identisch
        public override bool Equals(object obj)
        {
            if (obj is Buch)
            {
                Buch vgl = (Buch)obj;
                if(this.autor == vgl.autor && this.titel == vgl.titel)
                {
                    return true;
                }
            }
            return false;
        }

        // gleicher Autor -- die Bücher könnten identisch sein
        public override int GetHashCode()
        {
            return this.autor.Length;
        }

        public override string ToString()
        {
            return this.autor + " | " + this.titel + " | " + this.auflage + " | " + this.preis;
        }
    }
}
