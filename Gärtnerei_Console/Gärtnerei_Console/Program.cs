using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gärtnerei_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Strauch lia = new Strauch("Urwaldliane", 1922, 32, true);

            Console.WriteLine(lia.getInfo());
            Console.ReadLine();
        }
    }
}
