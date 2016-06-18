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
        public List<Persooncontact> zoekMetFilter(string zoekquery, string zoekcriteria, string Zoeknaar)
        {
            List<Persooncontact> resultatenLijst = new List<Persooncontact>();
            try
            {
                conn.Open();
                string query = bepaalFilterQuery(zoekquery, Zoeknaar);
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter zoekParam = new MySqlParameter("@zoekParam", MySqlDbType.VarChar);
                zoekParam.Value = zoekcriteria;
                command.Parameters.Add(zoekParam);
                MySqlDataReader lezer = command.ExecuteReader();
                while (lezer.Read())
                {
                    if (Zoeknaar == "Stagebegeleider" || Zoeknaar == "Gastspreker" || Zoeknaar == "Gastdocent")
                    {
                        Persooncontact contact = new Persooncontact();
                        resultatenLijst.Add(new Persooncontact { Contactcode = lezer.GetInt32("contactcode"), Voornaam = lezer.GetString("voornaam"), Achternaam = lezer.GetString("achternaam"), Locatie = lezer.GetString("locatie"), Email = lezer.GetString("email"), Functie = lezer["functie"] as string, Afdeling = lezer["afdeling"] as string, bedrijfnaam = lezer["bedrijfnaam"] as string });
                    }
                    else if (Zoeknaar == "Gebruiker")
                    {
                        if (zoekquery == "Locatie" && lezer.GetBoolean("locatie_iszichtbaar") == true)
                        {
                            //doe niets
                        }
                        else if (zoekquery == "Functie" && lezer.GetBoolean("functie_iszichtbaar") == true)
                        {
                            //doe niets
                        }
                        else
                        {
                            Persooncontact contact = new Persooncontact();
                            resultatenLijst.Add(new Persooncontact { Voornaam = lezer.GetString("voornaam"), Achternaam = lezer.GetString("achternaam"), Locatie = lezer.GetString("locatie"), Functie = lezer["functie"] as string, ingevoerddoor = lezer.GetString("gebruikersnaam"), locatieprivé = lezer.GetBoolean("locatie_iszichtbaar"), functieprivé = lezer.GetBoolean("functie_iszichtbaar") });
                        }
                    }
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
            return resultatenLijst;
        }
        public List<Bedrijfcontact> Zoekbedrijf(string zoekquery, string zoekcriteria, string Zoeknaar)
        {
            List<Bedrijfcontact> bedrijfresultlijst = new List<Bedrijfcontact>();
            try
            {
                conn.Open();
                string query = bepaalFilterQuery(zoekquery, Zoeknaar);
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter zoekParam = new MySqlParameter("@zoekParam", MySqlDbType.VarChar);
                zoekParam.Value = zoekcriteria;
                command.Parameters.Add(zoekParam);
                MySqlDataReader lezer = command.ExecuteReader();
                while (lezer.Read())
                {
                    Bedrijfcontact contact = new Bedrijfcontact();
                    bedrijfresultlijst.Add(new Bedrijfcontact { Bedrijfscode = lezer.GetInt32("bedrijfcode"), Bedrijfnaam = lezer.GetString("bedrijfnaam"), Hoofdlocatie = lezer.GetString("hoofdlocatie"), Website = lezer.GetString("website"), Email = lezer["email"] as string, Telefoonnr = lezer["telefoonnr"] as string, Omschrijving = lezer["omschrijving"] as string });
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
        public string bepaalFilterQuery(string zoekquery, string zoeknaar)
        {
            if (zoeknaar == "Stagebegeleider")
            {
                if (zoekquery == "Voornaam")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (voornaam LIKE '%' @zoekParam '%') AND isstagebegeleider = 1";
                }
                else if (zoekquery == "Achternaam")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (achternaam LIKE '%' @zoekParam '%') AND isstagebegeleider = 1";
                }
                else if (zoekquery == "Kwaliteit")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (kwaliteit LIKE '%' @zoekParam '%') AND isstagebegeleider = 1";
                }
                else if (zoekquery == "Bedrijf")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (bedrijfnaam LIKE '%' @zoekParam '%') AND C.isstagebegeleider = 1";
                }
                else if (zoekquery == "Locatie")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (locatie LIKE '%' @zoekParam '%') AND isstagebegeleider = 1";
                }
                else if (zoekquery == "Functie")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (functie LIKE '%' @zoekParam '%') AND isstagebegeleider = 1";
                }
                else
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE isstagebegeleider = 1";
                }
            }
            else if (zoeknaar == "Gastspreker")
            {
                if (zoekquery == "Voornaam")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (voornaam LIKE '%' @zoekParam '%') AND isstagebegeleider = 0 AND isgastdocent = 0";
                }
                else if (zoekquery == "Achternaam")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (achternaam LIKE '%' @zoekParam '%') AND isstagebegeleider = 0 AND isgastdocent = 0";
                }
                else if (zoekquery == "Kwaliteit")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (kwaliteit LIKE '%' @zoekParam '%') AND isstagebegeleider = 0 AND isgastdocent = 0";
                }
                else if (zoekquery == "Bedrijf")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (bedrijfnaam LIKE '%' @zoekParam '%') AND C.isstagebegeleider = 0 AND C.isgastdocent = 0";
                }
                else if (zoekquery == "Locatie")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (locatie LIKE '%' @zoekParam '%') AND AND isstagebegeleider = 0 AND isgastdocent = 0";
                }
                else if (zoekquery == "Functie")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (functie LIKE '%' @zoekParam '%') AND isstagebegeleider = 0 AND isgastdocent = 0";
                }
                else
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE isstagebegeleider = 0 AND isgastdocent = 0";
                }
            }
            if (zoeknaar == "Gastdocent")
            {
                if (zoekquery == "Voornaam")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (voornaam LIKE '%' @zoekParam '%') AND isgastdocent = 1";
                }
                else if (zoekquery == "Achternaam")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (achternaam LIKE '%' @zoekParam '%') AND isgastdocent = 1";
                }
                else if (zoekquery == "Kwaliteit")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (kwaliteit LIKE '%' @zoekParam '%') AND isgastdocent = 1";
                }
                else if (zoekquery == "Bedrijf")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (bedrijfnaam LIKE '%' @zoekParam '%')AND C.isgastdocent = 1";
                }
                else if (zoekquery == "Locatie")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (locatie LIKE '%' @zoekParam '%') AND isgastdocent = 1";
                }
                else if (zoekquery == "Functie")
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE (functie LIKE '%' @zoekParam '%') AND isgastdocent = 1";
                }
                else
                {
                    return "SELECT * FROM contactpersoon C JOIN bedrijf B ON B.bedrijfcode = C.bedrijfcode WHERE isgastdocent = 1";
                }
            }
            else if (zoeknaar == "Bedrijf")
            {
                if (zoekquery == "Bedrijfnaam")
                {
                    return "SELECT * FROM bedrijf WHERE (bedrijfnaam LIKE '%' @zoekParam '%')";
                }
                else if (zoekquery == "Hoofdlocatie")
                {
                    return "Select * FROM bedrijf WHERE (hoofdlocatie LIKE '%' @zoekParam '%')";
                }
                else if (zoekquery == "Omschrijving")
                {
                    return "SELECT * FROM bedrijf WHERE (omschrijving LIKE '%' @zoekParam '%'";
                }
                else
                {
                    return "SELECT * FROM bedrijf";
                }
            }
            else
            {
                if (zoekquery == "Voornaam")
                {
                    return "SELECT * FROM gebruiker_profiel WHERE (voornaam LIKE '%' @zoekParam '%')";
                }
                else if (zoekquery == "Achternaam")
                {
                    return "SELECT * FROM gebruiker_profiel WHERE (achternaam LIKE '%' @zoekParam '%')";
                }
                else if (zoekquery == "Kwaliteit") // Aanpassing
                {
                    return "SELECT * FROM gebruiker_profiel WHERE (kwaliteit LIKE '%' @zoekParam '%')";
                }
                else if (zoekquery == "Locatie")
                {
                    return "SELECT * FROM gebruiker_profiel WHERE (locatie LIKE '%' @zoekParam '%')";
                }
                else if (zoekquery == "Functie")
                {
                    return "SELECT * FROM gebruiker_profiel WHERE (functie LIKE '%' @zoekParam '%')";
                }
                else
                {
                    return "SELECT * FROM gebruiker_profiel";
                }
            }
        }
    }
}
