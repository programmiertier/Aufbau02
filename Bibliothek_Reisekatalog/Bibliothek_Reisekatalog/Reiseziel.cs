using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek_Reisekatalog
{
    public class Reiseziel
    {
        public String land { get; set; }
        public String ort { get; set; }
        public List<Hotel> hotels { get; set; }
    }
}
