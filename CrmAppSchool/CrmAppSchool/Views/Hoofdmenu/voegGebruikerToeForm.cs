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
        public voegGebruikerToeForm()
        {
            InitializeComponent();
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
    }
}
