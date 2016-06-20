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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CrmAppSchool.Views.Bedrijven
{
    public partial class BedrijfForm : Form
    {
        public bool ShowMenu { get; set; }
        private bool ShowSave { get; set; }
        private bool ShowZoeken { get; set; }
        private bool validwebsite { get; set; }
        private bool EditMode { get; set; }
        private bool validtelefoon { get; set; }
        private bool validbedrijfemail { get; set; }
        public Gebruiker _gebruiker { get; set; }
        BedrijfController cc = new BedrijfController();
        public BedrijfForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            // Alleen de admin mag bedrijven verwijderen
            if (_gebruiker.SoortGebruiker == "Admin")
                btnDelete.Visible = true;
            
            // Aanmaken imagelist voor de resultaten
            var imagelist = new ImageList();
            imagelist.Images.Add("GS", Properties.Resources.Afbeelding_ContactPersoon_GastSpreker);
            imagelist.Images.Add("GD", Properties.Resources.Afbeelding_ContactPersoon_GastDocent);
            imagelist.Images.Add("BD", Properties.Resources.Afbeelding_ContactPersoon_Bedrijf);
            imagelist.Images.Add("SB", Properties.Resources.Afbeelding_ContactPersoon_StageBegeleider);
            imagelist.ImageSize = new Size(50, 50);
            lvBedrijven.LargeImageList = imagelist;

            ShowMenu = false;
            ShowZoeken = false;
            ShowSave = false;
            EditMode = false;
            this._gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + this._gebruiker.Gebruikersnaam;

        }
        //
        // Alle eigen methodes van de form
        //
        private void vulContacten()
        {
            settooltips();
            lvBedrijven.Items.Clear();
            BedrijfController _getcontacten = new BedrijfController();
            List<Bedrijfcontact> contactenlijst = _getcontacten.haalBedrijfLijstOp();
            foreach (Bedrijfcontact contact in contactenlijst)
            {
                ListViewItem c = new ListViewItem(contact.Bedrijfnaam);
                c.SubItems.Add(Convert.ToString(contact.Hoofdlocatie));
                c.SubItems.Add(Convert.ToString(contact.Bedrijfscode));
                c.ImageKey = "BD";
                lvBedrijven.Items.Add(c);
            }
        }
        private void settooltips()
        {
            // Maakt de tooltips aan
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(tbWebsite, "Voer een geldige website in.\nExample: (www.)google.nl");
            ToolTip TPnieuw = new ToolTip();
            TPnieuw.ShowAlways = false;
            TPnieuw.SetToolTip(btnVoegtoe, "Voeg een nieuw bedrijf toe");
            ToolTip TPbewerk = new ToolTip();
            TPbewerk.ShowAlways = false;
            TPbewerk.SetToolTip(btnWijzig, "Bewerk het geselecteerde bedrijf");
            ToolTip TPdelete = new ToolTip();
            TPdelete.ShowAlways = false;
            TPdelete.SetToolTip(btnDelete, "Verwijder het geselecteerde bedrijf");
        }

        
        public void zoek()
        {
            lvBedrijven.Items.Clear();
            string input = "%" + tbSearch.Text + "%";
            List<Bedrijfcontact> resultaten = cc.ZoekBedrijven(input, _gebruiker);
            foreach (Bedrijfcontact contact in resultaten)
            {
                ListViewItem lvi = new ListViewItem(contact.Bedrijfnaam);
                lvi.SubItems.Add(contact.Hoofdlocatie);
                lvi.SubItems.Add(contact.Bedrijfscode.ToString());
                lvBedrijven.Items.Add(lvi);
                lvi.ImageKey = "BD";
            }
        }

        //
        // Alle button_Click events van de form
        //
        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            Close();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            if (ShowZoeken == true)
            {
                zoek();
                ShowZoeken = false;
                btnVoegtoe.Visible = true;
                btnZoeken.Location = new Point(527, 1);
                btnWijzig.Visible = true;
                btnDelete.Visible = true;
                tbSearch.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
                ActiveerZoeken();
            }

        }
        
        private void ActiveerZoeken()
        {
            if (ShowZoeken == false)
            {
                ShowZoeken = true;
                btnZoeken.Location = new Point(463, 1);
                btnVoegtoe.Visible = false;
                btnWijzig.Visible = false;
                btnDelete.Visible = false;
                tbSearch.Visible = true;
                btnCancel.Visible = true;
            }
        }
        private void AnnuleerZoeken()
        {
            vulContacten();
            ShowZoeken = false;
            btnVoegtoe.Visible = true;
            btnZoeken.Location = new Point(527, 1);
            btnWijzig.Visible = true;
            btnDelete.Visible = true;
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


        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            validtelefoon = true;
            if (ShowSave == false)
            {
                bedrijfPnl.Visible = true;
                pnbedrijf2.Visible = true;
                lvBedrijven.Visible = false;
                btnVoegtoe.Visible = false;
                btnAnnuleer.Visible = true;
                btnZoeken.Visible = false;
                btnOpslaan.Visible = true;
                btnWijzig.Visible = false;
                btnDelete.Visible = false;
                ShowSave = true;

            }
            else
            {
                btnVoegtoe.Visible = true;
                btnAnnuleer.Visible = false;
                btnOpslaan.Visible = false;
                btnZoeken.Visible = true;
                btnWijzig.Visible = true;
                btnDelete.Visible = true;
                ShowSave = false;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            bedrijfPnl.Visible = false;
            pnbedrijf2.Visible = false;
            btnZoeken.Visible = true;
            btnVoegtoe.Visible = true;
            btnWijzig.Visible = true;
            btnDelete.Visible = true;
            btnAnnuleer.Visible = false;
            btnOpslaan.Visible = false;
            lvBedrijven.Visible = true;
            ShowSave = false;
        }
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            bool opslaan = true;

            if ((string.IsNullOrWhiteSpace(tbHoofdlocatie.Text) || string.IsNullOrWhiteSpace(tbBedrijfsnaam.Text)))
            {
                opslaan = false;
                MessageBox.Show("Een of meer verplichte velden zijn leeg\nVul deze aan en probeer het opnieuw", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            string a = tbBedrijfsnaam.Text;

            for (int j = 0; j < lvBedrijven.Items.Count; j++)
            {
                string b = lvBedrijven.Items[j].Text;
                if (a == b)
                {
                    opslaan = false;
                    MessageBox.Show("Het gekozen bedrijf bestaat al\nProbeer a.u.b. een andere bedrijfnaam");
                    break;
                }
            }
            
            if (string.IsNullOrWhiteSpace(tbTelefoon.Text) && string.IsNullOrWhiteSpace(tbEadres.Text))
            {
                opslaan = false;
            }

            if (tbEadres.Text.Count() > 0)
            {
                if (validbedrijfemail == false)
                {
                    opslaan = false;
                }                
            }
            if (validtelefoon == false)
            {
                opslaan = false;
            }

            if (opslaan == true)
            {

                List<string> z = new List<string>();
                foreach (string line in tbKwaliteiten.Lines)
                {
                    z.Add(line);
                }
                Bedrijfcontact bedrijfcontact = new Bedrijfcontact() { Bedrijfnaam = tbBedrijfsnaam.Text, Contactpersoon = tbContact.Text, Email = tbEadres.Text, Hoofdlocatie = tbHoofdlocatie.Text, Telefoonnr = tbTelefoon.Text, Website = tbWebsite.Text, Kwaliteiten = z};
                BedrijfController bc = new BedrijfController();
                bc.voegBedrijfToe(bedrijfcontact);

                // Reset de listview
                vulContacten();


                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
                bedrijfPnl.Visible = false;
                btnZoeken.Visible = true;
                btnVoegtoe.Visible = true;
                btnWijzig.Visible = true;
                btnDelete.Visible = true;
                btnAnnuleer.Visible = false;
                btnOpslaan.Visible = false;
                lvBedrijven.Visible = true;
                ShowSave = false;
            }

        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            //Om te bewerken moet er minimaal en maximaal 1 contact geselecteerd zijn
            if (lvBedrijven.SelectedItems.Count == 1) 
            {
                string contactcode = lvBedrijven.SelectedItems[0].SubItems[2].Text;
                BedrijfController bc = new BedrijfController();
                Bedrijfcontact contact = bc.SelecteerBedrijf(Convert.ToInt32(contactcode));
                BedrijfBewerk bewerk = new BedrijfBewerk(contact, _gebruiker);
                bewerk.ShowDialog();

                // Refresh de listview
                vulContacten();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialoogResultaat = MessageBox.Show("Wilt u de geselecteerde contacten echt verwijderen?", "Verwijderen contacten", MessageBoxButtons.YesNo);
            if (dialoogResultaat == DialogResult.Yes)
            {
                if (lvBedrijven.SelectedItems.Count == 1)
                {
                    string contactcode = lvBedrijven.SelectedItems[0].SubItems[2].Text;
                    BedrijfController cc = new BedrijfController();
                    cc.verwijderBedrijf(Convert.ToInt32(contactcode));
                    vulContacten();
                }
                else if (lvBedrijven.SelectedItems.Count > 1)
                {
                    foreach (ListViewItem item in lvBedrijven.SelectedItems)
                    {
                        lvBedrijven.Items.Remove(item);
                        string contactcode = item.SubItems[2].Text;
                        BedrijfController cc = new BedrijfController();
                        cc.verwijderBedrijf(Convert.ToInt32(contactcode));
                    }
                }
            }

        }
        //
        // Alle overige events van de form
        //
        private void lvContacten_ItemActivate(object sender, EventArgs e)
        {
            string contactcode = lvBedrijven.SelectedItems[0].SubItems[2].Text;
            BedrijfController bc = new BedrijfController();
            Bedrijfcontact contact = bc.SelecteerBedrijf(Convert.ToInt32(contactcode));
            contact.Kwaliteiten = bc.Get_Kwaliteiten(_gebruiker, contact);
            BedrijfDetails details = new BedrijfDetails(_gebruiker, contact);
            details.ShowDialog();

        }

       
        private void ContactenForm_Load(object sender, EventArgs e)
        {
            vulContacten();
        }
        

        private void tbEadres_Leave(object sender, EventArgs e)
        {
            // Controleert of er een geldig email adres in ingevult
            if (tbEadres.Text.Count() > 0)
            {
                try
                {
                    var eMailValidator = new MailAddress(tbEadres.Text);

                }
                catch (FormatException)
                {
                    tbEadres.ForeColor = Color.Red;
                    validbedrijfemail = false;
                }
            }
        }

        private void tbEadres_Enter(object sender, EventArgs e)
        {
            tbEadres.ForeColor = Color.Black;
            validbedrijfemail = true;
        }

        private void tbTelefoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Er mag alleen getallen worden ingevoerd
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTelefoon_Enter(object sender, EventArgs e)
        {
            tbTelefoon.ForeColor = Color.Black;
            validtelefoon = false;
        }

        private void tbTelefoon_Leave(object sender, EventArgs e)
        {
            // Controleer of er een geldig telefoonnummer is ingevult
            // of dat deze leeg is
            if(tbTelefoon.Text.Count() < 10 && tbTelefoon.Text.Count() > 0)
            {
                tbTelefoon.ForeColor = Color.Red;
                validtelefoon = false;
            }
            else
            {
                tbTelefoon.ForeColor = Color.Black;
                validtelefoon = true;
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (ShowZoeken == true)
                {
                    zoek();
                }
            }
        }

        private void tbWebsite_Leave(object sender, EventArgs e)
        {
            // Controleert met Regex of er een geldige website is ingevult
            string a = "";
            if (tbWebsite.Text.StartsWith("http"))
                a = tbWebsite.Text;
            else
                a = "http://" + tbWebsite.Text;

            Regex RgxUrl = new Regex(@"^http\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$");

            if (RgxUrl.IsMatch(a))
            {
                if (!tbWebsite.Text.StartsWith("www"))
                {
                    tbWebsite.Text = "www." + tbWebsite.Text;
                }
                tbWebsite.ForeColor = Color.Black;
                validwebsite = true;
            }
            else
            {
                validwebsite = false;
                tbWebsite.ForeColor = Color.Red;

            }
        }

        private void tbWebsite_Enter(object sender, EventArgs e)
        {
            tbWebsite.ForeColor = Color.Black;
            validwebsite = false;
        }
    }
}
