using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedia_Console
{
    public class MIDI : Klingelton
    {
        public bool dateiformat;

        public bool getDateiformat() { return dateiformat; }
        public void setDateiformat(bool dateiformat) { this.dateiformat = dateiformat; }
    }
}
