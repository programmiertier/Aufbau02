using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BigBang
{
    class Spinne : Element
    {
        public void ausschalten()
        {
            WriteLine("Die Spinne rennt rum, wenns dunkel is");
        }

        public void einschalten()
        {
            WriteLine("Die Spinne bleibt stehen");
        }
    }
}
