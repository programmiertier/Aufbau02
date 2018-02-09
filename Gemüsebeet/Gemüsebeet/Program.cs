using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gemüsebeet
{
    class Program
    {
        static void Main(string[] args)
        {
            BeetM myBeet = new BeetM();

            myBeet.aussähen(new Möhre(), new Möhre(), new Möhre());

            string result = myBeet.bewirtschaften();
            WriteLine(result);

            WriteLine("Und das ist die Ernte.");
            foreach (Möhre m in myBeet.ernten())
            {
                WriteLine(m);
            }

            BeetK myOtherBeet = new BeetK();
            myOtherBeet.aussähen(new Kohlrabi());

            /*
            WriteLine("----------------------------");
            Beet allTogether = new Beet();
            allTogether.aussähen(new Möhre(), new Kohlrabi());
            result = allTogether.bewirtschaften();
            WriteLine(result);
            foreach (Gemüse g in allTogether.ernten())
            {
                WriteLine(g);
            }
            */


            //ein Beet für Gemüse
            Beet<Gemüse, Person> first = new Beet<Gemüse, Person>();
            first.aussähen(new Möhre(), new Kohlrabi());
            WriteLine(first.bewirtschaften(new Person(89)));
            foreach (Gemüse g in first.ernten())
            {
                WriteLine(g);
            }

            //ein Beet für Möhren
            Beet<Möhre, Person> second = new Beet<Möhre, Person>();
            second.aussähen(new Möhre(), new Möhre());
            WriteLine(second.bewirtschaften(new Person(40)));
            foreach (Möhre m in second.ernten())
            {
                WriteLine(m);
            }

            //ein Beet für Kohlrabi
            Beet<Kohlrabi, Gärtner> third = new Beet<Kohlrabi, Gärtner>();
            third.aussähen(new Kohlrabi(), new Kohlrabi());
            WriteLine(third.bewirtschaften(new Gärtner()));
            foreach (Kohlrabi k in third.ernten())
            {
                WriteLine(k);
            }

            ReadLine();
        }
    }
}
