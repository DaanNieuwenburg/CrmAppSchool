using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CrmAppSchool.Controllers
{
    public abstract class DatabaseController
    {
        protected MySqlConnection conn;
        public DatabaseController()
        {
            // DB is ook te bereiken met deze credentials via MySql Workbench
            conn = new MySqlConnection("Server=database.asuscomm.com;Database=crmapp;Uid=school;Pwd=1234");

        }
    }
}
