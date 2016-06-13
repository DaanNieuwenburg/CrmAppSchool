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
            string zoekquery = Convert.ToString(zoekfilterCbx.SelectedItem);
            string zoeknaar = Convert.ToString(cbZoeknaar.SelectedItem);
            if (Convert.ToString(zoekfilterCbx.SelectedItem) == "")
            {
                MessageBox.Show("Geef a.u.b. een zoekfilter op");
                //errorLbl.Text = "Geef a.u.b. een zoekfilter op";
                //errorLbl.Visible = true;
            }
            else
            {
                ZoekController zoekController = new ZoekController();
                if(cbZoeknaar.Text != "Bedrijf")
                {
                    List<Models.Persooncontact> resultaatLijst = zoekController.zoekMetFilter(zoekquery, zoekcriteriaTxb.Text, zoeknaar);
                    if (resultaatLijst.Count > 0)
                    {
                        ZoekOverzichtForm zoekOverzichtForm = new ZoekOverzichtForm(zoekfilterCbx, gebruiker);
                        zoekOverzichtForm.VulListviewPersoon(resultaatLijst);
                        this.Hide();
                        zoekOverzichtForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Geen Resultaten gevonden");
                    }
                }
                else
                {
                    List<Models.Bedrijfcontact> bedrijfresultaten = zoekController.Zoekbedrijf(zoekquery, zoekcriteriaTxb.Text, zoeknaar);
                    if(bedrijfresultaten.Count > 0)
                    {
                        ZoekOverzichtForm zoekOverzichtForm = new ZoekOverzichtForm(zoekfilterCbx, gebruiker);
                        zoekOverzichtForm.VulListviewBedrijf(bedrijfresultaten);
                        this.Hide();
                        zoekOverzichtForm.ShowDialog();
                    }
                }
                
            }
        }

        private void cbZoeknaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterLbl.Visible = true;
            zoekfilterCbx.Visible = true;
            if(cbZoeknaar.SelectedItem.ToString() == "Bedrijf")
            {
                zoekfilterCbx.Items.Clear();
                
                zoekfilterCbx.Items.Add("Bedrijfnaam");
                zoekfilterCbx.Items.Add("Hoofdlocatie");
                zoekfilterCbx.Items.Add("Omschrijving");
                zoekfilterCbx.SelectedItem = zoekfilterCbx.Items[0];
            }
            else
            {
                zoekfilterCbx.Items.Clear();
                zoekfilterCbx.Items.Add("Voornaam");
                zoekfilterCbx.Items.Add("Achternaam");
                zoekfilterCbx.Items.Add("Organisatie");
                zoekfilterCbx.Items.Add("Locatie");
                zoekfilterCbx.Items.Add("Functie");
                zoekfilterCbx.Items.Add("Kwaliteit");
                zoekfilterCbx.SelectedItem = zoekfilterCbx.Items[0];
            }
        }
    }
}
