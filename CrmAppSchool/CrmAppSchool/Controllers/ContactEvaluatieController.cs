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
        public void bepaalWhatToDo(Persooncontact contact, bool isinsert)
        {
            // bepaal of er al een beoordeling is
            if(isinsert == true)
            {

            }
            else
            {

            }
        }

        public void voegEvaluatieToe(Persooncontact contact)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO contacten_evaluatie (contactcode, gebruikersnaam,) VALUES (@contactcode, @gebruikersnaam)";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter contactcodeParam = new MySqlParameter("@contact", MySqlDbType.VarChar);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);

                contactcodeParam.Value = contact.Contactcode;
                //gebruikersnaamParam.Value = gebruiker.Gebruikersnaam;

                command.Parameters.Add(contactcodeParam);

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
