using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bücherliste
{
    // das ist eine Klasse für einen alternativen Vergleich
    // Die Klasse implementiert das generische Interface IComparer
    // als Typ wird Buch verwandt
    class BuchVergleich : IComparer<Buch>
    {
        public int Compare(Buch x, Buch y)
        {
            return x.preis.CompareTo(y.preis);
        }
    }
}
