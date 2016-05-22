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

namespace CrmAppSchool.Views.Hoofdmenu
{
    public partial class HoofdmenuForm : Form
    {
        public Gebruiker gebruiker;
        public HoofdmenuForm(Gebruiker _gebruiker)
        {
            gebruiker = _gebruiker;
            InitializeComponent();
            toonGebruikersnaam();
        }

        private void toonGebruikersnaam()
        {
            if(gebruiker is Admin)
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
            else if(gebruiker is Student)
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
            else if(gebruiker is Docent)
            {
                gebruikerLbl.Text = gebruikerLbl.Text + " " + gebruiker.Gebruikersnaam;
            }
        }

        private void voegGebruikerToeBtn_Click(object sender, EventArgs e)
        {
            voegGebruikerToeForm voegGebruikerToe = new voegGebruikerToeForm();
            voegGebruikerToe.ShowDialog();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            Zoeken.ZoekenForm Zoeken= new Zoeken.ZoekenForm();
            Zoeken.Show();
        }
    }
}
