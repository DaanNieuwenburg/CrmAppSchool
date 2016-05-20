using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Admin
    {
        public string Gebruikersnaam { get; set; }
        public Admin(string _gebruikersnaam)
        {
            Gebruikersnaam = _gebruikersnaam;
        }
    }
}
