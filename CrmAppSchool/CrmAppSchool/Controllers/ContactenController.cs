using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    class ContactenController : DatabaseController
    {

        public void voegBedrijfToe(Bedrijfcontact contact)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO bedrijf (bedrijfnaam, hoofdlocatie, website, email, omschrijving)
                                 VALUES (@bedrijfnaam, @hoofdlocatie, @website, @email, @omschrijving)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfnaamParam = new MySqlParameter("bedrijfnaam", MySqlDbType.VarChar);
                MySqlParameter hoofdlocatieParam = new MySqlParameter("hoofdlocatie", MySqlDbType.VarChar);
                MySqlParameter websiteParam = new MySqlParameter("website", MySqlDbType.VarChar);
                MySqlParameter emailParam = new MySqlParameter("email", MySqlDbType.VarChar);
                MySqlParameter telefoonnrParam = new MySqlParameter("telefoonnr", MySqlDbType.VarChar);
                MySqlParameter omschrijvingParam = new MySqlParameter("omschrijving", MySqlDbType.VarChar);

                bedrijfnaamParam.Value = contact.Bedrijfnaam;
                hoofdlocatieParam.Value = contact.Hoofdlocatie;
                websiteParam.Value = contact.Website;
                emailParam.Value = contact.Email;
                telefoonnrParam.Value = contact.Telefoonnr;
                omschrijvingParam.Value = contact.Omschrijving;

                command.Parameters.Add(bedrijfnaamParam);
                command.Parameters.Add(hoofdlocatieParam);
                command.Parameters.Add(websiteParam);
                command.Parameters.Add(emailParam);
                command.Parameters.Add(telefoonnrParam);
                command.Parameters.Add(omschrijvingParam);

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();

                // Zet de kwaliteiten in de kwaliteiten tabel
                long primaryKey = command.LastInsertedId;
                foreach(string kwaliteit in contact.Kwaliteiten)
                {
                    voegKwaliteitToe(kwaliteit, primaryKey);
                }
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - voegpersoontoe: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Bedrijfcontact> haalBedrijfLijstOp()
        {
            List<Bedrijfcontact> contactenlijst = new List<Bedrijfcontact>();
            try
            {
                conn.Open();
                string query = @"SELECT bedrijfcode, bedrijfnaam FROM bedrijf";
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Bedrijfcontact contact = new Bedrijfcontact();
                    contact.Bedrijfscode = dataReader.GetInt32("bedrijfcode");
                    contact.Bedrijfnaam = dataReader.GetString("bedrijfnaam");

                    contactenlijst.Add(contact);
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in contactencontroller - haalbedrijflijstop: " + e);
            }
            finally
            {
                conn.Close();
            }
            return contactenlijst;
        }

        public void voegKwaliteitToe(string kwaliteit, long id)
        {
            MySqlTransaction trans = null;
            try
            {
                string query = @"INSERT INTO bedrijf_kwaliteiten (bedrijfcode, kwaliteit)
                                 VALUES (@bedrijfcode, @kwaliteit)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);
                MySqlParameter kwaliteitParam = new MySqlParameter("kwaliteit", MySqlDbType.VarChar);

                bedrijfcodeParam.Value = id;
                kwaliteitParam.Value = kwaliteit;


                command.Parameters.Add(bedrijfcodeParam);
                command.Parameters.Add(kwaliteitParam);

                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - voegkwaliteittoe: " + e);
            }
            finally
            {
            }
        }

        public void voegPersoonToe(Persooncontact contact)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO contactpersoon (voornaam, achternaam, locatie, email, afdeling, linkedin, isgastdocent, isstagebegeleider, gebruikersnaam, bedrijfcode)
                                 VALUES (@voornaam, @achternaam, @locatie, @email, @afdeling, @linkedin, @isgastdocent, @isstagebegeleider, @gebruikersnaam, @bedrijfcode)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter voornaamParam = new MySqlParameter("voornaam", MySqlDbType.VarChar);
                MySqlParameter achternaamParam = new MySqlParameter("achternaam", MySqlDbType.VarChar);
                MySqlParameter locatieParam = new MySqlParameter("locatie", MySqlDbType.VarChar);
                MySqlParameter emailParam = new MySqlParameter("email", MySqlDbType.VarChar);
                MySqlParameter afdelingParam = new MySqlParameter("afdeling", MySqlDbType.VarChar);
                MySqlParameter linkedinParam = new MySqlParameter("linkedin", MySqlDbType.VarChar);
                MySqlParameter isgastdocentParam = new MySqlParameter("isgastdocent", MySqlDbType.Binary);
                MySqlParameter isstagebegeleiderParam = new MySqlParameter("isstagebegeleider", MySqlDbType.Binary);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);

                voornaamParam.Value = contact.Voornaam;
                achternaamParam.Value = contact.Achternaam;
                locatieParam.Value = contact.Locatie;
                emailParam.Value = contact.Email;
                afdelingParam.Value = contact.Afdeling;
                linkedinParam.Value = contact.Linkedin;
                isgastdocentParam.Value = Convert.ToInt32(contact.Isgastdocent);
                isstagebegeleiderParam.Value = Convert.ToInt32(contact.Isstagebegeleider);
                gebruikersnaamParam.Value = contact.Gebruiker.Gebruikersnaam;
                bedrijfcodeParam.Value = contact.Bedrijf.Bedrijfscode;

                command.Parameters.Add(voornaamParam);
                command.Parameters.Add(achternaamParam);
                command.Parameters.Add(locatieParam);
                command.Parameters.Add(emailParam);
                command.Parameters.Add(afdelingParam);
                command.Parameters.Add(linkedinParam);
                command.Parameters.Add(isgastdocentParam);
                command.Parameters.Add(isstagebegeleiderParam);
                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(bedrijfcodeParam);


                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch(MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - voegpersoontoe: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
