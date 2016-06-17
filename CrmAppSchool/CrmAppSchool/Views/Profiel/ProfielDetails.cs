using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrmAppSchool.Models;
using CrmAppSchool.Controllers;

namespace CrmAppSchool.Views.Profiel
{
    public partial class ProfielDetails : Form
    {

        private Models.Profiel profiel { get; set; }
        private Gebruiker gebruiker { get; set; }
        private ListViewColumnSorter lvwColumnSorter { get; set; }

        public ProfielDetails(Gebruiker _gebruiker, Models.Profiel _profiel)
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            lv_contacten.ListViewItemSorter = lvwColumnSorter;
            this.gebruiker = _gebruiker;
            profiel = _profiel;


            lbl_Voornaamwaarde.Text = profiel.Voornaam;
            lbl_Achternaamwaarde.Text = profiel.Achternaam;
            if (profiel.LocatieIsZichtbaar == false)
            {
                lbl_Locatiewaarde.Text = profiel.Locatie;
            }
            else
            {
                lbl_Locatiewaarde.Text = "*privé";
            }
            if (profiel.FunctieIsZichtbaar == false)
            {
                lbl_Functiewaarde.Text = profiel.Functie;
            }
            else
            {
                lbl_Functiewaarde.Text = "*privé";
            }
            lbl_Kwaliteitwaarde.Text = "-";
            if (profiel.KwaliteitIsZichtbaar == false)
            {
                if (profiel.KwaliteitenLijst != null)
                {
                    // Reset de txb en voer de kwaliteiten in
                    lbl_Kwaliteitwaarde.Text = "";
                    foreach (string kwaliteit in profiel.KwaliteitenLijst)
                    {
                        lbl_Kwaliteitwaarde.Text = lbl_Kwaliteitwaarde.Text + kwaliteit + Environment.NewLine;
                    }
                }
            }
            else
            {
                lbl_Kwaliteitwaarde.Text = "*privé";
            }

            ContactenController cc = new ContactenController();
            Gebruiker gebruiker = new Gebruiker();
            gebruiker.Gebruikersnaam = profiel.Gebruikersnaam;
            List<Persooncontact> list = cc.HaalContactenOp(gebruiker);
            foreach (Persooncontact a in list)
            {
                a.volnaam = a.Voornaam + " " + a.Achternaam;
                ListViewItem item = new ListViewItem(a.volnaam);
                if (a.Isgastdocent == true)
                {
                    item.SubItems.Add("Gastdocent");
                }
                else if (a.Isstagebegeleider == true)
                {
                    item.SubItems.Add("Stagebegeleider");
                }
                else
                {
                    item.SubItems.Add("Gastspreker");
                }
                item.SubItems.Add(a.Contactcode.ToString());
                lv_contacten.Items.Add(item);
            }
        }

        //
        // Alle overige events van de form
        //
        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lbl_Profielnaam.Text = profiel.Voornaam + " " + profiel.Achternaam;

        }

        private void lv_contacten_ItemActivate(object sender, EventArgs e)
        {
            string contactcode = lv_contacten.SelectedItems[0].SubItems[2].Text;
            ContactenController _controller = new ContactenController();
            Persooncontact contact = _controller.HaalInfoOp(contactcode);
            Contacten.ContactDetails _details = new Contacten.ContactDetails(gebruiker, contact);
            _details.ShowDialog();
            if (gebruiker.SoortGebruiker == "Admin")
            {

                lv_contacten.SelectedItems[0].Remove();
                ContactenController _controller2 = new ContactenController();
                Persooncontact contact2 = _controller2.HaalInfoOp(contactcode);
                if (contact2.Bedrijf != null)
                {
                    contact2.volnaam = contact2.Voornaam + " " + contact2.Achternaam;
                    ListViewItem a = new ListViewItem();

                    a.Text = contact2.volnaam;
                    string soort;
                    if (contact2.Isgastdocent == true)
                    {
                        soort = "Gastdocent";
                    }
                    else if (contact2.Isstagebegeleider == true)
                    {
                        soort = "Stagebegeleider";
                    }
                    else
                    {
                        soort = "Gastspreker";
                    }

                    a.SubItems.Add(soort);
                    a.SubItems.Add(contact2.Contactcode.ToString());
                    lv_contacten.Items.Add(a);

                    List<ListViewItem> sorteerlijst = new List<ListViewItem>();
                    int hoogste = 0;
                    foreach (ListViewItem b in lv_contacten.Items)
                    {
                        sorteerlijst.Add(b);
                        if (Int32.Parse(b.SubItems[2].Text) > hoogste)
                            hoogste = Int32.Parse(b.SubItems[2].Text);
                    }
                    lv_contacten.Items.Clear();
                    for (int i = 0; i <= hoogste; i++)
                    {
                        foreach (ListViewItem c in sorteerlijst)
                        {
                            if (Int32.Parse(c.SubItems[2].Text) == i)
                                lv_contacten.Items.Add(c);
                        }

                    }
                }
            }
        }

        private void lv_contacten_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lv_contacten.Sort();
        }
    }
}
