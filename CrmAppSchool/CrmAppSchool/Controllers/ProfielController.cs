using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    class ProfielController : DatabaseController
    {
        public void ietsLeuks()
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO gebruiker (gebruikersnaam, voornaam, achternaam, achternaam, bedrijf, locatie, functie, kwaliteit) VALUES ()";
                MySqlCommand command = new MySqlCommand(query, conn);

                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
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
