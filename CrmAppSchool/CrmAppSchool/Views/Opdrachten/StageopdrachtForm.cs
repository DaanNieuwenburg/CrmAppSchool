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
    public partial class StageopdrachtForm : Form
    {
        public bool ShowMenu { get; set; }                 // Boolean voor het zichtbaar maken van de mainmenu
        public bool ShowZoeken { get; set; }

        StageopdrachtController soc = new StageopdrachtController();
        public StageopdrachtForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            ShowMenu = false;
            ShowZoeken = false;
            setListBox();
            
        }


        public void setListBox()
        {
            lvStage.Items.Clear();
            List<Stageopdracht> opdrachten = soc.getOpdrachten();
            foreach (Stageopdracht opdracht in opdrachten)
            {
                ListViewItem lvi = new ListViewItem(opdracht.Code.ToString());
                lvi.SubItems.Add(opdracht.Naam);
                lvi.SubItems.Add(opdracht.Omschrijving);
                lvi.SubItems.Add(opdracht.Status);
                lvStage.Items.Add(lvi);
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void zoek()
        {
            lvStage.Items.Clear();
            string input = "%" + tbZoek.Text + "%";
            List<Stageopdracht> opdrachten = soc.ZoekOpdrachten(input);
            foreach (Stageopdracht opdracht in opdrachten)
            {
                ListViewItem lvi = new ListViewItem(opdracht.Code.ToString());
                lvi.SubItems.Add(opdracht.Naam);
                lvi.SubItems.Add(opdracht.Omschrijving);
                lvi.SubItems.Add(opdracht.Status);
                lvStage.Items.Add(lvi);
            }
        }

        private void btnVoegtoe_Click(object sender, EventArgs e)
        {
            opdrachtEditForm form = new opdrachtEditForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                setListBox();
            }
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            if (lvStage.SelectedItems.Count != 0)
            {
                Stageopdracht opdracht = new Stageopdracht();
                opdracht.Code = Convert.ToInt32(lvStage.SelectedItems[0].SubItems[0].Text);
                opdracht.Naam = lvStage.SelectedItems[0].SubItems[1].Text;
                opdracht.Omschrijving = lvStage.SelectedItems[0].SubItems[2].Text;
                opdracht.Status = lvStage.SelectedItems[0].SubItems[3].Text;

                opdrachtEditForm OEF = new opdrachtEditForm();
                OEF.Editopdracht(opdracht);
                OEF.ShowDialog();
                if (OEF.DialogResult == DialogResult.OK)
                {
                    setListBox();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvStage.SelectedItems != null)
            {
                soc.deleteStageopdracht(Convert.ToInt32(lvStage.SelectedItems[0].SubItems[0].Text));
                setListBox();
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Hide();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            if(ShowZoeken == false)
            {
                tbZoek.Visible = true;
                ShowZoeken = true;
                btnDelete.Visible = false;
                btnVoegtoe.Visible = false;
                btnWijzig.Visible = false;
            }
            else
            {
                tbZoek.Visible = false;
                ShowZoeken = false;

                if (tbZoek.Text.Equals(""))
                {
                    setListBox();
                }
                else
                {
                    zoek();
                }
                btnDelete.Visible = true;
                btnVoegtoe.Visible = true;
                btnWijzig.Visible = true;
            }
        }
    }
}
