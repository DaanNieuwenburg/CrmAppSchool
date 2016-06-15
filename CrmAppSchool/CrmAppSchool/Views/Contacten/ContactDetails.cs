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
    public partial class ContactDetails : Form
    {
        
        private Persooncontact contact { get; set; }
        private Gebruiker gebruiker { get; set; }
        private int beoordeling { get; set; }

        public ContactDetails(Gebruiker _gebruiker, Persooncontact _contact)
        {
            InitializeComponent();
            contact = _contact;
            gebruiker = _gebruiker;

            // Haal de contacten evaluaties op
            ContactEvaluatieController ce = new ContactEvaluatieController();
            contact = ce.HaalInfoOp(_gebruiker, contact);
            lbOmschrijvingValue.Text = contact.Evaluatie;
            beoordeling = contact.Beoordeling;

            //Haal de kwaliteiten op
            ContactenController cc = new ContactenController();           
            List<string> kwalteitenlijst = cc.Get_Kwaliteiten(_gebruiker, contact);
            if(kwalteitenlijst != null)
            {
                lbKWvalue.Text = "";
                int j = 0;
                foreach (string a in kwalteitenlijst)
                {
                    if (j == 0)
                        lbKWvalue.Text = a;
                    else
                        lbKWvalue.Text = lbKWvalue.Text + "\n" + a;

                    j++;
                }
            }

            // Niet student kunnen contacten toevoegen
            if (gebruiker.SoortGebruiker != "Student")
            {
                // Is de contact een eigen contact, laat dan niet de button zien
                bool bestaat = cc.heeftGebruikerContact(gebruiker, Convert.ToString(contact.Contactcode));
                if (bestaat == false)
                {
                    Console.WriteLine("Bestaat = false");
                    btnVoegtoe.Visible = true;
                }
                else
                {
                    Console.WriteLine("Bestaat = true");
                    btnVoegtoe.Visible = false;
                }
            }
            else
            {
                btnVoegtoe.Visible = false;
            }

            lblVNvalue.Text = contact.Voornaam;
            lblANvalue.Text = contact.Achternaam;
            lblLOvalue.Text = contact.Locatie;
            llbMValue.Text = contact.Email;
            lblMOvalue.Text = contact.Mobielnr;
            lblBDvalue.Text = contact.Bedrijf.Bedrijfnaam;
            if (contact.Isgastdocent == false && contact.Isstagebegeleider == false)
            {
                lbl_soort.Text = "Gastspreker";
            }
            else if (contact.Isgastdocent == true)
            {
                lbl_soort.Text = "Gastdocent";
            }
            else
            {
                lbl_soort.Text = "Stagebegeleider";
            }

            
            if(contact.Kwaliteiten != null)
            {
                foreach (string kwaliteit in contact.Kwaliteiten)
                {
                    lbKWvalue.Text = lbKWvalue.Text + "\n" + kwaliteit;
                }
            }
            
            if (contact.Functie != null)
            {
                lblFUvalue.Text = contact.Functie;
            }
            

        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lblContactnaam.Text = contact.Voornaam + " " + contact.Achternaam;
            setSterren();
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + llbMValue.Text);
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
            else if(beoordeling == 2)
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

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            ContactenController cc = new ContactenController();
            cc.voegContactPersoonKoppeltabel(gebruiker.Gebruikersnaam, contact.Contactcode);
            MessageBox.Show("Contact " + contact.Voornaam + " " + contact.Achternaam + " is toegevoegd");
        }
    }
}
