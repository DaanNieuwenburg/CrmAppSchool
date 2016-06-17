﻿using System;
using System.Collections.Generic;
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
            vulin();
        }

        //
        // Alle eigen methodes van de form
        //
        public void vulin()
        {
            // Haal de contacten evaluaties op
            ContactEvaluatieController ce = new ContactEvaluatieController();
            contact = ce.HaalInfoOp(gebruiker, contact);
            lbOmschrijvingValue.Text = contact.Evaluatie;
            beoordeling = contact.Beoordeling;

            //Haal de kwaliteiten op
            ContactenController cc = new ContactenController();
            List<string> kwalteitenlijst = cc.Get_Kwaliteiten(gebruiker, contact);
            if (kwalteitenlijst != null)
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
            ProfielController pc = new ProfielController();
            contact.Gebruiker = new Gebruiker();
            contact.Gebruiker.Gebruikersnaam = contact.ingevoerddoor;
            Models.Profiel profiel = pc.Get_Pofiel(contact.Gebruiker);

            if (contact.ingevoerddoor != "admin")
            {
                string volnaam = profiel.Voornaam + " " + profiel.Achternaam;
                lbl_ingevoerd.Text = volnaam;
                if (lbl_ingevoerd.Text == " ")
                {
                    lbl_ingevoerd.Text = "Gebruiker verwijderd";
                }
            }
            else
            {
                lbl_ingevoerd.Text = "admin";
            }

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


            if (contact.Kwaliteiten != null)
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

            if (lbl_ingevoerd.Text == "admin" || lbl_ingevoerd.Text == "Gebruiker verwijderd")
            {
                this.lbl_ingevoerd.Font = new System.Drawing.Font("Arial", 10F);
                this.lbl_ingevoerd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(183)))), ((int)(((byte)(52)))));
            }
            else
            {
                this.lbl_ingevoerd.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            if (gebruiker.SoortGebruiker != "Admin")
            {
                btnDelete.Visible = false;
                btnWijzig.Visible = false;

            }
        }

        //
        // Alle button_Click() events van de form
        //
        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            ContactenController cc = new ContactenController();
            cc.voegContactPersoonKoppeltabel(gebruiker.Gebruikersnaam, contact.Contactcode);
            MessageBox.Show("Contact " + contact.Voornaam + " " + contact.Achternaam + " is toegevoegd");
        }

        private void lbl_ingevoerd_Click(object sender, EventArgs e)
        {
            if (lbl_ingevoerd.Text != "admin" && lbl_ingevoerd.Text != "Gebruiker verwijderd")
            {
                Gebruiker gebruiker = new Gebruiker();
                gebruiker.Gebruikersnaam = contact.ingevoerddoor;
                ProfielController pc = new ProfielController();
                Models.Profiel profiel = pc.Get_Pofiel(gebruiker);
                Profiel.ProfielDetails details = new Profiel.ProfielDetails(gebruiker, profiel);
                details.ShowDialog();
            }
        }

        private void lblBDvalue_Click(object sender, EventArgs e)
        {
            Controllers.BedrijfController bc = new Controllers.BedrijfController();
            Models.Bedrijfcontact contact = bc.SelecteerBedrijf(Convert.ToInt32(this.contact.Bedrijf.Bedrijfscode));
            contact.Kwaliteiten = bc.Get_Kwaliteiten(gebruiker, contact);
            Views.Bedrijven.BedrijfDetails details = new Views.Bedrijven.BedrijfDetails(gebruiker, contact);
            details.ShowDialog();
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            string contactcode = this.contact.Contactcode.ToString();
            ContactenController cc = new ContactenController();
            Persooncontact contact = cc.HaalInfoOp(contactcode);
            Views.Bedrijven.ContactBewerk bewerk = new Views.Bedrijven.ContactBewerk(contact, gebruiker);
            bewerk.ShowDialog();


            this.contact = cc.HaalInfoOp(contactcode);
            vulin();
            lblContactnaam.Text = this.contact.Voornaam + " " + this.contact.Achternaam;

        }

        //
        // Alle overige events van de form
        //
        private void ContactDetails_Load(object sender, EventArgs e)
        {
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(btnVoegtoe, "Voeg deze persoon toe aan je contactenlijst");
            TP.SetToolTip(btnWijzig, "Bewerk dit contact");
            TP.SetToolTip(btnDelete, "Verwijder deze contact uit het hele systeem");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialoogResultaat = MessageBox.Show("Wilt u deze contactpersoon volledig verwijderen?\nNiemand zal deze persoon meer als contact behouden", "Verwijderen contact", MessageBoxButtons.YesNo);
            if (dialoogResultaat == DialogResult.Yes)
            {
                string contactcode = this.contact.Contactcode.ToString();
                ContactenController cc = new ContactenController();
                bool verwijderd = cc.verwijderContact(this.gebruiker, contactcode);
                if (verwijderd == true)
                    this.Close();

            }
        }
    }
}
