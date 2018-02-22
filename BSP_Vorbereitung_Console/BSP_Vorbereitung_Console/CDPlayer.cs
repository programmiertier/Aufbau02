using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BSP_Vorbereitung_Console
{
    class CDPlayer
    {
        private bool systemOn;
        private bool discInside;

        public CDPlayer() { this.systemOn = false; this.discInside = false; }
        public void Stop() { if (discInside == true) { Console.WriteLine("Abspielen der CD beendet!"); } }
        public void Power() { systemOn = true; }
        public void OpenClose() { if (discInside != true) { discInside = false; } else { discInside = true; } }
        public void Play(CD disk)
        {
            string title = disk.GetTitle();
            String interpret = disk.GetInterpret();
            int titleTime = disk.GetTitleTime();

            for (int zaehl = 0; zaehl <= titleTime; zaehl = zaehl + titleTime / 20000)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Titel: " + title);
            }
        }

    }
}
