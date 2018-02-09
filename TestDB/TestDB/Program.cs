using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient; //ACHTUNG --> Namespace für dll 

namespace TestDB
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
                Console.WriteLine("Verbindung aufgebaut");
            }
            else
            {
                Console.WriteLine("Verbindung konnte nicht hergestellt werden");
                return;
            }

            //Wechseln der Datenbank
            conn.ChangeDatabase("blumenladen");

            //Abfrage, wie viele Einträge in Tabelle verkauf vorhanden sind
            MySqlCommand comm = new MySqlCommand("select count(*) from verkauf", conn);

            Console.WriteLine("select count(*) from verkauf, gibt einen Wert von " + comm.ExecuteScalar() + " zurück");
            conn.Close();

            Console.ReadLine();
        }
    }
}

