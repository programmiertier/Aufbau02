using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek_Pizzalieferung
{
    public class Lieferdienst
    {
        private List<Pizza> bestellungen = new List<Pizza>();

        public void bestellen(Pizza p)
        {
            bestellungen.Add(p);
        }

        public Pizza[] getAlle()
        {
            return bestellungen.ToArray();
        }
    }
}
