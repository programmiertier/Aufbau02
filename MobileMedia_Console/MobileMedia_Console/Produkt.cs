using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedia_Console
{
    public abstract class Produkt
    {
        private int produktnummer;
        private float preis;
        private float dateigröße;

        public int getProduktnummer() { return produktnummer; }
        public void setProduktnummer(int produkt) { this.produktnummer = produkt; }

        public float getPreis() { return preis; }
        public void setPreis(float preis) { this.preis = preis; }

        public float getDategröße() { return dateigröße; }
        public void setDateigröße(float dateigröße) { this.dateigröße = dateigröße; }
    }
}
