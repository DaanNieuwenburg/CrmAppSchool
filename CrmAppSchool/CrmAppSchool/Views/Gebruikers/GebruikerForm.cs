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


        private Gebruiker gebruiker { get; set; }

        public voegGebruikerToeForm(Gebruiker _gebruiker)
        {


            InitializeComponent();
            tweedeSelectie = false;
            gebruiker = _gebruiker;
            ShowMenu = false;
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
                if (gebruiker.SoortGebruiker == "Admin")
                {
                    lvw.SubItems.Add("Admin");
                }
                else if (gebruiker.SoortGebruiker == "Docent")
                {
                    lvw.SubItems.Add("Docent");
                }
                else if (gebruiker.SoortGebruiker == "Student")
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
                Gebruiker gebruiker = new Gebruiker() { Gebruikersnaam = gebruikersnaamTxb.Text, Wachtwoord = wachtwoordTxb.Text, SoortGebruiker = soortGebruikerCbx.Text };
                GebruikerController gebruikercontroller = new GebruikerController();
                gebruikercontroller.voegGebruikerToe(gebruiker);

                this.Close();
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }
        private void voegGebruikerToeForm_Load(object sender, EventArgs e)
        {

        }

        private void gebruikerLvw_ItemActivate(object sender, EventArgs e)
        {
            Gebruiker nieuweGebruiker = null;
            // Bepaal gebruiker
            if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Admin")
            {
                nieuweGebruiker = new Gebruiker() { Gebruikersnaam = gebruikerLvw.SelectedItems[0].Text };
            }
            else if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Docent")
            {
                nieuweGebruiker = new Gebruiker() { Gebruikersnaam = gebruikerLvw.SelectedItems[0].Text };
            }
            else if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Student")
            {
                nieuweGebruiker = new Gebruiker() { Gebruikersnaam = gebruikerLvw.SelectedItems[0].Text };
            }

            // Open bewerk gebruiker form
            BewerkGebruikerForm bewerkgebruikerform = new BewerkGebruikerForm(nieuweGebruiker);
            bewerkgebruikerform.ShowDialog();

            // Reset de listview
            gebruikerLvw.Items.Clear();
            vulListView();
        }

    }
}

