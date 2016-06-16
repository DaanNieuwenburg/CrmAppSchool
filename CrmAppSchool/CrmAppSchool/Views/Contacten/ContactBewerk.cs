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

namespace CrmAppSchool.Views.Bedrijven
{
    public partial class ContactBewerk : Form
    {
        private int contactcode { get; set;}
        private int bedrijfcode { get; set; }
        private int beoordeling { get; set; }
        private bool isstagebegeleider { get; set; }
        private bool validmobiel { get; set; }
        private bool validemail { get; set; }
        private Gebruiker gebruiker { get; set; }
        public ContactBewerk(Persooncontact contact, Gebruiker _gebruiker)
        {
            InitializeComponent();
            validmobiel = true;
            validemail = true;
            gebruiker = _gebruiker;
            this.isstagebegeleider = contact.Isstagebegeleider;
            // Vult de bedrijven combobox met bedrijven
            BedrijfController bc = new BedrijfController(); 
            bedrijfCbx.DataSource = bc.haalBedrijfLijstOp();
            bedrijfCbx.DisplayMember = "Bedrijfnaam";
            bedrijfCbx.ValueMember = "Bedrijfscode";

            // Haal de contacten evaluaties op
            ContactEvaluatieController ce = new ContactEvaluatieController();
            contact = ce.HaalInfoOp(gebruiker, contact);
            tbOmschrijving.Text = contact.Evaluatie + "HAI";
            beoordeling = contact.Beoordeling;          
            mobielTb.Text = contact.Mobielnr;
            //Haal de kwaliteiten op
            ContactenController cc = new ContactenController();
            List<string> kwalteitenlijst = cc.Get_Kwaliteiten(_gebruiker, contact);
            if (kwalteitenlijst != null)
            {
                foreach (string a in kwalteitenlijst)
                {
                    tbKwaliteiten.Text = tbKwaliteiten.Text + a + Environment.NewLine;
                }
            }            
            setSterren();

            // Zet de evaluatie in txb, mits er een evaluatie is
            tbOmschrijving.Text = "";
            if(contact.Evaluatie != null)
            {
                string[] evaluatieLijnen = contact.Evaluatie.Split(new string[] { "\n", "\n\r" }, StringSplitOptions.None);
                int teller = 0;
                int totaal = evaluatieLijnen.Count();
                foreach (string evaluatie in evaluatieLijnen)
                {
                    if (teller == 0)
                    {
                        tbOmschrijving.Text = evaluatie + Environment.NewLine;
                    }
                    else if (teller + 1 == totaal)
                    {
                        tbOmschrijving.Text = tbOmschrijving.Text + evaluatie;
                    }
                    else
                    {
                        tbOmschrijving.Text = tbOmschrijving.Text + evaluatie + Environment.NewLine;
                    }
                    teller++;
                }
            }
            // Zet de combobox selectie naar het huidige bedrijf
            bedrijfCbx.SelectedIndex = bedrijfCbx.FindStringExact(contact.Bedrijf.Bedrijfnaam);

            // Koppelt alle contact data aan de texboxes 
            voornaamTb.Text = contact.Voornaam;
            lblContactnaam.Text = contact.Voornaam + " " + contact.Achternaam;
            achternaamTb.Text = contact.Achternaam;
            functieTb.Text = contact.Functie;
            locatieTb.Text = contact.Locatie;
            emailTb.Text = contact.Email;
            contactcode = contact.Contactcode;
            bedrijfcode = contact.Bedrijf.Bedrijfscode;

            // Zet de waardes van de cbx om
            if (contact.Isgastdocent == true)
            {
                soortCbx.Text = "Gastdocent";
            }
            else
            {
                soortCbx.Text = "Stagebegeleider";
            }
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
            bewerktContact.Mobielnr = mobielTb.Text;

            // Zet de waardes van de cbx om
            if(soortCbx.Text == "Gastdocent")
            {
                bewerktContact.Isgastdocent = true;
                bewerktContact.Isstagebegeleider = false;
            }
            else
            {
                bewerktContact.Isgastdocent = false;
                bewerktContact.Isstagebegeleider = true;
            }
            
            // Contactencontroller
            ContactenController cc = new ContactenController();
            cc.bewerkContact(bewerktContact);
            this.Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if(validmobiel == true && validemail == true)
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
                bewerktContact.Mobielnr = mobielTb.Text;
                List<string> kwalteitenlijst = new List<string>(); 
                foreach (string regel in tbKwaliteiten.Lines)
                {
                    kwalteitenlijst.Add(regel);
                }
                bewerktContact.Kwaliteiten = kwalteitenlijst;
                string omschr = "";
                if (tbOmschrijving.Text.Count() > 1)
                {
                    int teller = 0;
                    foreach (string line in tbOmschrijving.Lines)
                    {
                        if (teller == 0)
                        {
                            omschr = line + "\n";
                        }
                        else if (teller + 1 == tbOmschrijving.Lines.Count())
                        {
                            omschr = omschr + line;
                        }
                        else
                        {
                            omschr = omschr + line + "\n";
                        }
                        teller++;
                    }
                }

                // Zet de waardes van de cbx om
                if (soortCbx.Text == "Gastdocent")
                {
                    bewerktContact.Isgastdocent = true;
                    bewerktContact.Isstagebegeleider = false;
                }
                else if (soortCbx.Text == "Stagebegeleider")
                {
                    bewerktContact.Isgastdocent = false;
                    bewerktContact.Isstagebegeleider = true;
                }
                else
                {
                    bewerktContact.Isgastdocent = false;
                    bewerktContact.Isstagebegeleider = false;
                }

                bewerktContact.Evaluatie = omschr;
                // Contactencontroller
                ContactenController cc = new ContactenController();
                cc.bewerkContact(bewerktContact);

                // ContactenEvaluatiecontroller
                bewerktContact.Beoordeling = beoordeling;
                ContactEvaluatieController ce = new ContactEvaluatieController();
                ce.bepaalWhatToDo(bewerktContact, gebruiker);

                this.Close();
            }
            else
            {
                if(validmobiel == false)
                    MessageBox.Show("Er is geen geldig mobiel nummer ingevoerd");
                if (validemail == false)
                    MessageBox.Show("Er is geen geldig email adres ingevoerd");
            }
            
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mobielTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mobielTb_Enter(object sender, EventArgs e)
        {
            mobielTb.ForeColor = Color.Black;
            validmobiel = true;
        }

