using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace linqSzamonkeres_PhanThiLinhTra
{
    internal class SzornyAdatbazis
    {

        private string connectionString = "server=localhost;database=fantasybestariumdb;uid=root;pwd=;";

        public List<Szorny> Feltolt()
        {
            List<Szorny> szornyek = new List<Szorny>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM `szornyek`;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Szorny szorny = new Szorny(
                                Convert.ToInt32(reader["id"]),
                                reader["nev"].ToString(),
                                Convert.ToInt32(reader["veszelyessegiSzint"]),
                                reader["elohely"].ToString(),
                                reader["foGyengeseg"].ToString(),
                                reader["legGyakoribbZsakmany"].ToString(),
                                Convert.ToBoolean(reader["veszelyesE"])
                            );

                            szornyek.Add(szorny);
                        }
                    }
                }
            }

            return szornyek;
        }
    }
}