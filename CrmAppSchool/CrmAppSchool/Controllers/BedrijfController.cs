using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;
using System.Windows.Forms;

namespace CrmAppSchool.Controllers
{
    public class BedrijfController : DatabaseController
    {
        public void voegBedrijfToe(Bedrijfcontact contact)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO bedrijf (bedrijfnaam, hoofdlocatie, website, email, omschrijving)
                                 VALUES (@bedrijfnaam, @hoofdlocatie, @website, @email, @omschrijving)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfnaamParam = new MySqlParameter("bedrijfnaam", MySqlDbType.VarChar);
                MySqlParameter hoofdlocatieParam = new MySqlParameter("hoofdlocatie", MySqlDbType.VarChar);
                MySqlParameter websiteParam = new MySqlParameter("website", MySqlDbType.VarChar);
                MySqlParameter emailParam = new MySqlParameter("email", MySqlDbType.VarChar);
                MySqlParameter telefoonnrParam = new MySqlParameter("telefoonnr", MySqlDbType.VarChar);
                MySqlParameter omschrijvingParam = new MySqlParameter("omschrijving", MySqlDbType.VarChar);

                bedrijfnaamParam.Value = contact.Bedrijfnaam;
                hoofdlocatieParam.Value = contact.Hoofdlocatie;
                websiteParam.Value = contact.Website;
                emailParam.Value = contact.Email;
                telefoonnrParam.Value = contact.Telefoonnr;
                omschrijvingParam.Value = contact.Omschrijving;

                command.Parameters.Add(bedrijfnaamParam);
                command.Parameters.Add(hoofdlocatieParam);
                command.Parameters.Add(websiteParam);
                command.Parameters.Add(emailParam);
                command.Parameters.Add(telefoonnrParam);
                command.Parameters.Add(omschrijvingParam);

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();

