using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemüsebeet
{
    class BeetM
    {
        private List<Möhre> möhren { get; set; }
        private static Random rnd = new Random();

        public BeetM()
        {
            möhren = new List<Möhre>();
        }

        public void aussähen(params Möhre[] zeug)
        {
            foreach (Möhre m in zeug)
            {
                möhren.Add(m);
            }
        }

        public String bewirtschaften()
        {
            int zufall = rnd.Next(2);
            switch (zufall)
            {
                case 0:
                    foreach (Möhre m in möhren)
                    {
                        m.vernichtenFeind();
                    }
                    return "Alles vernichtet!";

                case 1:
                    foreach (Möhre m in möhren)
                    {
                        m.bewässern();
                    }
                    return "Alles bewässert!";
            }
            return "blubb";
        }

        public List<Möhre> ernten()
        {
            // jede reife Möhre wird geerntet
            List<Möhre> kannWeg = new List<Möhre>();
            kannWeg = möhren.FindAll(m => m.isReif);
            möhren.RemoveAll(m => m.isReif);


            return kannWeg;
        }
    }
}