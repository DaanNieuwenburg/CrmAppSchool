using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmAppSchool.Views.Opdrachten
{
    public partial class OpdrachtDetails : Form
    {
        public Models.Gebruiker gebruiker { get; set; }
        public string bedrijfscode { get; set; }

        public OpdrachtDetails(Models.Stageopdracht opdracht, Models.Gebruiker gebruiker, string bedrijfscode)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            this.bedrijfscode = bedrijfscode;
            lbOpdrachtBedrijf.Text = opdracht.Bedrijf.Bedrijfnaam;
            lbOpdrachtContact.Text = opdracht.Contact.Voornaam + " " + opdracht.Contact.Achternaam;
            lbOpdrachtnaam.Text = opdracht.Naam;
            lbOpdrachtOmschrijving.Text = opdracht.Omschrijving;
            lbOpdrachtStatus.Text = opdracht.Status;
            lbNaam.Text = opdracht.Naam;
        }

        private void OpdrachtDetails_Load(object sender, EventArgs e)
        {
        }

        private void lbOpdrachtBedrijf_Click(object sender, EventArgs e)
        {
            //Bedrijven.BedrijfDetails details = new Bedrijven.BedrijfDetails(gebruiker,bedrijfscode);

            Controllers.BedrijfController bc = new Controllers.BedrijfController();
            Models.Bedrijfcontact contact = bc.SelecteerBedrijf(Convert.ToInt32(bedrijfscode));
            contact.Kwaliteiten = bc.Get_Kwaliteiten(gebruiker, contact);
            Views.Bedrijven.BedrijfDetails details = new Views.Bedrijven.BedrijfDetails(gebruiker, contact);
            details.ShowDialog();
        }
    }
}
