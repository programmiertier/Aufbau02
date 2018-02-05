using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Schließfach
    {
        private static int lfdNummer = 0;

        public int nummer { get; private set; }

        public bool belegt = false;

        public List<String> inhalt { get; private set; }
        
        public Schließfach()
        {
            inhalt = new List<String>();
            belegt = false;
            nummer = ++lfdNummer;
        }
    }
}
