using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BieneDLL
{
    public class Blume
    {
        public String farbe { get; private set; }
        public String art { get; private set; }

        public Blume(String farbe, String art)
        {
            this.farbe = farbe;
            this.art = art;
        }

        // diese Methode darf nur von der Biene aufgerufen werden
        // internal heißt, Zugriff nur innerhalb der gleichen dll
        internal String bestaeuben()
        {
            return "Die Biene war da";
        }
    }
}
