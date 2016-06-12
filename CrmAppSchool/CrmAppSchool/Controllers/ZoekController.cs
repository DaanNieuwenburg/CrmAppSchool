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
        public List<Persooncontact> zoekMetFilter(string zoekquery, string zoekcriteria)
        {
            List<Persooncontact> resultatenLijst = new List<Persooncontact>();
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
                    if(zoekquery != "Organisatie")
                    {
                        Persooncontact contact = new Persooncontact();
                        resultatenLijst.Add(new Persooncontact { Voornaam = lezer.GetString("voornaam"), Achternaam = lezer.GetString("achternaam"), Locatie = lezer.GetString("locatie"), Email = lezer.GetString("email"), Functie = lezer["functie"] as string, Afdeling = lezer["afdeling"] as string });
                    }
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
        public List<Bedrijfcontact> Zoekbedrijf(string zoekquery, string zoekcriteria)
        {
            List<Bedrijfcontact> bedrijfresultlijst = new List<Bedrijfcontact>();
            try
            {
                conn.Open();
                string query = bepaalFilterQuery(zoekquery);
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter zoekParam = new MySqlParameter("@zoekParam", MySqlDbType.VarChar);
                zoekParam.Value = zoekcriteria;
                command.Parameters.Add(zoekParam);
                MySqlDataReader lezer = command.ExecuteReader();
                while (lezer.Read())
                {

                        Bedrijfcontact contact = new Bedrijfcontact();
                        bedrijfresultlijst.Add(new Bedrijfcontact { Bedrijfnaam = lezer.GetString("bedrijfnaam"), Hoofdlocatie = lezer.GetString("hoofdlocatie"), Website = lezer.GetString("website")/*, Email = lezer.GetString("email"), Telefoonnr = lezer.GetString("telefoonnr"), Omschrijving = lezer.GetString("omschrijving") */});
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
                return bedrijfresultlijst;
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
                return "SELECT * FROM bedrijf WHERE (bedrijfnaam LIKE '%' @zoekParam '%')";
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
