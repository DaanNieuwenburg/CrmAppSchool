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
        public MijnprofielForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            lblGebruikerWaarde.Text = gebruiker.Gebruikersnaam;
            lblWachtwoordWaarde.Text = gebruiker.Wachtwoord;
            ShowMenu = false;
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
            voornaamTxb.Visible = true;
            voornaamTxb.Text = lblVoornaamWaarde.Text;
            achternaamTxb.Visible = true;
            achternaamTxb.Text = lblAchternaamWaarde.Text;
            bedrijfTxb.Visible = true;
            bedrijfTxb.Text = lblBedrijfWaarde.Text;
            locatieTxb.Visible = true;
            locatieTxb.Text = lblLocatieWaarde.Text;
            functieTxb.Visible = true;
            functieTxb.Text = lblFunctieWaarde.Text;
            kwaliteitTxb.Visible = true;
            kwaliteitTxb.Text = lblKwaliteitWaarde.Text;

        }
    }
}
