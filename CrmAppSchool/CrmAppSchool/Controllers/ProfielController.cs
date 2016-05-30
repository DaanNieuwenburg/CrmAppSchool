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
        public string Gebruikersnaam { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Bedrijf { get; set; }
        public string Locatie { get; set; }
        public string Functie { get; set; }
        public string Kwaliteit { get; set; }

        public Profiel Get_Pofiel(Gebruiker _gebruiker)
        {
            try
            {
                conn.Open();
                string query = "Select * from profiel where gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlParameter UN_PARAM = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);

                UN_PARAM.Value = _gebruiker.Gebruikersnaam;

                command.Parameters.Add(UN_PARAM);
                Profiel profiel = new Profiel();
                MySqlDataReader datalezer = command.ExecuteReader();
                
                while (datalezer.Read())
                {
                    profiel.Gebruikersnaam = datalezer.GetString("gebruikersnaam");
                    profiel.Voornaam = datalezer.GetString("voornaam");
                    profiel.Achternaam = datalezer.GetString("Achternaam");
                    profiel.Bedrijf = datalezer.GetString("bedrijf");
                    profiel.Locatie = datalezer.GetString("locatie");
                    profiel.Functie = datalezer.GetString("functie");
                    profiel.Kwaliteit = datalezer.GetString("kwaliteit");
                }
                return profiel;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("ERROR! EXCEPTION! ARGHHH! : " + e);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool bestaatProfiel(Gebruiker _gebruiker)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM profiel WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query,conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                command.Parameters.Add(gebruikersnaamParam);
                MySqlDataReader lezer = command.ExecuteReader();

                bool bestaatProfiel = false;
                while(lezer.Read())
                {
                    bestaatProfiel = true;
                }
                return bestaatProfiel;
            }
            catch(MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - bestaatprofiel " + e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update_Profiel(Gebruiker _gebruiker, string voornaam, string achternaam, string bedrijf, string locatie, string functie, string kwaliteit)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                string query = "Update profiel Set voornaam = @Voornaam, achternaam = @Achternaam, bedrijf = @Bedrijf, locatie = @Locatie, functie = @Functie, kwaliteit = @Kwaliteit where gebruikersnaam = @gebruikersnaam"; // dit moet een UPDATE worden
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlParameter UN_PARAM = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter VN_PARAM = new MySqlParameter("@Voornaam", MySqlDbType.VarChar);
                MySqlParameter AN_PARAM = new MySqlParameter("@Achternaam", MySqlDbType.VarChar);
                MySqlParameter BD_PARAM = new MySqlParameter("@Bedrijf", MySqlDbType.VarChar);
                MySqlParameter LO_PARAM = new MySqlParameter("@Locatie", MySqlDbType.VarChar);
                MySqlParameter FU_PARAM = new MySqlParameter("@Functie", MySqlDbType.VarChar);
                MySqlParameter KW_PARAM = new MySqlParameter("@Kwaliteit", MySqlDbType.VarChar);


                UN_PARAM.Value = _gebruiker.Gebruikersnaam;
                VN_PARAM.Value = voornaam;
                AN_PARAM.Value = achternaam;
                BD_PARAM.Value = bedrijf;
                LO_PARAM.Value = locatie;
                FU_PARAM.Value = functie;
                KW_PARAM.Value = kwaliteit;

                command.Parameters.Add(UN_PARAM);
                command.Parameters.Add(VN_PARAM);
                command.Parameters.Add(AN_PARAM);
                command.Parameters.Add(BD_PARAM);
                command.Parameters.Add(LO_PARAM);
                command.Parameters.Add(FU_PARAM);
                command.Parameters.Add(KW_PARAM);

                Profiel profiel = new Profiel();

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
                /*MySqlDataReader datalezer = command.ExecuteReader();

                while (datalezer.Read())
                {
                    profiel.Gebruikersnaam = datalezer.GetString("gebruikersnaam");
                    profiel.Voornaam = datalezer.GetString("voornaam");
                    profiel.Achternaam = datalezer.GetString("Achternaam");
                    profiel.Bedrijf = datalezer.GetString("bedrijf");
                    profiel.Locatie = datalezer.GetString("locatie");
                    profiel.Functie = datalezer.GetString("functie");
                    profiel.Kwaliteit = datalezer.GetString("kwaliteit");
                }
                return profiel;*/
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("ERROR! EXCEPTION! ARGHHH! : " + e);
                //return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void verwijderProfiel(Gebruiker _gebruiker)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM profiel WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                command.Parameters.Add(gebruikersnaamParam);
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in ProfielController/verwijderGebruiker " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
