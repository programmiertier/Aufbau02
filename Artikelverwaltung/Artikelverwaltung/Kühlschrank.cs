using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung
{
    class Kühlschrank : Artikel
    {
        public Kühlschrank(String bezeichnung, double preis, int menge)
            : base (bezeichnung, preis, menge)
        {

        }
    }
}
