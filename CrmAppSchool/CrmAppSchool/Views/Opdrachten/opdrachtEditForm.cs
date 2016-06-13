using CrmAppSchool.Controllers;
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

namespace CrmAppSchool.Views.Opdrachten
{
    public partial class opdrachtEditForm : Form
    {
        Stageopdracht opdracht = new Stageopdracht();
        StageopdrachtController soc = new StageopdrachtController();
        public opdrachtEditForm()
        {
            InitializeComponent();
            getStatus();
            BedrijfController bc = new BedrijfController();
            bedrijfCbx.DataSource = bc.haalBedrijfLijstOp();
            bedrijfCbx.DisplayMember = "Bedrijfnaam";
            bedrijfCbx.ValueMember = "Bedrijfscode";
            bedrijfCbx.Text = null;
            cbx_contact.Text = null;

        }

        public void getStatus()
        {
            cbStatus.Items.Add("Open");
            cbStatus.Items.Add("In uitvoering");
            cbStatus.Items.Add("Voldaan");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void nieuweOpdracht()
        {
            opdracht.Status = (string)cbStatus.SelectedItem.ToString();
            opdracht.Naam = tbNaam.Text;
            opdracht.Omschrijving = tbOmschrijving.Text;
            opdracht.Bedrijf = (Bedrijfcontact)bedrijfCbx.SelectedItem;
            opdracht.Contact = (Persooncontact)cbx_contact.SelectedItem;
            soc.InsertStageopdracht(opdracht);
            DialogResult = DialogResult.OK;
        }

        public void Editopdracht(Stageopdracht huidigeopdracht)
        {
            opdracht = huidigeopdracht;
            tbNaam.Text = opdracht.Naam;
            tbOmschrijving.Text = opdracht.Omschrijving;
            cbStatus.Text = opdracht.Status;
            bedrijfCbx.Text = opdracht.Bedrijf.Bedrijfnaam;
            string naam = opdracht.Contact.Voornaam + " " + opdracht.Contact.Achternaam;
            cbx_contact.Text = naam;

        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (((Bedrijfcontact)bedrijfCbx.SelectedItem) == null)
            {
                MessageBox.Show("Je hebt geen bedrijf geselecteerd");
            }

            else if (((Persooncontact)cbx_contact.SelectedItem) == null)
            {
                MessageBox.Show("Je hebt geen contact geselecteerd");
            }
            else if (tbNaam.Text == "")
            {
                MessageBox.Show("Je hebt geen naam ingevoerd");
            }
            else if (tbOmschrijving.Text == "")
            {
                MessageBox.Show("Je hebt geen omschrijving ingevoerd");
            }


            else if (cbStatus.SelectedItem != null)
            {
                if (opdracht.Naam == null)
                {
                    nieuweOpdracht();
                }
                else
                {



                    soc.updateStageopdracht(opdracht.Code, cbStatus.Text, tbNaam.Text, tbOmschrijving.Text, ((Bedrijfcontact)bedrijfCbx.SelectedItem).Bedrijfscode, ((Persooncontact)cbx_contact.SelectedItem).Contactcode);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Je hebt geen status geselecteerd");
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bedrijfCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bedrijfcontact bedrijf = bedrijfCbx.SelectedItem as Bedrijfcontact;
            ContactenController cc = new ContactenController();
            cbx_contact.Text = "";
            if (bedrijf != null)
            cbx_contact.DataSource = cc.ContactenBijBedrijf(bedrijf);
            cbx_contact.DisplayMember = "volnaam";
            cbx_contact.ValueMember = "contactcode";
        }
    }
}