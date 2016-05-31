using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAppSchool.Controllers;
using CrmAppSchool.Models;

namespace CrmAppSchool.Views.Contacten
{
    public partial class ContactenForm : Form
    {
        public bool ShowMenu { get; set; }
        private bool ShowSave { get; set; }
        private bool ShowZoeken { get; set; }
        private bool EditMode { get; set; }
        private Gebruiker gebruiker { get; set; }
        public ContactenForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            ShowMenu = false;
            ShowZoeken = false;
            ShowSave = false;
            EditMode = false;
            gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            ActiveerZoeken();

        }
        private void ActiveerZoeken()
        {
            if (ShowZoeken == false)
            {
                ShowZoeken = true;
                btnZoeken.Location = new Point(282, 1);
                btnVoegtoe.Visible = false;
                btnWijzig.Visible = false;
                btnDelete.Visible = false;
                tbSearch.Visible = true;
                btnCancel.Visible = true;
            }
        }
        private void AnnuleerZoeken()
        {
            ShowZoeken = false;
            btnVoegtoe.Visible = true;
            btnZoeken.Location = new Point(335, 1);
            btnWijzig.Visible = true;
            btnDelete.Visible = true;
            tbSearch.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AnnuleerZoeken();
            tbSearch.Text = "Zoeken...";
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void toonContactenInvoer(object sender, EventArgs e)
        {
            // Toont de textboxes a.d.h.v. contactSoortCbx selectie
            string invoerKeuze = Convert.ToString(contactSoortCbx.SelectedItem);
            if (invoerKeuze == "Bedrijf")
            {
                persoonPnl.Visible = false;
                pnOptioneel.Visible = false;
                bedrijfPnl.Visible = true;
            }
            else if (invoerKeuze == "Stagebegeleider")
            {
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
                pnOptioneel.Visible = true;
            }
            else if (invoerKeuze == "Gastdocent")
            {
                bedrijfPnl.Visible = false;
                pnOptioneel.Visible = true;
                persoonPnl.Visible = true;
            }
            else if (invoerKeuze == "Gastspreker")
            {
                bedrijfPnl.Visible = false;
                pnOptioneel.Visible = true;
                persoonPnl.Visible = true;
            }
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {

            if (ShowSave == false)
            {
                lvContacten.Visible = false;
                lblSoort.Visible = true;
                btnVoegtoe.Visible = false;
                btnAnnuleer.Visible = true;
                btnOpslaan.Visible = true;
                contactSoortCbx.Visible = true;
                btnWijzig.Visible = false;
                btnDelete.Visible = false;
                Makeempty();
                ShowSave = true;
            }
            else
            {
                btnVoegtoe.Visible = true;
                btnAnnuleer.Visible = false;
                btnOpslaan.Visible = false;
                contactSoortCbx.Visible = false;
                btnWijzig.Visible = true;
                btnDelete.Visible = true;
                ShowSave = false;
            }
        }
        private void SaveContact(Persooncontact persoon)
        {
            /*ContactPersoon newcontact = new ContactPersoon();
            newcontact.Voornaam = tbVoornaam.Text;
            newcontact.Achternaam = tbAchternaam.Text;
            newcontact.Bedrijf = tbBedrijf.Text;
            newcontact.Email = tbEmail.Text;
            newcontact.Functie = tbFunctie.Text;
            newcontact.Locatie = tbLocatie.Text;
            newcontact.Mobiel = tbMobiel.Text;
            newcontact.Privemail = tbPriveMail.Text;*/
            lvContacten.Items.Add(persoon.Voornaam + " " + persoon.Achternaam);
        }
        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            btnVoegtoe.Visible = true;
            btnWijzig.Visible = true;
            btnDelete.Visible = true;
            btnAnnuleer.Visible = false;
            btnOpslaan.Visible = false;
            contactSoortCbx.Visible = false;
            persoonPnl.Visible = false;
            pnOptioneel.Visible = false;
            lblSoort.Visible = false;
            lvContacten.Visible = true;
            ShowSave = false;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Persooncontact persooncontact = new Persooncontact() { Voornaam = tbVoornaam.Text, Achternaam = tbAchternaam.Text, Locatie = tbLocatie.Text, Email = tbEmail.Text };
            string contactSoort = Convert.ToString(contactSoortCbx);
            switch (contactSoort)
            {
                case "Stagebegeleider":
                    persooncontact.Isstagebegeleider = true;
                    break;
                case "Gastdocent":
                    persooncontact.Isgastdocent = true;
                    break;
                case "Gastspreker":
                    persooncontact.Isgastspreker = true;
                    break;
            }
            ContactenController contactencontroller = new ContactenController();
            contactencontroller.voegPersoonToe(persooncontact);
            SaveContact(persooncontact);
            pnOptioneel.Visible = false;
            persoonPnl.Visible = false;
            bedrijfPnl.Visible = false;
            lblSoort.Visible = false;
            btnVoegtoe.Visible = true;
            btnWijzig.Visible = true;
            btnDelete.Visible = true;
            btnAnnuleer.Visible = false;
            btnOpslaan.Visible = false;
            contactSoortCbx.Visible = false;
            lvContacten.Visible = true;
            ShowSave = false;
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvContacten.SelectedItems.Count == 1)
            {
                lvContacten.Items.Remove(lvContacten.SelectedItems[0]);
            }
            else if(lvContacten.SelectedItems.Count > 1)
            {
                foreach (ListViewItem item in lvContacten.SelectedItems)
                {
                    lvContacten.Items.Remove(item);
                }
            }
        }
        private void Makeempty()
        {
            contactSoortCbx.Text = "";
            tbVoornaam.Text = "";
            tbAchternaam.Text = "";
            tbBedrijf.Text = "";
            tbEmail.Text = "";
            tbFunctie.Text = "";
            tbLocatie.Text = "";
            tbMobiel.Text = "";
            tbPriveMail.Text = "";

        }
    }
}
