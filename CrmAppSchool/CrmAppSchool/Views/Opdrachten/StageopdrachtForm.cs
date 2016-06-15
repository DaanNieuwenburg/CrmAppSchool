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
        public bool ShowMenu { get; set; }                 // Boolean voor het zichtbaar maken van de mainmenus
        public bool ShowZoeken { get; set; }
        private Gebruiker gebruiker { get; set; }

        StageopdrachtController soc = new StageopdrachtController();
        public StageopdrachtForm(Gebruiker _gebruiker)
        {
            InitializeComponent();
            gebruiker = _gebruiker;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            ShowMenu = false;
            ShowZoeken = false;
            setListBox();
            if (gebruiker.SoortGebruiker == "Student")
            {
                btnDelete.Visible = false;
                btnVoegtoe.Visible = false;
                btnWijzig.Visible = false;
            }
            Cursor = Cursors.Default;
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
                Bedrijfcontact bcontact = opdracht.Bedrijf;
                if (opdracht.Bedrijf != null)
                {
                    lvi.SubItems.Add(bcontact.Bedrijfnaam);
                }
                Persooncontact pcontact = opdracht.Contact;
                if (opdracht.Contact != null)
                {
                    pcontact.volnaam = pcontact.Voornaam + " " + pcontact.Achternaam;
                    lvi.SubItems.Add(pcontact.volnaam);
                }
                if (opdracht.Bedrijf != null)
                {
                    lvi.SubItems.Add(Convert.ToString(bcontact.Bedrijfscode));
                }
                if (opdracht.Contact != null)
                {
                    lvi.SubItems.Add(Convert.ToString(pcontact.Contactcode));
                }
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
                /*  Er is maar een btnwijzig.click methode, LVI moeten dan wel exact aan elkaar gelijk zijn.
                    
                ListViewItem lvi = new ListViewItem(opdracht.Code.ToString());
                lvi.SubItems.Add(opdracht.Naam);
                lvi.SubItems.Add(opdracht.Omschrijving);
                lvi.SubItems.Add(opdracht.Status);
                lvi.SubItems.Add(Convert.ToString(opdracht.Bedrijf.Bedrijfscode));
                lvi.SubItems.Add(opdracht.Bedrijf.Contactpersoon);
                lvStage.Items.Add(lvi); */
                ListViewItem lvi = new ListViewItem(opdracht.Code.ToString());
                lvi.SubItems.Add(opdracht.Naam);
                lvi.SubItems.Add(opdracht.Omschrijving);
                lvi.SubItems.Add(opdracht.Status);
                Bedrijfcontact bcontact = opdracht.Bedrijf;
                if (opdracht.Bedrijf != null)
                {
                    lvi.SubItems.Add(bcontact.Bedrijfnaam);
                }
                Persooncontact pcontact = opdracht.Contact;
                if (opdracht.Contact != null)
                {
                    pcontact.volnaam = pcontact.Voornaam + " " + pcontact.Achternaam;
                    lvi.SubItems.Add(pcontact.volnaam);
                }
                if (opdracht.Bedrijf != null)
                {
                    lvi.SubItems.Add(Convert.ToString(bcontact.Bedrijfscode));
                }
                if (opdracht.Contact != null)
                {
                    lvi.SubItems.Add(Convert.ToString(pcontact.Contactcode));
                }
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
                int bedrijfcode = Convert.ToInt32(lvStage.SelectedItems[0].SubItems[6].Text);   // bedrijfcode
                int contactcode = Convert.ToInt32(lvStage.SelectedItems[0].SubItems[7].Text);   // contactcode
                opdracht.Code = Convert.ToInt32(lvStage.SelectedItems[0].SubItems[0].Text);
                opdracht.Naam = lvStage.SelectedItems[0].SubItems[1].Text;
                opdracht.Omschrijving = lvStage.SelectedItems[0].SubItems[2].Text;
                opdracht.Status = lvStage.SelectedItems[0].SubItems[3].Text;

                // Haal bedrijfinfo op
                BedrijfController bc = new BedrijfController();
                Bedrijfcontact bedrijf = bc.SelecteerBedrijf(bedrijfcode);
                opdracht.Bedrijf = bedrijf;

                //Haal contactinfo op
                ContactenController cc = new ContactenController();
                Persooncontact contact = cc.HaalInfoOp(contactcode.ToString());
                opdracht.Contact = contact;

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
                DialogResult dialoogResultaat = MessageBox.Show("Wilt u deze stageopdracht echt verwijderen?", "Verwijderen stageopdracht", MessageBoxButtons.YesNo);
                if (dialoogResultaat == DialogResult.Yes)
                {

                    soc.deleteStageopdracht(Convert.ToInt32(lvStage.SelectedItems[0].SubItems[0].Text));
                    setListBox();
                }
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

                // Laat de buttons niet zien als het een student is
                if (gebruiker.SoortGebruiker != "Student")
                {
                    btnDelete.Visible = true;
                    btnVoegtoe.Visible = true;
                    btnWijzig.Visible = true;
                }
            }
        }

        private void lvStage_ItemActivate(object sender, EventArgs e)
        {
            StageopdrachtController controller = new StageopdrachtController();
            string opdrachtcode = lvStage.SelectedItems[0].Text;
            Stageopdracht opdracht = controller.HaalInfoOp(opdrachtcode);
            OpdrachtDetails details = new OpdrachtDetails(opdracht);
            details.ShowDialog();
        }

        private void tbZoek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ShowZoeken == false)
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

                    // Laat de buttons niet zien als het een student is
                    if (gebruiker.SoortGebruiker != "Student")
                    {
                        btnDelete.Visible = true;
                        btnVoegtoe.Visible = true;
                        btnWijzig.Visible = true;
                    }
                }
            }
        }

        private void StageopdrachtForm_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
