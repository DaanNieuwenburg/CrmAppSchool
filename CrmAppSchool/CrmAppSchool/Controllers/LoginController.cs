using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;
using CrmAppSchool.Views.Gebruikers;

namespace CrmAppSchool.Controllers
{
    class LoginController : DatabaseController
    {

        public bool VerifieerGebruiker(string _gebruikersnaam, string _wachtwoord)
        {
            EncryptieController ecr = new EncryptieController();
            string sha512Wachtwoord = ecr.encrypt(_wachtwoord);
            try
            {
                conn.Open();
                string query = "SELECT * FROM gebruiker WHERE gebruikersnaam = @gebruikersnaam AND wachtwoord = @wachtwoord";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter wachtwoordParam = new MySqlParameter("@wachtwoord", MySqlDbType.VarChar);

                gebruikersnaamParam.Value = _gebruikersnaam;
                wachtwoordParam.Value = sha512Wachtwoord;

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(wachtwoordParam);

                MySqlDataReader datalezer = command.ExecuteReader();

                // Haalt de data op uit de database en vult het model met data
                bool isnull = true;
                Gebruiker gebruiker = null;
                while (datalezer.Read())
                {
                    if (datalezer.GetBoolean("isadmin") == true)
                    {
                        gebruiker = new Admin(datalezer.GetString("gebruikersnaam"));
                    }
                    else if (datalezer.GetBoolean("isdocent") == true)
                    {
                        gebruiker = new Docent(datalezer.GetString("gebruikersnaam"));
                    }
                    else if (datalezer.GetBoolean("isstudent") == true)
                    {
                        gebruiker = new Student(datalezer.GetString("gebruikersnaam"));
                    }
                    isnull = false;

                    // Roept het hoofdmenu aan
                    HoofdmenuForm hoofdmenu = new HoofdmenuForm(gebruiker);
                    hoofdmenu.Show();
                }

                // Null checkt 
                if(isnull == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in logincontroller - verifieergebruiker: " + e);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
