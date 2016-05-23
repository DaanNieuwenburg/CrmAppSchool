using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    public class ZoekController : DatabaseController
    {
        public List<Profiel> zoekOpKwaliteit()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM profiel";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader lezer = command.ExecuteReader();
                List<Profiel> resultatenLijst = new List<Profiel>();

                while(lezer.Read())
                {
                    Profiel profiel = new Profiel();
                    resultatenLijst.Add(new Profiel { Gebruikersnaam = lezer.GetString("gebruikersnaam"), Voornaam = lezer.GetString("voornaam"), Achternaam = lezer.GetString("achternaam"), Bedrijf = lezer.GetString("bedrijf"), Functie = lezer.GetString("functie"), Kwaliteit = lezer.GetString("kwaliteit") });
                }
                return resultatenLijst;
            }
            catch(MySqlException e)
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
