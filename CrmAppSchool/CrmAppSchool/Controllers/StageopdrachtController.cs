using CrmAppSchool.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Controllers
{
    public class StageopdrachtController : DatabaseController
    {
        public List<Stageopdracht> getOpdrachten()
        {
            List<Stageopdracht> opdrachten = new List<Stageopdracht>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM stageopdracht";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int code = dataReader.GetInt32("opdrachtcode");

                    string status = dataReader.GetString("status");
                    string naam = dataReader.GetString("naam");
                    string omschrijving = dataReader.GetString("omschrijving");
                    int bedrijfcode = dataReader.GetInt32("bedrijfcode");
                    int contactcode = dataReader.GetInt32("contactcode");
                    Stageopdracht opdracht = new Stageopdracht { Code = code, Status = status, Naam = naam, Omschrijving = omschrijving };
                    BedrijfController bc = new BedrijfController();
                    Bedrijfcontact bedrijfcontact = bc.SelecteerBedrijf(bedrijfcode);
                    ContactenController cc = new ContactenController();
                    Persooncontact persooncontact = cc.HaalInfoOp(contactcode.ToString());
                    Console.WriteLine("de bnaam = " + bedrijfcontact.Bedrijfnaam);
                    opdracht.Bedrijf = bedrijfcontact;
                    opdracht.Contact = persooncontact;
                    opdrachten.Add(opdracht);
                }
                return opdrachten;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in stageopdrachtcontroller - getopdrachten " + e);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }
        public Stageopdracht HaalInfoOp(string opdrachtcode)
        {
            Stageopdracht opdracht = new Stageopdracht();
            try
            {
                conn.Open();
                string query = @"SELECT * FROM stageopdracht
                                JOIN bedrijf on stageopdracht.bedrijfcode = bedrijf.bedrijfcode
                                JOIN contactpersoon on stageopdracht.contactcode = contactpersoon.contactcode
                                WHERE opdrachtcode = @opdrachtcode";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter opdrachtcodeParam = new MySqlParameter("@opdrachtcode", MySqlDbType.Int32);

                opdrachtcodeParam.Value = opdrachtcode;
                command.Parameters.Add(opdrachtcodeParam);

                command.Prepare();
                MySqlDataReader datalezer = command.ExecuteReader();

                while (datalezer.Read())
                {
                    opdracht.Naam = datalezer.GetString("naam");
                    opdracht.Omschrijving = datalezer.GetString("omschrijving");
                    opdracht.Bedrijf = new Bedrijfcontact();
                    opdracht.Bedrijf.Bedrijfnaam = datalezer.GetString("bedrijfnaam");
                    Console.WriteLine("Test: " + datalezer.GetString("bedrijfnaam"));
                    opdracht.Contact = new Persooncontact();
                    opdracht.Contact.Voornaam = datalezer.GetString("voornaam");
                    opdracht.Contact.Achternaam = datalezer.GetString("achternaam");
                    opdracht.Status = datalezer.GetString("status");
                }

            }
            catch (MySqlException e)
            {
                
                Console.WriteLine("Error in stageopdrachtcontroller - haalinfoop: " + e);
            }
            finally
            {
                conn.Close();
            }

            return opdracht;
        }
        public List<Stageopdracht> ZoekOpdrachten(string tekst)
        {
            List<Stageopdracht> opdrachten = new List<Stageopdracht>();

            try
            {
                conn.Open();

                string selectQuery = @"SELECT * FROM stageopdracht where naam like @naam";
                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                MySqlParameter naamParam = new MySqlParameter("@naam", MySqlDbType.String);
                naamParam.Value = tekst;
                cmd.Parameters.Add(naamParam);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                int bedrijfcode = 0;
                while (dataReader.Read())
                {
                    int code = dataReader.GetInt32("opdrachtcode");
                    string status = dataReader.GetString("status");
                    string naam = dataReader.GetString("naam");
                    string omschrijving = dataReader.GetString("omschrijving");
                    bedrijfcode = dataReader.GetInt32("bedrijfcode");
                    Stageopdracht opdracht = new Stageopdracht { Code = code, Status = status, Naam = naam, Omschrijving = omschrijving };
                    BedrijfController bc = new BedrijfController();
                    Bedrijfcontact bedrijfcontact = bc.SelecteerBedrijf(bedrijfcode);
                    Console.WriteLine("de bnaam = " + bedrijfcontact.Bedrijfnaam);
                    opdracht.Bedrijf = bedrijfcontact;
                    opdrachten.Add(opdracht);
                }
                return opdrachten;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in stageopdrachtcontroller - zoekopdrachten: " + e);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        public void deleteStageopdracht(int opdrachtcode)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string insertString = @"DELETE FROM stageopdracht WHERE opdrachtcode = @code";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter opdrachtcodeParam = new MySqlParameter("@code", MySqlDbType.Int32);

                opdrachtcodeParam.Value = opdrachtcode;

                cmd.Parameters.Add(opdrachtcodeParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in stageopdrachtcontroller - deletestageopdracht: " + e);
            }
            finally
            {
                conn.Close();
            }

        }

        public void InsertStageopdracht(Stageopdracht opdracht)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string insertString = @"INSERT INTO stageopdracht (status, naam, omschrijving, bedrijfcode, contactcode) VALUES (@status, @naam, @omschrijving, @bedrijf, @contact)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter statusParam = new MySqlParameter("@status", MySqlDbType.VarChar);
                MySqlParameter naamParam = new MySqlParameter("@naam", MySqlDbType.VarChar);
                MySqlParameter omschrijvingParam = new MySqlParameter("@omschrijving", MySqlDbType.VarChar);
                MySqlParameter bedrijfParam = new MySqlParameter("@bedrijf", MySqlDbType.Int32);
                MySqlParameter contactParam = new MySqlParameter("@contact", MySqlDbType.Int32);

                statusParam.Value = opdracht.Status;
                naamParam.Value = opdracht.Naam;
                omschrijvingParam.Value = opdracht.Omschrijving;
                bedrijfParam.Value = opdracht.Bedrijf.Bedrijfscode;
                contactParam.Value = opdracht.Contact.Contactcode;

                cmd.Parameters.Add(statusParam);
                cmd.Parameters.Add(naamParam);
                cmd.Parameters.Add(omschrijvingParam);
                cmd.Parameters.Add(bedrijfParam);
                cmd.Parameters.Add(contactParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in stageopdrachtcontroller - insertstageopdracht: " + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void updateStageopdracht(int code, string status, string naam, string omschrijving, int bedrijf, int contact)
        {

            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string insertString = @"UPDATE stageopdracht SET status = @status, naam = @naam, omschrijving = @omschrijving, bedrijfcode = @bedrijf, contactcode = @contact WHERE opdrachtcode= @code";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter codeParam = new MySqlParameter("@code", MySqlDbType.Bit);
                MySqlParameter statusParam = new MySqlParameter("@status", MySqlDbType.VarChar);
                MySqlParameter naamParam = new MySqlParameter("@naam", MySqlDbType.VarChar);
                MySqlParameter omschrijvingParam = new MySqlParameter("@omschrijving", MySqlDbType.VarChar);
                MySqlParameter bedrijfParam = new MySqlParameter("@bedrijf", MySqlDbType.Int32);
                MySqlParameter contactParam = new MySqlParameter("@contact", MySqlDbType.Int32);

                statusParam.Value = status;
                naamParam.Value = naam;
                omschrijvingParam.Value = omschrijving;
                codeParam.Value = code;
                bedrijfParam.Value = bedrijf;
                contactParam.Value = contact;

                cmd.Parameters.Add(codeParam);
                cmd.Parameters.Add(statusParam);
                cmd.Parameters.Add(omschrijvingParam);
                cmd.Parameters.Add(naamParam);
                cmd.Parameters.Add(bedrijfParam);
                cmd.Parameters.Add(contactParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("Error in stageopdrachtcontroller - updatestageopdracht " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
