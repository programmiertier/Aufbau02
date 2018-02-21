using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedia_Console
{
    public class MP3 : Klingelton
    {
        public int bitrate;
        public bool copyright;

        public int getBitrate () { return bitrate; }
        public void setBitrate(int bitrate) { this.bitrate = bitrate; }

        public bool getCopyright() { return copyright; }
        public void setCopyright(bool copy) { this.copyright = copy; }
    }
}
