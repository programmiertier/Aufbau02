using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei_Console
{
    public class Baum : Gehoelz
    {
        private int maxHoehe;

        public int getMaxhoehe() { return maxHoehe; }
        public void setMaxhoehe(int maxHoehe) { this.maxHoehe = maxHoehe; }

        public Baum(String art, int pflanzjahr, float preis, int maxHoehe) : base (art, pflanzjahr, preis)
        {
            this.maxHoehe = maxHoehe;
        }

        public override string getInfo()
        {
            String info = base.getInfo() + "\t|Maxhoehe:\t" + maxHoehe;

            return info;
        }


    }
}
