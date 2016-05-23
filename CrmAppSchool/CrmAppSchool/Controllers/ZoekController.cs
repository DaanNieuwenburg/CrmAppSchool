using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CrmAppSchool.Controllers
{
    public class ZoekController : DatabaseController
    {
        private void zoekOpKwaliteit()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM profiel";
                MySqlCommand command = new MySqlCommand(query, conn);
                //MySqlDataReader lezer = new MySqlDataReader();
            }
            catch(MySqlException e)
            {
                Console.WriteLine("ERROR! EXCEPTION! ARGHHH! : " + e);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
