using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using MySql.Data.MySqlClient; //ACHTUNG --> Namespace für dll 

namespace Blumenladen
{
    class Program
    {
        static void Main(string[] args)
        {

            MySqlConnection conn = new MySqlConnection();

            //Allg. Aufbau der Zeichenfolge für Verbindung
            //server=[servername];uid=[username];pwd=[password]
            //hier gilt: Username ist root und es gibt kein Passwort, Verbunden wird mit localhost 
            String connString = "server=localhost;uid=root";

            conn.ConnectionString = connString;

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                WriteLine("Verbindung aufgebaut");
                ReadLine();
            }
            else
            {
                WriteLine("Verbindung konnte nicht hergestellt werden");
                ReadLine();
                return;
            }

            //Wechseln der Datenbank
            conn.ChangeDatabase("blumenladen");

            //Abfrage, wie viele Einträge in Tabelle verkauf vorhanden sind
            MySqlCommand comm = new MySqlCommand("select count(*) from verkauf", conn);

            //was wir beim comm aufgerufen wird, ist abhängig von dem, was das SQL-Command zurückgibt
            object obj = comm.ExecuteScalar();
            WriteLine(obj);

            //Abfrage einer Tabelle
            string sql = "select * from verkauf";

            //es kann mehrere Verbindungen gleichzeitig im Programm geben (Datenbanken auf einem Server, 
            //verschiedene Server) -- wir müssen immer festlegen, auf welcher Verbindung das sql-Commando
            //aufgeführt werden soll 
            comm = new MySqlCommand(sql, conn);

            //msdr zeigt auf einen vom Server bereitgestellten Datenstrom 
            //dieser Datenstrom zum Server muss offen bleiben, bis die Daten alle geholt wurden
            //msdr ist ein Zeiger, der nach Ausführung von ExecuteReader() VOR der ersten Zeile steht 
            MySqlDataReader msdr = comm.ExecuteReader();
            //solange noch Daten vorhanden sind
            //Read() liest eine Zeile des Datenstrom/Tabelle
            //Read() ist ein Zeiger, der immer eine Zeile vorwärts geht 
            while (msdr.Read())
            {
                //wir haben eine Zeile (Spaltenanzahl unbekannt), alle Zellen dieser Zeile ausgeben
                //die Zeile, die wir bekommen, ist ein Array 
                //FieldCount gibt aus, aus wie vielen SPalten die Tabelle besteht
                for (int i = 0; i < msdr.FieldCount; i++)
                {
                    //msdr ist ein Array betreffend der aktuellen Zeile, mit dem index [i] greife ich auf 
                    //eine Zelle in dieser Zeile zu 
                    //msdr[0] --> erste Spalte 
                    Write(msdr[i].ToString() + "\t");
                }
                WriteLine();
            }
            //der Datenstrom wird geschlossen
            msdr.Close();

            //Ausführung einer Anweisung zur Datenmanipulation
            sql = "update blume set preis = 4.59 where art='Diestel'";

            comm = new MySqlCommand(sql, conn);

            //dieses Commando gibt keine Ergebnistabelle zurück, sondern nur, ob die sql-anweisung 
            //ausgeführt werden konnte oder nicht (... rows affected)
            int result = comm.ExecuteNonQuery();

            WriteLine(result + " rows affected");


            //wie viele Blumen in einem Blumenstrauß
            sql = "select bs_id, sum(anzahl) from verkauf group by bs_id";

            comm = new MySqlCommand(sql, conn);
            msdr = comm.ExecuteReader();

            while (msdr.Read())
            {
                Console.WriteLine();
                for (int i = 0; i < msdr.FieldCount; i++)
                {
                    Write(msdr[i] + "\t");
                }
            }
            msdr.Close();

            Console.WriteLine();
            //Einfügen einer neuen Blume 
            //Nutzer gibt Daten ein 
            string was = "schneeglöcken";
            double preis = 12;
            int anzahl = 45;

            sql = "insert into blume(art,preis,anzahl) values( '" + was + "', " + preis + ", " + anzahl + ")";
            WriteLine("sql = " + sql);

            comm = new MySqlCommand(sql, conn);
            result = comm.ExecuteNonQuery();
            WriteLine("insert: " + result + " rows affected");


            //Ausgabe Tabelle Blume
            sql = "select b_id, art, preis, anzahl from blume";
            comm = new MySqlCommand(sql, conn);
            msdr = comm.ExecuteReader();
            while (msdr.Read())
            {
                WriteLine(msdr["b_id"] + "\t" + msdr["art"] + "\t" + msdr["preis"] + "\t" + msdr["anzahl"]);
            }
            msdr.Close();

            Console.WriteLine("Kosten Blumenstrauß");
            //Welcher Blumenstrauß kostet wie viel
            sql = "select bs_id, sum(verkauf.anzahl*preis) as Gesamt from blume inner join verkauf using (b_id) inner join blumenstrauß using (bs_id) group by bs_id";
            comm = new MySqlCommand(sql, conn);
            msdr = comm.ExecuteReader();
            while (msdr.Read())
            {
                WriteLine(msdr["bs_id"] + "\t" + msdr["Gesamt"]);
            }
            msdr.Close();

            //wie viele Blumen stehen grundsätzlich zum Verkauf
            comm = new MySqlCommand("select count(*) from blume", conn);
            WriteLine("Anzahl Blumen: " + comm.ExecuteScalar());

            //Wie viele Blumensträuße wurden bisher verkauft
            sql = "select count(*) from blumenstrauß";
            comm = new MySqlCommand(sql, conn);
            WriteLine("Anzahl Blumensträuße: " + comm.ExecuteScalar());

            //Wie hoch ist der Durchschnittspreis
            sql = "select avg(Gesamt) from (select bs_id, sum(verkauf.anzahl*preis) as Gesamt from blume inner join verkauf using (b_id) inner join blumenstrauß using (bs_id) group by bs_id) as t";
            comm = new MySqlCommand(sql, conn);
            WriteLine("Durchschnittspreis: " + comm.ExecuteScalar());


            conn.Close();

            ReadLine();
        }
    }
}
