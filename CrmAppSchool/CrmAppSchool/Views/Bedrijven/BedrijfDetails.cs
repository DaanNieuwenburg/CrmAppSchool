using System;
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

namespace CrmAppSchool.Views.Bedrijven
{
    public partial class BedrijfDetails : Form
    {
        
        private Bedrijfcontact contact { get; set; }
        private Gebruiker gebruiker { get; set; }
        private ListViewColumnSorter lvwColumnSorter { get; set; }

        public BedrijfDetails(Gebruiker _gebruiker, Bedrijfcontact _contact)
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.lv_contacten.ListViewItemSorter = lvwColumnSorter;
            contact = _contact;
            this.gebruiker = _gebruiker;

            
            lblBNvalue.Text = contact.Bedrijfnaam;
            lblHLvalue.Text = contact.Hoofdlocatie;
            llbEValue.Text = contact.Email;
            lblTvalue.Text = contact.Telefoonnr;
            lblCPvalue.Text = contact.Contactpersoon;
            llbWSvalue.Text = contact.Website;
            BedrijfController cc = new BedrijfController();
            List<string> kwalteitenlijst = cc.Get_Kwaliteiten(_gebruiker, contact);
            if (kwalteitenlijst != null)
            {
                lblKWvalue.Text = "";
                int j = 0;
                foreach (string a in kwalteitenlijst)
                {
                    if (j == 0)
                        lblKWvalue.Text = a;
                    else
                        lblKWvalue.Text = lblKWvalue.Text + "\n" + a;

                    j++;
                }
            }

            ContactenController cc2 = new ContactenController();
            List<Persooncontact> list = cc2.ContactenBijBedrijf(_contact, true);
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

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lblContactnaam.Text = contact.Bedrijfnaam;
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + llbEValue.Text);
        }

        private void llbWSvalue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(llbWSvalue.Text);
            }
            catch(Win32Exception ex)
            {
                if ((uint)ex.ErrorCode == 0x80004005)
                {
                    MessageBox.Show("Deze website kan helaas niet geopend worden");
                }
            }
        }

        private void lv_contacten_ItemActivate(object sender, EventArgs e)
        {
            string contactcode = lv_contacten.SelectedItems[0].SubItems[2].Text;
            ContactenController _controller = new ContactenController();
            Persooncontact contact = _controller.HaalInfoOp(contactcode);
            CrmAppSchool.Views.Contacten.ContactDetails _details = new CrmAppSchool.Views.Contacten.ContactDetails(gebruiker, contact);
            _details.ShowDialog();

            if (gebruiker.SoortGebruiker == "Admin")
            {
                int code = contact.Bedrijf.Bedrijfscode;
                lv_contacten.SelectedItems[0].Remove();
                ContactenController _controller2 = new ContactenController();
                Persooncontact contact2 = _controller2.HaalInfoOp(contactcode);
                if (contact2.Bedrijf.Bedrijfscode == code)
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
