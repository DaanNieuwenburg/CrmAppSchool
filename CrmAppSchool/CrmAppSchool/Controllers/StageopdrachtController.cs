using CrmAppSchool.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Controllers
{
    class StageopdrachtController : DatabaseController
    {
        public List<Stageopdracht> getOpdrachten()
        {
            List<Stageopdracht> opdrachten = new List<Stageopdracht>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM stageopdracht";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string status = dataReader.GetString("status");
                    string naam = dataReader.GetString("naam");
                    string omschrijving = dataReader.GetString("omschrijving");
                    Stageopdracht opdracht = new Stageopdracht { Status = status, Naam = naam, Omschrijving = omschrijving };

                    opdrachten.Add(opdracht);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van stageopdrachten mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return opdrachten;
        }

        public List<Stageopdracht> ZoekOpdrachten(string tekst)
        {
            List<Stageopdracht> opdrachten = new List<Stageopdracht>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM stageopdracht where naam like @naam";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlParameter naamParam = new MySqlParameter("@naam", MySqlDbType.String);
                naamParam.Value = tekst;
                cmd.Parameters.Add(naamParam);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string status = dataReader.GetString("status");
                    string naam = dataReader.GetString("naam");
                    string omschrijving = dataReader.GetString("omschrijving");
                    Stageopdracht opdracht = new Stageopdracht { Status = status, Naam = naam, Omschrijving = omschrijving };

                    opdrachten.Add(opdracht);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van stageopdrachten mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return opdrachten;
        }
    }
}
