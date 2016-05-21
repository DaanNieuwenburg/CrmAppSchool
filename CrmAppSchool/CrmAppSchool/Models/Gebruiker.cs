using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public abstract class Gebruiker
    {
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
    }
}
