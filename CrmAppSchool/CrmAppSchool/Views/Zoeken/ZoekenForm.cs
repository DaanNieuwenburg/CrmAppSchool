﻿using System;
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
            string zoekquery = Convert.ToString(zoekfilterCbx.SelectedItem);
            if (Convert.ToString(zoekfilterCbx.SelectedItem) == "")
            {
                MessageBox.Show("Geef a.u.b. een zoekfilter op");
                //errorLbl.Text = "Geef a.u.b. een zoekfilter op";
                //errorLbl.Visible = true;
            }
            else
            {
                ZoekController zoekController = new ZoekController();
                List<Models.Persooncontact> resultaatLijst = zoekController.zoekMetFilter(zoekquery, zoekcriteriaTxb.Text);
                if (resultaatLijst.Count > 0)
                {
                    ZoekOverzichtForm zoekOverzichtForm = new ZoekOverzichtForm(resultaatLijst);
                    this.Hide();
                    zoekOverzichtForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Geen Resultaten gevonden");
                }
            }
        }
    }
}
