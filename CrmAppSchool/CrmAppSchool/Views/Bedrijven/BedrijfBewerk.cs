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
using System.Net.Mail;

namespace CrmAppSchool.Views.Bedrijven
{
    public partial class BedrijfBewerk : Form
    {
        //
        private int contactcode { get; set; }
        private int bedrijfcode { get; set; }
        private int beoordeling { get; set; }
        private bool validmobiel { get; set; }
        private bool validemail { get; set; }
        private bool isinsert { get; set; }
        private bool validtelefoon { get; set; }
        private Gebruiker gebruiker { get; set; }
        public BedrijfBewerk(Bedrijfcontact contact, Gebruiker _gebruiker)
        {
            InitializeComponent();
            validmobiel = true;
            validemail = true;
            gebruiker = _gebruiker;


            // Koppelt alle contact data aan de texboxes 
            tbBedrijfsnaam.Text = contact.Bedrijfnaam;
            lblContactnaam.Text = contact.Bedrijfnaam;
            tbHoofdlocatie.Text = contact.Hoofdlocatie;
            tbWebsite.Text = contact.Website;
            tbTelefoon.Text = contact.Telefoonnr;
            tbEadres.Text = contact.Email;
            contactcode = contact.Bedrijfscode;
            tbContact.Text = contact.Contactpersoon;
            /*foreach (string line in contact.Kwaliteiten)
            {
                tbKwaliteiten.Text = line + "\n";
            }*/

        }

       

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            bool opslaan = true;
            if (validtelefoon == false)
            {
                opslaan = false;
                MessageBox.Show("Er is geen geldig telefoonnummer ingevoerd");
            }
            if (opslaan == true)
            {
                // Zet alle waardes van de textboxes in het nieuwe contact
                Bedrijfcontact bewerktContact = new Bedrijfcontact();
                bewerktContact.Bedrijfscode = contactcode;
                bewerktContact.Bedrijfnaam = tbBedrijfsnaam.Text;
                bewerktContact.Hoofdlocatie = tbHoofdlocatie.Text;
                bewerktContact.Website = tbWebsite.Text;
                bewerktContact.Telefoonnr = tbTelefoon.Text;
                string[] a = new string[tbKwaliteiten.Lines.Count()];
                int i = 0;
                foreach (string line in tbKwaliteiten.Lines)
                {
                    a[i] = line;
                    i++;
                }
                bewerktContact.Kwaliteiten = a;
                bewerktContact.Email = tbEadres.Text;

                // Bedrijfcontroller
                BedrijfController cc = new BedrijfController();
                cc.bewerkContact(bewerktContact);


                this.Close();
            }
            
            

        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbTelefoon_Leave(object sender, EventArgs e)
        {
            if (tbTelefoon.Text.Count() < 10 && tbTelefoon.Text.Count() > 0)
            {
                tbTelefoon.ForeColor = Color.Red;
                validtelefoon = false;
            }
            else
            {
                tbTelefoon.ForeColor = Color.Black;
                validtelefoon = true;
            }
        }

        private void tbTelefoon_Enter(object sender, EventArgs e)
        {
            tbTelefoon.ForeColor = Color.Black;
            validtelefoon = false;
        }

        private void tbTelefoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEadres_Leave(object sender, EventArgs e)
        {
            if (tbEadres.Text.Count() > 0)
            {
                try
                {
                    var eMailValidator = new MailAddress(tbEadres.Text);

                }
                catch (FormatException)
                {
                    tbEadres.ForeColor = Color.Red;
                    validemail = false;
                }
            }
        }

        private void tbEadres_Enter(object sender, EventArgs e)
        {
            tbEadres.ForeColor = Color.Black;
            validemail = true;
        }
    }
}

