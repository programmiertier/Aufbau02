using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagelöhner
{
    delegate double DelBeruf(int std);
    class Tagelöhner
    {
        public DelBeruf was = null;
        public double lohn { get; private set; }
        public double arbeiten(int std)
        {
            // ich muss prüfen, ob für was eine Methode hinterlegt wurde
            if (was != null)
            {
                // Methode was nimmt int entgegen und gibt double zurück
                lohn += was(std);
                
            }
            return lohn;    // gesamter Lohn bis jetzt
        }
    }
}
