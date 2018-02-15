using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek_Pizzalieferung
{
    public class Pizza
    {
        /* public enum Größe
        {
            KLEIN, MITTEL, GROß
        }   */

        public String size { get; set; }
        // public Größe Size { get; set; }
        public List<String> belag { get; set; }
        public bool fertig { get; set; }

    }
}