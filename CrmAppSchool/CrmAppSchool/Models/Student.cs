using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Student
    {
        public string Gebruikersnaam { get; set; }
        public Student(string _gebruikersnaam)
        {
            Gebruikersnaam = _gebruikersnaam;
        }
    }
}
