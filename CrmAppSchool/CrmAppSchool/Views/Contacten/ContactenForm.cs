﻿using CrmAppSchool.Models;
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
        private bool ShowZoeken { get; set; }
        private Gebruiker gebruiker { get; set; }
        public ContactenForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            ShowMenu = false;
            ShowZoeken = false;
            gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            ActiveerZoeken();

        }
        private void ActiveerZoeken()
        {
            if (ShowZoeken == false)
            {
                ShowZoeken = true;
                btnVoegtoe.Visible = false;
                tbSearch.Visible = true;
                btnCancel.Visible = true;
            }
        }
        private void AnnuleerZoeken()
        {
            ShowZoeken = false;
            btnVoegtoe.Visible = true;
            tbSearch.Visible = false;
            btnCancel.Visible = false;  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AnnuleerZoeken();
            tbSearch.Text = "Zoeken...";
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }
    }
}
