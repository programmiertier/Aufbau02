using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikelverwaltung
{
    class Artikelliste<T> where T: Artikel
    {
        public List<T> kram { get; private set; }
        // private static Random rnd = new Random();
        
        public Artikelliste()
        {
            kram = new List<T>();
        }

        public void hinzufügen(T artikel)
        {
            kram.Add(artikel);
        }

        public void löschen(int nummer)
        {
            kram.RemoveAll(a => a.artNr == nummer);
        }

        public T ausgeben(int nummer)
        {
            return kram.Find(a => a.artNr == nummer);
        }

        public T[] getAll()
        {
            return kram.ToArray();
        }

    }
}
