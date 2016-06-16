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

namespace CrmAppSchool.Views.Bedrijven
{
    public partial class ContactenForm : Form
    {
        public bool ShowMenu { get; set; }
        private bool ShowSave { get; set; }
        private bool ShowZoeken { get; set; }
        private bool EditMode { get; set; }
        private bool validemail { get; set; }
        private bool validmobiel { get; set; }
        public Gebruiker _gebruiker { get; set; }
        ContactenController cc = new ContactenController();
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
            if (ShowZoeken == true)
            {
                zoek();
            }
            else
            {
                ActiveerZoeken();
            }

        }
        public void zoek()
        {
            lvContacten.Items.Clear();
            string input = "%" + tbSearch.Text + "%";
            List<Persooncontact> resultaten = cc.ZoekContacten(input, _gebruiker);
            foreach (Persooncontact contact in resultaten)
            {
                ListViewItem lvi = new ListViewItem(contact.Voornaam);
                lvi.SubItems.Add(contact.Contactcode.ToString());
                lvContacten.Items.Add(lvi);
                if (contact.Isgastdocent == true)
                {
                    lvi.ImageKey = "GD";            // Stel de afbeelding in voor een gastdocent
                }
                else
                {
                    if (contact.Isstagebegeleider == true)
                    {
                        lvi.ImageKey = "SB";        // Stel de afbeelding in voor een stagebegeleider
                    }
                    else
                    {
                        lvi.ImageKey = "GS";        // Stel de afbeelding in voor een Gastspreker
                    }
                }


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

        private void toonContactenInvoer(object sender, EventArgs e)
        {
            // Toont de textboxes a.d.h.v. contactSoortCbx selectie
            string invoerKeuze = Convert.ToString(contactSoortCbx.SelectedItem);
            if (invoerKeuze == "Stagebegeleider")
            {
                persoonPnl.Visible = true;
                pnOptioneel.Visible = true;
            }
            else if (invoerKeuze == "Gastdocent")
            {
                pnOptioneel.Visible = true;
                persoonPnl.Visible = true;
            }
            else if (invoerKeuze == "Gastspreker")
            {
                pnOptioneel.Visible = true;
                persoonPnl.Visible = true;
            }
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            validmobiel = true;
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
                /*List<string> newCBlist = new List<string>();
                foreach (string a in bedrijfCbx.Items)
                {
                    if (!(newCBlist.Contains(a)))
                        newCBlist.Add(a);

                }
                foreach (string a in newCBlist)
                {
                    bedrijfCbx.Items.Add(a);
                }*/
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
            bool opslaan = false;
            if (contactSoortCbx.Text != "Bedrijf")
            {
                bool a = false;
                bool b = false;
                if ((tbVoornaam.Text.Count() <= 0 || tbAchternaam.Text.Count() <= 0 || tbEmail.Text.Count() <= 0 || bedrijfCbx.Text.Count() <= 0))
                {
                    a = false;
                    MessageBox.Show("Een of meer verplichte velden zijn leeg\nVul deze aan en probeer het opnieuw");
                }
                else
                {
                    a = true;
                }
                if (validemail == true && validmobiel == true)
                {
                    b = true;
                }
                else
                {
                    MessageBox.Show("Het ingevoerde emailadres of mobiel nr. is onjuist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (a == true && b == true)
                    opslaan = true;
            }
            
            if (opslaan == true)
            {
                if (contactSoortCbx.Text != "Bedrijf")
                {
                    Persooncontact persooncontact = new Persooncontact() { Voornaam = tbVoornaam.Text, Achternaam = tbAchternaam.Text, Functie = tbFunctie.Text, Afdeling = tbAfdeling.Text, Locatie = tbLocatie.Text, Email = tbEmail.Text, Mobielnr = tbMobiel.Text, Gebruiker = _gebruiker };
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
                    lvContacten.Clear();
                    vulContacten();
                }
                
                pnOptioneel.Visible = false;
                persoonPnl.Visible = false;
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
            if (lvContacten.SelectedItems.Count == 1) //Om te bewerken moet er minimaal en maximaal 1 contact geselecteerd zijn
            {
                string contactcode = lvContacten.SelectedItems[0].SubItems[2].Text;
                ContactenController cc = new ContactenController();
                Persooncontact contact = cc.HaalInfoOp(contactcode);
                ContactBewerk bewerk = new ContactBewerk(contact, _gebruiker);
                bewerk.ShowDialog();

                // Reset de listview
                lvContacten.Clear();
                vulContacten();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialoogResultaat = MessageBox.Show("Wilt u de geselecteerde contacten echt verwijderen?", "Verwijderen contacten", MessageBoxButtons.YesNo);
            if (dialoogResultaat == DialogResult.Yes)
            {
                if (lvContacten.SelectedItems.Count == 1)
                {
                    string contactcode = lvContacten.SelectedItems[0].SubItems[2].Text;
                    ContactenController cc = new ContactenController();
                    cc.verwijderContact(_gebruiker, contactcode);
                    lvContacten.Items.Remove(lvContacten.SelectedItems[0]);
                }
                else if (lvContacten.SelectedItems.Count > 1)
                {
                    foreach (ListViewItem item in lvContacten.SelectedItems)
                    {
                        lvContacten.Items.Remove(item);
                        string contactcode = item.SubItems[2].Text;
                        ContactenController cc = new ContactenController();
                        cc.verwijderContact(_gebruiker, contactcode);
                    }
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
            string contactcode = lvContacten.SelectedItems[0].SubItems[2].Text;
            ContactenController _controller = new ContactenController();
            Persooncontact contact = _controller.HaalInfoOp(contactcode);
            Contacten.ContactDetails _details = new Contacten.ContactDetails(_gebruiker, contact);
            _details.ShowDialog();
        }

        private void vulContacten()
        {           
            settooltips();
            //lvContacten.Clear();
            ContactenController _getcontacten = new ContactenController();
            List<Persooncontact> contactenlijst = _getcontacten.HaalContactenOp(_gebruiker);
            foreach (Persooncontact contact in contactenlijst)
            {
                ListViewItem c = new ListViewItem(contact.Voornaam + " " + contact.Achternaam);
                c.SubItems.Add(contact.Achternaam);
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
        private void ContactenForm_Load(object sender, EventArgs e) //
        {
            vulContacten();

        }
        private void settooltips()
        {
            ToolTip TP = new ToolTip();
            TP.ShowAlways = true;
            TP.SetToolTip(tbEmail, "Voer een geldig email adres in.\nExample: harry@hotmail.com");
            ToolTip TP1 = new ToolTip();
            TP1.ShowAlways = true;
            TP1.SetToolTip(tbMobiel, "Voer een geldig mobiel nummer in.\nExample: 0612345678");
            ToolTip TPnieuw = new ToolTip();
            TPnieuw.ShowAlways = false;
            TPnieuw.SetToolTip(btnVoegtoe, "Voeg een nieuw contact toe");
            ToolTip TPbewerk = new ToolTip();
            TPbewerk.ShowAlways = false;
            TPbewerk.SetToolTip(btnWijzig, "Bewerk het geselecteerde contact");
            ToolTip TPdelete = new ToolTip();
            TPdelete.ShowAlways = false;
            TPdelete.SetToolTip(btnDelete, "Verwijder het geselecteerde contact");
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
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text.Count() > 0)
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(tbEmail.Text);
                }
                catch (FormatException ex)
                {
                    // wrong e-mail address
                    tbEmail.ForeColor = Color.Red;
                    validemail = false;
                    Console.WriteLine(ex);
                }
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            tbEmail.ForeColor = Color.Black;
            validemail = true;
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
            validmobiel = true;
        }

        private void tbMobiel_Leave(object sender, EventArgs e)
        {
            if (tbMobiel.Text.Count() < 10 && tbMobiel.Text.Count() > 0)
            {
                tbMobiel.ForeColor = Color.Red;
                validmobiel = false;
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
    }
}
