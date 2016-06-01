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
using CrmAppSchool.Views.Gebruikers;

namespace CrmAppSchool.Views.Gebruikers
{
    public partial class voegGebruikerToeForm : Form
    {
        public bool ShowMenu { get; set; }
        public bool tweedeSelectie { get; set; }
        private bool geverifieerd { get; set; }
        public int Verkeerdwachtwoord { get; set; }

        private Gebruiker gebruiker { get; set; }
        private List<Form> openForms { get; set; }
        public voegGebruikerToeForm(Gebruiker _gebruiker)
        {
            openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            tweedeSelectie = false;
            gebruiker = _gebruiker;
            Verifieer_login();
            InitializeComponent();
            ShowMenu = false;
            geverifieerd = false;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            vulListView();
        }

        private void vulListView()
        {
            // Deze methode vult het listview met alle gebruikers van het systeem
            GebruikerController gebruikercontroller = new GebruikerController();
            List<Gebruiker> gebruikersLijst = gebruikercontroller.haalGebruikersOp();

            // Zet alle gebruikers in de lijst
            foreach (Models.Gebruiker gebruiker in gebruikersLijst)
            {
                ListViewItem lvw = new ListViewItem(gebruiker.Gebruikersnaam);
                // Bepaal het soort gebruiker
                if (gebruiker is Admin)
                {
                    lvw.SubItems.Add("Admin");
                }
                else if (gebruiker is Docent)
                {
                    lvw.SubItems.Add("Docent");
                }
                else if (gebruiker is Student)
                {
                    lvw.SubItems.Add("Student");
                }

                // Voegt gegevens aan listview toe
                gebruikerLvw.Items.Add(lvw);
            }
        }

        private void voegToeBtn_Click(object sender, EventArgs e)
        {
            // valideert of alle gegevens zijn en ingevuld, zo ja roept de controller aan
            if (gebruikersnaamTxb.Text == "" || wachtwoordTxb.Text == "" || Convert.ToString(soortGebruikerCbx.SelectedItem) == "")
            {
                MessageBox.Show("Voer a.u.b.alle informatie in", "Error");
            }
            else
            {
                Gebruiker gebruiker = null;
                if (Convert.ToString(soortGebruikerCbx.SelectedItem) == "Docent")
                {
                    gebruiker = new Docent(gebruikersnaamTxb.Text);
                }
                else if (Convert.ToString(soortGebruikerCbx.SelectedItem) == "Student")
                {
                    gebruiker = new Student(gebruikersnaamTxb.Text);
                }
                gebruiker.Wachtwoord = wachtwoordTxb.Text;

                AdminController admincontroller = new AdminController();
                admincontroller.voegGebruikerToe(gebruiker);

                this.Close();
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void gebruikerLvw_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            Gebruiker nieuweGebruiker = null;
            // Omdat deselecteren ook deze event uitvoert, is er het if statement en de boolean
            if (gebruikerLvw.SelectedIndices.Count > 0 && tweedeSelectie == false)
            {
                // Bepaal gebruiker
                if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Admin")
                {
                    nieuweGebruiker = new Admin(gebruikerLvw.SelectedItems[0].Text);
                }
                else if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Docent")
                {
                    nieuweGebruiker = new Docent(gebruikerLvw.SelectedItems[0].Text);
                }
                else if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Student")
                {
                    nieuweGebruiker = new Student(gebruikerLvw.SelectedItems[0].Text);
                }

                // Open bewerk gebruiker form
                BewerkGebruikerForm bewerkgebruikerform = new BewerkGebruikerForm(nieuweGebruiker);
                bewerkgebruikerform.ShowDialog();

                // Reset de listview
                gebruikerLvw.Items.Clear();
                vulListView();

                // Hierna ziet de app weer een selectie.. daarom is deze boolean er.
                tweedeSelectie = true;
            }
            else
            {
                tweedeSelectie = false;
            }


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
                bool resultaat = logincontroller.VerifieerGebruiker(gebruikersnaam, wachtwoord);
                if (resultaat == false)
                {
                    MessageBox.Show("Het wachtwoord is incorrect\nProbeer het opnieuw", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Verkeerdwachtwoord++;
                    if (Verkeerdwachtwoord == 5)
                    {
                        MessageBox.Show("U heeft 5 maal het verkeerde wachtwoord ingevoerd\nU wordt uit veiligheidsoverwegingen uitgelogd", "Te veel pogingen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.Abort;

                        Login.InlogForm inlog = new Login.InlogForm();
                        openForms.Add(inlog);                   
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

        private void voegGebruikerToeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
