using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    class Stageopdracht
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }

        public override string ToString()
        {
            string opdracht = Naam +","+ Omschrijving + "," + Status;
            return opdracht;
        }

        public enum status
        {
            test
        }
    }
}
