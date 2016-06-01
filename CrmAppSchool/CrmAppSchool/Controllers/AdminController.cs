using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    class AdminController : DatabaseController
    {
        public void voegGebruikerToe(Gebruiker _gebruiker)
        {
            MySqlTransaction trans = null;
            EncryptieController ecr = new EncryptieController();
            string wachtwoord = ecr.encrypt(_gebruiker.Wachtwoord);
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = "INSERT INTO gebruiker (gebruikersnaam, wachtwoord, isadmin, isdocent, isstudent) VALUES (@gebruikersnaam, @wachtwoord, @isadmin, @isdocent, @isstudent)";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter wachtwoordParam = new MySqlParameter("@wachtwoord", MySqlDbType.VarChar);
                MySqlParameter isadminParam = new MySqlParameter("@isadmin", MySqlDbType.Bit);
                MySqlParameter isdocentParam = new MySqlParameter("@isdocent", MySqlDbType.Bit);
                MySqlParameter isstudentParam = new MySqlParameter("@isstudent", MySqlDbType.Bit);

                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                wachtwoordParam.Value = wachtwoord;


                if (_gebruiker.SoortGebruiker == "Admin")
                {
                    isadminParam.Value = 1;
                }
                else
                {
                    isadminParam.Value = 0;
                }

                if(_gebruiker.SoortGebruiker == "Docent")
                {
                    isdocentParam.Value = 1;
                }
                else
                {
                    isdocentParam.Value = 0;
                }

                if(_gebruiker.SoortGebruiker == "Student")
                {
                    isstudentParam.Value = 1;
                }
                else
                {
                    isstudentParam.Value = 0;
                }

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(wachtwoordParam);
                command.Parameters.Add(isadminParam);
                command.Parameters.Add(isdocentParam);
                command.Parameters.Add(isstudentParam);

                command.Prepare();
                command.ExecuteNonQuery();

                trans.Commit();

                // Voeg profiel toe
                if (_gebruiker is Docent || _gebruiker is Admin)
                {
                    ProfielController profielcontroller = new ProfielController();
                    profielcontroller.voegProfielToe(_gebruiker.Gebruikersnaam);
                }
            }
            catch(MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in admincontroller - voeggebruikertoe: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
