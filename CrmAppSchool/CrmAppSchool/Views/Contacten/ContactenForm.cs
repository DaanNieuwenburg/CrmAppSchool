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
        private bool ShowZoeken { get; set; }
        private Gebruiker gebruiker { get; set; }
        public ContactenForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            ShowMenu = false;
            ShowZoeken = false;
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
                btnVoegtoe.Visible = false;
                tbSearch.Visible = true;
                btnCancel.Visible = true;
            }
        }
        private void AnnuleerZoeken()
        {
            ShowZoeken = false;
            btnVoegtoe.Visible = true;
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
            // Toont de textboxxes a.d.h.v. contactSoortCbx selectie
            string invoerKeuze = Convert.ToString(contactSoortCbx.SelectedItem);
            if(invoerKeuze == "Bedrijf")
            {
                persoonPnl.Visible = false;
                bedrijfPnl.Visible = true;
            }
            else if(invoerKeuze == "Stagebegeleider")
            {
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
            }
            else if(invoerKeuze == "Gastdocent")
            {
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
            }
            else if(invoerKeuze == "Gastspreker")
            {
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
            }
        }

        private void voegPersoonToeBtn_Click(object sender, EventArgs e)
        {
            Persooncontact persooncontact = new Persooncontact() {Voornaam = voornaamTxb.Text, Achternaam = achternaamTxb.Text, Locatie = locatieTxb.Text, Email = emailTxb.Text};
            string contactSoort = Convert.ToString(contactSoortCbx);
            switch(contactSoort)
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
        }
    }
}
