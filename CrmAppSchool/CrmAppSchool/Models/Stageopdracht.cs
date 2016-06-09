using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    public class Stageopdracht
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public Bedrijfcontact Bedrijf { get; set; }

        public override string ToString()
        {
            string opdracht = Naam +","+ Omschrijving + "," + Status + "," + Bedrijf;
            return opdracht;
        }
    }
}
