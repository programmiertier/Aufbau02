using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei_Console
{
    public class Liane : Gehoelz
    {
        public Liane() { }

        public Liane(String art, int pflanzjahr, float preis) : 
                    base (art, pflanzjahr, preis)
        {

        }

        public override String getInfo()
        {
            return base.getInfo();
        }
    }
}
