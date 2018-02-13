using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxizentrale
{
    public class Fahrt
    {
        public int f_ID { get; set; }

        public DateTime start { get; set; }

        public DateTime ende { get; set; }

        public double km { get; set; }

        public int automobil { get; set; }
    }
}
