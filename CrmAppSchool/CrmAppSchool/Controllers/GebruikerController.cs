using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAppSchool.Models;
using MySql.Data.MySqlClient;

namespace CrmAppSchool.Controllers
{
    public class GebruikerController : DatabaseController
    {

        public void voegGebruikerToe(Gebruiker _gebruiker)
        {
            MySqlTransaction trans = null;
            // Encrypt het ingevoerde wachtwoord van de gebruiker
            if (_gebruiker != null)
            {
                EncryptieController ecr = new EncryptieController();
                _gebruiker.Wachtwoord = ecr.encrypt(_gebruiker.Wachtwoord);
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    string query = "INSERT INTO gebruiker (gebruikersnaam, wachtwoord, soortgebruiker) VALUES (@gebruikersnaam, @wachtwoord, @soortgebruiker)";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                    MySqlParameter wachtwoordParam = new MySqlParameter("@wachtwoord", MySqlDbType.VarChar);
                    MySqlParameter soortgebruikerParam = new MySqlParameter("@soortgebruiker", MySqlDbType.VarChar);

                    gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                    wachtwoordParam.Value = _gebruiker.Wachtwoord;
                    soortgebruikerParam.Value = _gebruiker.SoortGebruiker;


                    command.Parameters.Add(gebruikersnaamParam);
                    command.Parameters.Add(wachtwoordParam);
                    command.Parameters.Add(soortgebruikerParam);

                    command.Prepare();
                    command.ExecuteNonQuery();

                    trans.Commit();
                    
                }
                catch (MySqlException e)
                {
                    if ((uint)e.ErrorCode == 0x80004005)
                    {
                        MessageBox.Show("Deze gebruiker kan niet toegevoegd worden: deze gebruiker bestaat al");
                    }
                    if (trans != null)
                    {
                        trans.Rollback();
                    }
                    Console.WriteLine("Error in gebruikercontroller - voeggebruikertoe: " + e);
                }
                finally
                {
                    conn.Close();
                }
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
            EncryptieController ecr = new EncryptieController();
            _gebruiker.Wachtwoord = ecr.encrypt(_gebruiker.Wachtwoord);
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
