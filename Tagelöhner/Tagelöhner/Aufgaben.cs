using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagelöhner
{
    class Aufgaben
    {
        public static double verteilenZettel(int std)
        {
            return 8.84 * std;
        }

        public static double kellnern(int std)
        {
            return std * 9.20;
        }

        public static double bauenTrojaner(int std)
        {
            return 50 * std;
        }
    }
}
