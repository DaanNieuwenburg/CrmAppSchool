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

        private void voegGebruikerToeBtn_Click(object sender, EventArgs e)
        {
            this.voegGebruikerToeBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            voegGebruikerToeForm voegGebruikerToe = new voegGebruikerToeForm();
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
            Zoeken.ZoekenForm Zoeken= new Zoeken.ZoekenForm();
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
            Contacten.ContactenForm Contacten = new Contacten.ContactenForm();
            Contacten.Show();
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            this.btnProfiel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            Profiel.MijnprofielForm Profiel = new Profiel.MijnprofielForm(gebruiker);
            this.Hide();
            Profiel.ShowDialog();
            if(Profiel.ShowMenu == true)
            {
                Show();
                Profiel.ShowMenu = false;
            }
        }
    }
}
