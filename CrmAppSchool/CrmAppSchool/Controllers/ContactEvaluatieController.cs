using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    public class ContactEvaluatieController : DatabaseController
    {
        public void bepaalWhatToDo(Persooncontact contact, Gebruiker gebruiker)
        {
            // bepaal of er al een beoordeling is
            bool isinsert = bestaatEvaluatie(contact, gebruiker);
            if (isinsert == true)
            {
                bewerkEvaluatie(contact, gebruiker);
            }
            else
            {
                voegEvaluatieToe(contact, gebruiker);
            }
        }

        public bool bestaatEvaluatie(Persooncontact contact, Gebruiker gebruiker)
        {
            bool bestaat = false;
            try
            {
                conn.Open();
                string query = @"SELECT count(contactcode) as aantal FROM contactpersoon_evaluatie 
                                 WHERE contactcode = @contactcode AND gebruikersnaam = @gebruikersnaam";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("contactcode", MySqlDbType.Int32);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);

                contactcodeParam.Value = contact.Contactcode;
                gebruikersnaamParam.Value = gebruiker.Gebruikersnaam;

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(contactcodeParam);

                command.Prepare();
                MySqlDataReader datalezer = command.ExecuteReader();
                int aantal = 0;
                while (datalezer.Read())
                {
                    aantal = datalezer.GetInt32("aantal");
                }
                if (aantal > 0)
                {
                    bestaat = true;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in contactevaluatiecontroller - haalevaluatieop: " + e);
            }
            finally
            {
                conn.Close();
            }

            return bestaat;
        }

        public void voegEvaluatieToe(Persooncontact contact, Gebruiker gebruiker)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO contactpersoon_evaluatie (contactcode, gebruikersnaam, evaluatie, waardering) VALUES (@contactcode, @gebruikersnaam, @evaluatie, @waardering)";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("@contactcode", MySqlDbType.Int32);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter evaluatieParam = new MySqlParameter("@evaluatie", MySqlDbType.VarChar);
                MySqlParameter waarderingParam = new MySqlParameter("@waardering", MySqlDbType.VarChar);

                contactcodeParam.Value = contact.Contactcode;
                gebruikersnaamParam.Value = gebruiker.Gebruikersnaam;
                evaluatieParam.Value = contact.Evaluatie;
                waarderingParam.Value = contact.Beoordeling;

                command.Parameters.Add(contactcodeParam);
                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(evaluatieParam);
                command.Parameters.Add(waarderingParam);

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactevaluatiecontroller - voegevaluatietoe: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void bewerkEvaluatie(Persooncontact contact, Gebruiker gebruiker)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE contactpersoon_evaluatie SET contactcode = @contactcode, gebruikersnaam = @gebruikersnaam, evaluatie = @evaluatie, waardering = @waardering 
                                     WHERE contactcode = @contactcode AND gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("@contactcode", MySqlDbType.Int32);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter evaluatieParam = new MySqlParameter("@evaluatie", MySqlDbType.VarChar);
                MySqlParameter waarderingParam = new MySqlParameter("@waardering", MySqlDbType.VarChar);

                contactcodeParam.Value = contact.Contactcode;
                gebruikersnaamParam.Value = gebruiker.Gebruikersnaam;
                evaluatieParam.Value = contact.Evaluatie;
                waarderingParam.Value = contact.Beoordeling;

                command.Parameters.Add(contactcodeParam);
                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(evaluatieParam);
                command.Parameters.Add(waarderingParam);

                command.Prepare();
                command.ExecuteNonQuery();
            }


            catch (MySqlException e)
            {
                Console.WriteLine("Error in contactevaluatiecontroller - bewerkevaluatie: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public Persooncontact HaalInfoOp(Gebruiker gebruiker, Persooncontact contact)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"SELECT * FROM contactpersoon_evaluatie 
                                 WHERE contactcode = @contactcode AND gebruikersnaam = @gebruikersnaam";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("contactcode", MySqlDbType.Int32);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);

                contactcodeParam.Value = contact.Contactcode;
                gebruikersnaamParam.Value = gebruiker.Gebruikersnaam;

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(contactcodeParam);

                command.Prepare();
                MySqlDataReader datalezer = command.ExecuteReader();
                while (datalezer.Read())
                {
                    contact.Evaluatie = datalezer["evaluatie"] as string;
                    if (datalezer["waardering"] != null)
                    {
                        contact.Beoordeling = datalezer.GetInt32("waardering");
                    }
                    else
                    {
                        contact.Beoordeling = 0;
                    }
                }
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactevaluatiecontroller - haalevaluatieop: " + e);
            }
            finally
            {
                conn.Close();
            }

            return contact;
        }
    }
}
