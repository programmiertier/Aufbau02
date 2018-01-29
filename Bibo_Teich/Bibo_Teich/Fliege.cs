using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Teich
{
    public class Fliege
    {
        public string name { get; private set; }
        private int _beine = 6;
        private int _fluegel = 2;

        public Fliege(string name)
        {
            this.name = name;
        }

        internal String wirdGefuttert()
        {
            return name + " vom Frosch gefuttert!";
        }
    }
}
