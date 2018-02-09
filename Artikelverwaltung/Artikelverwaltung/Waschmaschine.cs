using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung
{
    class Waschmaschine : Artikel
    {
        public Waschmaschine (String bezeichnung, double preis, int menge)
            : base (bezeichnung, preis, menge)
        {

        }
    }
}
