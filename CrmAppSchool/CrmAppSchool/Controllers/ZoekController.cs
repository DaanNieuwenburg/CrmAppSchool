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
        public List<Profiel> zoekMetFilter(string zoekquery, string zoekcriteria)
        {
            try
            {
                conn.Open();
                string query = bepaalFilterQuery(zoekquery);
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter zoekParam = new MySqlParameter("@zoekParam", MySqlDbType.VarChar);
                zoekParam.Value = zoekcriteria;
                command.Parameters.Add(zoekParam);
                MySqlDataReader lezer = command.ExecuteReader();
                List<Profiel> resultatenLijst = new List<Profiel>();
                Console.WriteLine("HOI " + query);
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

        public string bepaalFilterQuery(string zoekquery)
        {
            if(zoekquery == "Voornaam")
            {
                return "SELECT * FROM profiel WHERE voornaam = @zoekParam";
            }
            else if(zoekquery == "Achternaam")
            {
                return "SELECT * FROM profiel WHERE achternaam = @zoekParam";
            }
            else if(zoekquery == "Kwaliteit")
            {
                return "SELECT * FROM profiel WHERE kwaliteit = @zoekParam";
            }
            else if (zoekquery == "Organisatie")
            {
                return "SELECT * FROM profiel WHERE organisatie = @zoekParam";
            }
            else if (zoekquery == "Locatie")
            {
                return "SELECT * FROM profiel WHERE locatie = @zoekParam";
            }
            else if (zoekquery == "Functie")
            {
                return "SELECT * FROM profiel WHERE functie = @zoekParam";
            }
            else
            {
                return "SELECT * FROM profiel";
            }
        }
    }
}
