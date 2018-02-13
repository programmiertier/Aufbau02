using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sprachqualifikation
{
    public class AbfragePool
    {
        MySqlConnection conn;

        public AbfragePool()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server = loclahost; uid = root";
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

            MySqlCommand comm = new MySqlCommand("select persnr, name, vorname from person", conn);
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
    }
}