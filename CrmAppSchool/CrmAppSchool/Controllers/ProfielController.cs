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
        public string Gebruikersnaam { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Bedrijf { get; set; }
        public string Locatie { get; set; }
        public string Functie { get; set; }
        public string Kwaliteit { get; set; }

        public Profiel Get_Pofiel(Gebruiker _gebruiker)
        {
            try
            {
                conn.Open();
                string query = "Select * from profiel where gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlParameter UN_PARAM = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);

                UN_PARAM.Value = _gebruiker.Gebruikersnaam;

                command.Parameters.Add(UN_PARAM);
                Profiel profiel = new Profiel();
                MySqlDataReader datalezer = command.ExecuteReader();
                
                while (datalezer.Read())
                {
                    profiel.Gebruikersnaam = datalezer.GetString("gebruikersnaam");
                    profiel.Voornaam = datalezer.GetString("voornaam");
                    profiel.Achternaam = datalezer.GetString("Achternaam");
                    profiel.Bedrijf = datalezer.GetString("bedrijf");
                    profiel.Locatie = datalezer.GetString("locatie");
                    profiel.Functie = datalezer.GetString("functie");
                    profiel.Kwaliteit = datalezer.GetString("kwaliteit");
                }
                return profiel;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("ERROR! EXCEPTION! ARGHHH! : " + e);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public Profiel Update_Profiel(Gebruiker _gebruiker)
        {
            try
            {
                conn.Open();
                string query = "Select * from profiel where gebruikersnaam = @gebruikersnaam"; // dit moet een UPDATE worden
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlParameter UN_PARAM = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);

                UN_PARAM.Value = _gebruiker.Gebruikersnaam;

                command.Parameters.Add(UN_PARAM);
                Profiel profiel = new Profiel();
                MySqlDataReader datalezer = command.ExecuteReader();

                while (datalezer.Read())
                {
                    profiel.Gebruikersnaam = datalezer.GetString("gebruikersnaam");
                    profiel.Voornaam = datalezer.GetString("voornaam");
                    profiel.Achternaam = datalezer.GetString("Achternaam");
                    profiel.Bedrijf = datalezer.GetString("bedrijf");
                    profiel.Locatie = datalezer.GetString("locatie");
                    profiel.Functie = datalezer.GetString("functie");
                    profiel.Kwaliteit = datalezer.GetString("kwaliteit");
                }
                return profiel;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("ERROR! EXCEPTION! ARGHHH! : " + e);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
