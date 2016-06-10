using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;
using System.Data.SqlClient;

namespace CrmAppSchool.Controllers
{
    class ContactenController : DatabaseController
    {
        public ContactenController()
        {
        }
 
        public void controleerOfContactBestaat(Gebruiker gebruiker, Persooncontact contact)
        {
            // Query de database en kijk of contact bestaat
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"SELECT contactcode FROM contactpersoon 
                                 WHERE voornaam = @voornaam AND achternaam = @achternaam OR email = @email";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter voornaamParam = new MySqlParameter("voornaam", MySqlDbType.VarChar);
                MySqlParameter achternaamParam = new MySqlParameter("achternaam", MySqlDbType.VarChar);
                MySqlParameter emailParam = new MySqlParameter("email", MySqlDbType.VarChar);


                voornaamParam.Value = contact.Voornaam;
                achternaamParam.Value = contact.Achternaam;
                emailParam.Value = contact.Email;

                command.Parameters.Add(voornaamParam);
                command.Parameters.Add(achternaamParam);
                command.Parameters.Add(emailParam);


                MySqlDataReader dataReader = command.ExecuteReader();
                int? klantcode = null;
                while (dataReader.Read())
                {
                    klantcode = dataReader.GetInt32("contactcode");
                }

                // Bepaal of contactpersoon bestaat
                conn.Close();
                if (klantcode == null)
                {
                    // Maakt een nieuwe contactpersoon aan
                    voegPersoonToe(gebruiker, contact);
                }
                else
                {
                    // Voert de contactpersoon in db in
                    voegContactPersoonKoppeltabel(gebruiker.Gebruikersnaam, Convert.ToInt64(klantcode));
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
        public void voegPersoonToe(Gebruiker gebruiker, Persooncontact contact)
        { 

            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                string query = @"INSERT INTO contactpersoon (voornaam, achternaam, locatie, email, functie, afdeling, isgastdocent, isstagebegeleider, gebruikersnaam, bedrijfcode)
                                 VALUES (@voornaam, @achternaam, @locatie, @email, @functie, @afdeling, @isgastdocent, @isstagebegeleider, @gebruikersnaam, @bedrijfcode)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter voornaamParam = new MySqlParameter("voornaam", MySqlDbType.VarChar);
                MySqlParameter achternaamParam = new MySqlParameter("achternaam", MySqlDbType.VarChar);
                MySqlParameter locatieParam = new MySqlParameter("locatie", MySqlDbType.VarChar);
                MySqlParameter emailParam = new MySqlParameter("email", MySqlDbType.VarChar);
                MySqlParameter functieParam = new MySqlParameter("functie", MySqlDbType.VarChar);
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
                functieParam.Value = contact.Functie;
                afdelingParam.Value = contact.Afdeling;
                isgastdocentParam.Value = Convert.ToInt32(contact.Isgastdocent);
                isstagebegeleiderParam.Value = Convert.ToInt32(contact.Isstagebegeleider);
                gebruikersnaamParam.Value = contact.Gebruiker.Gebruikersnaam;
                bedrijfcodeParam.Value = contact.Bedrijf.Bedrijfscode;

                command.Parameters.Add(voornaamParam);
                command.Parameters.Add(achternaamParam);
                command.Parameters.Add(locatieParam);
                command.Parameters.Add(emailParam);
                command.Parameters.Add(functieParam);
                command.Parameters.Add(afdelingParam);
                command.Parameters.Add(linkedinParam);
                command.Parameters.Add(isgastdocentParam);
                command.Parameters.Add(isstagebegeleiderParam);
                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(bedrijfcodeParam);


                command.Prepare();
                command.ExecuteNonQuery();
                //trans.Commit();

                // Zet de kwaliteiten in de kwaliteiten tabel
                long primaryKey = command.LastInsertedId;
                conn.Close();
                foreach (string kwaliteit in contact.Kwaliteiten)
                {
                    voegContactPersoonKwaliteitToe(kwaliteit, primaryKey);
                }

                // Zet de contact in de gebruikercontactpersoon koppeltabel
                conn.Close();
                voegContactPersoonKoppeltabel(gebruiker.Gebruikersnaam, primaryKey);
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
                // Conn close in Controleer of persoon bestaat
            }
        }


        public List<Persooncontact> HaalContactenOp(Gebruiker _gebruiker)
        {
            List<Persooncontact> contactenlijst = new List<Persooncontact>();
            MySqlTransaction trans = null;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"SELECT * FROM gebruikercontactpersoon g
                                 INNER JOIN contactpersoon c on g.contactcode = c.contactcode
                                 INNER JOIN bedrijf b ON c.bedrijfcode = b.bedrijfcode 
                                 WHERE g.gebruikersnaam = @gebruikersnaam";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikerParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);

                gebruikerParam.Value = _gebruiker.Gebruikersnaam;

                command.Parameters.Add(gebruikerParam);

                command.Prepare();
                MySqlDataReader datalezer = command.ExecuteReader();
                while (datalezer.Read())
                {
                    Persooncontact contact = new Persooncontact();
                    contact.Contactcode = datalezer.GetInt32("contactcode");
                    contact.Voornaam = datalezer.GetString("voornaam");
                    contact.Achternaam = datalezer.GetString("achternaam");
                    contact.Locatie = datalezer.GetString("locatie");
                    contact.Email = datalezer.GetString("email");
                    contact.Functie = datalezer["functie"] as string;
                    contact.Afdeling = datalezer["afdeling"] as string;
                    contact.Isgastdocent = datalezer.GetBoolean("isgastdocent");
                    contact.Isstagebegeleider = datalezer.GetBoolean("isstagebegeleider");
                    contactenlijst.Add(contact);
                    }
                    }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - haalcontactenop: " + e);
            }
            finally
            {
                conn.Close();
            }
            return contactenlijst;
        }
        public Persooncontact HaalInfoOp(string contactcode)
        {
            Console.WriteLine("T" + contactcode);
            MySqlTransaction trans = null;
            Persooncontact contact = new Persooncontact();
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"SELECT c.voornaam, c.achternaam, c.locatie, c.email, c.functie, c.afdeling, c.isgastdocent, c.isstagebegeleider, b.bedrijfnaam FROM contactpersoon c 
                                 INNER JOIN bedrijf b ON c.bedrijfcode = b.bedrijfcode 
                                 WHERE contactcode = @contactcode";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("contactcode", MySqlDbType.Int32);

                contactcodeParam.Value = contactcode;
                command.Parameters.Add(contactcodeParam);

                command.Prepare();
                MySqlDataReader datalezer = command.ExecuteReader();  
                while (datalezer.Read())
                {
                    contact.Voornaam = ((string)datalezer["voornaam"]);
                    contact.Achternaam = ((string)datalezer["achternaam"]);
                    contact.Locatie = ((string)datalezer["locatie"]);
                    contact.Email = ((string)datalezer["email"]);
                    contact.Functie = datalezer["functie"] as string;
                    //contact.Kwaliteiten = datalezer.Get["kwaliteiten"]);
                    contact.Afdeling = datalezer["afdeling"] as string;
                    contact.Isgastdocent = datalezer.GetBoolean("Isgastdocent");
                    contact.Isstagebegeleider = datalezer.GetBoolean("isstagebegeleider");
                    contact.Bedrijf = new Bedrijfcontact();
                    contact.Bedrijf.Bedrijfnaam = ((string)datalezer["bedrijfnaam"]);
                }

            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - haalcontactenop: " + e);
            }
            finally
            {
                conn.Close();
            }

