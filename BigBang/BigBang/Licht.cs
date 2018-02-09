using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BigBang
{
    class Licht : Element
    {
        public void einschalten()
        {
            WriteLine("Licht an");
        }

        public void ausschalten()
        {
            WriteLine("Licht aus");
        }
    }
}
