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

        public BedrijfDetails(Gebruiker _gebruiker, Bedrijfcontact _contact)
        {
            InitializeComponent();
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
        }
    }
}
