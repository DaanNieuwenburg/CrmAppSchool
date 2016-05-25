﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmAppSchool.Models
{
    class Stageopdracht
    {
        public int Code { get; }
        public string Status { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }

        public string toString()
        {
            string opdracht = Naam +","+ Omschrijving + "," + Status;
            return opdracht;
        }
    }
}