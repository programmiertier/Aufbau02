using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedia_Console
{
    public abstract class Klingelton : Produkt
    {
        private String titel;
        private String interpret;

        public String getTitel() { return titel; }
        public void setTitel(string titel) { this.titel = titel; }

        public String getInterpret() { return titel; }
        public void setInterpret(string interpret) { this.interpret = interpret; }

        public float geteffektiverPreis()
        {
            float effektiverPreis = 0.0f;
            // effektiverPreis = this.preis * 0.9f;
            // bei gelockertem Zugriffschutz protected
            effektiverPreis = this.getPreis() * 0.9f;
            return effektiverPreis;
        }
    }
}
