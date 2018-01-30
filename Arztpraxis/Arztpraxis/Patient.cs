using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztpraxis
{
    class Patient : IComparable<Patient>
    {
        public String name { get; private set; }
        public int alter { get; private set; }
        public ekrank krank { get; private set; }
        public enum ekrank
        {
            Beinbruch, Fleischwunde
        }

        public Patient(String name, int alter, ekrank krank)
        {
            this.name = name;
            this.alter = alter;
            this.krank = krank;
        }

        public override bool Equals(object obj)
        {
            if (obj is Patient)
            {
                Patient vgl = (Patient)obj;
                if (this.name == vgl.name && this.alter == vgl.alter && this.krank == vgl.krank)
                {
                    return true;
                }
            }
            return false;
        }

        // gleicher Autor -- die Bücher könnten identisch sein
        public override int GetHashCode()
        {
            return this.name.Length;
        }

        public override string ToString()
        {
            return this.name + " | " + this.alter + " | " + this.krank;
        }

        public int CompareTo(Patient other)
        {
            return this.name.CompareTo(other.name);
        }
       
    }
}
