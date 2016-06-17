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
        public string contactcode { get; set; }

        public OpdrachtDetails(Models.Stageopdracht opdracht, Models.Gebruiker gebruiker, string bedrijfscode, string contactcode)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            this.bedrijfscode = bedrijfscode;
            this.contactcode = contactcode;
            lbOpdrachtBedrijf.Text = opdracht.Bedrijf.Bedrijfnaam;
            lbOpdrachtContact.Text = opdracht.Contact.Voornaam + " " + opdracht.Contact.Achternaam;
            lbOpdrachtnaam.Text = opdracht.Naam;
            lbOpdrachtOmschrijving.Text = opdracht.Omschrijving;
            lbOpdrachtStatus.Text = opdracht.Status;
            lbNaam.Text = opdracht.Naam;
        }

        //
        // Alle button_Click() events van de form
        //
        private void lbOpdrachtBedrijf_Click(object sender, EventArgs e)
        {
           
            Controllers.BedrijfController bc = new Controllers.BedrijfController();
            Models.Bedrijfcontact contact = bc.SelecteerBedrijf(Convert.ToInt32(bedrijfscode));
            contact.Kwaliteiten = bc.Get_Kwaliteiten(gebruiker, contact);
            Views.Bedrijven.BedrijfDetails details = new Views.Bedrijven.BedrijfDetails(gebruiker, contact);
            details.ShowDialog();
        }

        private void lbOpdrachtContact_Click(object sender, EventArgs e)
        {
            Controllers.ContactenController _controller = new Controllers.ContactenController();
            Models.Persooncontact contact = _controller.HaalInfoOp(contactcode);
            
            Contacten.ContactDetails _details = new Contacten.ContactDetails(gebruiker, contact);
            _details.ShowDialog();
        }
    }
}
