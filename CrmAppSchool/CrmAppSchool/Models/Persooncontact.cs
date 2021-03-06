﻿using System;
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
        public string volnaam { get; set; }
        public string Locatie { get; set; }
        public string Email { get; set; }
        public string Functie { get; set; }
        public string[] Kwaliteiten { get; set; }
        public string Afdeling { get; set; }
        public bool Isgastdocent { get; set; }
        public bool Isstagebegeleider { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public Bedrijfcontact Bedrijf { get; set; }
    }
    
}
