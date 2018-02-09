using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Artikelverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikelliste<Artikel> liste = new Artikelliste<Artikel>();
            liste.hinzufügen(new Waschmaschine("Waschen 3000", 1200, 4));
            liste.hinzufügen(new Kühlschrank("Kühlen 500", 1300, 5));

            foreach (Artikel a in liste.getAll())
            {
                WriteLine(a);
            }

            ReadLine();
        }
    }
}
