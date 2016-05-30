using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmAppSchool.Models;
using MySql.Data.MySqlClient;

namespace CrmAppSchool.Controllers
{
    class GebruikerController : DatabaseController
    {
        public List<Gebruiker> haalGebruikersOp()
        {
            try
            {
                List<Gebruiker> gebruikersLijst = new List<Gebruiker>();
                conn.Open();
                string query = "SELECT * FROM gebruiker";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader lezer = command.ExecuteReader();

                while (lezer.Read())
                {
                    string gebruikersnaam = lezer.GetString("gebruikersnaam");
                    bool isadmin = lezer.GetBoolean("isadmin");
                    bool isdocent = lezer.GetBoolean("isdocent");
                    bool isstudent = lezer.GetBoolean("isstudent");
                    if (isadmin == true)
                    {
                        gebruikersLijst.Add(new Admin(gebruikersnaam));
                    }
                    else if (isdocent == true)
                    {
                        gebruikersLijst.Add(new Docent(gebruikersnaam));
                    }
                    else if (isstudent == true)
                    {
                        gebruikersLijst.Add(new Student(gebruikersnaam));
                    }
                }
                return gebruikersLijst;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void veranderWachtwoordGebruiker(Gebruiker _gebruiker)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                string query = "UPDATE gebruiker SET wachtwoord = @wachtwoord WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter wachtwoordParam = new MySqlParameter("wachtwoord", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                wachtwoordParam.Value = _gebruiker.Wachtwoord;
                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(wachtwoordParam);

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
                Console.WriteLine("Error in Gebruikercontroller/verwijderGebruiker " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void verwijderGebruiker(Gebruiker _gebruiker)
        {
            // Controleer of gebruiker over een profiel beschikt
            ProfielController pfc = new ProfielController();
            bool bestaatProfiel = pfc.bestaatProfiel(_gebruiker);

            // Zoja verwijder het profiel
            if (bestaatProfiel == true)
            {
                pfc.verwijderProfiel(_gebruiker);
            }

            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                string query = "DELETE FROM gebruiker WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                command.Parameters.Add(gebruikersnaamParam);

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();

            }
            catch(MySqlException e)
            {
                if(trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in Gebruikercontroller/verwijderGebruiker " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
