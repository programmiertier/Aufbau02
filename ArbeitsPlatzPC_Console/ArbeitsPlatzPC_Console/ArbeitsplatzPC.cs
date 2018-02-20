using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitsPlatzPC_Console
{
    public class ArbeitsplatzPC
    {
        private String _macAdresse;
        private char _netz;

        public string macAdresse
        {
            get
            {
                return _macAdresse;
            }

            set
            {
                _macAdresse = value;
            }
        }

        public char netz
        {
            get
            {
                return _netz;
            }

            set
            {
                _netz = value;
            }
        }

        ArbeitsplatzPC(String mac, char ne)
        {
            this.macAdresse = mac;
            this.netz = ne;
        }

        private bool checkHex(char hexChe)
        {
            switch (hexChe)
            {
                case '0': return true;
                case '1': return true;
                case '2': return true;
                case '3': return true;
                case '4': return true;
                case '5': return true;
                case '6': return true;
                case '7': return true;
                case '8': return true;
                case '9': return true;
                case 'a':
                case 'A': return true;
                case 'b': 
                case 'B': return true;
                case 'c': 
                case 'C': return true;
                case 'd': 
                case 'D': return true;
                case 'e': 
                case 'E': return true;
                case 'f': 
                case 'F': return true;
                default: return false;
            }
        }

        public bool checkMac (string macAdresse)
        {
            bool trigger = true;
            int laenge = 0;
            int index = 0;
            laenge = macAdresse.Length;

            if (laenge != 17)
            {
                trigger = false;
            }
            else
            {
                for (index = 2; index < 17; index = index +3)
                {
                    if (macAdresse[index] == '-')
                    {

                    }
                    else
                    {
                        trigger = false;
                    }
                }
            }
            return trigger;
        }
    }
}
