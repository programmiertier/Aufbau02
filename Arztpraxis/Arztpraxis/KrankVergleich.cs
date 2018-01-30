using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arztpraxis
{
    class KrankVergleich : IComparer<Patient>
    {
        public int Compare(Patient x, Patient y)
        {
            return x.krank.CompareTo(y.krank);
        }

        
    }
}
