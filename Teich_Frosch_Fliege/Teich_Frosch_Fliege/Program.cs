using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibo_Teich;
using static System.Console;

namespace Teich_Frosch_Fliege
{
    class Program
    {
        static void Main(string[] args)
        {
            Frosch quakl = new Frosch("quakl", 5, 3, Frosch.ehunger.satt);
            Fliege summ = new Fliege("summ");
            
            WriteLine(quakl.maxalter);
            WriteLine(quakl.alter);
            WriteLine(quakl.hunger);
            quakl.feiernGeburtstag();
            WriteLine(quakl.alter);
            


            String result = quakl.huepfen(299);
            WriteLine(result);
            
            result = quakl.geheFuttern(summ);
            WriteLine(result);

            ReadLine();
        }
    }
}
