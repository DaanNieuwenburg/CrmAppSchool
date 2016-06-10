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
using System.Net.Mail;

namespace CrmAppSchool.Views.Contacten
{
    public partial class ContactenForm : Form
    {
        public bool ShowMenu { get; set; }
        private bool ShowSave { get; set; }
        private bool ShowZoeken { get; set; }
        private bool EditMode { get; set; }
        public Gebruiker _gebruiker { get; set; }
        public ContactenForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            var imagelist = new ImageList();
            imagelist.Images.Add("GS", Properties.Resources.Afbeelding_ContactPersoon_GastSpreker);
            imagelist.Images.Add("GD", Properties.Resources.Afbeelding_ContactPersoon_GastDocent);
            imagelist.Images.Add("BD", Properties.Resources.Afbeelding_ContactPersoon_Bedrijf);
            imagelist.Images.Add("SB", Properties.Resources.Afbeelding_ContactPersoon_StageBegeleider);
            imagelist.ImageSize = new Size(50, 50);
            lvContacten.LargeImageList = imagelist;
            ShowMenu = false;
            ShowZoeken = false;
            ShowSave = false;
            EditMode = false;
            this._gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + this._gebruiker.Gebruikersnaam;

            // Vul de combobox van bedrijven met bedrijven
            BedrijfController bc = new BedrijfController();
            bedrijfCbx.DataSource = bc.haalBedrijfLijstOp();
            bedrijfCbx.DisplayMember = "Bedrijfnaam";
            bedrijfCbx.ValueMember = "Bedrijfscode";
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            Close();
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

