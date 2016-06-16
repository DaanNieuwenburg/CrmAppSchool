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
using System.Text.RegularExpressions;

namespace CrmAppSchool.Views.Bedrijven
{
    public partial class BedrijfBewerk : Form
    {
        //
        //
        private int contactcode { get; set; }
        private int bedrijfcode { get; set; }
        private int beoordeling { get; set; }
        private bool validmobiel { get; set; }
        private bool validwebsite { get; set; }
        private bool validemail { get; set; }
        private bool isinsert { get; set; }
        private bool validtelefoon { get; set; }
        private Gebruiker gebruiker { get; set; }
        public BedrijfBewerk(Bedrijfcontact contact, Gebruiker _gebruiker)
        {
            InitializeComponent();
            //deze waardes zijn true, omdat er geen ongeldige waarde kan worden opgeslagen bij het aanmaken
            validmobiel = true;
            validemail = true;
            validwebsite = true;
            validtelefoon = true;
            gebruiker = _gebruiker;

            // Maak de tooltips aan
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(tbWebsite, "Voer een geldige website in.\nExample: (www.)google.nl");

            ToolTip TP1 = new ToolTip();
            TP1.ShowAlways = true;
            TP1.SetToolTip(tbEadres, "Voer een geldig email adres in.\nExample: harry1998@hotmail.com");

            // Koppelt alle contact data aan de texboxes 
            tbBedrijfsnaam.Text = contact.Bedrijfnaam;
            lblContactnaam.Text = contact.Bedrijfnaam;
            tbHoofdlocatie.Text = contact.Hoofdlocatie;
            tbWebsite.Text = contact.Website;
            tbTelefoon.Text = contact.Telefoonnr;
            tbEadres.Text = contact.Email;
            contactcode = contact.Bedrijfscode;
            tbContact.Text = contact.Contactpersoon;
            BedrijfController cc = new BedrijfController(); 
            List<string> kwaliteitenlijst = cc.Get_Kwaliteiten(_gebruiker, contact);
            if (kwaliteitenlijst != null)
            {
                foreach (string line in kwaliteitenlijst)
                {
                    tbKwaliteiten.Text = tbKwaliteiten.Text + line + Environment.NewLine;
                }
            }
        }

       

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            bool opslaan = true;
            if (validtelefoon == false)
            {
                opslaan = false;
                MessageBox.Show("Er is geen geldig telefoonnummer ingevoerd");
            }
            if (validwebsite == false)
            {
                opslaan = false;
                MessageBox.Show("Er is geen geldige website ingevoerd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                bewerktContact.Kwaliteiten = new List<string>();
                foreach (string ingevoerdeKwaliteit in tbKwaliteiten.Lines)
                {
                    if (ingevoerdeKwaliteit != "")
                    {
                        bewerktContact.Kwaliteiten.Add(ingevoerdeKwaliteit);
                    }
                }
                bewerktContact.Email = tbEadres.Text;

                // Zet de kwaliteiten in de list

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
            // Kijkt of er een geldig telefoonnummer is ingevoerd
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
            // Zorgt ervoor dat er alleen cijfers ingevoerd mag worden
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEadres_Leave(object sender, EventArgs e)
        {
            // Controleerd of er een geldig email adres is ingevoerd
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

        private void tbWebsite_Enter(object sender, EventArgs e)
        {
            tbWebsite.ForeColor = Color.Black;
            validwebsite = false;
        }

        private void tbWebsite_Leave(object sender, EventArgs e)
        {
            // Controleerd m.b.v. Regex of het ingevoerde adres geldig is
            string a = "";
            if (tbWebsite.Text.StartsWith("http"))
                a = tbWebsite.Text;
            else
                a = "http://" + tbWebsite.Text;
            
            Regex RgxUrl = new Regex(@"^http\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$");
           
            if (RgxUrl.IsMatch(a))
            {
                if (!tbWebsite.Text.StartsWith("www"))
                {
                    tbWebsite.Text = "www." + tbWebsite.Text;
                }
                tbWebsite.ForeColor = Color.Black;
                validwebsite = true;
            }
            else
            {            
                validwebsite = false;
                tbWebsite.ForeColor = Color.Red;
                
            }

           
        }
    }
}

