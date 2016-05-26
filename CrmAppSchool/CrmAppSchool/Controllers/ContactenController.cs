using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrmAppSchool.Models;

namespace CrmAppSchool.Controllers
{
    class ContactenController : DatabaseController
    {

        public void voegPersoonToe(Persooncontact contact)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO persooncontact (voornaam, achternaam, locatie, email, isgastspreker, isgastdocent, isstagebegeleider, iscontactpersoon, afdelingscode)
                                 VALUES (@voornaam, @achternaam, @locatie, @email, @isgastspreker, @isgastdocent, @isstagebegeleider, @iscontactpersoon, @afdelingscode)";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlParameter voornaamParam = new MySqlParameter("voornaam", MySqlDbType.VarChar);
                MySqlParameter achternaamParam = new MySqlParameter("achternaam", MySqlDbType.VarChar);
                MySqlParameter locatieParam = new MySqlParameter("locatie", MySqlDbType.VarChar);
                MySqlParameter emailParam = new MySqlParameter("email", MySqlDbType.VarChar);
                MySqlParameter isgastsprekerParam = new MySqlParameter("isgastspreker", MySqlDbType.Binary);
                MySqlParameter isgastdocentParam = new MySqlParameter("isgastdocent", MySqlDbType.Binary);
                MySqlParameter isstagebegeleiderParam = new MySqlParameter("isstagebegeleider", MySqlDbType.Binary);
                MySqlParameter iscontactpersoonParam = new MySqlParameter("iscontactpersoon", MySqlDbType.Binary);
                MySqlParameter afdelingscodeParam = new MySqlParameter("afdelingscode", MySqlDbType.Int32);

                voornaamParam.Value = contact.Voornaam;
                achternaamParam.Value = contact.Achternaam;
                locatieParam.Value = contact.Locatie;
                emailParam.Value = contact.Email;
                isgastsprekerParam.Value = contact.Isgastspreker;
                isgastdocentParam.Value = contact.Isgastdocent;
                isstagebegeleiderParam.Value = contact.Isstagebegeleider;
                iscontactpersoonParam.Value = contact.Iscontactpersoon;
                afdelingscodeParam.Value = contact.Afdelingscode;

                command.Parameters.Add(voornaamParam);
                command.Parameters.Add(achternaamParam);
                command.Parameters.Add(locatieParam);
                command.Parameters.Add(emailParam);
                command.Parameters.Add(isgastsprekerParam);
                command.Parameters.Add(isgastdocentParam);
                command.Parameters.Add(isstagebegeleiderParam);
                command.Parameters.Add(iscontactpersoonParam);
                command.Parameters.Add(afdelingscodeParam);

                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                Console.WriteLine("voegPersoonToe kan helaas geen persoon toevoegen: " + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
