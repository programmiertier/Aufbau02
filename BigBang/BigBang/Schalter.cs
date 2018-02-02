using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBang
{
    class Schalter
    {
        public List<Element> was{ get; private set; }

        public Schalter()
        {
            was = new List<Element>();
        }

        public void hinzufügen(Element was)
        {
            this.was.Add(was);
        }

        public void ein()
        {
            foreach (Element e in was)
            {
                e.einschalten();
            }
        }

        public void aus()
        {
            foreach (Element e in was)
            {
                e.ausschalten();
            }
        }
    }
}
