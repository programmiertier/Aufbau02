using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BigBang
{
    class Program
    {
        static void Main(string[] args)
        {
            Schalter button = new Schalter();
            button.hinzufügen(new Licht());
            button.hinzufügen(new Spinne());
            button.ein();

            button.aus();

            ReadLine();
        }
    }
}
