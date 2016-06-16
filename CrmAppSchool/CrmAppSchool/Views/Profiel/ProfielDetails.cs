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

namespace CrmAppSchool.Views.Profiel
{
    public partial class ProfielDetails : Form
    {

        private Models.Profiel profiel { get; set; }

        public ProfielDetails(Gebruiker _gebruiker, Models.Profiel _profiel)
        {
            InitializeComponent();
            profiel = _profiel;


            lbl_Voornaamwaarde.Text = profiel.Voornaam;
            lbl_Achternaamwaarde.Text = profiel.Achternaam;
            if (profiel.LocatieIsZichtbaar == false)
            {
                lbl_Locatiewaarde.Text = profiel.Locatie;
            }
            else
            {
                lbl_Locatiewaarde.Text = "*privé";
            }
            if (profiel.FunctieIsZichtbaar == false)
            {
                lbl_Functiewaarde.Text = profiel.Functie;
            }
            else
            {
                lbl_Functiewaarde.Text = "*privé";
            }
            lbl_Kwaliteitwaarde.Text = "-";
            if (profiel.KwaliteitIsZichtbaar == false)
            {
                if (profiel.KwaliteitenLijst != null)
                {
                    // Reset de txb en voer de kwaliteiten in
                    lbl_Kwaliteitwaarde.Text = "";
                    foreach (string kwaliteit in profiel.KwaliteitenLijst)
                    {
                        lbl_Kwaliteitwaarde.Text = lbl_Kwaliteitwaarde.Text + kwaliteit + Environment.NewLine;
                    }
                }
            }
            else
            {
                lbl_Kwaliteitwaarde.Text = "*privé";
            }
            /*BedrijfController cc = new BedrijfController();
            List<string> kwalteitenlijst = cc.Get_Kwaliteiten(_gebruiker, contact);
            if (kwalteitenlijst != null)
            {
                lbl_Kwaliteitwaarde.Text = "";
                int j = 0;
                foreach (string a in kwalteitenlijst)
                {
                    if (j == 0)
                        lbl_Kwaliteitwaarde.Text = a;
                    else
                        lbl_Kwaliteitwaarde.Text = lbl_Kwaliteitwaarde.Text + "\n" + a;

                    j++;
                }
            }*/

        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lbl_Profielnaam.Text = profiel.Voornaam + " " + profiel.Achternaam;

        }
    }
}
