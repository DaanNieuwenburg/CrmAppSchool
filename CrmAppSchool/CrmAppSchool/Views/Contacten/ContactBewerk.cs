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
        private int contactcode { get; set;}
        private int bedrijfcode { get; set; }
        public ContactBewerk(Persooncontact contact)
        {
            InitializeComponent();

            // Vult de bedrijven combobox met bedrijven
            BedrijfController bc = new BedrijfController();
            bedrijfCbx.DataSource = bc.haalBedrijfLijstOp();
            bedrijfCbx.DisplayMember = "Bedrijfnaam";
            bedrijfCbx.ValueMember = "Bedrijfscode";

            // Zet de combobox selectie naar het huidige bedrijf
            bedrijfCbx.SelectedIndex = bedrijfCbx.FindStringExact(contact.Bedrijf.Bedrijfnaam);

            // Koppelt alle contact data aan de texboxes 
            voornaamTb.Text = contact.Voornaam;
            achternaamTb.Text = contact.Achternaam;
            functieTb.Text = contact.Functie;
            locatieTb.Text = contact.Locatie;
            emailTb.Text = contact.Email;
            contactcode = contact.Contactcode;
            bedrijfcode = contact.Bedrijf.Bedrijfscode;
        }

        private void bewerkBtn_Click(object sender, EventArgs e)
        {
            // Zet alle waardes van de textboxes in het nieuwe contact
            Persooncontact bewerktContact = new Persooncontact();
            bewerktContact.Contactcode = contactcode;
            bewerktContact.Voornaam = voornaamTb.Text;
            bewerktContact.Achternaam = achternaamTb.Text;
            bewerktContact.Bedrijf = new Bedrijfcontact();
            bewerktContact.Bedrijf.Bedrijfscode = Convert.ToInt32(bedrijfCbx.SelectedValue);
            bewerktContact.Functie = functieTb.Text;
            bewerktContact.Locatie = locatieTb.Text;
            bewerktContact.Email = emailTb.Text;
            
            // Contactencontroller
            ContactenController cc = new ContactenController();
            cc.bewerkContact(bewerktContact);
            this.Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            // Zet alle waardes van de textboxes in het nieuwe contact
            Persooncontact bewerktContact = new Persooncontact();
            bewerktContact.Contactcode = contactcode;
            bewerktContact.Voornaam = voornaamTb.Text;
            bewerktContact.Achternaam = achternaamTb.Text;
            bewerktContact.Bedrijf = new Bedrijfcontact();
            bewerktContact.Bedrijf.Bedrijfscode = Convert.ToInt32(bedrijfCbx.SelectedValue);
            bewerktContact.Functie = functieTb.Text;
            bewerktContact.Locatie = locatieTb.Text;
            bewerktContact.Email = emailTb.Text;

            // Contactencontroller
            ContactenController cc = new ContactenController();
            cc.bewerkContact(bewerktContact);
            this.Close();
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
