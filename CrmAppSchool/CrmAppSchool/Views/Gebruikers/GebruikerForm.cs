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
using CrmAppSchool.Views.Gebruikers;

namespace CrmAppSchool.Views.Gebruikers
{
    public partial class voegGebruikerToeForm : Form
    {
        public bool ShowMenu { get; set; }
        public bool tweedeSelectie { get; set; }

        private ListViewColumnSorter lvwColumnSorter { get; set; }
        private Gebruiker gebruiker { get; set; }

        public voegGebruikerToeForm(Gebruiker _gebruiker)
        {


            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.gebruikerLvw.ListViewItemSorter = lvwColumnSorter;
            tweedeSelectie = false;
            gebruiker = _gebruiker;
            ShowMenu = false;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            vulListView();
        }

        private void vulListView()
        {
            // Deze methode vult het listview met alle gebruikers van het systeem
            GebruikerController gebruikercontroller = new GebruikerController();
            List<Gebruiker> gebruikersLijst = gebruikercontroller.haalGebruikersOp();

            // Zet alle gebruikers in de lijst
            foreach (Models.Gebruiker gebruiker in gebruikersLijst)
            {
                ListViewItem lvw = new ListViewItem(gebruiker.Gebruikersnaam);
                // Bepaal het soort gebruiker
                if (gebruiker.SoortGebruiker == "Admin")
                {
                    lvw.SubItems.Add("Admin");
                }
                else if (gebruiker.SoortGebruiker == "Docent")
                {
                    lvw.SubItems.Add("Docent");
                }
                else if (gebruiker.SoortGebruiker == "Student")
                {
                    lvw.SubItems.Add("Student");
                }

                // Voegt gegevens aan listview toe
                gebruikerLvw.Items.Add(lvw);
            }
        }

        private void voegToeBtn_Click(object sender, EventArgs e)
        {
            // valideert of alle gegevens zijn en ingevuld, zo ja roept de controller aan

            if (Convert.ToString(soortGebruikerCbx.SelectedItem) == "")
            {
                MessageBox.Show("Voer a.u.b.alle informatie in", "Error");
            }
            else if (soortGebruikerCbx.Text == "Student" && (gebruikersnaamTxb.Text == "" || wachtwoordTxb.Text == ""))
            {
                MessageBox.Show("Voer a.u.b.alle informatie in", "Error");
            }
            else if (soortGebruikerCbx.Text == "Docent" && (gebruikersnaamTxb.Text == "" || wachtwoordTxb.Text == "" || tb_voornaam.Text == "" || tb_achternaam.Text == ""))
            {
                MessageBox.Show("Voer a.u.b.alle informatie in", "Error");
            }
            else
            {
                Gebruiker gebruiker = new Gebruiker() { Gebruikersnaam = gebruikersnaamTxb.Text, Wachtwoord = wachtwoordTxb.Text, SoortGebruiker = soortGebruikerCbx.Text };
                GebruikerController gebruikercontroller = new GebruikerController();
                gebruikercontroller.voegGebruikerToe(gebruiker);
                if (gebruiker.SoortGebruiker == "Admin" || gebruiker.SoortGebruiker == "Docent")
                {
                    ProfielController profielcontroller = new ProfielController();
                    profielcontroller.voegProfielToe(gebruiker.Gebruikersnaam, tb_voornaam.Text, tb_achternaam.Text);
                }

                // Reset de textboxxes
                gebruikersnaamTxb.Text = "";
                wachtwoordTxb.Text = "";
                soortGebruikerCbx.Text = "";
                tb_achternaam.Text = "";
                tb_voornaam.Text = "";
                tb_achternaam.Visible = true;
                tb_voornaam.Visible = true;
                label1.Visible = true;
                label2.Visible = true;

                // Reset de listview
                gebruikerLvw.Items.Clear();
                vulListView();
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();

        }
        private void voegGebruikerToeForm_Load(object sender, EventArgs e)
        {
        }

        private void gebruikerLvw_ItemActivate(object sender, EventArgs e)
        {
            Gebruiker nieuweGebruiker = null;
            // Bepaal gebruiker
            if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Admin")
            {
                nieuweGebruiker = new Gebruiker() { Gebruikersnaam = gebruikerLvw.SelectedItems[0].Text };
                nieuweGebruiker.SoortGebruiker = "Admin";
            }
            else if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Docent")
            {
                nieuweGebruiker = new Gebruiker() { Gebruikersnaam = gebruikerLvw.SelectedItems[0].Text };
            }
            else if (gebruikerLvw.SelectedItems[0].SubItems[1].Text == "Student")
            {
                nieuweGebruiker = new Gebruiker() { Gebruikersnaam = gebruikerLvw.SelectedItems[0].Text };
            }

            // Open bewerk gebruiker form
            BewerkGebruikerForm bewerkgebruikerform = new BewerkGebruikerForm(nieuweGebruiker);
            bewerkgebruikerform.ShowDialog();

            // Reset de listview
            gebruikerLvw.Items.Clear();
            vulListView();
        }

        private void soortGebruikerCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soortGebruikerCbx.Text == "Student")
            {
                label1.Visible = false;
                label2.Visible = false;
                tb_voornaam.Text = "";
                tb_achternaam.Text = "";
                tb_achternaam.Visible = false;
                tb_voornaam.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                tb_achternaam.Visible = true;
                tb_voornaam.Visible = true;
            }
        }

        private void gebruikerLvw_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.gebruikerLvw.Sort();
        }
    }
}

