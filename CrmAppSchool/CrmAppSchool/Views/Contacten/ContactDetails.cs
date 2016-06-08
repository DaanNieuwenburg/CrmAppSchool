using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAppSchool.Models;

namespace CrmAppSchool.Views.Contacten
{
    public partial class ContactDetails : Form
    {
        /* ????
        private string Contactnaam { get; set; }
        private string Voornaam { get; set; }
        private string Achternaam { get; set; }
        private string Bedrijf { get; set; }
        private string Functie { get; set; }
        private string Locatie { get; set; }
        private string Mobiel { get; set; }
        private string Email { get; set; }
        private string Prive_Email { get; set; }
        private string[] _contactinfo { get; set; }
        */
        private Persooncontact contact { get; set; }

        public ContactDetails(Persooncontact _contact)
        {
            InitializeComponent();

            /*_contactinfo = new string[4];
            _contactinfo = contactinfo;
            Contactnaam = _contact;
            lblVNvalue.Text = _contactinfo[0];
            lblANvalue.Text = _contactinfo[1];
            lblLOvalue.Text = _contactinfo[2];
            lblMvalue.Text = _contactinfo[3];*/

            lblVNvalue.Text = _contact.Voornaam;
            lblANvalue.Text = _contact.Achternaam;
            lblLOvalue.Text = _contact.Locatie;
            lblMvalue.Text = _contact.Email;

            contact = _contact;
        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lblContactnaam.Text = contact.Voornaam + contact.Achternaam;
        }
    }
}
