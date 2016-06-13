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
        public void bepaalWhatToDo(Persooncontact contact)
        {
            // bepaal of er al een beoordeling is
            try
            {

            }
            catch(MySqlException e)
            {
                Console.WriteLine("Error in contactevaluatiecontroller - bepaalWhatToDo: " + e);
            }
            finally
            {
                conn.Close();
            }
            
        }

    }
}
