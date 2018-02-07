using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drucker
{
    class Druckauftrag
    {
        public String beschreibung { get; private set; }

        public int zeit { get; private set; }

        public Druckauftrag() { }

        public Druckauftrag(String bez, int zei)
        {
            beschreibung = bez;
            zeit = zei;
        }

    }
}
