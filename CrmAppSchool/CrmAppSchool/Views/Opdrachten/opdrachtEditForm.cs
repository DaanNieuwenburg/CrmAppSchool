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
        }

        public void getStatus()
        {
                cbStatus.Items.Add("test");
                cbStatus.Items.Add("beschikbaar");
                cbStatus.Items.Add("afgerond");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void nieuweOpdracht()
        {
            opdracht.Status = (string)cbStatus.SelectedItem.ToString();
            opdracht.Naam = tbNaam.Text;
            opdracht.Omschrijving = tbOmschrijving.Text;
            soc.InsertStageopdracht(opdracht);
            DialogResult = DialogResult.OK;
        }

        public void Editopdracht(Stageopdracht huidigeopdracht)
        {
            opdracht = huidigeopdracht;
            tbNaam.Text = opdracht.Naam;
            tbOmschrijving.Text = opdracht.Omschrijving;
            cbStatus.Text = opdracht.Status;

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
                    soc.updateStageopdracht(opdracht.Code, cbStatus.Text, tbNaam.Text, tbOmschrijving.Text);
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

    }
}
