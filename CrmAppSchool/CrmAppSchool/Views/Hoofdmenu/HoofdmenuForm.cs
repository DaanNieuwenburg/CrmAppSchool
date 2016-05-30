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
using CrmAppSchool.Views.Opdrachten;

namespace CrmAppSchool.Views.Gebruikers
{
    public partial class HoofdmenuForm : Form
    {
        public Gebruiker gebruiker;
        private bool ShowHelp { get; set; }
        public HoofdmenuForm(Gebruiker _gebruiker)
        {
            gebruiker = _gebruiker;
            InitializeComponent();
            toonGebruikersnaam();
            bepaalMenu();
            ShowHelp = false;

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
            voegGebruikerToe.ShowDialog();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            this.btnZoeken.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            Zoeken.ZoekenForm Zoeken = new Zoeken.ZoekenForm(gebruiker);
            Zoeken.Text = "Zoeken";
            Zoeken.ShowDialog();
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
            Contacten.ShowDialog();
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
            Models.Profiel profielModel = profiel.Get_Pofiel(gebruiker);
            Profiel.MijnprofielForm Profiel = new Profiel.MijnprofielForm(gebruiker, profielModel);
            this.Hide();
            Profiel.Text = "Profiel";
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (ShowHelp == false)
            {
                if (gebruiker is Admin)
                {
                    lblContacten.Visible = true;
                    lblOpdrachten.Visible = true;
                    lblProfiel.Visible = true;
                    lblRegistreer.Visible = true;
                    lblUitloggen.Visible = true;
                    lblZoeken.Visible = true;
                    ShowHelp = true;
                }
                else if (gebruiker is Docent)
                {
                    lblContacten.Visible = true;
                    lblOpdrachten.Visible = true;
                    lblProfiel.Visible = true;
                    lblUitloggen.Visible = true;
                    lblZoeken.Visible = true;
                }
                else if (gebruiker is Student)
                {
                    lblContacten.Text = "Zoeken";
                    lblContacten.Visible = true;
                    lblContacten.Location = new Point(84, 212);
                    lblProfiel.Text = "Opdrachten";
                    lblProfiel.Visible = true;
                    lblOpdrachten.Text = "Uitloggen";
                    lblOpdrachten.Location = new Point(258, 374);
                    lblOpdrachten.Visible = true;
                }
            }
            else
            {
                lblContacten.Visible = false;
                lblOpdrachten.Visible = false;
                lblProfiel.Visible = false;
                lblRegistreer.Visible = false;
                lblUitloggen.Visible = false;
                lblZoeken.Visible = false;
                ShowHelp = false;
            }

        }

        private void btnOpdrachten_Click(object sender, EventArgs e)
        {
            StageopdrachtForm soform = new StageopdrachtForm(gebruiker);
            soform.ShowDialog();
        }
    }
}
