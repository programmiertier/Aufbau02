using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarGmbH_Console
{
    public class Investor
    {
        private String _vorname;
        private String _zuname;
        private String _telefonnummer;
        private String _email;

        public string vorname
        {
            get
            {
                return _vorname;
            }

            set
            {
                _vorname = value;
            }
        }

        public string zuname
        {
            get
            {
                return _zuname;
            }

            set
            {
                _zuname = value;
            }
        }

        public string telefonnummer
        {
            get
            {
                return _telefonnummer;
            }

            set
            {
                _telefonnummer = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        public Investor() { }

        public Investor(string vorname, string zuname, string telefonnummer, string email)
        {
            this.vorname = vorname;
            this.zuname = zuname;
            this.telefonnummer = telefonnummer;
            this.email = email;
        }
    }
}
