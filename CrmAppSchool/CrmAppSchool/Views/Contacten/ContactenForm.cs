using CrmAppSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmAppSchool.Views.Contacten
{
    public partial class ContactenForm : Form
    {
        public bool ShowMenu { get; set; }
        private Gebruiker gebruiker { get; set; }
        public ContactenForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            ShowMenu = false;
            gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }
    }
}
