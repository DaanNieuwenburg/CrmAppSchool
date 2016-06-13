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
            if (cbStatus.SelectedItem != null)
            {
                if (opdracht.Naam == null)
                {
                    nieuweOpdracht();
                }
                else
                {
                    soc.updateStageopdracht(opdracht.Code, cbStatus.Text, tbNaam.Text, tbOmschrijving.Text, ((Bedrijfcontact)bedrijfCbx.SelectedItem).Bedrijfscode);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("je hebt geen status geslecteerd");
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
            cbx_contact.DataSource = cc.ContactenBijBedrijf(bedrijf);
            cbx_contact.DisplayMember = "volnaam";
            cbx_contact.ValueMember = "contactcode";


        }
    }
}