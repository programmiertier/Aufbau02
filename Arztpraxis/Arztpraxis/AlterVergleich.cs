using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztpraxis
{
    class AlterVergleich : IComparer<Patient>
    {
        public int Compare(Patient x, Patient y)
        {
            return y.alter.CompareTo(x.alter);
        }
    }
}
