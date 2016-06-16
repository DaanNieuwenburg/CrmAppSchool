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
        public string Achternaam { get; set; }
        public string Locatie { get; set; }
        public bool LocatieIsZichtbaar { get; set; }
        public string Functie { get; set; }
        public bool FunctieIsZichtbaar { get; set; }
        public List<string> KwaliteitenLijst { get; set; }
        public bool KwaliteitIsZichtbaar { get; set; }
    }
}