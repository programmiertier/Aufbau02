using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek_Reisekatalog
{
    public delegate void LOG(String was);
    public class Katalog
    {
        public List<Reiseziel> lliste { get; private set; }
        public event LOG log;

        public Katalog()
        {
            lliste = new List<Reiseziel>();
            Reiseziel r1 = new Reiseziel { land = "GR", ort = "Athen" };
            Reiseziel r2 = new Reiseziel { land = "ES", ort = "Barcelona" };
            Reiseziel r3 = new Reiseziel { land = "Fr", ort = "Cannes" };

            r1.hotels = new List<Hotel>();
            r1.hotels.Add(new Hotel { name = "Hotel1", beschreibung = "ist Ok", bewertung = 2, bild = "Image/bild1.png" });
            r1.hotels.Add(new Hotel { name = "Hotel2", beschreibung = "perfekt", bewertung = 5, bild = "Image//bild1.png" });

            r2.hotels = new List<Hotel>();
            r2.hotels.Add(new Hotel { name = "Hotel1", beschreibung = "so lala", bewertung = 1, bild = "Image/bild1.png" });
            r2.hotels.Add(new Hotel { name = "Hotel2", beschreibung = "ist Ok", bewertung = 2, bild = "Image/bild1.png" });
            r2.hotels.Add(new Hotel { name = "Hotel3", beschreibung = "annehmbar", bewertung = 4, bild = "Image/bild1.png" });
            
            r3.hotels = new List<Hotel>();
            r3.hotels.Add(new Hotel { name = "Hotel1", beschreibung = "so lala", bewertung = 3, bild = "Image/bild1.png" });
            r3.hotels.Add(new Hotel { name = "Hotel2", beschreibung = "ist Ok", bewertung = 2, bild = "Image/bild1.png" });
            r3.hotels.Add(new Hotel { name = "Hotel3", beschreibung = "annehmbar", bewertung = 4, bild = "Image/bild1.png" });

            lliste.Add(r1);
            lliste.Add(r2);
            lliste.Add(r3);
        }

        public Reiseziel[] getZiele()
        {
            if (log != null) log("alle Reiseziele ausgegeben");
            return lliste.ToArray();
        }
        public Hotel[] getHotels(String Land)
        {
            if (log != null) log("Alle Hotels im Lande " + Land + " gesucht");
            List<Hotel> list = new List<Hotel>();
            foreach (Reiseziel welche in lliste.FindAll(r => r.land == Land))
            {
                list.AddRange(welche.hotels);
            }
            return list.ToArray();
        }

        public Hotel[] getHotels(String Land, String Ort)
        {
            if (log != null) log("Alle Hotels im Lande " + Land + " / Ort " + Ort + " gesucht");
            return lliste.Find(r => r.land == Land && r.ort == Ort).hotels.ToArray();
        }

        public Hotel[] getHotels(String Land, String Ort, int sterne)
        {
            if (log != null) log("Alle Hotels in " + Land + "/" + Ort + " mit mindestens " + sterne + " Sterne");
            return lliste.Find(r => r.land == Land && r.ort == Ort).hotels.FindAll(h => h.bewertung >= sterne).ToArray();
        }
    }
}
