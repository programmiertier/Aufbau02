using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sitec_GmbH_Console
{
    class Abrechnung
    {
        

        public static void endsumme()
        {
            string line = null;
            string[] felder = null;
            double endsumme = 0.0;
            double mwst_A_Satz = 19;
            double mwst_B_Satz = 7;
            double mwst_Betrag = 0.00;
            double mwst_A_gesamt = 0.00;
            double mwst_B_gesamt = 0.00;
            double mwst_gesamt = 0.00;


            //Öffnen der Datei                  // im Ordner bin/Debug/
            StreamReader file = new StreamReader("Positionen.txt");

            //1. Datensatz lesen
            line = file.ReadLine();

            while (line != null)
            {
                felder = line.Split(';');
                endsumme = endsumme + Convert.ToDouble(felder[5]);
                // Console.WriteLine(line);

                if(Convert.ToChar(felder[6]) == 'A')
                {
                    mwst_Betrag = Convert.ToDouble(felder[5]) * mwst_A_Satz / (100 + mwst_A_Satz);
                    mwst_A_gesamt = mwst_A_gesamt + mwst_Betrag;
                }
                else
                {
                    mwst_Betrag = Convert.ToDouble(felder[5]) * mwst_B_Satz / (100 + mwst_B_Satz);
                    mwst_B_gesamt = mwst_B_gesamt + mwst_Betrag;
                }
                //nächsten Datensatz lesen
                line = file.ReadLine();
            }
            mwst_gesamt = mwst_A_gesamt + mwst_B_gesamt;

            WriteLine("Endsumme: " + endsumme);
            WriteLine("Mehrwertst A: " + mwst_A_gesamt + "\nMehrwertst B: " + mwst_B_gesamt);
            WriteLine("Mehrwertst. gesamt: " + mwst_gesamt);
            //Schließen der Datei
            file.Close();
        }
    }
}