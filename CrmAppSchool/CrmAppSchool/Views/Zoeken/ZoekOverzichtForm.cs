﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAppSchool.Models;
using CrmAppSchool.Controllers;

using MaterialSkin.Controls;

namespace CrmAppSchool.Views.Zoeken
{

    public partial class ZoekOverzichtForm : Form //MaterialForm
    {
        private int soortresultaat { get; set; }
        public bool ShowMenu { get; set; }
        private bool Sorteermenu { get; set; }
        private ComboBox cb { get; set; } 
        private Gebruiker _gebruiker { get; set; }
        private ImageList imagelist
        {
            get; set;
        }
        public ZoekOverzichtForm(ComboBox cb, Gebruiker gebruiker, int soortresultaat)
        {
            
            // add an item
            // var listViewItem = listView.Items.Add("Item with image");
            // and tell the item which image to use
            //listViewItem.ImageKey = "itemImageKey";
            InitializeComponent();
            _gebruiker = gebruiker;
            this.soortresultaat = soortresultaat;
            lblGebruiker.Text = lblGebruiker.Text + " " + gebruiker.Gebruikersnaam;
            ShowMenu = false;
            // create image list and fill it 
            imagelist = new ImageList();
            imagelist.Images.Add("GS", Properties.Resources.Afbeelding_ContactPersoon_GastSpreker);
            imagelist.Images.Add("GD", Properties.Resources.Afbeelding_ContactPersoon_GastDocent);
            imagelist.Images.Add("BD", Properties.Resources.Afbeelding_ContactPersoon_Bedrijf);
            imagelist.Images.Add("SB", Properties.Resources.Afbeelding_ContactPersoon_StageBegeleider);
            // tell your ListView to use the new image list
            resultatenLvw.LargeImageList = imagelist;
            this.cb = cb;
            cbSorteerOp.Items.Clear();
            foreach(string item in cb.Items)
            {
                cbSorteerOp.Items.Add(item);
            }
            cbSorteerOp.Text = cb.Items[0].ToString();
        
        }

        public void VulCombobox()
        {

        }
        public void VulListviewPersoon(List<Models.Persooncontact> resultatenlijst)
        {
            //if (resultaatLijst != null && resultaatLijst.Count() > 0)
            //{
            foreach (Models.Persooncontact contact in resultatenlijst)
            {
                ListViewItem lvw = new ListViewItem(contact.Voornaam);
                lvw.SubItems.Add(contact.Achternaam);
                lvw.SubItems.Add(Convert.ToString(contact.Contactcode));
                //lvw.SubItems.Add(contact.Bedrijf.Bedrijfnaam);
                Console.WriteLine("IN LVW cc=" + contact.Contactcode);
                lvw.SubItems.Add(contact.Functie);
                lvw.SubItems.Add(contact.Locatie);
                //lvw.SubItems.Add(contact.Kwaliteit);        
                resultatenLvw.Items.Add(lvw);
                imagelist.ImageSize = new Size(50, 50);
                lvw.ImageKey = "GS";        // Stel de afbeelding voor de persoon in
            }
        }
        public void VulListviewBedrijf(List<Models.Bedrijfcontact> resultatenlijst)
        {
            //if (resultaatLijst != null && resultaatLijst.Count() > 0)
            //{
            foreach (Models.Bedrijfcontact contact in resultatenlijst)
            {
                ListViewItem lvw = new ListViewItem(contact.Bedrijfnaam);
                lvw.SubItems.Add(contact.Hoofdlocatie);
                //lvw.SubItems.Add(contact.Bedrijf.Bedrijfnaam);
                lvw.SubItems.Add(contact.Email);
                lvw.SubItems.Add(contact.Website);
                lvw.SubItems.Add(contact.Bedrijfscode.ToString());
                //lvw.SubItems.Add(contact.Kwaliteit);        
                resultatenLvw.Items.Add(lvw);
                imagelist.ImageSize = new Size(50, 50);
                lvw.ImageKey = "BD";        // Stel de afbeelding voor de persoon in
            }
        }

        // }



        private void btnSorteer_Click(object sender, EventArgs e)
        {
            string a = cbSorteerOp.Text;
            if (Sorteermenu == true)
            {
                resultatenLvw.ListViewItemSorter = new ListViewItemComparer(cbSorteerOp.SelectedIndex, cbSorteerVolgorde.Text);
                // Sorteer met behulp van input van comboboxen
                /*if (cbSorteerVolgorde.Text == "A→Z")
                {                    
                   resultatenLvw.Sorting = SortOrder.Ascending;
                    resultatenLvw.Sort();
                }
                else if (cbSorteerVolgorde.Text == "Z→A")
                {
                    
                   resultatenLvw.Sorting = SortOrder.Descending;
                    resultatenLvw.Sort();
                }*/
                resultatenLvw.Sort();
            }
            UpdateSorteerMenu();
        }
        private void UpdateSorteerMenu()
        {
            // Zodra sorteermenu true wordt, worden ook de invoermogelijkheden zichtbaar
            if (Sorteermenu == false)
            {
                cbSorteerOp.Visible = true;
                cbSorteerVolgorde.Visible = true;
                Sorteermenu = true;
                btnCancel.Visible = true;
            }
            else
            {
                cbSorteerOp.Visible = false;
                cbSorteerVolgorde.Visible = false;
                Sorteermenu = false;
                btnCancel.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbSorteerOp.Visible = false;
            cbSorteerVolgorde.Visible = false;
            Sorteermenu = false;
            btnCancel.Visible = false;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ShowMenu = true;
            this.Close();
        }

        private void ZoekOverzichtForm_Load(object sender, EventArgs e)
        {
            ToolTip TPsort = new ToolTip();
            TPsort.ShowAlways = false;
            TPsort.SetToolTip(btnSorteer, "Sorteer de zoekresultaten");
        }

        private void resultatenLvw_ItemActivate(object sender, EventArgs e)
        {
            
            if (soortresultaat == 1)
            {
                string contactcode = resultatenLvw.SelectedItems[0].SubItems[2].Text;
                ContactenController _controller = new ContactenController();
                Persooncontact contact = _controller.HaalInfoOp(contactcode);
                CrmAppSchool.Views.Contacten.ContactDetails _details = new CrmAppSchool.Views.Contacten.ContactDetails(_gebruiker, contact);
                _details.ShowDialog();
            }
            else if (soortresultaat == 2)
            {
                string contactcode = resultatenLvw.SelectedItems[0].SubItems[4].Text;
                BedrijfController bc = new BedrijfController();
                Bedrijfcontact contact = bc.SelecteerBedrijf(Convert.ToInt32(contactcode));

                Bedrijven.BedrijfDetails details = new Bedrijven.BedrijfDetails(_gebruiker, contact);
                details.ShowDialog();
            }

        }
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        private string sort;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column, string sorteervolgorde)
        {
            col = column;
            sort = sorteervolgorde;
        }
        public int Compare(object x, object y)
        {
            if (sort == "A→Z")
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
            else if (sort == "Z→A")
            {
                return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
            }
            else
            {
                return 0;
            }

        }
    }
}
