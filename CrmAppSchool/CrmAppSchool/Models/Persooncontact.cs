using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Persooncontact
    {
        public int Contactcode { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Bedrijf { get; set; }
        public string Email { get; set; }
        public bool Isgastspreker{ get; set; }
        public bool Isgastdocent { get; set; }
        public bool Isstagebegeleider { get; set; }
        public bool Iscontactpersoon { get; set; }
        public int Afdelingscode { get; set; }
    }
}
