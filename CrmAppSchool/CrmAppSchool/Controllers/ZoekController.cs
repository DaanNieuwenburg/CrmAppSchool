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
            List<Profiel> resultatenLijst = new List<Profiel>();
            try
            {
                conn.Open();
                string query = bepaalFilterQuery(zoekquery);
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter zoekParam = new MySqlParameter("@zoekParam", MySqlDbType.VarChar);
                zoekParam.Value = zoekcriteria;
                command.Parameters.Add(zoekParam);
                MySqlDataReader lezer = command.ExecuteReader();
                while(lezer.Read())
                {
                    Profiel profiel = new Profiel();
                    resultatenLijst.Add(new Profiel { Gebruikersnaam = lezer.GetString("gebruikersnaam"), Voornaam = lezer.GetString("voornaam"), Achternaam = lezer.GetString("achternaam"), Bedrijf = lezer.GetString("bedrijf"), Functie = lezer.GetString("functie"), Kwaliteit = lezer.GetString("kwaliteit") });
                }
            }
            catch(MySqlException e)
            {
                Console.WriteLine("ERROR! EXCEPTION! ARGHHH! : " + e);
            }
            finally
            {
                conn.Close();
            }
            return resultatenLijst;
        }

        public string bepaalFilterQuery(string zoekquery)
        {
            if(zoekquery == "Voornaam")
            {
                return "SELECT * FROM contactpersoon WHERE (voornaam LIKE '%' @zoekParam '%')";
            }
            else if(zoekquery == "Achternaam")
            {
                return "SELECT * FROM contactpersoon WHERE (achternaam LIKE '%' @zoekParam '%')";
            }
            else if(zoekquery == "Kwaliteit")
            {
                return "SELECT * FROM contactpersoon WHERE (kwaliteit LIKE '%' @zoekParam '%')";
            }
            else if (zoekquery == "Organisatie")
            {
                return "SELECT * FROM contactpersoon WHERE (bedrijf LIKE '%' @zoekParam '%')";
            }
            else if (zoekquery == "Locatie")
            {
                return "SELECT * FROM contactpersoon WHERE (locatie LIKE '%' @zoekParam '%')";
            }
            else if (zoekquery == "Functie")
            {
                return "SELECT * FROM contactpersoon WHERE (functie LIKE '%' @zoekParam '%')";
            }
            else
            {
                return "SELECT * FROM contactpersoon";
            }
        }
    }
}
