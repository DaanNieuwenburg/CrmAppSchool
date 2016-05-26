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

namespace CrmAppSchool.Views.Hoofdmenu
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

        }

        private void voegToeBtn_Click(object sender, EventArgs e)
        {
            // valideert of alle gegevens zijn en ingevuld, zo ja roept de controller aan
            if (gebruikersnaamTxb.Text == "" || wachtwoordTxb.Text == "" || Convert.ToString(soortGebruikerCbx.SelectedItem) == "")
            {
                errorLbl.Visible = true;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gebruikersnaamLbl_Click(object sender, EventArgs e)
        {

        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void voegGebruikerToeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
