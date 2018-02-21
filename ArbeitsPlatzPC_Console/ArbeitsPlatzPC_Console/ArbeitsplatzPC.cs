using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitsPlatzPC_Console
{
    public class ArbeitsplatzPC
    {
        private String macAdresse;
        private char netz;

        public ArbeitsplatzPC(string macAdresse, char netz)
        {
            bool trigger = false;
            trigger = setnetz(netz);
            if (trigger == true)
            {
                this.netz = netz;
                Console.WriteLine("Netzkennung okay");
            }

            trigger = setMAC(macAdresse);
            if (trigger == true)
            {
                this.macAdresse = macAdresse;
                Console.WriteLine("MAC-Adresse okay");
            }
        }

        public bool setnetz(char netz)
        {
            bool trigger = false;
            if (netz == 'A' || netz == 'B')
            {
                trigger = true;
            }
            return trigger;
        }

        public bool setMAC(string macAdresse)
        {
            bool trigger = true;
            if (checkMac(macAdresse) == false)
            {
                trigger = false;
            }
            return trigger;
        }

        private bool checkMac(string macAdresse)
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
                for (index = 2; index < 17; index = index + 3)
                {
                    if (macAdresse[index] == '-')
                    {

                    }
                    else
                    {
                        trigger = false;
                    }
                }

                index = 0;
                while (index < 17)
                {
                    if (macAdresse[index] != '-')
                    {
                        if (checkHex(macAdresse[index]) == false)
                        {
                            trigger = false;
                        }
                    }
                    index = index + 1;
                }
            }
            return trigger;
        }

        private bool checkHex(char z)
        {
            switch (z)
            {
                case '0': return true;
                case '1': return true;
                case '2': return true;
                case '3': return true;
                case '4': return true;
                case '5': return true;
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
    }
}