            return contact;
        }
        public void voegContactPersoonKoppeltabel(string gebruikersnaam, long contactcode)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                string query = @"INSERT INTO gebruikercontactpersoon (gebruikersnaam, contactcode)
                                 VALUES (@gebruikersnaam, @contactcode)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter contactcodeParam = new MySqlParameter("contactcode", MySqlDbType.Int32);

                gebruikersnaamParam.Value = gebruikersnaam;
                contactcodeParam.Value = contactcode;


                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(contactcodeParam);

                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - voegContactPersoonKoppeltabel: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void voegContactPersoonKwaliteitToe(string kwaliteit, long id)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                string query = @"INSERT INTO contactpersoon_kwaliteiten (contactcode, kwaliteit)
                                 VALUES (@contactcode, @kwaliteit)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("contactcode", MySqlDbType.Int32);
                MySqlParameter kwaliteitParam = new MySqlParameter("kwaliteit", MySqlDbType.VarChar);

                contactcodeParam.Value = id;
                kwaliteitParam.Value = kwaliteit;


                command.Parameters.Add(contactcodeParam);
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
                Console.WriteLine("Error in contactencontroller - voegcontactpersoonkwaliteittoe: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void verwijderContact(Gebruiker gebruiker, string persooncode)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                // Verwijder contact in koppeltabel
                string query = @"DELETE FROM gebruikercontactpersoon WHERE gebruikersnaam = @gebruikersnaam AND contactcode = @contactcode";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter contactcodeParam = new MySqlParameter("contactcode", MySqlDbType.Int32);

                gebruikersnaamParam.Value = gebruiker.Gebruikersnaam;
                contactcodeParam.Value = persooncode;


                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(contactcodeParam);

                command.Prepare();
                command.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - verwijdercontact: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Persooncontact> ContactenBijBedrijf(Bedrijfcontact bedrijf)
        {
            List<Persooncontact> contactenlijst = new List<Persooncontact>();
            MySqlTransaction trans = null;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"SELECT *
                                 FROM contactpersoon c JOIN bedrijf b
                                 ON c.bedrijfcode = b.bedrijfcode
                                 WHERE b.bedrijfcode = @bedrijfcode";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfParam = new MySqlParameter("bedrijfcode" , MySqlDbType.VarChar);

                bedrijfParam.Value = bedrijf.Bedrijfscode;

                command.Parameters.Add(bedrijfParam);
                command.Prepare();
                MySqlDataReader datalezer = command.ExecuteReader();

                while (datalezer.Read())
                {
                    Persooncontact contact = new Persooncontact();
                    contact.Contactcode = datalezer.GetInt32("contactcode");
                    contact.Voornaam = datalezer.GetString("voornaam");
                    contact.Achternaam = datalezer.GetString("achternaam");
                    contact.Locatie = datalezer.GetString("locatie");
                    contact.Email = datalezer.GetString("email");
                    contact.Functie = datalezer["functie"] as string;
                    contact.Afdeling = datalezer["afdeling"] as string;
                    contact.Isgastdocent = datalezer.GetBoolean("isgastdocent");
                    contact.Isstagebegeleider = datalezer.GetBoolean("isstagebegeleider");
                    contact.volnaam = contact.Voornaam + " " + contact.Achternaam;
                    contactenlijst.Add(contact);
                }
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - ContactenBijBedrijf: " + e);
            }
            finally
            {
                conn.Close();
            }
            return contactenlijst;
        }
    }
}
