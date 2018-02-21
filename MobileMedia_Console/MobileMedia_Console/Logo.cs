using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedia_Console
{
    public class Logo : Produkt
    {
        public String name;
        public bool art;

        public String getName() { return name; }
        public void setName(string name) { this.name = name; }

        public bool getArt() { return art; }
        public void setArt(bool art) { this.art = art; }

    }
}
