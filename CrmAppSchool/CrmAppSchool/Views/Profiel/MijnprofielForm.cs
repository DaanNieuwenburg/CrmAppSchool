﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAppSchool.Models;

namespace CrmAppSchool.Views.Profiel
{
    public partial class MijnprofielForm : Form
    {
        private Gebruiker gebruiker { get; set; }          // De huidige ingelogde gebruiker
        private Models.Profiel profiel { get; set; }       // De profielinfo van de ingelogde gebruiker
        public bool[] Bewerkt { get; private set; }        // Bool array om te kijken welke info er is bewerkt
        public bool ShowMenu { get; set; }                 // Boolean voor het zichtbaar maken van de mainmenu
        private bool EditMode { get; set; }                // Boolean voor het menu om profiel te bewerken
        private bool EditWachtwoordMode { get; set; }      // Boolean voor het menu om wachtwoord te veranderen
        private bool PriveMode { get; set; }               // Boolean voor het menu om info prive te maken

        public MijnprofielForm(Gebruiker _gebruiker, Models.Profiel _profiel)
        {
            InitializeComponent();
            Bewerkt = new bool[6] { false, false, false, false, false, false };
            gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            lblGebruikerWaarde.Text = gebruiker.Gebruikersnaam;
            lblWachtwoordWaarde.Text = gebruiker.Wachtwoord;

            // Bind model aan form
            profiel = _profiel;

            // Zet alle modes in het begin op false
            ShowMenu = false;
            EditMode = false;
            PriveMode = false;
            EditWachtwoordMode = false;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void MijnprofielForm_Load(object sender, EventArgs e)
        {
            // Zet de informatie van het profiel naar de labels
            lblVoornaamWaarde.Text = profiel.Voornaam;
            lblAchternaamWaarde.Text = profiel.Achternaam;
            lblBedrijfWaarde.Text = profiel.Bedrijf;
            lblLocatieWaarde.Text = profiel.Locatie;
            lblKwaliteitWaarde.Text = profiel.Kwaliteit;
            lblFunctieWaarde.Text = profiel.Functie;
        }

        private void btnBewerk_Click(object sender, EventArgs e)
        {
            EditMode = true;

            tbVoornaam.Text = lblVoornaamWaarde.Text;
            tbAchternaam.Text = lblAchternaamWaarde.Text;
            tbBedrijf.Text = lblBedrijfWaarde.Text;
            tbLocatie.Text = lblLocatieWaarde.Text;
            tbFunctie.Text = lblFunctieWaarde.Text;
            tbKwaliteit.Text = lblKwaliteitWaarde.Text;
            Updatebuttons();
        }
        private void Updatebuttons()
        {
            // Zet de knoppen naar edit mode of terug naar beginmode
            if (EditMode == true)
            {
                btnBewerk.Visible = false;
                btnPrive.Visible = false;
                btnOpslaan.Visible = true;
                btnAnnuleer.Visible = true;

                tbVoornaam.Visible = true;
                tbAchternaam.Visible = true;
                tbBedrijf.Visible = true;
                tbLocatie.Visible = true;
                tbFunctie.Visible = true;
                tbKwaliteit.Visible = true;

                lblVoornaamWaarde.Visible = false;
                lblAchternaamWaarde.Visible = false;
                lblBedrijfWaarde.Visible = false;
                lblKwaliteitWaarde.Visible = false;
                lblLocatieWaarde.Visible = false;
                lblFunctieWaarde.Visible = false;


            }
            else
            {
                btnBewerk.Visible = true;
                btnPrive.Visible = true;
                btnOpslaan.Visible = false;
                btnAnnuleer.Visible = false;

                tbVoornaam.Visible = false;
                tbAchternaam.Visible = false;
                tbBedrijf.Visible = false;
                tbLocatie.Visible = false;
                tbFunctie.Visible = false;
                tbKwaliteit.Visible = false;

                lblVoornaamWaarde.Visible = true;
                lblAchternaamWaarde.Visible = true;
                lblBedrijfWaarde.Visible = true;
                lblKwaliteitWaarde.Visible = true;
                lblLocatieWaarde.Visible = true;
                lblFunctieWaarde.Visible = true;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            // Annuleer bewerk mode
            if (EditMode == true)
            {
                EditMode = false;
                Updatebuttons();
            }
            // annuleer prive mode
            else if (PriveMode == true)
            {
                PriveMode = false;
                UpdatePrive();
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (Bewerkt[i] == true)
                {
                    if (i == 0)
                    {
                        lblVoornaamWaarde.Text = tbVoornaam.Text;
                    }
                    else if (i == 1)
                    {
                        lblAchternaamWaarde.Text = tbAchternaam.Text;
                    }
                    else if (i == 2)
                    {
                        lblBedrijfWaarde.Text = tbBedrijf.Text;
                    }
                    else if (i == 3)
                    {
                        lblLocatieWaarde.Text = tbLocatie.Text;
                    }
                    else if (i == 4)
                    {
                        lblFunctieWaarde.Text = tbFunctie.Text;
                    }
                    else if (i == 5)
                    {
                        lblKwaliteitWaarde.Text = tbKwaliteit.Text;
                    }
                }

                // Schrijf de nieuwe profiel informatie over naar de database
                Controllers.ProfielController profielController = new Controllers.ProfielController();
                Models.Profiel profiel = new Models.Profiel() { Voornaam = lblVoornaamWaarde.Text, Achternaam = lblAchternaamWaarde.Text, Bedrijf = lblBedrijfWaarde.Text, Locatie = lblLocatieWaarde.Text, Functie = lblFunctieWaarde.Text, Kwaliteit = lblKwaliteitWaarde.Text };
                profielController.Update_Profiel(gebruiker, profiel);
                
                // Zet de bewerk of prive mode weer uit
                if (EditMode == true)
                {
                    EditMode = false;
                    Updatebuttons();
                }
                else if (PriveMode == true)
                {
                    PriveMode = false;
                    UpdatePrive();
                }


            }
        }

        private void btnPrive_Click(object sender, EventArgs e)
        {
            PriveMode = true;
            UpdatePrive();
        }
        private void UpdatePrive()
        {
            if (PriveMode == true)
            {
                btnBewerk.Visible = false;
                btnPrive.Visible = false;
                btnOpslaan.Visible = true;
                btnAnnuleer.Visible = true;

                cbPriveAN.Visible = true;
                cbPriveBD.Visible = true;
                cbPriveFU.Visible = true;
                cbPriveKW.Visible = true;
                cbPriveLO.Visible = true;
                cbPriveVN.Visible = true;

                lblAchternaamWaarde.Visible = false;
                lblVoornaamWaarde.Visible = false;
                lblLocatieWaarde.Visible = false;
                lblKwaliteitWaarde.Visible = false;
                lblFunctieWaarde.Visible = false;
                lblBedrijfWaarde.Visible = false;
            }
            else
            {
                //Hier moet de code komen voor het prive zetten in de database

                btnBewerk.Visible = true;
                btnPrive.Visible = true;
                btnOpslaan.Visible = false;
                btnAnnuleer.Visible = false;

                cbPriveAN.Visible = false;
                cbPriveBD.Visible = false;
                cbPriveFU.Visible = false;
                cbPriveKW.Visible = false;
                cbPriveLO.Visible = false;
                cbPriveVN.Visible = false;

                lblAchternaamWaarde.Visible = true;
                lblVoornaamWaarde.Visible = true;
                lblLocatieWaarde.Visible = true;
                lblKwaliteitWaarde.Visible = true;
                lblFunctieWaarde.Visible = true;
                lblBedrijfWaarde.Visible = true;
            }
        }

        private void voornaamTxb_TextChanged(object sender, EventArgs e)
        {
            Bewerkt[0] = true;
        }

        private void achternaamTxb_TextChanged(object sender, EventArgs e)
        {
            Bewerkt[1] = true;
        }

        private void bedrijfTxb_TextChanged(object sender, EventArgs e)
        {
            Bewerkt[2] = true;
        }

        private void locatieTxb_TextChanged(object sender, EventArgs e)
        {
            Bewerkt[3] = true;
        }

        private void functieTxb_TextChanged(object sender, EventArgs e)
        {
            Bewerkt[4] = true;
        }

        private void kwaliteitTxb_TextChanged(object sender, EventArgs e)
        {
            Bewerkt[5] = true;
        }

        private void btnBewerkLogin_Click(object sender, EventArgs e)
        {
            if(EditWachtwoordMode == false)
            {
                tbWachtwoord.Visible = true;
                tbBevestig.Visible = true;
                lblBevestig.Visible = true;
                EditWachtwoordMode = true;
            }
            else if(tbWachtwoord.Text != tbBevestig.Text)
            {
                MessageBox.Show("De wachtwoorden komen niet overeen", "Waarschuwing");
            }
            else if(EditWachtwoordMode == true && tbWachtwoord.Text == tbBevestig.Text)
            {
                tbWachtwoord.Visible = false;
                lblBevestig.Visible = false;
                tbBevestig.Visible = false;
                EditWachtwoordMode = false;
                // Set nieuw wachtwoord
            }
        }
    }
}
