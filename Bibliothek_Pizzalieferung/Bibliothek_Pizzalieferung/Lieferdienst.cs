using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek_Pizzalieferung
{
    public class Lieferdienst
    {
        private List<Pizza> Bestellungen { get; set; }

        public void bestellen(Pizza p)
        {
            Bestellungen.Add(p);
        }

        public Pizza[] getAlle()
        {
            return Bestellungen.ToArray();
        }
    }
}
