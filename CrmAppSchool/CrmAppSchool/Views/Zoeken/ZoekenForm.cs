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
using CrmAppSchool.Controllers;
using CrmAppSchool.Models;

namespace CrmAppSchool.Views.Zoeken
{
    public partial class ZoekenForm : Form
    {
        private Gebruiker gebruiker { get; set; }
        public bool ShowMenu { get; set; }
        public ZoekenForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            ShowMenu = false;
            gebruiker = _gebruiker;
            lblgebruiker.Text = lblgebruiker.Text + " " + gebruiker.Gebruikersnaam;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            ZoekController zoekController = new ZoekController();
            List<Models.Profiel> resultaatLijst = zoekController.zoekOpKwaliteit();
            ZoekOverzichtForm zoekOverzichtForm = new ZoekOverzichtForm(resultaatLijst);
            zoekOverzichtForm.ShowDialog();
        }
    }
}
