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
    public partial class ContactBewerk : Form
    {
        public ContactBewerk(Persooncontact contact)
        {
            InitializeComponent();
            voornaamTb.Text = contact.Voornaam;
            achternaamTb.Text = contact.Achternaam;
            bedrijfTb.Text = contact.Bedrijf.Bedrijfnaam;
            functieTb.Text = contact.Functie;
            locatieTb.Text = contact.Locatie;
            emailTb.Text = contact.Email;
        }

        private void bewerkBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
