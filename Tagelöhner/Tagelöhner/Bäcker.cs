using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tagelöhner
{
    delegate String Urteil(Praktikant p, String was);
    class Bäcker
    {
        public Urteil urteilen = null;
        public double backenBrot(int std)
        {
            WriteLine("backe backe Kuchen");
            return std * 11.50;
        }

        public String einsetzen(Praktikant p, String was)
        {
            if (urteilen != null)
            {
                return urteilen(p, was);
            }
            return "Nix zu beurteilen gefunden";
        }
    }
}
