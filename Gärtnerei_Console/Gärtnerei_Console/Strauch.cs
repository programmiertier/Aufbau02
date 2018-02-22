using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei_Console
{
    public class Strauch : Gehoelz
    {
        private bool istGiftig;

        public bool getIstGiftig() { return istGiftig; }
        public void setIstGiftig(bool istGiftig) { this.istGiftig = istGiftig; }

        public Strauch () { }

        public Strauch(String art, int pflanzjahr, float preis, bool istGiftig) :
                        base(art, pflanzjahr, preis)
        {
            this.istGiftig = istGiftig;
        }

        public override string getInfo()
        {
            String info = base.getInfo() + "\t|Ist giftig:\t" + istGiftig;
            return info;
        }
    }
}
