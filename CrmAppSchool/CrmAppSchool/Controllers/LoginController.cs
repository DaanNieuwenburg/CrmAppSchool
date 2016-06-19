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
    public class LoginController : DatabaseController
    {
        public bool relogin { get; set; }


        public bool VerifieerGebruiker(string _gebruikersnaam, string _wachtwoord, bool nieuwscherm)
        {
            string salt = haalSaltKeyOp(_gebruikersnaam);
            EncryptieController ecr = new EncryptieController();
            string[] wachtwoordInfo = ecr.encrypt(_wachtwoord, salt);
            string sha512Wachtwoord = wachtwoordInfo[1];
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
                    string gebruikersnaam = datalezer.GetString("gebruikersnaam");
                    string soortgebruiker = datalezer.GetString("soortgebruiker");
                    gebruiker = new Gebruiker() { Gebruikersnaam = gebruikersnaam, SoortGebruiker = soortgebruiker };
                    isnull = false;

                    // Roept het hoofdmenu aan
                    if (relogin == false && nieuwscherm == true)
                    {
                        HoofdmenuForm hoofdmenu = new HoofdmenuForm(gebruiker);
                        hoofdmenu.Show();
                    }
                }

                // Null checkt 
                if (isnull == true)
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

        public string haalSaltKeyOp(string _gebruikersnaam)
        {
            string saltSleutel = "";
            try
            {
                conn.Open();
                string query = "SELECT wachtwoordsalt FROM gebruiker WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruikersnaam;
                command.Parameters.Add(gebruikersnaamParam);

                MySqlDataReader datalezer = command.ExecuteReader();
                while (datalezer.Read())
                {
                    saltSleutel = datalezer.GetString("wachtwoordsalt");
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in logincontroller - haalSaltKeyOp: " + e);
            }
            finally
            {
                conn.Close();
            }
            return saltSleutel;
        }
    }
}
