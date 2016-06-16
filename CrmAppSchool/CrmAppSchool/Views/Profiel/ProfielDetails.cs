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
        private Gebruiker gebruiker { get; set; }

        public ProfielDetails(Gebruiker _gebruiker, Models.Profiel _profiel)
        {
            InitializeComponent();
            this.gebruiker = _gebruiker;
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

            ContactenController cc = new ContactenController();
            Gebruiker gebruiker = new Gebruiker();
            gebruiker.Gebruikersnaam = profiel.Gebruikersnaam;
            List<Persooncontact> list = cc.HaalContactenOp(gebruiker);
            foreach(Persooncontact a in list)
            {
                a.volnaam = a.Voornaam + " " + a.Achternaam;
                ListViewItem item = new ListViewItem(a.volnaam);
                if (a.Isgastdocent == true)
                {
                    item.SubItems.Add("Gastdocent");
                }
                else if (a.Isstagebegeleider == true)
                {
                    item.SubItems.Add("Stagebegeleider");
                }
                else
                {
                    item.SubItems.Add("Gastspreker");
                }
                item.SubItems.Add(a.Contactcode.ToString());
                lv_contacten.Items.Add(item);
            }
        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            lbl_Profielnaam.Text = profiel.Voornaam + " " + profiel.Achternaam;

        }

        private void lv_contacten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_contacten_ItemActivate(object sender, EventArgs e)
        {
            string contactcode = lv_contacten.SelectedItems[0].SubItems[2].Text;
            ContactenController _controller = new ContactenController();
            Persooncontact contact = _controller.HaalInfoOp(contactcode);
            CrmAppSchool.Views.Contacten.ContactDetails _details = new CrmAppSchool.Views.Contacten.ContactDetails(gebruiker, contact);
            _details.ShowDialog();
        }
    }
}
