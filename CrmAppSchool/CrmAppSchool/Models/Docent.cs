using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Docent : Gebruiker
    {
        public Docent(string _gebruikersnaam)
        {
            Gebruikersnaam = _gebruikersnaam;
        }
    }
}
