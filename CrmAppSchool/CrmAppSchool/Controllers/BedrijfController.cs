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
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in contactencontroller - voegpersoontoe: " + e);
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
                string query = @"DELETE FROM bedrijf WHERE bedrijfcode = @bedrijfcode";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter codeParam = new MySqlParameter("bedrijfcode", MySqlDbType.Int32);

                codeParam.Value = bedrijfcode;

                command.Parameters.Add(codeParam);
                command.Prepare();

                command.ExecuteNonQuery();


            }
            catch(MySqlException e)
            {
                if(trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in bedrijfcontroller - verwijderbedrijf: " + e);
                if((uint)e.ErrorCode == 0x80004005)
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
                Console.WriteLine("Error in contactencontroller - haalbedrijflijstop: " + e);
            }
            finally
            {
                conn.Close();
            }
            return contactenlijst;
        }
        public void bewerkContact(Bedrijfcontact contact)
        {
            try
            {
                conn.Open();
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
            }


            catch (MySqlException e)
            {
                Console.WriteLine("Error in Bedrijfcontroller - bewerkContact: " + e);
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
                Console.WriteLine("Error in contactencontroller - haalbedrijflijstop: " + e);
            }
            finally
            {
                conn.Close();
            }
            return contact;
        }
    }
}
