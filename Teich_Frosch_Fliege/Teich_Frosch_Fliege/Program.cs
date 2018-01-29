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
            Frosch[] quak = new Frosch[3];
            quak[0] = new Frosch("Hein", 4, 2, Frosch.ehunger.hungrig);
            quak[1] = new Frosch("Paul", 3, 1, Frosch.ehunger.hungrig);
            quak[2] = new Frosch("Karl", 3, 1, Frosch.ehunger.hungrig);

            Fliege[] summ = new Fliege[3];
            summ[0] = new Fliege(6, 2);
            summ[1] = new Fliege(6, 2);
            summ[2] = new Fliege(6, 2);


            quak[0].getoetet(ref summ[0]);

            // Maja muss weg!
            if (summ[0] == null)
            {
                WriteLine("Fliege ist tot Jim!");
            }
            else
            {
                WriteLine("Lang lebe Fliege");
            }
            ReadLine();
        }
    }
}
