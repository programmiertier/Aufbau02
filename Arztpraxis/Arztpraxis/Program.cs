using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arztpraxis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> liste = new List<Patient>();
            liste.Add(new Patient("Mister Buttons", 39, Patient.ekrank.Beinbruch));
            liste.Add(new Patient("Rotzi", 15, Patient.ekrank.Beinbruch));
            liste.Add(new Patient("Paulchen", 11, Patient.ekrank.Fleischwunde));
            liste.Add(new Patient("Motzi", 19, Patient.ekrank.Fleischwunde));

            for (int zaehl = 0; zaehl < liste.Count; zaehl++)
            {
                WriteLine(liste[zaehl]);
            }
            WriteLine("-----");
            ReadLine();

            foreach (Patient p in liste)
            {
                WriteLine(p);
            }
            WriteLine("-----");
            ReadLine();

            /* for (int zaehl = 0; zaehl < liste.Count; zaehl++)
            {
                if (liste[zaehl].name == liste[zaehl].name)
                {
                    liste.Remove(liste[zaehl]);
                }
            }   */
            WriteLine("-----");
            ReadLine();
            liste.Sort();
            foreach (Patient p in liste)
            {
                WriteLine(p);
            }

            WriteLine("-----");
            ReadLine();
            WriteLine("Krankvergleich:");
            liste.Sort(new KrankVergleich());
            foreach (Patient p in liste)
            {
                WriteLine(p);
            }

            WriteLine("-----");
            ReadLine();
            WriteLine("Altersvergleich:");
            liste.Sort(new AlterVergleich());
            foreach (Patient p in liste)
            {
                WriteLine(p);
            }
            
            WriteLine("-----");
            ReadLine();
        }
    }
}
