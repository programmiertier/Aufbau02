using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sprachqualifikation
{
    class Program
    {
        static void Main(string[] args)
        {
            AbfragePool pool = null;
            try
            {
                pool = new AbfragePool();
            }
            catch (Exception e)
            {
                WriteLine("Keine Verbindung zur DB");
                return;
            }

            WriteLine("Liste aller Personen");
            foreach( Person p in pool.getPersonen())
            {

            }

            ReadLine();
        }
    }
}
