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

                if (_gebruiker.SoortGebruiker == "Docent")
                {
                    isdocentParam.Value = 1;
                }
                else
                {
                    isdocentParam.Value = 0;
                }

                if (_gebruiker.SoortGebruiker == "Student")
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
                if (_gebruiker.SoortGebruiker == "Docent" || _gebruiker.SoortGebruiker == "Admin")
                {
                    ProfielController profielcontroller = new ProfielController();
                    profielcontroller.voegProfielToe(_gebruiker.Gebruikersnaam);
                }
            }
            catch (MySqlException e)
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
                    string soortgebruiker = lezer.GetString("soortgebruiker");
                    gebruikersLijst.Add(new Gebruiker() { Gebruikersnaam = gebruikersnaam, SoortGebruiker = soortgebruiker });
                   
                }
                return gebruikersLijst;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in gebruikercontroller - haalgebruikersop: " + e);
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
                Console.WriteLine("Error in gebruikercontroller - veranderwachtwoordgebruiker: " + e);
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
                Console.WriteLine("Error in gebruikercontroller - verwijdergebruiker: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
