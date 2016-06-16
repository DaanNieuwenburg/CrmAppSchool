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
using CrmAppSchool.Controllers;

namespace CrmAppSchool.Views.Gebruikers
{
    public partial class HoofdmenuForm : Form
    {
        private bool geverifieerd { get; set; }
        public int Verkeerdwachtwoord { get; set; }
        private bool uitloggen { get; set; }
        public Gebruiker gebruiker;
        private bool ShowHelp { get; set; }
        private List<Form> openForms { get; set; }
        public HoofdmenuForm(Gebruiker _gebruiker)
        {
            openForms = new List<Form>();

            uitloggen = false;
            gebruiker = _gebruiker;
            InitializeComponent();
            toonGebruikersnaam();
            bepaalMenu();
            ShowHelp = false;

        }

        private void toonGebruikersnaam()
        {
            if(gebruiker.SoortGebruiker == "Admin")
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
            else if(gebruiker.SoortGebruiker == "Student")
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
            else if(gebruiker.SoortGebruiker == "Docent")
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
        }

        private void bepaalMenu()
        {
            if(gebruiker.SoortGebruiker == "Docent")
            {
                voegGebruikerToeBtn.Visible = false;
            }
            else if(gebruiker.SoortGebruiker == "Student")
            {
                voegGebruikerToeBtn.Visible = false;
                btnProfiel.Visible = false;
                btnContacten.Visible = false;
                btnBedrijven.Visible = false;
                btnZoeken.Location = new Point(24, 75);
                btnOpdrachten.Location = new Point(28, 231);
                btnUitloggen.Location = new Point(203, 231);
            }
            else if(gebruiker.SoortGebruiker == "Admin")
            {
                btnProfiel.Visible = false;
            }
        }

        private void voegGebruikerToeBtn_Click(object sender, EventArgs e)
        {
            
            this.voegGebruikerToeBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            Verifieer_login();
            if(geverifieerd == true)
            {
                voegGebruikerToeForm voegGebruikerToe = new voegGebruikerToeForm(gebruiker);
                voegGebruikerToe.Show();

                if (voegGebruikerToe.ShowMenu == true)
                {
                    Show();
                    voegGebruikerToe.ShowMenu = false;
                }

                this.Hide();
            }
            
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
            Bedrijven.ContactenForm Contacten = new Bedrijven.ContactenForm(gebruiker);
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
            uitloggen = true;
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
            {
                if (f.Text != "Inloggen")
                    f.Close();
            }
            Login.InlogForm login = new Login.InlogForm();
            login.Show();
        }
        private void Verifieer_login()
        {
            while (geverifieerd == false)
            {
                string gebruikersnaam = gebruiker.Gebruikersnaam;
                string wachtwoord = "";
                Gebruikers.ValidateForm _popup = new ValidateForm();
                _popup.ShowDialog();
                if (_popup.DialogResult == DialogResult.OK)
                {
                    wachtwoord = _popup.password;
                }
                LoginController logincontroller = new LoginController();
                logincontroller.relogin = true;
                bool resultaat = logincontroller.VerifieerGebruiker(gebruikersnaam, wachtwoord);
                if (resultaat == false)
                {
                    MessageBox.Show("Het wachtwoord is incorrect\nProbeer het opnieuw", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Verkeerdwachtwoord++;
                    if (Verkeerdwachtwoord == 5)
                    {
                        uitloggen = true;
                        MessageBox.Show("U heeft 5 maal het verkeerde wachtwoord ingevoerd\nU wordt uit veiligheidsoverwegingen uitgelogd", "Te veel pogingen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.Abort;

                        Login.InlogForm inlog = new Login.InlogForm();
                        openForms.Add(inlog);
                        foreach (Form f in Application.OpenForms)
                            openForms.Add(f);
                        foreach (Form f in openForms)
                        {
                            if (f.Text != "Inloggen")
                                f.Close();
                        }
                        inlog.Show();
                        break;
                    }
                }
                else
                {
                    geverifieerd = true;
                }
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (ShowHelp == false)
            {
                if (gebruiker.SoortGebruiker == "Admin")
                {
                    lblContacten.Visible = true;
                    lblOpdrachten.Visible = true;
                    lblRegistreer.Visible = true;
                    lblUitloggen.Visible = true;
                    BedrijvenLbl.Visible = true;
                    lblZoeken.Visible = true;
                    ShowHelp = true;
                }
                else if (gebruiker.SoortGebruiker == "Docent")
                {
                    lblContacten.Visible = true;
                    lblOpdrachten.Visible = true;
                    lblProfiel.Visible = true;
                    lblUitloggen.Visible = true;
                    lblZoeken.Visible = true;
                    BedrijvenLbl.Visible = true;
                    ShowHelp = true;
                }
                else if (gebruiker.SoortGebruiker == "Student")
                {
                    lblContacten.Text = "Zoeken";
                    lblContacten.Visible = true;
                    lblContacten.Location = new Point(84, 212);
                    lblProfiel.Text = "Opdrachten";
                    lblProfiel.Visible = true;
                    lblOpdrachten.Text = "Uitloggen";
                    lblOpdrachten.Location = new Point(258, 374);
                    lblOpdrachten.Visible = true;
                    ShowHelp = true;
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
                BedrijvenLbl.Visible = false;
                ShowHelp = false;
            }

        }

        private void btnOpdrachten_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            StageopdrachtForm soform = new StageopdrachtForm(gebruiker);
            soform.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btnBedrijven_Click(object sender, EventArgs e)
        {
            //Cursor = Cursors.AppStarting;
            Bedrijven.BedrijfForm bForm = new Bedrijven.BedrijfForm(gebruiker);
            bForm.ShowDialog();
            //Cursor = Cursors.Default;
        }

        private void HoofdmenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (uitloggen == false)
                Environment.Exit(0);
        }
    }
}

