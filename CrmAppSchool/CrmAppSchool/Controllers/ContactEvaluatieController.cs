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
        public void bepaalWhatToDo(Persooncontact contact, Gebruiker gebruiker, bool isinsert)
        {
            // bepaal of er al een beoordeling is
            if(isinsert == true)
            {
                voegEvaluatieToe(contact, gebruiker);
            }
            else
            {

            }
        }

        public void voegEvaluatieToe(Persooncontact contact, Gebruiker gebruiker)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO contacten_evaluatie (contactcode, gebruikersnaam, evaluatie, waardering) VALUES (@contactcode, @gebruikersnaam, @evaluatie, @waardering)";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("@contact", MySqlDbType.Int32);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter evaluatieParam = new MySqlParameter("@evaluatie", MySqlDbType.VarChar);
                MySqlParameter waarderingParam = new MySqlParameter("@waardering", MySqlDbType.VarChar);

                contactcodeParam.Value = contact.Contactcode;
                gebruikersnaamParam.Value = gebruiker.Gebruikersnaam;
                //evaluatieParam.Value = contact.Evaluatie;
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
    }
}
