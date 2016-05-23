using CrmAppSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmAppSchool.Views.Profiel
{
    public partial class MijnprofielForm : Form
    {
        private Gebruiker gebruiker { get; set; }
        public MijnprofielForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            gebruiker = _gebruiker;
            lblGebruikerWaarde.Text = gebruiker.Gebruikersnaam;
            lblWachtwoordWaarde.Text = gebruiker.Wachtwoord;
        }
    }
}
