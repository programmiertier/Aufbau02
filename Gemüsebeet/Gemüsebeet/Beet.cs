using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemüsebeet
{
    //eine generische Klasse ist eine Vorlage für eine Menge von Klassen
    //der Typparameter ist unbestimmt -> entweder Gemüse, Möhre Kohlrabi (was auf der Liste steht)
    // daher ersetzt durch T
    //Wenn nur Beet<T> -> dann ist der allg. Typ der verwendet wird, auf jeden Fall object
    //wir müssen eine Einschränkung definieren, damit die Methoden für bewässern()... aufgerufen werden
    //where T:Gemüse -> als Typparameter kommt in Frage: Klasse Gemüse/eine ihrer Unterklassen
    class Beet<T, U> where T : Gemüse where U : Person
    {

        private List<T> gemüse { get; set; }
        private static Random rnd = new Random();

        public Beet()
        {
            gemüse = new List<T>();
        }

        public void aussähen(params T[] zeug)
        {
            foreach (T m in zeug)
            {
                gemüse.Add(m);
            }
        }

        public String bewirtschaften(U p)
        {

            if (p is Gärtner)
            {
                foreach (T m in gemüse)
                {
                    m.bewässern();
                    m.vernichtenFeind();
                }
                return "Alles erledigt";
            }

            if (p.Skills > 50)

            {
                int zufall = rnd.Next(2);
                switch (zufall)
                {
                    case 0:
                        foreach (T m in gemüse)
                        {
                            m.vernichtenFeind();
                        }
                        return "Alles vernichtet!";

                    case 1:
                        foreach (T m in gemüse)
                        {
                            m.bewässern();
                        }
                        return "Alles bewässert!";
                }
                return "blubb";
            }

            return "Nix gemacht";
        }

        public List<T> ernten()
        {
            // jede reife Kohlrabi wird geerntet
            List<T> kannWeg = new List<T>();
            kannWeg = gemüse.FindAll(m => m.isReif);
            gemüse.RemoveAll(m => m.isReif);


            return kannWeg;
        }
    }
}