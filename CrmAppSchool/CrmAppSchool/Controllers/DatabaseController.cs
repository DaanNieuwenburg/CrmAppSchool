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
            conn = new MySqlConnection("Server=127.0.0.1;Database=crmapp;Uid=root;Pwd=root");
        }
    }
}
