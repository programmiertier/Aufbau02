using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Teich
{
    public class Frosch
    {
        private static string _quak = "quak quak";

        public string name { get; private set; }
        private int beine = 2;
        public int maxalter { get; private set; }
        public int alter { get; private set; }
        public ehunger hunger { get; private set; }
        public enum ehunger
        {
            satt, hungrig
        }


        public Frosch(string name, int maxalter, int alter, ehunger hunger)
        {
            this.name = name;
            this.maxalter = maxalter;
            this.alter = alter;
            this.hunger = hunger;
            sagWas();
        }

        public string feiernGeburtstag()
        {
            // double aelterwerden = alter++;
            if (this.alter == maxalter)
            {
                return "ich bin tot";
            }
            else
            {
                this.alter++;
                return "Yay, ein Jahr älter";
            }
        }

        public string huepfen(double strecke)
        {
            // pro 100m 1g weniger
            return "Ich bin " + strecke + " gehüpft";
        }

        public static String sagWas()
        {
            return _quak;
        }

        public String geheFuttern(Fliege welche)
        {
            String result = welche.wirdGefuttert();
            return "Auftrag ausgeführt. Fliege " + result + "ist gegessen";
        }


    }
}
