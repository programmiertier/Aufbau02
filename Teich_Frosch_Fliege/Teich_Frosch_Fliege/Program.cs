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
            Frosch[] froesche = new Frosch[] { new Frosch("Walter", 1, 3), new Frosch("Maxi", 3, 2), new Frosch("Ole", 4, 1) };
            Fliege[] fliegen = new Fliege[] { new Fliege(6, 2), new Fliege(6, 2), new Fliege(6, 2) };
            int index = 0;
            int count = 0;
            foreach (Frosch f in froesche)
            {
                Console.WriteLine(f);
            }

            do
            {

                WriteLine("-------------");
                WriteLine("Welcher Frosch darf feiern 1, 2 oder 3?");
                int zahl = Int32.Parse(ReadLine());

                if (zahl < 1 || zahl > 3)
                {
                    continue;
                }

                froesche[zahl - 1].feiernGeburtstag();
                if (!froesche[zahl - 1].lebendig)
                {
                    WriteLine("Dieser Frosch ist tot");
                }
                else if (froesche[zahl - 1].hungrig == false)
                {
                    WriteLine("Dieser Frosch hat keinen Hunger");
                }
                else
                {
                    froesche[zahl - 1].geheFuttern(fliegen[index]);
                    index++;
                }

                WriteLine("Die Frösche");
                count = 0;
                foreach (Frosch f in froesche)
                {
                    WriteLine(f);
                    if (f.lebendig == false) count++;
                }
            }
            while (index < 3 && count < 3);
        }
        /*
        static void Main(string[] args)
        {
            Frosch walter = new Frosch(3, 6, "Walter");
            

            Console.WriteLine(walter);

            while (walter.Lebendig)
            {
                Console.WriteLine(walter.feiernGeburtstag());
                Console.WriteLine(walter.Alter);
            }

            Frosch walter_twin = new Frosch(3, 6, "Twin");
            if(walter.Equals(walter_twin))
            {
                Console.WriteLine("Identisch");
            }

            Fliege opfer = new Fliege(6,2);
            Console.WriteLine(opfer.Lebendig);
            Console.WriteLine(walter.fressen(opfer));
            Console.WriteLine(opfer.Lebendig);

            //ZUgriff auf Klasseneigenschaften / Klassenmethoden
            Console.WriteLine("Jeder Frosch hat " + Frosch.Beine + " Beine");
        }
         * */
    }
}
