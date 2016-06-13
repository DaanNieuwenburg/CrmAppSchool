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
        private int beoordeling { get; set; }

        public ContactDetails(Persooncontact _contact)
        {
            InitializeComponent();
            contact = _contact;
            beoordeling = 0; // HIER MOET DIE HEM OVERSCHIJVEN MET VALUE UIT DB
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
            setSterren();
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + llbMValue.Text);
        }
        private void setSterren()
        {
            if (beoordeling == 0)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if (beoordeling == 1)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if(beoordeling == 2)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if (beoordeling == 3)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else if (beoordeling == 4)
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            }
            else
            {
                pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
                pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            }
        }
        private void pbRate2_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }


        private void pbRate3_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }

        private void pbRate4_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }

        private void pbRate5_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
        }

        private void pbRate1_MouseEnter(object sender, EventArgs e)
        {
            pbRate1.BackgroundImage = Properties.Resources.Afbeelding_Ster_vol;
            pbRate2.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate3.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate4.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
            pbRate5.BackgroundImage = Properties.Resources.Afbeelding_Ster_leeg1;
        }

        private void pbRate1_Click(object sender, EventArgs e)
        {
            beoordeling = 1;
            setSterren();
        }

        private void pbRate2_Click(object sender, EventArgs e)
        {
            beoordeling = 2;
            setSterren();
        }

        private void pbRate3_Click(object sender, EventArgs e)
        {
            beoordeling = 3;
            setSterren();
        }

        private void pbRate4_Click(object sender, EventArgs e)
        {
            beoordeling = 4;
            setSterren();
        }

        private void pbRate5_Click(object sender, EventArgs e)
        {
            beoordeling = 5;
            setSterren();
        }

        private void pbRating_MouseLeave(object sender, EventArgs e)
        {
            setSterren();
        }
    }
}
