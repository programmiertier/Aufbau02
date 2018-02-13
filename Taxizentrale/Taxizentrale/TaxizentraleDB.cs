using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Taxizentrale
{
    public static class TaxizentraleDB
    {
        private static MySqlConnection conn = new MySqlConnection("server=localhost; database=taxizentrale; uid=root");

        public static Taxi[] getAlle()
        {
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Closed) return null;

            List<Taxi> tabelle = new List<Taxi>();

            MySqlCommand befehl = new MySqlCommand("select * from taxi", conn);
            using (MySqlDataReader daten = befehl.ExecuteReader())
            {
                while (daten.Read())
                {
                    Taxi t = new Taxi();
                    t.nummer = Convert.ToInt32(daten["nummer"]);
                    if (daten["belegt"].ToString() == "Yes")
                        t.belegt = true;
                    else
                        t.belegt = false;
                    tabelle.Add(t);
                }
            }

            conn.Close();
            return tabelle.ToArray();
        }

        public static Taxi[] getBelegt()
        {
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Closed) return null;

            List<Taxi> tabelle = new List<Taxi>();

            MySqlCommand befehl = new MySqlCommand("select * from taxi where belegt='Yes'", conn);
            using (MySqlDataReader daten = befehl.ExecuteReader())
            {
                while (daten.Read())
                {
                    Taxi t = new Taxi();
                    t.nummer = Convert.ToInt32(daten["nummer"]);
                    t.belegt = true;
                    tabelle.Add(t);
                }
            }

            conn.Close();
            return tabelle.ToArray();
        }

        public static Taxi[] getFrei()
        {
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Closed) return null;

            List<Taxi> tabelle = new List<Taxi>();

            MySqlCommand befehl = new MySqlCommand("select * from taxi where belegt='No'", conn);
            using (MySqlDataReader daten = befehl.ExecuteReader())
            {
                while (daten.Read())
                {
                    Taxi t = new Taxi();
                    t.nummer = Convert.ToInt32(daten["nummer"]);
                    t.belegt = false;
                    tabelle.Add(t);
                }
            }

            conn.Close();
            return tabelle.ToArray();
        }

        public static Fahrt[] getAbgeschlosseneFahrten()
        {
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Closed) return null;

            List<Fahrt> tabelle = new List<Fahrt>();

            MySqlCommand befehl = new MySqlCommand("Select * from fahrten where ende is not null", conn);

            using (MySqlDataReader daten = befehl.ExecuteReader())
            {
                while (daten.Read())
                {
                    Fahrt f = new Fahrt();

                    f.f_ID = Convert.ToInt32(daten["f_id"]);
                    f.km = Convert.ToDouble(daten["km"]);
                    f.automobil = Convert.ToInt32(daten["t_id"]);
                    f.start = DateTime.ParseExact(daten["start"].ToString(), "dd.MM.yyyy HH:mm:ss", null);
                    f.ende = DateTime.ParseExact(daten["ende"].ToString(), "dd.MM.yyyy HH:mm:ss", null);

                    tabelle.Add(f);
                }
            }

            conn.Close();
            return tabelle.ToArray();

        }

        public static Fahrt[] getBegonneneFahrten()
        {
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Closed) return null;

            List<Fahrt> tabelle = new List<Fahrt>();

            MySqlCommand befehl = new MySqlCommand("Select * from fahrten where ende is null", conn);

            using (MySqlDataReader daten = befehl.ExecuteReader())
            {
                while (daten.Read())
                {
                    Fahrt f = new Fahrt();

                    f.f_ID = Convert.ToInt32(daten["f_id"]);
                    f.automobil = Convert.ToInt32(daten["t_id"]);
                    f.start = DateTime.ParseExact(daten["start"].ToString(), "dd.MM.yyyy HH:mm:ss", null);

                    tabelle.Add(f);
                }
            }

            conn.Close();
            return tabelle.ToArray();
        }

        public static void eintragenFahrtbeginn(int t_id, DateTime start)
        {
            string sql = "insert into fahrten (start, t_id) values (str_to_date('" + start.ToString() + "', '%d.%m.%Y %H:%i:%S'), " + t_id + ")";

            conn.Open();

            new MySqlCommand(sql, conn).ExecuteNonQuery();

            conn.Close();

        }

        public static void eintragenFahrtende(int t_id, DateTime ende, double km)
        {
            string sql = "update fahrten set ende = str_to_date('" + ende.ToString() + "','%d.%m.%Y %H:%i:%S'), km = " + km + " where t_id = " + t_id;

            conn.Open();

            new MySqlCommand(sql, conn).ExecuteNonQuery();

            conn.Close();
        }

        public static Taxi[] suchen(int nummer)
        {
            conn.Open();


            List<Taxi> tabelle = new List<Taxi>();
            using (MySqlDataReader daten = new MySqlCommand("select * from taxi where nummer = " + nummer, conn).ExecuteReader())
            {
                while (daten.Read())
                {
                    Taxi t = new Taxi();
                    t.nummer = Convert.ToInt32(daten["nummer"]);
                    if (daten["belegt"].ToString() == "yes")
                        t.belegt = true;
                    else
                        t.belegt = false;
                    tabelle.Add(t);
                }
            }

            conn.Close();
            return tabelle.ToArray();
        }

        public static double getGesamtumsatz()
        {
            string sql = "select sum(km * 1.5) from fahrten";

            conn.Open();

            double umsatz = (double)new MySqlCommand(sql, conn).ExecuteScalar();


            conn.Close();

            return umsatz;
        }

        public static double getUmsatz(int nummer)
        {
            string sql = "select sum(km * 1.5) from fahrten where t_id = " + nummer;

            conn.Open();

            double umsatz = (double)new MySqlCommand(sql, conn).ExecuteScalar();

            conn.Close();

            return umsatz;

        }
    }
}
