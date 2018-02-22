using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSP_Vorbereitung_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CD spiel = new CD();
            spiel.SetInterpret("Maus");
            spiel.SetTitle("Mausemusik");
            spiel.SetTitleTime(2);
            WriteLine(spiel.GetTitle() + "\t|\t" + spiel.GetInterpret() + "\t|\t" + spiel.GetTitleTime());

            CDPlayer abspiel = new CDPlayer();

            abspiel.Power();
            abspiel.OpenClose();
            
            abspiel.Play(spiel);
            abspiel.Stop();
            ReadLine();
        }
    }
}
