using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedia_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MP3 mp = new MP3();
            mp.setBitrate(120);
            mp.setPreis(99);
            Console.WriteLine("" + mp.bitrate + "\t|\t" + mp.getPreis());
            mp.geteffektiverPreis();
            Console.WriteLine("Effektiver Preis 90%:\t" + mp.geteffektiverPreis());

            Console.ReadLine();
        }
    }
}
