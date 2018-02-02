using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagelöhner
{
    class Praktikant
    {
        public String name { get; private set; }
        public int moral { get; private set; }

        public Praktikant(String name, int moral)
        {
            this.name = name;
            this.moral = moral;
        }
    }
}
