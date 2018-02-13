using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SQL_Bibliothek
{
    public class AbfragePool
    {

        MySqlConnection conn;

        public AbfragePool()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root";
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.ChangeDatabase("sprachquali");
            }
            else
            {
                throw new Exception("Keine Verbindung möglich");
            }
        }

        public Person[] getPersonen()
        {
            List<Person> liste = new List<Person>();
            MySqlCommand comm = new MySqlCommand("Select persnr, name, vorname from person", conn);
            MySqlDataReader msdr = comm.ExecuteReader();
            while (msdr.Read())
            {
                Person p = new Person();
                p.name = msdr["name"].ToString();
                p.vorname = msdr["vorname"].ToString();
                p.persNr = msdr["persnr"].ToString();

                liste.Add(p);
            }
            msdr.Close();
            return liste.ToArray();
        }

        public Person getPerson(String persnr)
        {
            MySqlCommand comm = new MySqlCommand("select name, vorname from person where persnr = '" + persnr + "'", conn);
            MySqlDataReader msdr = comm.ExecuteReader();
            if (msdr.HasRows)
            {
                msdr.Read();
                Person p = new Person();
                p.persNr = persnr;
                p.name = msdr["name"].ToString();
                p.vorname = msdr["vorname"].ToString();
                msdr.Close();
                return p;
            }
            msdr.Close();
            return null;
        }

        public Person[] getPersonen(char anfang)
        {
            List<Person> liste = new List<Person>();
            MySqlCommand comm = new MySqlCommand("select * from person where name like '" + anfang + "%'", conn);
            MySqlDataReader msdr = comm.ExecuteReader();
            while (msdr.Read())
            {
                Person p = new Person();
                p.name = msdr["name"].ToString();
                p.vorname = msdr["vorname"].ToString();
                p.persNr = msdr["persnr"].ToString();

                liste.Add(p);
            }
            msdr.Close();
            return liste.ToArray();
        }

        public String[] getSprachen()
        {
            List<String> liste = new List<String>();
            MySqlCommand comm = new MySqlCommand("select distinct sprache from sprachen", conn);
            MySqlDataReader msdr = comm.ExecuteReader();
            while (msdr.Read())
            {
                liste.Add(msdr[0].ToString());
            }
            msdr.Close();

            return liste.ToArray();
        }


        public int? getGrad(String nummer, String sprache)
        {
            MySqlCommand comm = new MySqlCommand("select grad from sprachen where persnr = '" + nummer + "' and sprache = '" + sprache + "'", conn);
            object result = comm.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToInt32(result.ToString());
            }
            else
            {
                return null;
            }
        }

        public double? getAvgGrad(String sprache)
        {
            MySqlCommand comm = new MySqlCommand("select avg(grad) from sprachen where sprache = '" + sprache + "'", conn);
            object result = comm.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToDouble(result.ToString());
            }
            else
            {
                return null;
            }
        }


        //Ausgabe aller Kunden mit Kundendetails
        public Person[] getGesamt()
        {
            List<Person> liste = new List<Person>();
            MySqlCommand comm = new MySqlCommand("select persnr, name, vorname, sprache, grad from person inner join sprachen using (persnr)", conn);
            MySqlDataReader msdr = comm.ExecuteReader();
            while (msdr.Read())
            {
                Person suche = liste.Find(p => p.persNr == msdr["persnr"].ToString());
                if (suche != null)
                {
                    Sprachen s = new Sprachen();
                    s.sprache = msdr["sprache"].ToString();
                    s.grad = Convert.ToInt32(msdr["grad"].ToString());
                    suche.sprachen.Add(s);

                }
                else
                {
                    suche = new Person();
                    suche.name = msdr["name"].ToString();
                    suche.vorname = msdr["vorname"].ToString();
                    suche.persNr = msdr["persnr"].ToString();
                    suche.sprachen = new List<Sprachen>();
                    Sprachen s = new Sprachen();
                    s.sprache = msdr["sprache"].ToString();
                    s.grad = Convert.ToInt32(msdr["grad"].ToString());
                    suche.sprachen.Add(s);

                    liste.Add(suche);
                }
            }
            msdr.Close();
            return liste.ToArray();
        }


        public List<Sprachen> getSprachen(String nummer)
        {
            List<Sprachen> liste = new List<Sprachen>();
            MySqlCommand sec = new MySqlCommand("select sprache, grad from sprachen where persnr = '" + nummer + "'", conn);
            MySqlDataReader data = sec.ExecuteReader();
            while (data.Read())
            {
                Sprachen s = new Sprachen();
                s.sprache = data["sprache"].ToString();
                s.grad = Convert.ToInt32(data["grad"].ToString());
                liste.Add(s);
            }

            data.Close();
            return liste;

        }

        public int einfügen(Person p)
        {
            String sql = "insert into person (persnr, name, vorname) values (@nr, @nn, @vn)";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlParameter param1 = new MySqlParameter("@nr", MySqlDbType.String, 0);
            MySqlParameter param2 = new MySqlParameter("@nn", MySqlDbType.String, 100);
            MySqlParameter param3 = new MySqlParameter("@vn", MySqlDbType.String, 100);
            param1.Value = p.persNr;
            param2.Value = p.name;
            param3.Value = p.vorname;

            comm.Parameters.Add(param1);
            comm.Parameters.Add(param2);
            comm.Parameters.Add(param3);

            comm.Prepare();
            return comm.ExecuteNonQuery();

        }

        public int einfügen(String nummer, String sprache, int grad)
        {
            String sql = "insert into sprachen (persnr, sprache, grad) values (@nr, @sprache, @grad)";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlParameter param1 = new MySqlParameter("@nr", MySqlDbType.String, 0);
            MySqlParameter param2 = new MySqlParameter("@sprache", MySqlDbType.String, 100);
            MySqlParameter param3 = new MySqlParameter("@grad", MySqlDbType.Int32, 0);
            param1.Value = nummer;
            param2.Value = sprache;
            param3.Value = grad;

            comm.Parameters.Add(param1);
            comm.Parameters.Add(param2);
            comm.Parameters.Add(param3);

            comm.Prepare();
            return comm.ExecuteNonQuery();
        }

        public int aktualisieren(String nummer, String sprache, int grad)
        {
            String sql = "update sprachen set grad = @grad where persnr = @nr and sprache = @sprache";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlParameter param1 = new MySqlParameter("@nr", MySqlDbType.String, 0);
            MySqlParameter param2 = new MySqlParameter("@sprache", MySqlDbType.String, 100);
            MySqlParameter param3 = new MySqlParameter("@grad", MySqlDbType.Int32, 0);
            param1.Value = nummer;
            param2.Value = sprache;
            param3.Value = grad;

            comm.Parameters.Add(param1);
            comm.Parameters.Add(param2);
            comm.Parameters.Add(param3);

            comm.Prepare();
            return comm.ExecuteNonQuery();
        }

        public int aktualisieren(Person p)
        {
            String sql = "update person set name = @name where persnr = @nr";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlParameter param1 = new MySqlParameter("@nr", MySqlDbType.String, 0);
            MySqlParameter param2 = new MySqlParameter("@name", MySqlDbType.String, 100);
            param1.Value = p.persNr;
            param2.Value = p.name;

            comm.Parameters.Add(param1);
            comm.Parameters.Add(param2);

            comm.Prepare();
            return comm.ExecuteNonQuery();
        }

        public int loeschen(Person p)
        {
            String sql = "delete from sprachen where persnr = '" + p.persNr + "'";
            new MySqlCommand(sql, conn).ExecuteNonQuery();

            sql = "delete from person where persnr = '" + p.persNr + "'";
            return new MySqlCommand(sql, conn).ExecuteNonQuery();
        }

        ~AbfragePool()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
