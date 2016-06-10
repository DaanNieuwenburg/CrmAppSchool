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
using CrmAppSchool.Controllers;

namespace CrmAppSchool.Views.Contacten
{
    public partial class ContactBewerk : Form
    {
        public ContactBewerk(Persooncontact contact)
        {
            InitializeComponent();
            voornaamTb.Text = contact.Voornaam;
            achternaamTb.Text = contact.Achternaam;
            bedrijfTb.Text = contact.Bedrijf.Bedrijfnaam;
            functieTb.Text = contact.Functie;
            locatieTb.Text = contact.Locatie;
            emailTb.Text = contact.Email;
        }

        private void bewerkBtn_Click(object sender, EventArgs e)
        {
            Persooncontact bewerktContact = new Persooncontact();
            bewerktContact.Voornaam = voornaamTb.Text;
            bewerktContact.Achternaam = achternaamTb.Text;
            //bewerktContact.Bedrijf = bedrijfTb.Text;
            bewerktContact.Functie = functieTb.Text;
            bewerktContact.Locatie = locatieTb.Text;
            bewerktContact.Email = emailTb.Text;

            // Contactencontroller
            ContactenController cc = new ContactenController();
            cc.bewerkContact(bewerktContact);
        }
    }
}
