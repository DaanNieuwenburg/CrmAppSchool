using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    public class ProfielController : DatabaseController
    {
        public void voegProfielToe(string gebruikersnaam, string voornaam, string achternaam)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO gebruiker_profiel (gebruikersnaam, voornaam, achternaam) VALUES (@gebruikersnaam, @voornaam, @achternaam)";
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter voornaamParam = new MySqlParameter("@voornaam", MySqlDbType.VarChar);
                MySqlParameter achternaamParam = new MySqlParameter("@achternaam", MySqlDbType.VarChar);

                gebruikersnaamParam.Value = gebruikersnaam;
                voornaamParam.Value = voornaam;
                achternaamParam.Value = achternaam;

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(voornaamParam);
                command.Parameters.Add(achternaamParam);

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
                Console.WriteLine("Error in profielcontroller - voegprofieltoe: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public Profiel Get_Pofiel(Gebruiker _gebruiker)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM gebruiker_profiel WHERE gebruikersnaam = @gebruikersnaam";
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
                    profiel.Locatie = datalezer.GetString("locatie");
                    profiel.LocatieIsZichtbaar = datalezer.GetBoolean("locatie_iszichtbaar");
                    profiel.Functie = datalezer.GetString("functie");
                    profiel.FunctieIsZichtbaar = datalezer.GetBoolean("functie_iszichtbaar");
                    profiel.KwaliteitIsZichtbaar = datalezer.GetBoolean("kwaliteit_iszichtbaar");
                }

                // Haal kwaliteiten op
                conn.Close();
                profiel.KwaliteitenLijst = new List<string>();
                profiel.KwaliteitenLijst = Get_Kwaliteiten(_gebruiker);
                return profiel;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - Get_profiel: " + e);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> Get_Kwaliteiten(Gebruiker _gebruiker)
        {
            List<string> kwaliteitenLijst = new List<string>();
            try
            {
                conn.Open();
                string query = "SELECT kwaliteit FROM gebruiker_profiel_kwaliteiten WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter UN_PARAM = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                UN_PARAM.Value = _gebruiker.Gebruikersnaam;
                command.Parameters.Add(UN_PARAM);
                MySqlDataReader datalezer = command.ExecuteReader();

                while (datalezer.Read())
                {
                    kwaliteitenLijst.Add(datalezer.GetString("kwaliteit"));
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - Get_Kwaliteiten: " + e);
            }
            finally
            {
                conn.Close();
            }
            return kwaliteitenLijst;
        }

        public bool bestaatProfiel(Gebruiker _gebruiker)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM gebruiker_profiel WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                command.Parameters.Add(gebruikersnaamParam);
                MySqlDataReader lezer = command.ExecuteReader();

                bool bestaatProfiel = false;
                while (lezer.Read())
                {
                    bestaatProfiel = true;
                }
                return bestaatProfiel;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - bestaatprofiel: " + e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update_Profiel(Gebruiker _gebruiker, Profiel _profiel)
        {

            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                string query = @"UPDATE gebruiker_profiel SET voornaam = @Voornaam, achternaam = @Achternaam, locatie = @Locatie, locatie_iszichtbaar = @Locatie_iszichtbaar, functie = @Functie, functie_iszichtbaar = @Functie_iszichtbaar, kwaliteit_iszichtbaar = @Kwaliteit_iszichtbaar
                                WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlParameter UN_PARAM = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter VN_PARAM = new MySqlParameter("@Voornaam", MySqlDbType.VarChar);
                MySqlParameter AN_PARAM = new MySqlParameter("@Achternaam", MySqlDbType.VarChar);
                MySqlParameter LO_PARAM = new MySqlParameter("@Locatie", MySqlDbType.VarChar);
                MySqlParameter LO_iszichtbaar = new MySqlParameter("@Locatie_iszichtbaar", MySqlDbType.Int32);
                MySqlParameter FU_PARAM = new MySqlParameter("@Functie", MySqlDbType.VarChar);
                MySqlParameter FU_iszichtbaar = new MySqlParameter("@Functie_iszichtbaar", MySqlDbType.Int32);
                MySqlParameter KW_iszichtbaar = new MySqlParameter("@Kwaliteit_iszichtbaar", MySqlDbType.Int32);

                UN_PARAM.Value = _gebruiker.Gebruikersnaam;
                VN_PARAM.Value = _profiel.Voornaam;
                AN_PARAM.Value = _profiel.Achternaam;
                LO_PARAM.Value = _profiel.Locatie;
                LO_iszichtbaar.Value = _profiel.LocatieIsZichtbaar;
                FU_PARAM.Value = _profiel.Functie;
                FU_iszichtbaar.Value = _profiel.FunctieIsZichtbaar;
                KW_iszichtbaar.Value = _profiel.KwaliteitIsZichtbaar;

                command.Parameters.Add(UN_PARAM);
                command.Parameters.Add(VN_PARAM);
                command.Parameters.Add(AN_PARAM);
                command.Parameters.Add(LO_PARAM);
                command.Parameters.Add(LO_iszichtbaar);
                command.Parameters.Add(FU_PARAM);
                command.Parameters.Add(FU_iszichtbaar);
                command.Parameters.Add(KW_iszichtbaar);

                Profiel profiel = new Profiel();

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                bepaalUpdateKwaliteiten(_gebruiker, _profiel);
            }

            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in profielcontroller - update_profiel: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void bepaalUpdateKwaliteiten(Gebruiker _gebruiker, Profiel _profiel)
        {
            // Bepaal eerst het aantal huidige kwaliteiten van het profiel
            List<string> oudeKwaliteitLijst = new List<string>();
            try
            {
                conn.Open();
                string query = "SELECT kwaliteit FROM gebruiker_profiel_kwaliteiten WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("@gebruikersnaam", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                command.Parameters.Add(gebruikersnaamParam);
                MySqlDataReader lezer = command.ExecuteReader();

                while (lezer.Read())
                {
                    oudeKwaliteitLijst.Add(lezer.GetString("kwaliteit"));
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - updatekwaliteiten: " + e);
            }
            finally
            {
                conn.Close();
            }

            // Kijk of de kwaliteiten gelijk zijn aan elkaar
            bool isGelijk = oudeKwaliteitLijst.SequenceEqual(_profiel.KwaliteitenLijst);

            if (isGelijk == false)
            {
                // Update kwaliteiten
                if (_profiel.KwaliteitenLijst.Count() == oudeKwaliteitLijst.Count())
                {
                    int teller = 0;
                    foreach (string nieuwekwaliteit in _profiel.KwaliteitenLijst)
                    {
                        UpdateKwaliteit(_gebruiker, nieuwekwaliteit, oudeKwaliteitLijst[teller]);
                        teller++;
                    }
                }
                // Voer nieuwe kwaliteiten in als er nog geen kwaliteiten bestaan
                else if (oudeKwaliteitLijst.Count() == 0)
                {
                    foreach (string nieuwekwaliteit in _profiel.KwaliteitenLijst)
                    {
                        VoerKwaliteitIn(_gebruiker, nieuwekwaliteit);
                    }
                }

                // Voer nieuwe kwaliteiten in en update bestaande kwaliteiten
                else if (_profiel.KwaliteitenLijst.Count() > oudeKwaliteitLijst.Count())
                {
                    int teller = 0;
                    foreach (string nieuwekwaliteit in _profiel.KwaliteitenLijst)
                    {
                        if (teller >= oudeKwaliteitLijst.Count())
                        {
                            // Insert
                            VoerKwaliteitIn(_gebruiker, nieuwekwaliteit);
                            teller++;
                        }
                        else
                        {
                            // Update
                            UpdateKwaliteit(_gebruiker, nieuwekwaliteit, oudeKwaliteitLijst[teller]);
                            teller++;
                        }
                    }
                }

                // Verwijder kwaliteiten in en update bestaande kwaliteiten
                else if (_profiel.KwaliteitenLijst.Count() < oudeKwaliteitLijst.Count())
                {
                    int teller = 0;
                    foreach (string nieuwekwaliteit in _profiel.KwaliteitenLijst)
                    {
                        // Update
                        UpdateKwaliteit(_gebruiker, nieuwekwaliteit, oudeKwaliteitLijst[teller]);
                        teller++;
                    }

                    // Verwijder de kwaliteiten
                    int begintVanaf = _profiel.KwaliteitenLijst.Count();
                    int verschil = oudeKwaliteitLijst.Count();
                    for (int i = begintVanaf; i < verschil; i++)
                    {
                        VerwijderKwaliteit(_gebruiker, oudeKwaliteitLijst[i]);
                    }
                }
            }
        }

        public void VoerKwaliteitIn(Gebruiker _gebruiker, string kwaliteit)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO gebruiker_profiel_kwaliteiten (gebruikersnaam, kwaliteit) VALUES (@gebruikersnaam, @kwaliteit)";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter kwaliteitParam = new MySqlParameter("kwaliteit", MySqlDbType.VarChar);

                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                kwaliteitParam.Value = kwaliteit;

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(kwaliteitParam);

                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - VoerKwaliteitIn: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateKwaliteit(Gebruiker _gebruiker, string nieuweKwaliteit, string oudeKwaliteit)
        {
            try
            {
                conn.Open();
                string query = "UPDATE gebruiker_profiel_kwaliteiten SET kwaliteit = @nieuwekwaliteit WHERE gebruikersnaam = @gebruikersnaam AND kwaliteit = @oudekwaliteit";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter oudeKwaliteitParam = new MySqlParameter("oudekwaliteit", MySqlDbType.VarChar);
                MySqlParameter nieuweKwaliteitParam = new MySqlParameter("nieuwekwaliteit", MySqlDbType.VarChar);

                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                oudeKwaliteitParam.Value = oudeKwaliteit;
                nieuweKwaliteitParam.Value = nieuweKwaliteit;

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(oudeKwaliteitParam);
                command.Parameters.Add(nieuweKwaliteitParam);

                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - updatekwaliteiten: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
        public void VerwijderKwaliteit(Gebruiker _gebruiker, string oudeKwaliteit)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM gebruiker_profiel_kwaliteiten WHERE gebruikersnaam = @gebruikersnaam AND kwaliteit = @oudekwaliteit";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                MySqlParameter oudeKwaliteitParam = new MySqlParameter("oudekwaliteit", MySqlDbType.VarChar);

                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                oudeKwaliteitParam.Value = oudeKwaliteit;

                command.Parameters.Add(gebruikersnaamParam);
                command.Parameters.Add(oudeKwaliteitParam);

                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - verwijderkwaliteiten: " + e);
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
                string query = "DELETE FROM gebruiker_profiel WHERE gebruikersnaam = @gebruikersnaam";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter gebruikersnaamParam = new MySqlParameter("gebruikersnaam", MySqlDbType.VarChar);
                gebruikersnaamParam.Value = _gebruiker.Gebruikersnaam;
                command.Parameters.Add(gebruikersnaamParam);
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in profielcontroller - verwijderprofiel: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
