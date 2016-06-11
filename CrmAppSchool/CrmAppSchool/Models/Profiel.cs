using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Profiel
    {
        public string Gebruikersnaam { get; set; }
        public string Voornaam { get; set; }
        public bool VoornaamIsZichtbaar { get; set; }
        public string Achternaam { get; set; }
        public bool AchternaamIsZichtbaar { get; set; }
        public string Bedrijf { get; set; }
        public bool BedrijfIsZichtbaar { get; set; }
        public string Locatie { get; set; }
        public bool LocatieIsZichtbaar { get; set; }
        public string Functie { get; set; }
        public bool FunctieIsZichtbaar { get; set; }
        public string Kwaliteit { get; set; }
        public bool KwaliteitIsZichtbaar { get; set; }
    }
}