        private void toonContactenInvoer(object sender, EventArgs e)
        {
            // Toont de textboxes a.d.h.v. contactSoortCbx selectie
            string invoerKeuze = Convert.ToString(contactSoortCbx.SelectedItem);
            if (invoerKeuze == "Bedrijf")
            {
                persoonPnl.Visible = false;
                pnOptioneel.Visible = false;
                pnbedrijf2.Visible = true;
                bedrijfPnl.Visible = true;
            }
            else if (invoerKeuze == "Stagebegeleider")
            {
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
                pnOptioneel.Visible = true;
                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
            }
            else if (invoerKeuze == "Gastdocent")
            {
                bedrijfPnl.Visible = false;
                pnOptioneel.Visible = true;
                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
            }
            else if (invoerKeuze == "Gastspreker")
            {
                bedrijfPnl.Visible = false;
                pnOptioneel.Visible = true;
                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
                persoonPnl.Visible = true;
            }
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {

            if (ShowSave == false)
            {
                lvContacten.Visible = false;
                lblSoort.Visible = true;
                btnVoegtoe.Visible = false;
                btnAnnuleer.Visible = true;
                btnZoeken.Visible = false;
                btnOpslaan.Visible = true;
                contactSoortCbx.Visible = true;
                btnWijzig.Visible = false;
                btnDelete.Visible = false;
                Makeempty();
                ShowSave = true;
            }
            else
            {
                btnVoegtoe.Visible = true;
                btnAnnuleer.Visible = false;
                btnOpslaan.Visible = false;
                btnZoeken.Visible = true;
                contactSoortCbx.Visible = false;
                btnWijzig.Visible = true;
                btnDelete.Visible = true;
                ShowSave = false;
            }
        }
        private void SaveContact(Persooncontact persoon)
        {
            ListViewItem contact = new ListViewItem(persoon.Voornaam);
            contact.SubItems.Add(persoon.Achternaam);
            lvContacten.Items.Add(contact);
            if (contactSoortCbx.Text == "Gastspreker")
            {
                contact.ImageKey = "GS";
            }               
            else if (contactSoortCbx.Text == "Gastdocent")
            {
                contact.ImageKey = "GD";
            }              
            else if (contactSoortCbx.Text == "Stagebegeleider")
            {
                contact.ImageKey = "SB";
            }

        }
        private void SaveBedrijf(Bedrijfcontact bedrijf)
        {
            ListViewItem Company = new ListViewItem(bedrijf.Bedrijfnaam);
            lvContacten.Items.Add(Company);
            Company.ImageKey = "BD";
        }
        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            btnZoeken.Visible = true;
            btnVoegtoe.Visible = true;
            btnWijzig.Visible = true;
            btnDelete.Visible = true;
            btnAnnuleer.Visible = false;
            btnOpslaan.Visible = false;
            contactSoortCbx.Visible = false;
            persoonPnl.Visible = false;
            pnOptioneel.Visible = false;
            lblSoort.Visible = false;
            lvContacten.Visible = true;
            ShowSave = false;
        }
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if(contactSoortCbx.Text != "Bedrijf" && (tbVoornaam.Text.Count() <= 0 || tbAchternaam.Text.Count() <= 0 || tbEmail.Text.Count() <= 0|| bedrijfCbx.Text.Count() <= 0))
            {
                MessageBox.Show("Een of meer verplichte velden zijn leeg\nVul deze aan en probeer het opnieuw");
            }
            else if(contactSoortCbx.Text == "Bedrijf" && (tbHoofdlocatie.Text.Count() <= 0 || tbBedrijfsnaam.Text.Count() <= 0) || (tbEadres.Text.Count() <= 0 && tbTelefoon.Text.Count() <= 0))
            {
                MessageBox.Show("Een of meer verplichte velden zijn leeg\nVul deze aan en probeer het opnieuw");
            }
            else
            {
                if (contactSoortCbx.Text != "Bedrijf")
                {
                    Persooncontact persooncontact = new Persooncontact() { Voornaam = tbVoornaam.Text, Achternaam = tbAchternaam.Text, Functie = tbFunctie.Text, Afdeling = tbAfdeling.Text, Locatie = tbLocatie.Text, Email = tbEmail.Text, Gebruiker = _gebruiker };
                    string contactSoort = Convert.ToString(contactSoortCbx.SelectedItem);
                    Console.WriteLine(tbFunctie.Text);
                    int bedrijfcode = Convert.ToInt32(bedrijfCbx.SelectedValue);
                    persooncontact.Bedrijf = new Bedrijfcontact() { Bedrijfscode = bedrijfcode };

                    // Haal kwaliteiten op
                    string[] kwaliteiten = new string[tbKwaliteitenP.Lines.Count()];
                    int i = 0;
                    foreach (string line in tbKwaliteitenP.Lines)
                    {
                        kwaliteiten[i] = line;
                        i++;
                    }
                    persooncontact.Kwaliteiten = kwaliteiten;

                    switch (contactSoort)
                    {
                        case "Stagebegeleider":
                            persooncontact.Isstagebegeleider = true;
                            break;
                        case "Gastdocent":
                            persooncontact.Isgastdocent = true;
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                    ContactenController contactencontroller = new ContactenController();
                    contactencontroller.controleerOfContactBestaat(_gebruiker, persooncontact);
                    SaveContact(persooncontact);
                }
                else
                {
                    string[] a = new string[tbKwaliteiten.Lines.Count()];
                    int i = 0;
                    foreach (string line in tbKwaliteiten.Lines)
                    {
                        a[i] = line;
                        i++;
                    }
                    Bedrijfcontact bedrijfcontact = new Bedrijfcontact() { Bedrijfnaam = tbBedrijfsnaam.Text, Contactpersoon = tbContact.Text, Email = tbEadres.Text, Hoofdlocatie = tbHoofdlocatie.Text, Telefoonnr = tbTelefoon.Text, Website = tbWebsite.Text, Kwaliteiten = a };
                    BedrijfController bc = new BedrijfController();
                    bc.voegBedrijfToe(bedrijfcontact);
                    SaveBedrijf(bedrijfcontact);
                }

                pnOptioneel.Visible = false;
                persoonPnl.Visible = false;
                pnbedrijf2.Visible = false;
                bedrijfPnl.Visible = false;
                bedrijfPnl.Visible = false;
                btnZoeken.Visible = true;
                lblSoort.Visible = false;
                btnVoegtoe.Visible = true;
                btnWijzig.Visible = true;
                btnDelete.Visible = true;
                btnAnnuleer.Visible = false;
                btnOpslaan.Visible = false;
                contactSoortCbx.Visible = false;
                lvContacten.Visible = true;
                ShowSave = false;
            }
            
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            if(lvContacten.SelectedItems.Count == 1) //Om te bewerken moet er minimaal en maximaal 1 contact geselecteerd zijn
            {
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvContacten.SelectedItems.Count == 1)
            {
                Console.WriteLine("HOIII1");
                string contactcode = lvContacten.SelectedItems[0].SubItems[1].Text;
                ContactenController cc = new ContactenController();
                cc.verwijderContact(_gebruiker, contactcode);
                lvContacten.Items.Remove(lvContacten.SelectedItems[0]);
            }
            else if (lvContacten.SelectedItems.Count > 1)
            {
                foreach (ListViewItem item in lvContacten.SelectedItems)
                {
                    lvContacten.Items.Remove(item);
                    Console.WriteLine("HOIII2");
                }
            }
        }

