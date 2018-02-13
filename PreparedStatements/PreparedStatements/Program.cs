using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using MySql.Data.MySqlClient;

namespace PreparedStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eine Verbindung zum Server

            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = "server=localhost; uid=root";
            conn.Open();
            conn.ChangeDatabase("test");

            // hier gibt es eine Tabelle, in welcher ein int, ein double und ein String
            // eingetragen werden kann

            // eintragen einer int zahl
            // die eingetragenden Werte sind in Variablen gespeichert und die sql-Anweisung
            // wird zusammengebaut mit den Variablen

            int zahl = 10;
            String sql = "insert into prepstmt (zahl) values (" + zahl + ")";

            WriteLine("SQL: " + sql);

            MySqlCommand comm = new MySqlCommand(sql, conn);

            int result = comm.ExecuteNonQuery();
            WriteLine(result);
            WriteLine("-----");
            ReadLine();

            // eintragen einer double-Zahl
            double komma = 12.34;
            sql = "insert into prepstmt (komma) values (" + komma + ")";
            WriteLine("SQL: " + sql);
            // das ist die Ausgabe: insert into prepstmt (komma) values (12,34)
            // im Deutschen wird das 12.34 zu 12,34 -> das sind zwei Values, die eingetragen werden
            // sollen, aber es wurde nur eine Spalte für das Eintragen ausgegeben
            // -> führt zu MySqlException

            // daher: Arbeit mit PreparedStatement
            // für den Wert, den ich noch nicht kenne, denke ich mir eine Bezeichnung aus
            // Das @ davor kennzeichnet einen Platzhalter
            String prepare = "insert into prepstmt (komma) values (@komma)";        // kann auch (käsekästchen) sein

            // Kommando erstellen mit dieser sql-Anweisung
            comm = new MySqlCommand(prepare, conn);

            // für jeden Parameter / Platzhalter definieren, was soll dort eingetragen werden
            // man definiert den Datentyp

            MySqlParameter paramet = new MySqlParameter("@komma", MySqlDbType.Double, 0);

            // dem paramet den einzutragenden Wert zuweisen
            // der Wert der Variablen komma
            paramet.Value = komma;

            // Dem auszuführenden KOmmando wird der parameter zugewiesen
            comm.Parameters.Add(paramet);

            // jetzt vorbereiten der sql-Anweisung mit den Werten für die Parameter
            comm.Prepare();

            result = comm.ExecuteNonQuery();
            WriteLine(result);
            WriteLine("-----");
            ReadLine();

            // Eintragen einer Zeichenkette
            String wort = "Hallo Welt";

            // zusammenbau der Zeichenkette
            sql = "insert into prepstmt (wort) values ('" + wort + "')";

            WriteLine(sql);

            
            ReadLine();
        }
    }
}
