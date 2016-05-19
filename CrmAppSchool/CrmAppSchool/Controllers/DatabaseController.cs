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
            conn = new MySqlConnection("Server=172.98.192.163;Database=localhost;Uid=crmapp;Pwd=1234");
        }
    }
}
