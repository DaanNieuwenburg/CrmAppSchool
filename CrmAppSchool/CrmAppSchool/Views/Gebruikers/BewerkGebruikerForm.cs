﻿using System;
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

namespace CrmAppSchool.Views.Gebruikers
{
    public partial class BewerkGebruikerForm : Form
    {
        private Gebruiker gebruiker { get; set; }

        public BewerkGebruikerForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            gebruiker = _gebruiker;
            this.Text = "Gebruiker: " + gebruiker.Gebruikersnaam;
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            // Controleert of wachtwoord niet leeg is
            if (nieuwWachtwoordTxb.Text == "")
            {
                MessageBox.Show("Het nieuwe wachtwoord mag niet leeg zijn","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(nieuwWachtwoordTxb.Text != tbBevestig.Text)
            {
                MessageBox.Show("De wachtwoordvelden komen niet overeen\nProbeer het a.u.b. opnieuw","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gebruiker.Wachtwoord = nieuwWachtwoordTxb.Text;
                GebruikerController gebruikercontroller = new GebruikerController();
                gebruikercontroller.veranderWachtwoordGebruiker(gebruiker);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gebruiker.SoortGebruiker == "Admin")
            {
                errorLbl.Text = "Het is niet mogelijk om een admin te verwijderen";
                errorLbl.Visible = true;
            }
            else
            {
                DialogResult dialoogResultaat = MessageBox.Show("Wilt u gebruiker " + gebruiker.Gebruikersnaam + " echt verwijderen?", "Verwijderen gebruiker", MessageBoxButtons.YesNo);
                if (dialoogResultaat == DialogResult.Yes)
                {
                    GebruikerController gebruikercontroller = new GebruikerController();
                    gebruikercontroller.verwijderGebruiker(gebruiker);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
