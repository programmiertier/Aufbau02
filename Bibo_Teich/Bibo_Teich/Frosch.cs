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
        public const int beine = 2;
        public int maxalter { get; private set; }
        public int alter { get; private set; }
        public bool lebendig { get; private set; }
        public ehunger hunger { get; private set; }
        public bool hungrig { get; private set; }
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
            this.lebendig = true;
            sagWas();
        }

        public Frosch(string name, int alter, int maxalter)
        {
            this.name = name;
            this.maxalter = maxalter;
            this.alter = alter;
            this.lebendig = true;
            sagWas();
        }

        public string feiernGeburtstag()
        {
            this.alter++;
            if (this.alter == maxalter)
            {
                this.lebendig = false;
                return "ich bin tot";
            }
            else
            {
                return "Yay, ein Jahr älter";
            }
        }

        public string huepfen(double strecke)
        {
            
            return "Ich bin " + strecke + " gehüpft";
        }

        public static String sagWas()
        {
            return _quak;
        }


        public String geheFuttern(Fliege welche)
        {
            welche.wirdGefuttert();
            welche = null;
            this.hungrig = false;
            return "Fliege vertilgt";
        }

        public override int GetHashCode()
        {
            return this.name.Length;
        }

        public override bool Equals(object obj)
        {
            if (obj is Frosch)
            {
                Frosch vergleich = (Frosch)obj;
                if (this.alter == vergleich.alter && this.maxalter == vergleich.maxalter)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void getoetet(ref Fliege opfer)
        {
            // opfer ist eine Referenz die auf nix zeigt
            // Wir haben eine Leiche im RAM
            opfer = null;
        }


    }
}
