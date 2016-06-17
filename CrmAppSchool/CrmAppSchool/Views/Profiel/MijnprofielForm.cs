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
using CrmAppSchool.Controllers;

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

            // Bind model aan form
            profiel = _profiel;

            // Zet alle modes in het begin op false
            ShowMenu = false;
            EditMode = false;
            PriveMode = false;
            EditWachtwoordMode = false;
        }

        //
        // Alle eigen methodes van de form
        //
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
                tbLocatie.Visible = true;
                tbFunctie.Visible = true;
                tbKwaliteit.Visible = true;

                lblVoornaamWaarde.Visible = false;
                lblAchternaamWaarde.Visible = false;
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
                tbLocatie.Visible = false;
                tbFunctie.Visible = false;
                tbKwaliteit.Visible = false;

                lblVoornaamWaarde.Visible = true;
                lblAchternaamWaarde.Visible = true;
                lblKwaliteitWaarde.Visible = true;
                lblLocatieWaarde.Visible = true;
                lblFunctieWaarde.Visible = true;
            }
        }
        private void UpdatePrive()
        {
            if (PriveMode == true)
            {
                btnBewerk.Visible = false;
                btnPrive.Visible = false;
                btnOpslaan.Visible = true;
                btnAnnuleer.Visible = true;
                lblVoornaam.Visible = false;
                lblAchternaam.Visible = false;

                cbPriveFU.Visible = true;
                cbPriveKW.Visible = true;
                cbPriveLO.Visible = true;

                lblAchternaamWaarde.Visible = false;
                lblVoornaamWaarde.Visible = false;
                lblLocatieWaarde.Visible = false;
                lblKwaliteitWaarde.Visible = false;
                lblFunctieWaarde.Visible = false;
            }
            else
            {
                btnBewerk.Visible = true;
                btnPrive.Visible = true;
                btnOpslaan.Visible = false;
                btnAnnuleer.Visible = false;

                lblVoornaam.Visible = true;
                lblAchternaam.Visible = true;

                cbPriveFU.Visible = false;
                cbPriveKW.Visible = false;
                cbPriveLO.Visible = false;

                lblAchternaamWaarde.Visible = true;
                lblVoornaamWaarde.Visible = true;
                lblLocatieWaarde.Visible = true;
                lblKwaliteitWaarde.Visible = true;
                lblFunctieWaarde.Visible = true;
            }
        }

        //
        // Alle button_Click() events van de form
        //
        private void pbHome_Click(object sender, EventArgs e)
        {
            //Brengt je terug naar het hoofdmenu
            ShowMenu = true;
            this.Hide();
        }

        private void MijnprofielForm_Load(object sender, EventArgs e)
        {
            // Set de tooltips
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(btnBewerkLogin, "Bewerk je inloggegevens");
            ToolTip TPnieuw = new ToolTip();
            TPnieuw.ShowAlways = false;
            TPnieuw.SetToolTip(btnPrive, "Zet bepaalde informatie prive");
            ToolTip TPbewerk = new ToolTip();
            TPbewerk.ShowAlways = false;
            TPbewerk.SetToolTip(btnBewerk, "Bewerk je profielgegevens");

            // Zet de informatie van het profiel naar de labels
            lblVoornaamWaarde.Text = profiel.Voornaam;
            lblAchternaamWaarde.Text = profiel.Achternaam;
            lblLocatieWaarde.Text = profiel.Locatie;
            cbPriveLO.Checked = profiel.LocatieIsZichtbaar;
            if (profiel.KwaliteitenLijst != null)
            {
                // Reset de txb en voer de kwaliteiten in
                lblKwaliteitWaarde.Text = "";

                int teller = 0;
                foreach (string kwaliteit in profiel.KwaliteitenLijst)
                {
                    if (teller + 1 == profiel.KwaliteitenLijst.Count())
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit;
                        lblKwaliteitWaarde.Text = lblKwaliteitWaarde.Text + kwaliteit;
                    }
                    else
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit + Environment.NewLine;
                        lblKwaliteitWaarde.Text = lblKwaliteitWaarde.Text + kwaliteit + Environment.NewLine;
                    }
                }
            }
            cbPriveKW.Checked = profiel.KwaliteitIsZichtbaar;
            lblFunctieWaarde.Text = profiel.Functie;
            cbPriveFU.Checked = profiel.FunctieIsZichtbaar;
            cbPriveKW.Checked = profiel.KwaliteitIsZichtbaar;
        }

        private void btnBewerk_Click(object sender, EventArgs e)
        {
            EditMode = true; //Kijkt of het bewerken aan of uit staat
            tbVoornaam.Text = lblVoornaamWaarde.Text;
            tbAchternaam.Text = lblAchternaamWaarde.Text;
            tbLocatie.Text = lblLocatieWaarde.Text;
            tbFunctie.Text = lblFunctieWaarde.Text;
            if (profiel.KwaliteitenLijst != null)
            {
                // Reset de txb en voer de kwaliteiten in
                tbKwaliteit.Text = "";
                int teller = 0;
                foreach (string kwaliteit in profiel.KwaliteitenLijst)
                {
                    if (teller + 1 == profiel.KwaliteitenLijst.Count())
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit;
                    }
                    else
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit + Environment.NewLine;
                    }
                    teller++;
                }
            }
            Updatebuttons();
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
            bool error = false;
            for (int i = 0; i < 6; i++)
            {
                if (Bewerkt[i] == true)
                {
                    if (i == 0)
                    {
                        if (tbVoornaam.Text != "")
                            lblVoornaamWaarde.Text = tbVoornaam.Text;

                        else
                            error = true;
                    }
                    else if (i == 1)
                    {
                        if (tbAchternaam.Text != "")
                            lblAchternaamWaarde.Text = tbAchternaam.Text;

                        else
                            error = true;
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
                    }
                }
            }
            if (error == true)
            {
                MessageBox.Show("De velden Voornaam en Achternaam mogen niet leeg zijn.");
            }
            else {
                // Schrijf de nieuwe profiel informatie over naar de database
                Controllers.ProfielController profielController = new Controllers.ProfielController();
                profiel.Voornaam = lblVoornaamWaarde.Text;
                profiel.Achternaam = lblAchternaamWaarde.Text;
                profiel.Locatie = lblLocatieWaarde.Text;
                profiel.Functie = lblFunctieWaarde.Text;

                // Zet de kwaliteiten in de list
                profiel.KwaliteitenLijst = new List<string>();
                foreach (string ingevoerdeKwaliteit in tbKwaliteit.Lines)
                {
                    if (ingevoerdeKwaliteit != "")
                    {
                        profiel.KwaliteitenLijst.Add(ingevoerdeKwaliteit);
                    }
                }

                // Zet de kwaliteiten weer in de textbox
                tbKwaliteit.Text = "";
                lblKwaliteitWaarde.Text = "";
                int teller = 0;
                foreach (string kwaliteit in profiel.KwaliteitenLijst)
                {
                    if (teller + 1 == profiel.KwaliteitenLijst.Count())
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit;
                        lblKwaliteitWaarde.Text = lblKwaliteitWaarde.Text + kwaliteit;
                    }
                    else
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit + Environment.NewLine;
                        lblKwaliteitWaarde.Text = lblKwaliteitWaarde.Text + kwaliteit + Environment.NewLine;
                    }
                    teller++;
                }

                tbKwaliteit.Text = "";

                // Zet de checkboxes in het profiel
                profiel.LocatieIsZichtbaar = cbPriveLO.Checked;
                profiel.FunctieIsZichtbaar = cbPriveFU.Checked;
                profiel.KwaliteitIsZichtbaar = cbPriveKW.Checked;

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
                
                // Zet de kwaliteiten weer in de textbox
                tbKwaliteit.Text = "";
                lblKwaliteitWaarde.Text = "";
                int tellerr = 0;
                foreach (string kwaliteit in profiel.KwaliteitenLijst)
                {
                    if (tellerr + 1 == profiel.KwaliteitenLijst.Count())
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit;
                        lblKwaliteitWaarde.Text = lblKwaliteitWaarde.Text + kwaliteit;
                    }
                    else
                    {
                        tbKwaliteit.Text = tbKwaliteit.Text + kwaliteit + Environment.NewLine;
                        lblKwaliteitWaarde.Text = lblKwaliteitWaarde.Text + kwaliteit + Environment.NewLine;
                    }
                    tellerr++;
                }
            }
        }
        private void btnBewerkLogin_Click(object sender, EventArgs e)
        {
            if (EditWachtwoordMode == false)
            {
                lblWachtwoord.Visible = true;
                lbloldpassword.Text = "Huidige Wachtwoord:";
                tbHuidigwachtwoord.Visible = true;
                tbWachtwoord.Visible = true;
                tbBevestig.Visible = true;
                lblBevestig.Visible = true;
                lblWachtwoordWaarde.Visible = false;
                EditWachtwoordMode = true;
            }
            else if (tbHuidigwachtwoord.Text == "")
            {
                lblWachtwoord.Visible = false;
                lbloldpassword.Text = "Wachtwoord:";
                tbHuidigwachtwoord.Visible = false;
                tbWachtwoord.Visible = false;
                tbBevestig.Visible = false;
                lblBevestig.Visible = false;
                lblWachtwoordWaarde.Visible = true;
                EditWachtwoordMode = false;
                tbWachtwoord.Text = "";
                tbBevestig.Text = "";
            }
            // Kijk of het nieuwe wachtwoord en de bevestiging overeen komen
            else if (tbWachtwoord.Text != tbBevestig.Text)
            {
                MessageBox.Show("De wachtwoorden komen niet overeen", "Waarschuwing");
            }
            else if (tbWachtwoord.Text == "")
            {
                MessageBox.Show("Voer een nieuw wachtwoord in.");
            }
            else if (EditWachtwoordMode == true && tbWachtwoord.Text == tbBevestig.Text)
            {
                // Kijk of het oude wachtwoord klopt met die in de database
                string gebruikersnaam = gebruiker.Gebruikersnaam;
                string wachtwoord = tbHuidigwachtwoord.Text;
                LoginController logincontroller = new LoginController();
                bool resultaat = logincontroller.VerifieerGebruiker(gebruikersnaam, wachtwoord, false);
                if (resultaat == true)
                {
                    lbloldpassword.Text = "Wachtwoord:";
                    lblWachtwoordWaarde.Visible = true;
                    lblWachtwoord.Visible = false;
                    tbHuidigwachtwoord.Visible = false;
                    tbWachtwoord.Visible = false;
                    lblBevestig.Visible = false;
                    tbBevestig.Visible = false;
                    EditWachtwoordMode = false;
                    gebruiker.Wachtwoord = tbWachtwoord.Text;
                    GebruikerController gebruikercontroller = new GebruikerController();
                    gebruikercontroller.veranderWachtwoordGebruiker(gebruiker);
                    tbWachtwoord.Text = "";
                    tbHuidigwachtwoord.Text = "";
                    tbBevestig.Text = "";


                    // Set nieuw wachtwoord
                }
                else
                {
                    MessageBox.Show("Het huidige wachtwoord is incorrect\nPas deze aan en probeer opnieuw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnPrive_Click(object sender, EventArgs e)
        {
            PriveMode = true;
            UpdatePrive();
        }    

        //
        // Alle overige events van de form
        //
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

    }
}
