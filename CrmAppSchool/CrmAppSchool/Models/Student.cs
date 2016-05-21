using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Student : Gebruiker
    {
        public Student(string _gebruikersnaam)
        {
            Gebruikersnaam = _gebruikersnaam;
        }
    }
}
