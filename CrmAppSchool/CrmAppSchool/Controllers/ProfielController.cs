using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    class ProfielController : DatabaseController
    {
        private Gebruiker gebruiker { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Bedrijf { get; set; }
        public string Locatie { get; set; }
        public string Functie { get; set; }
        public string Kwaliteit { get; set; }

        public void Get_Pofiel(Gebruiker _gebruiker)
        {
            gebruiker = _gebruiker;
            try
            {
                conn.Open();
                string query = "Select * from profiel where gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlParameter UN_PARAM = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);

                UN_PARAM.Value = _gebruiker.Gebruikersnaam;

                command.Parameters.Add(UN_PARAM);

                MySqlDataReader datalezer = command.ExecuteReader();

                bool isnull = true;
                Gebruiker gebruiker = null;
                while (datalezer.Read())
                {
                    Gebruikersnaam = datalezer.GetString("gebruikersnaam");
                    Voornaam = datalezer.GetString("voornaam");
                    Achternaam = datalezer.GetString("Achternaam");
                    Bedrijf = datalezer.GetString("bedrijf");
                    Locatie = datalezer.GetString("locatie");
                    Functie = datalezer.GetString("functie");
                    Kwaliteit = datalezer.GetString("kwaliteit");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("ERROR! EXCEPTION! ARGHHH! : " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