        private void mobielTb_Leave(object sender, EventArgs e)
        {
            if (mobielTb.Text.Count() < 10 && mobielTb.Text.Count() > 0)
            {
                mobielTb.ForeColor = Color.Red;
                validmobiel = false;
            }
        }

        private void emailTb_Enter(object sender, EventArgs e)
        {
            emailTb.ForeColor = Color.Black;
            validemail = true;
        }

        private void emailTb_Leave(object sender, EventArgs e)
        {
            if (emailTb.Text.Count() > 0)
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(emailTb.Text);
                }
                catch (FormatException ex)
                {
                    // verkeerd e-mail address
                    emailTb.ForeColor = Color.Red;
                    validemail = false;
                    Console.WriteLine(ex);
                }
            }
        }
        private void setSterren()
        {
            if (beoordeling == 0)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if (beoordeling == 1)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if (beoordeling == 2)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if (beoordeling == 3)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if (beoordeling == 4)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            }
        }
        private void pbRate2_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }


        private void pbRate3_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }

        private void pbRate4_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }

        private void pbRate5_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
        }

        private void pbRate1_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }

        private void pbRate1_Click(object sender, EventArgs e)
        {
            beoordeling = 1;
            setSterren();
        }

        private void pbRate2_Click(object sender, EventArgs e)
        {
            beoordeling = 2;
            setSterren();
        }

        private void pbRate3_Click(object sender, EventArgs e)
        {
            beoordeling = 3;
            setSterren();
        }

        private void pbRate4_Click(object sender, EventArgs e)
        {
            beoordeling = 4;
            setSterren();
        }

        private void pbRate5_Click(object sender, EventArgs e)
        {
            beoordeling = 5;
            setSterren();
        }

        private void pbRating_MouseLeave(object sender, EventArgs e)
        {
            setSterren();
        }

        private void soortCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isstagebegeleider == true && soortCbx.Text != "Stagebegeleider")
            {
                StageopdrachtController soc = new StageopdrachtController();
                List<Stageopdracht> opdrachten = soc.getOpdrachten();
                bool gevonden = false;
                foreach (Stageopdracht a in opdrachten)
                {
                    if (a.Contact.Contactcode == this.contactcode)
                    {
                        gevonden = true;
                        break;
                    }
                }
                if (gevonden == true)
                {
                    MessageBox.Show("Deze contactpersoon staat als stagebegeleider ingesteld bij een stageopdracht. \nHierdoor kan deze instelling niet worden aangepast");
                    soortCbx.Text = "Stagebegeleider";
                }
            }
        }
    }
}

