using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek_Pizzalieferung
{
    public class Pizza
    {
        public enum Größe
        {
            KLEIN, MITTEL, GROß
        }


        public Größe Size { get; set; }
        public List<String> Belag { get; set; }

    }
}