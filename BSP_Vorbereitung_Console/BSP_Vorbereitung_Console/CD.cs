using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSP_Vorbereitung_Console
{
    class CD
    {
        private String title;
        private String interpret;
        private int titelTime;

        public CD() { this.title = "NoTitle"; this.interpret = "No Interpret"; this.titelTime = 0;  }

        public String GetTitle() { return title; }
        public void SetTitle(String title) { this.title = title; }

        public String GetInterpret() { return interpret; }
        public void SetInterpret(String interpret) { this.interpret = interpret; }

        public int GetTitleTime() { return titelTime; }
        public void SetTitleTime(int titelTime) { this.titelTime = titelTime; }
    }
}
