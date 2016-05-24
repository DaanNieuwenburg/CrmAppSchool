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

namespace CrmAppSchool.Views.Hoofdmenu
{
    public partial class HoofdmenuForm : Form
    {
        public Gebruiker gebruiker;
        public HoofdmenuForm(Gebruiker _gebruiker)
        {
            gebruiker = _gebruiker;
            InitializeComponent();
            toonGebruikersnaam();
            bepaalMenu();
        }

        private void toonGebruikersnaam()
        {
            if(gebruiker is Admin)
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
            else if(gebruiker is Student)
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
            else if(gebruiker is Docent)
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
        }

        private void bepaalMenu()
        {
            if(gebruiker is Docent)
            {
                voegGebruikerToeBtn.Visible = false;
            }
            else if(gebruiker is Student)
            {
                voegGebruikerToeBtn.Visible = false;
                btnProfiel.Visible = false;
                btnContacten.Visible = false;
                btnZoeken.Location = new Point(24, 75);
                btnOpdrachten.Location = new Point(28, 231);
                btnUitloggen.Location = new Point(203, 231);
            }
        }

        private void voegGebruikerToeBtn_Click(object sender, EventArgs e)
        {
            this.voegGebruikerToeBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            voegGebruikerToeForm voegGebruikerToe = new voegGebruikerToeForm(gebruiker);
            voegGebruikerToe.Text = "Registreer Gebruiker";
            voegGebruikerToe.ShowDialog();
            if (voegGebruikerToe.ShowMenu == true)
            {
                Show();
                voegGebruikerToe.ShowMenu = false;
            }
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            this.btnZoeken.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            Zoeken.ZoekenForm Zoeken= new Zoeken.ZoekenForm(gebruiker);
            Zoeken.Text = "Zoeken";
            Zoeken.Show();
            if (Zoeken.ShowMenu == true)
            {
                Show();
                Zoeken.ShowMenu = false;
            }
        }

        private void btnContacten_Click(object sender, EventArgs e)
        {
            this.btnContacten.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            Contacten.ContactenForm Contacten = new Contacten.ContactenForm(gebruiker);
            Contacten.Text = "Contacten";
            Contacten.Show();
            if (Contacten.ShowMenu == true)
            {
                Show();
                Contacten.ShowMenu = false;
            }
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            this.btnProfiel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            Controllers.ProfielController profiel = new Controllers.ProfielController();
            profiel.Get_Pofiel(gebruiker);
            Profiel.MijnprofielForm Profiel = new Profiel.MijnprofielForm(gebruiker);
            this.Hide();
            Profiel.Text = "Profiel";
            Profiel.Gebruikersnaam = profiel.Gebruikersnaam;
            Profiel.Voornaam = profiel.Voornaam;
            Profiel.Achternaam = profiel.Achternaam;
            Profiel.Bedrijf = profiel.Bedrijf;
            Profiel.Locatie = profiel.Locatie;
            Profiel.Functie = profiel.Functie;
            Profiel.Kwaliteit = profiel.Kwaliteit;
            Profiel.ShowDialog();
            if(Profiel.ShowMenu == true)
            {
                Show();
                Profiel.ShowMenu = false;
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Close();
            Login.InlogForm login = new Login.InlogForm();
            login.Show();
        }
    }
}
