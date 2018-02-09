using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemüsebeet
{
    class Gemüse
    {

        public bool isReif { get; private set; }

        public Gemüse()
        {
            this.isReif = false;
        }

        public String bewässern()
        {
            this.isReif = true;
            return this.GetType().Name + " wurde bewässert";
        }

        public String vernichtenFeind()
        {
            this.isReif = true;
            return "Feinde vernichtet";
        }
    }
}