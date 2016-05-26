﻿using CrmAppSchool.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Controllers
{
    class StageopdrachtController : DatabaseController
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
                    int code = dataReader.GetInt32("code");
                    string status = dataReader.GetString("status");
                    string naam = dataReader.GetString("naam");
                    string omschrijving = dataReader.GetString("omschrijving");
                    Stageopdracht opdracht = new Stageopdracht { Code = code, Status = status, Naam = naam, Omschrijving = omschrijving };

                    opdrachten.Add(opdracht);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van stageopdrachten mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return opdrachten;
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

                while (dataReader.Read())
                {
                    int code = dataReader.GetInt32("code");
                    string status = dataReader.GetString("status");
                    string naam = dataReader.GetString("naam");
                    string omschrijving = dataReader.GetString("omschrijving");
                    Stageopdracht opdracht = new Stageopdracht { Code = code, Status = status, Naam = naam, Omschrijving = omschrijving };

                    opdrachten.Add(opdracht);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ophalen van stageopdrachten mislukt" + ex);
            }
            finally
            {
                conn.Close();
            }

            return opdrachten;
        }

        public void deleteStageopdracht(int opdrachtcode)
        {
            MySqlTransaction trans = null;
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                string insertString = @"DELETE FROM stageopdracht WHERE code = @code";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter opdrachtcodeParam = new MySqlParameter("@code", MySqlDbType.Int32);

                opdrachtcodeParam.Value = opdrachtcode;

                cmd.Parameters.Add(opdrachtcodeParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                Console.WriteLine("opdracht niet verwijderd: " + ex);
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
                string insertString = @"INSERT INTO stageopdracht (status,naam, omschrijving) VALUES (@status, @naam, @omschrijving)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);
                MySqlParameter statusParam = new MySqlParameter("@status", MySqlDbType.VarChar);
                MySqlParameter naamParam = new MySqlParameter("@naam", MySqlDbType.VarChar);
                MySqlParameter omschrijvingParam = new MySqlParameter("@omschrijving", MySqlDbType.VarChar);

                statusParam.Value = opdracht.Status;
                naamParam.Value = opdracht.Naam;
                omschrijvingParam.Value = opdracht.Omschrijving;

                cmd.Parameters.Add(statusParam);
                cmd.Parameters.Add(naamParam);
                cmd.Parameters.Add(omschrijvingParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();   //FIXME: This will be a problem!
                }
                Console.WriteLine("Genre niet toegeveogd: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