        private void Makeempty()
        {
            contactSoortCbx.Text = "";
            tbVoornaam.Text = "";
            tbAchternaam.Text = "";
            tbEmail.Text = "";
            tbFunctie.Text = "";
            tbLocatie.Text = "";
            tbMobiel.Text = "";
            tbKwaliteitenP.Text = "";

        }


        private void lvContacten_ItemActivate(object sender, EventArgs e)
        {
            string contactcode = lvContacten.SelectedItems[0].SubItems[1].Text;
            ContactenController _controller = new ContactenController();
            
            Persooncontact contact = _controller.HaalInfoOp(contactcode);
            ContactDetails _details = new ContactDetails(contact);
            _details.ShowDialog();
        }

        private void ContactenForm_Load(object sender, EventArgs e)
        {
            settooltips();
            ContactenController _getcontacten = new ContactenController();
            List<Persooncontact> contactenlijst = _getcontacten.HaalContactenOp(_gebruiker);
            foreach(Persooncontact contact in contactenlijst)
            {
                ListViewItem c = new ListViewItem(contact.Voornaam + contact.Achternaam);
                c.SubItems.Add(Convert.ToString(contact.Contactcode));
                if (contact.Isstagebegeleider == true)
                {
                    c.ImageKey = "SB";
                }
                else
            {
                    c.ImageKey = "GD";
                }
                lvContacten.Items.Add(c);
            }
        }
        private void settooltips()
        {
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(tbEmail, "Voer een geldig email adres in.\nExample: harry@hotmail.com");
            ToolTip TP1 = new ToolTip();
            TP1.ShowAlways = true;
            TP1.SetToolTip(tbMobiel, "Voer een geldig mobiel nummer in.\nExample: 0612345678");
        }
        private void tbMobiel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbVoornaam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if(tbEmail.Text.Count() > 0)
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(tbEmail.Text);
                }
                catch (FormatException ex)
                {
                    // wrong e-mail address
                    tbEmail.ForeColor = Color.Red;
                }
            }       
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            tbEmail.ForeColor = Color.Black;
        }
        private void tbEadres_Leave(object sender, EventArgs e)
        {
            if (tbEadres.Text.Count() > 0)
            {
                try
                {
                    var eMailValidator = new MailAddress(tbEadres.Text);
                }
                catch (FormatException ex)
                {
                    // wrong e-mail address
                    tbEadres.ForeColor = Color.Red;
                }
            }
        }

        private void tbEadres_Enter(object sender, EventArgs e)
        {
            tbEadres.ForeColor = Color.Black;
        }

        private void tbTelefoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMobiel_Enter(object sender, EventArgs e)
        {
            tbMobiel.ForeColor = Color.Black;
        }

        private void tbMobiel_Leave(object sender, EventArgs e)
        {
            if(tbMobiel.Text.Count() < 10)
                tbMobiel.ForeColor = Color.Red;
        }
    }
}
