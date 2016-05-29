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

                while(lezer.Read())
                {
                    string gebruikersnaam = lezer.GetString("gebruikersnaam");
                    bool isadmin = lezer.GetBoolean("isadmin");
                    bool isdocent = lezer.GetBoolean("isdocent");
                    bool isstudent = lezer.GetBoolean("isstudent");
                    if(isadmin == true)
                    {
                        gebruikersLijst.Add(new Admin(gebruikersnaam));
                    }
                    else if(isdocent == true)
                    {
                        gebruikersLijst.Add(new Docent(gebruikersnaam));
                    }
                    else if(isstudent == true)
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
    }
}
