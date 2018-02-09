using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemüsebeet
{
    class BeetK
    {
        private List<Kohlrabi> kohlrabi { get; set; }
        private static Random rnd = new Random();

        public BeetK()
        {
            kohlrabi = new List<Kohlrabi>();
        }

        public void aussähen(params Kohlrabi[] zeug)
        {
            foreach (Kohlrabi m in zeug)
            {
                kohlrabi.Add(m);
            }
        }

        public String bewirtschaften()
        {
            int zufall = rnd.Next(2);
            switch (zufall)
            {
                case 0:
                    foreach (Kohlrabi m in kohlrabi)
                    {
                        m.vernichtenFeind();
                    }
                    return "Alles vernichtet!";

                case 1:
                    foreach (Kohlrabi m in kohlrabi)
                    {
                        m.bewässern();
                    }
                    return "Alles bewässert!";
            }
            return "blubb";
        }

        public List<Kohlrabi> ernten()
        {
            // jede reife Kohlrabi wird geerntet
            List<Kohlrabi> kannWeg = new List<Kohlrabi>();
            kannWeg = kohlrabi.FindAll(m => m.isReif);
            kohlrabi.RemoveAll(m => m.isReif);


            return kannWeg;
        }
    }
}