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

        public BedrijfDetails(Gebruiker _gebruiker, Bedrijfcontact _contact)
        {
            InitializeComponent();
            contact = _contact;

            
            lblBNvalue.Text = contact.Bedrijfnaam;
            lblHLvalue.Text = contact.Hoofdlocatie;
            llbEValue.Text = contact.Email;
            lblTvalue.Text = contact.Telefoonnr;
            lblCPvalue.Text = contact.Contactpersoon;
            lblWSvalue.Text = contact.Website;
            
        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lblContactnaam.Text = contact.Bedrijfnaam;
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + llbEValue.Text);
        }      
    }
}
