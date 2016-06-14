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
        public OpdrachtDetails(Models.Stageopdracht opdracht)
        {
            InitializeComponent();
            lbOpdrachtBedrijf.Text = opdracht.Bedrijf.Bedrijfnaam;
            lbOpdrachtContact.Text = opdracht.Contact.Voornaam + " " + opdracht.Contact.Achternaam;
            lbOpdrachtnaam.Text = opdracht.Naam;
            lbOpdrachtOmschrijving.Text = opdracht.Omschrijving;
            lbOpdrachtStatus.Text = opdracht.Status;
        }

        private void OpdrachtDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
