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
            var imagelist = new ImageList();
            imagelist.Images.Add("GS", Properties.Resources.Afbeelding_ContactPersoon_GastSpreker);
            imagelist.Images.Add("GD", Properties.Resources.Afbeelding_ContactPersoon_GastDocent);
            imagelist.Images.Add("BD", Properties.Resources.Afbeelding_ContactPersoon_Bedrijf);
            imagelist.Images.Add("SB", Properties.Resources.Afbeelding_ContactPersoon_StageBegeleider);
            imagelist.ImageSize = new Size(50, 50);
            lvContacten.LargeImageList = imagelist;
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
            Close();
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
                btnZoeken.Location = new Point(463, 1);
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
            btnZoeken.Location = new Point(527, 1);
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
                pnbedrijf2.Visible = true;
                bedrijfPnl.Visible = true;
            }
            else if (invoerKeuze == "Stagebegeleider")
            {
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
                pnOptioneel.Visible = true;
                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
            }
            else if (invoerKeuze == "Gastdocent")
            {
                bedrijfPnl.Visible = false;
                pnOptioneel.Visible = true;
                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
            }
            else if (invoerKeuze == "Gastspreker")
            {
                bedrijfPnl.Visible = false;
                pnOptioneel.Visible = true;
                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
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
                btnZoeken.Visible = false;
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
                btnZoeken.Visible = true;
                contactSoortCbx.Visible = false;
                btnWijzig.Visible = true;
                btnDelete.Visible = true;
                ShowSave = false;
            }
        }
        private void SaveContact(Persooncontact persoon)
        {
            ListViewItem contact = new ListViewItem(persoon.Voornaam);
            contact.SubItems.Add(persoon.Achternaam);
            lvContacten.Items.Add(contact);
            if (contactSoortCbx.Text == "Gastspreker")
            {
                contact.ImageKey = "GS";
            }               
            else if (contactSoortCbx.Text == "Gastdocent")
            {
                contact.ImageKey = "GD";
            }              
            else if (contactSoortCbx.Text == "Stagebegeleider")
            {
                contact.ImageKey = "SB";
            }
                


        }
        private void SaveBedrijf(Bedrijfcontact bedrijf)
        {
            ListViewItem Company = new ListViewItem(bedrijf.Bedrijfnaam);
            lvContacten.Items.Add(Company);
            Company.ImageKey = "BD";
        }
        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            btnZoeken.Visible = true;
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
            if (contactSoortCbx.Text != "Bedrijf")
            {
                Persooncontact persooncontact = new Persooncontact() { Voornaam = tbVoornaam.Text, Achternaam = tbAchternaam.Text, Bedrijf = tbBedrijf.Text, Email = tbEmail.Text };
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
            }
            else
            {
                string[] a = new string[tbKwaliteiten.Lines.Count()];
                int i = 0;
                foreach (string line in tbKwaliteiten.Lines)
                {
                    a[i] = line;
                    i++;
                }
                Bedrijfcontact bedrijfcontact = new Bedrijfcontact() { Bedrijfnaam = bedrijfsnaamTxb.Text, Contactpersoon = tbContact.Text, Email = tbEadres.Text, Hoofdlocatie = tbHoofdlocatie.Text, Telefoonnr = tbTelefoon.Text, Website = tbWebsite.Text, Kwaliteiten = a };
                SaveBedrijf(bedrijfcontact);
            }

            pnOptioneel.Visible = false;
            persoonPnl.Visible = false;
            pnbedrijf2.Visible = false;
            bedrijfPnl.Visible = false;
            bedrijfPnl.Visible = false;
            btnZoeken.Visible = true;
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
            if (lvContacten.SelectedItems.Count == 1)
            {
                lvContacten.Items.Remove(lvContacten.SelectedItems[0]);
            }
            else if (lvContacten.SelectedItems.Count > 1)
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
