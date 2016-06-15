using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Bedrijfcontact
    {
        public int Bedrijfscode { get; set; }
        public string Bedrijfnaam { get; set; }
        public string Hoofdlocatie { get; set; }
        public string Website { get; set; }
        public string Contactpersoon { get; set; }
        public string Email { get; set; }
        public List<string> Kwaliteiten { get; set; }
        public string Telefoonnr { get; set; }
        public string Omschrijving { get; set; }
    }
}
