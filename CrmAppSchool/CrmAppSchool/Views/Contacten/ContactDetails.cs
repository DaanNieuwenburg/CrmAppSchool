using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmAppSchool.Views.Contacten
{
    public partial class ContactDetails : Form
        
    {
        private string Voornaam { get; set; }
        private string Achternaam { get; set; }
        private string Bedrijf { get; set; }
        private string Functie { get; set; }
        private string Locatie { get; set; }
        private string Mobiel { get; set; }
        private string Email { get; set; }
        private string Prive_Email { get; set; }

        public ContactDetails()
        {
            InitializeComponent();
        }
    }
}