                // Zet de kwaliteiten in de kwaliteiten tabel
                conn.Close();
                long primaryKey = command.LastInsertedId;
                foreach (string kwaliteit in contact.Kwaliteiten)
                {
                    voegBedrijfKwaliteitToe(kwaliteit, primaryKey);
                }
            }
            catch (MySqlException e)
            {
                if ((uint)e.ErrorCode == 0x80004005)
                {
                    MessageBox.Show("Dit bedrijf kan niet toegevoegd worden: dit bedrijf bestaat al");
                }
                else
                {
                    Console.WriteLine("Error in bedrijfcontroller - voegpersoontoe: " + e);
                }
                if (trans != null)
                {
                    trans.Rollback();
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public void verwijderBedrijf(int bedrijfcode)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"DELETE FROM bedrijf WHERE bedrijfcode = @bedrijfcode";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter codeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);

                codeParam.Value = bedrijfcode;

                command.Parameters.Add(codeParam);
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
                Console.WriteLine("Error in bedrijfcontroller - verwijderbedrijf: " + e);
                if ((uint)e.ErrorCode == 0x80004005)
                {
                    MessageBox.Show("Dit bedrijf kan niet verwijderd worden: er zijn nog contacten voor dit bedrijf");
                }

            }
            finally
            {
                conn.Close();
            }
        }
        public void voegBedrijfKwaliteitToe(string kwaliteit, long id)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"INSERT INTO bedrijf_kwaliteiten (bedrijfcode, kwaliteit)
                                 VALUES (@bedrijfcode, @kwaliteit)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);
                MySqlParameter kwaliteitParam = new MySqlParameter("kwaliteit", MySqlDbType.VarChar);

                bedrijfcodeParam.Value = id;
                kwaliteitParam.Value = kwaliteit;


                command.Parameters.Add(bedrijfcodeParam);
                command.Parameters.Add(kwaliteitParam);

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
                Console.WriteLine("Error in bedrijfcontroller - voegbedrijfkwaliteittoe: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
        public List<string> Get_Kwaliteiten(Gebruiker _gebruiker, Bedrijfcontact _contact)
        {
            List<string> kwaliteitenLijst = new List<string>();
            try
            {
                conn.Open();
                string query = "SELECT kwaliteit FROM bedrijf_kwaliteiten WHERE bedrijfcode = @bedrijfcode";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter BC_PARAM = new MySqlParameter("@bedrijfcode", MySqlDbType.VarChar);
                BC_PARAM.Value = _contact.Bedrijfscode;
                command.Parameters.Add(BC_PARAM);
                MySqlDataReader datalezer = command.ExecuteReader();

                while (datalezer.Read())
                {
                    kwaliteitenLijst.Add(datalezer.GetString("kwaliteit"));
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in Bedrijfcontroller - Get_Kwaliteiten: " + e);
            }
            finally
            {
                conn.Close();
            }
            return kwaliteitenLijst;
        }





        public List<Bedrijfcontact> ZoekBedrijven(string tekst, Gebruiker gebruiker)
        {
            List<Bedrijfcontact> resultaten = new List<Bedrijfcontact>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM bedrijf where bedrijfnaam LIKE @bedrijfnaam";

                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlParameter bedrijfParam = new MySqlParameter("@bedrijfnaam", MySqlDbType.VarChar);
                bedrijfParam.Value = tekst;
                cmd.Parameters.Add(bedrijfParam);

                cmd.Prepare();
                MySqlDataReader datalezer = cmd.ExecuteReader();
                while (datalezer.Read())
                {
                    Bedrijfcontact contact = new Bedrijfcontact();
                    contact.Bedrijfscode = datalezer.GetInt32("bedrijfcode");
                    contact.Bedrijfnaam = datalezer.GetString("bedrijfnaam");
                    contact.Hoofdlocatie = datalezer.GetString("hoofdlocatie");
                    contact.Telefoonnr = datalezer["telefoonnr"] as string;
                    contact.Email = datalezer.GetString("email");
                    contact.Website = datalezer.GetString("website");
                    contact.Omschrijving = datalezer["omschrijving"] as string;
                    resultaten.Add(contact);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Bedrijfcontroller - Zoekbedrijf: " + e);
            }
            finally
            {

                conn.Close();

            }
            return resultaten;
        }
        public List<Bedrijfcontact> haalBedrijfLijstOp()
        {
            List<Bedrijfcontact> contactenlijst = new List<Bedrijfcontact>();
            try
            {
                conn.Open();
                string query = @"SELECT bedrijfcode, bedrijfnaam FROM bedrijf ORDER BY bedrijfnaam asc"; // AANGEPAST
                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Bedrijfcontact contact = new Bedrijfcontact();
                    contact.Bedrijfscode = dataReader.GetInt32("bedrijfcode");
                    contact.Bedrijfnaam = dataReader.GetString("bedrijfnaam");
                    /*if (contactenlijst.Contains(contact))*/
                    contactenlijst.Add(contact);


                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in bedrijfcontroller - haalbedrijflijstop: " + e);
            }
            finally
            {
                conn.Close();
            }
            return contactenlijst;
        }
        public void bewerkContact(Bedrijfcontact contact)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = @"UPDATE bedrijf SET bedrijfnaam = @bedrijfnaam, hoofdlocatie = @hoofdlocatie, website = @website, email = @email, telefoonnr = @telefoonnr WHERE bedrijfcode = @code";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfnaamParam = new MySqlParameter("bedrijfnaam", MySqlDbType.VarChar);
                MySqlParameter hoofdlocatieParam = new MySqlParameter("hoofdlocatie", MySqlDbType.VarChar);
                MySqlParameter websiteParam = new MySqlParameter("website", MySqlDbType.VarChar);
                MySqlParameter emailParam = new MySqlParameter("email", MySqlDbType.VarChar);
                MySqlParameter telefoonnrParam = new MySqlParameter("telefoonnr", MySqlDbType.VarChar);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("code", MySqlDbType.Int32);


                bedrijfnaamParam.Value = contact.Bedrijfnaam;
                hoofdlocatieParam.Value = contact.Hoofdlocatie;
                websiteParam.Value = contact.Website;
                emailParam.Value = contact.Email;
                telefoonnrParam.Value = contact.Telefoonnr;
                bedrijfcodeParam.Value = contact.Bedrijfscode;


                command.Parameters.Add(bedrijfnaamParam);
                command.Parameters.Add(hoofdlocatieParam);
                command.Parameters.Add(websiteParam);
                command.Parameters.Add(emailParam);
                command.Parameters.Add(telefoonnrParam);
                command.Parameters.Add(bedrijfcodeParam);

                command.Prepare();
                command.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                bepaalUpdateKwaliteiten(contact);
            }


            catch (MySqlException e)
            {
                if((uint)e.ErrorCode == 0x80004005)
                {
                    MessageBox.Show("De bedrijfnaam kan niet bewerkt worden: dit bedrijf bestaat al");
                }
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in Bedrijfcontroller - bewerkContact: " + e);
            }
            finally
            {
                conn.Close();
            }
        }


        public void bepaalUpdateKwaliteiten(Bedrijfcontact bedrijf)
        {
            // Bepaal eerst het aantal huidige kwaliteiten van het profiel
            List<string> oudeKwaliteitLijst = new List<string>();
            try
            {
                conn.Open();
                string query = "SELECT kwaliteit FROM bedrijf_kwaliteiten WHERE bedrijfcode = @bedrijfcode";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("@bedrijfcode", MySqlDbType.Int32);
                bedrijfcodeParam.Value = bedrijf.Bedrijfscode;
                command.Parameters.Add(bedrijfcodeParam);
                MySqlDataReader lezer = command.ExecuteReader();

                while (lezer.Read())
                {
                    oudeKwaliteitLijst.Add(lezer.GetString("kwaliteit"));
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in bedrijfcontroller - bepaalUpdatekwaliteiten: " + e);
            }
            finally
            {
                conn.Close();
            }

            // Kijk of de kwaliteiten gelijk zijn aan elkaar
            Bedrijfcontact tempbedrijf = new Bedrijfcontact();
            tempbedrijf.Kwaliteiten = oudeKwaliteitLijst;
            bool isGelijk = tempbedrijf.Kwaliteiten.SequenceEqual(bedrijf.Kwaliteiten);

            if (isGelijk == false)
            {
                // Update kwaliteiten
                if (bedrijf.Kwaliteiten.Count() == tempbedrijf.Kwaliteiten.Count())
                {
                    Console.WriteLine("KW UPDATE");
                    int teller = 0;
                    foreach (string nieuwekwaliteit in bedrijf.Kwaliteiten)
                    {
                        if (nieuwekwaliteit != "")
                        {
                            UpdateKwaliteit(bedrijf, nieuwekwaliteit, tempbedrijf.Kwaliteiten[teller]);
                        }
                        teller++;
                    }
                }
                // Voer nieuwe kwaliteiten in als er nog geen kwaliteiten bestaan
                else if (tempbedrijf.Kwaliteiten.Count() == 0)
                {
                    Console.WriteLine("KW INVOER NIEUW");
                    foreach (string nieuwekwaliteit in bedrijf.Kwaliteiten)
                    {
                        if (nieuwekwaliteit != "")
                        {
                            VoerKwaliteitIn(bedrijf, nieuwekwaliteit);
                        }
                    }
                }

                // Voer nieuwe kwaliteiten in en update bestaande kwaliteiten
                else if (bedrijf.Kwaliteiten.Count() > tempbedrijf.Kwaliteiten.Count())
                {
                    Console.WriteLine("KW UPDATE en voer in");
                    int teller = 0;
                    foreach (string nieuwekwaliteit in bedrijf.Kwaliteiten)
                    {
                        if (teller >= oudeKwaliteitLijst.Count())
                        {
                            // Insert
                            if (nieuwekwaliteit != "")
                            {
                                VoerKwaliteitIn(bedrijf, nieuwekwaliteit);
                            }
                            teller++;
                        }
                        else
                        {
                            // Update
                            if (nieuwekwaliteit != "")
                            {
                                UpdateKwaliteit(bedrijf, nieuwekwaliteit, oudeKwaliteitLijst[teller]);
                            }
                            teller++;
                        }
                    }
                }

                // Verwijder kwaliteiten in en update bestaande kwaliteiten
                else if (bedrijf.Kwaliteiten.Count() < oudeKwaliteitLijst.Count())
                {
                    Console.WriteLine("KW UPDATE en VERWIJDER");
                    int teller = 0;
                    foreach (string nieuwekwaliteit in bedrijf.Kwaliteiten)
                    {
                        // Update
                        if (nieuwekwaliteit != "")
                        {
                            UpdateKwaliteit(bedrijf, nieuwekwaliteit, oudeKwaliteitLijst[teller]);
                        }
                        teller++;
                    }

                    // Verwijder de kwaliteiten
                    int begintVanaf = bedrijf.Kwaliteiten.Count();
                    int verschil = oudeKwaliteitLijst.Count();
                    for (int i = begintVanaf; i < verschil; i++)
                    {
                        VerwijderKwaliteit(bedrijf, oudeKwaliteitLijst[i]);
                    }
                }
            }
        }

        public void VoerKwaliteitIn(Bedrijfcontact bedrijf, string kwaliteit)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = "INSERT INTO bedrijf_kwaliteiten (bedrijfcode, kwaliteit) VALUES (@bedrijfcode, @kwaliteit)";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);
                MySqlParameter kwaliteitParam = new MySqlParameter("kwaliteit", MySqlDbType.VarChar);

                bedrijfcodeParam.Value = bedrijf.Bedrijfscode;
                kwaliteitParam.Value = kwaliteit;

                command.Parameters.Add(bedrijfcodeParam);
                command.Parameters.Add(kwaliteitParam);

                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in bedrijfcontroller - VoerKwaliteitIn: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateKwaliteit(Bedrijfcontact bedrijf, string nieuweKwaliteit, string oudeKwaliteit)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = "UPDATE bedrijf_kwaliteiten SET kwaliteit = @nieuwekwaliteit WHERE bedrijfcode = @bedrijfcode AND kwaliteit = @oudekwaliteit";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);
                MySqlParameter oudeKwaliteitParam = new MySqlParameter("oudekwaliteit", MySqlDbType.VarChar);
                MySqlParameter nieuweKwaliteitParam = new MySqlParameter("nieuwekwaliteit", MySqlDbType.VarChar);

                bedrijfcodeParam.Value = bedrijf.Bedrijfscode;
                oudeKwaliteitParam.Value = oudeKwaliteit;
                nieuweKwaliteitParam.Value = nieuweKwaliteit;

                command.Parameters.Add(bedrijfcodeParam);
                command.Parameters.Add(oudeKwaliteitParam);
                command.Parameters.Add(nieuweKwaliteitParam);

                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in bedrijfcontroller - updatekwaliteiten: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
        public void VerwijderKwaliteit(Bedrijfcontact bedrijf, string oudeKwaliteit)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string query = "DELETE FROM bedrijf_kwaliteiten WHERE bedrijfcode = @bedrijfcode AND kwaliteit = @oudekwaliteit";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);
                MySqlParameter oudeKwaliteitParam = new MySqlParameter("oudekwaliteit", MySqlDbType.VarChar);

                bedrijfcodeParam.Value = bedrijf.Bedrijfscode;
                oudeKwaliteitParam.Value = oudeKwaliteit;

                command.Parameters.Add(bedrijfcodeParam);
                command.Parameters.Add(oudeKwaliteitParam);

                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (MySqlException e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in bedrijfcontroller - verwijderkwaliteiten: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public Bedrijfcontact SelecteerBedrijf(int bedrijfcode)
        {
            Bedrijfcontact contact = new Bedrijfcontact();
            try
            {
                conn.Open();
                string query = @"SELECT * FROM bedrijf WHERE bedrijfcode = @bedrijfcode";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter bedrijfcodeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);

                bedrijfcodeParam.Value = bedrijfcode;
                command.Parameters.Add(bedrijfcodeParam);

                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    contact.Bedrijfscode = dataReader.GetInt32("bedrijfcode");
                    contact.Bedrijfnaam = dataReader.GetString("bedrijfnaam");
                    contact.Hoofdlocatie = dataReader.GetString("hoofdlocatie");
                    contact.Website = dataReader.GetString("website");
                    contact.Email = dataReader.GetString("email");
                    contact.Telefoonnr = dataReader["telefoonnr"] as string;
                    contact.Omschrijving = dataReader["omschrijving"] as string;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in bedrijfcontroller - haalbedrijflijstop: " + e);
            }
            finally
            {
                conn.Close();
            }
            return contact;
        }
    }
}
