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
        public voegGebruikerToeForm()
        {
            InitializeComponent();
            ShowMenu = false;
        }

        private void voegToeBtn_Click(object sender, EventArgs e)
        {
            Gebruiker gebruiker = null;
            if (Convert.ToString(soortGebruikerCbx.SelectedItem) == "Docent")
            {
                gebruiker = new Docent(gebruikersnaamTxb.Text);
            }
            else if(Convert.ToString(soortGebruikerCbx.SelectedItem) == "Student")
            {
                gebruiker = new Student(gebruikersnaamTxb.Text);
            }
            gebruiker.Wachtwoord = wachtwoordTxb.Text;

            AdminController admincontroller = new AdminController();
            admincontroller.voegGebruikerToe(gebruiker);

            this.Close();
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
    }
}
