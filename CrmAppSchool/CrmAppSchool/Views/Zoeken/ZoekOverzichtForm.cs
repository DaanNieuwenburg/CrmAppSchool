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

namespace CrmAppSchool.Views.Zoeken
{
    public partial class ZoekOverzichtForm : Form
    {
        private bool Sorteermenu { get; set; }
        public ZoekOverzichtForm(List<Models.Profiel> resultaatLijst)
        {
            InitializeComponent();

            if (resultaatLijst != null && resultaatLijst.Count() > 0)
            {
                foreach (Models.Profiel profiel in resultaatLijst)
                {
                    ListViewItem lvw = new ListViewItem(profiel.Voornaam);
                    lvw.SubItems.Add(profiel.Achternaam);
                    lvw.SubItems.Add(profiel.Bedrijf);
                    lvw.SubItems.Add(profiel.Functie);
                    lvw.SubItems.Add(profiel.Kwaliteit);
                    resultatenLvw.Items.Add(lvw);
                }
            }
            else
            {
                MessageBox.Show("Geen Resultaten gevonden");
            }
        }

        private void btnSorteer_Click(object sender, EventArgs e)
        {
            
            if (Sorteermenu == true)
            {
                // Sorteer met behulp van input van comboboxen
                resultatenLvw.Sorting = SortOrder.Ascending;
            }
            UpdateSorteerMenu();
        }
        private void UpdateSorteerMenu()
        {
            // Zodra sorteermenu true word, worden ook de invoermogelijkheden zichtbaar
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
    }
}
