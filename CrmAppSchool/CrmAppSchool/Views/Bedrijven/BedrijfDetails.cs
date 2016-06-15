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
    }
}
