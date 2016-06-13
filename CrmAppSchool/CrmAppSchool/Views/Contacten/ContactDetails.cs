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

namespace CrmAppSchool.Views.Contacten
{
    public partial class ContactDetails : Form
    {
        
        private Persooncontact contact { get; set; }

        public ContactDetails(Persooncontact _contact)
        {
            InitializeComponent();
            contact = _contact;

            lblVNvalue.Text = contact.Voornaam;
            lblANvalue.Text = contact.Achternaam;
            lblLOvalue.Text = contact.Locatie;
            llbMValue.Text = contact.Email;
            lblMOvalue.Text = contact.Mobielnr;
            if(contact.Functie != null)
            {
                lblFUvalue.Text = contact.Functie;
            }
            lblBDvalue.Text = contact.Bedrijf.Bedrijfnaam;
        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lblContactnaam.Text = contact.Voornaam + " " + contact.Achternaam;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + llbMValue.Text);
        }
    }
}
