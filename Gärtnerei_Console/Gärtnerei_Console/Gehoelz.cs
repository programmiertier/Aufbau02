using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei_Console
{
    public abstract class Gehoelz
    {
        private String art;
        private int pflanzjahr;
        private float preis;

        public String getArt() { return art; }
        public void setArt(String art) { this.art = art; }

        public int getPflanzjahr() { return pflanzjahr; }
        public void setPflanzjahr(int pflanzjahr) { this.pflanzjahr = pflanzjahr; }

        public float getPreis() { return preis; }
        public void setPreis(float preis) { this.preis = preis; }

        public Gehoelz() { }

        public Gehoelz (String art, int pflanzjahr, float preis)
        {
            this.art = art;
            this.pflanzjahr = pflanzjahr;
            this.preis = preis;
        }

        public virtual String getInfo()
        {
            String info = "Art:\t" + art + "|\tPflanzjahr:\t" + pflanzjahr + "|\tPreis:\t" + preis;
            return info;
        }
    }
}
