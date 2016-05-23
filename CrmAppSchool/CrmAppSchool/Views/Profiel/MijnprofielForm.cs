using CrmAppSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmAppSchool.Views.Profiel
{
    public partial class MijnprofielForm : Form
    {
        private Gebruiker gebruiker { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Bedrijf { get; set; }
        public string Locatie { get; set; }
        public string Functie { get; set; }
        public string Kwaliteit { get; set; }
        public bool ShowMenu { get; set; }
        private bool EditMode { get; set; }
        private bool PriveMode { get; set; }
        public MijnprofielForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            lblGebruikerWaarde.Text = gebruiker.Gebruikersnaam;
            lblWachtwoordWaarde.Text = gebruiker.Wachtwoord;
            ShowMenu = false;
            EditMode = false;
            PriveMode = false;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void MijnprofielForm_Load(object sender, EventArgs e)
        {
            lblVoornaamWaarde.Text = Voornaam;
            lblAchternaamWaarde.Text = Achternaam;
            lblBedrijfWaarde.Text = Bedrijf;
            lblLocatieWaarde.Text = Locatie;
            lblKwaliteitWaarde.Text = Kwaliteit;
            lblFunctieWaarde.Text = Functie;
        }

        private void btnBewerk_Click(object sender, EventArgs e)
        {
            EditMode = true;
            
            voornaamTxb.Text = lblVoornaamWaarde.Text;         
            achternaamTxb.Text = lblAchternaamWaarde.Text;
            bedrijfTxb.Text = lblBedrijfWaarde.Text;
            locatieTxb.Text = lblLocatieWaarde.Text;
            functieTxb.Text = lblFunctieWaarde.Text;
            kwaliteitTxb.Text = lblKwaliteitWaarde.Text;
            Updatebuttons();
        }
        private void Updatebuttons()
        {
            if (EditMode == true)
            {
                btnBewerk.Visible = false;
                btnPrive.Visible = false;
                btnOpslaan.Visible = true;
                btnAnnuleer.Visible = true;

                voornaamTxb.Visible = true;
                achternaamTxb.Visible = true;
                bedrijfTxb.Visible = true;
                locatieTxb.Visible = true;
                functieTxb.Visible = true;
                kwaliteitTxb.Visible = true;

                
            }
            else
            {
                btnBewerk.Visible = true;
                btnPrive.Visible = true;
                btnOpslaan.Visible = false;
                btnAnnuleer.Visible = false;
                voornaamTxb.Visible = false;
                achternaamTxb.Visible = false;
                bedrijfTxb.Visible = false;
                locatieTxb.Visible = false;
                functieTxb.Visible = false;
                kwaliteitTxb.Visible = false;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
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

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                EditMode = false;
                Updatebuttons();
            }
            else if(PriveMode == true)
            {
                PriveMode = false;
                UpdatePrive();
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
    }
}
