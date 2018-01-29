using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Teich
{
    public class Fliege
    {
        public string name { get; private set; }
        private int _beine = 6;
        private int _fluegel = 2;
        public bool lebendig { get; private set; }

        public Fliege(int beine, int fluegel)
        {
            this._beine = beine;
            this._fluegel = fluegel;
            this.lebendig = true;
        }

        internal void wirdGefuttert()
        {
            this.lebendig = false;
        }
    }
}
