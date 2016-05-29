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

        private Gebruiker gebruiker { get; set; }
        public voegGebruikerToeForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            ShowMenu = false;
            gebruiker = _gebruiker;
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

        private void gebruikerLvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gebruiker nieuweGebruiker = null;
            // Omdat deselecteren ook deze event uitvoert, is er het if statement
            if (gebruikerLvw.SelectedIndices.Count > 0)
            {
                Console.WriteLine(gebruikerLvw.SelectedIndices.Count);
                // Bepaal gebruiker
                if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Admin")
                {
                    nieuweGebruiker = new Admin(gebruikerLvw.SelectedItems[0].Text);
                }
                else if(gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Docent")
                {
                    nieuweGebruiker = new Docent(gebruikerLvw.SelectedItems[0].Text);
                }
                else if(gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Student")
                {
                    nieuweGebruiker = new Student(gebruikerLvw.SelectedItems[0].Text);
                }

                // Open bewerk gebruiker form
                BewerkGebruikerForm bewerkgebruikerform = new BewerkGebruikerForm(nieuweGebruiker);
                bewerkgebruikerform.ShowDialog();

                // Reset de listview
                gebruikerLvw.Items.Clear();
                vulListView();
                gebruikerLvw.Items[0].Selected = false;
                gebruikerLvw.Items[0].Focused = false;
            }
        }
    }
}
