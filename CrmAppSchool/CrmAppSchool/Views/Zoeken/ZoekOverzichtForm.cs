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
        public ZoekOverzichtForm(List<Models.Profiel> resultaatLijst)
        {
            InitializeComponent();
            foreach(Models.Profiel profiel in resultaatLijst)
            {
                ListViewItem lvw = new ListViewItem(profiel.Voornaam);
                lvw.SubItems.Add(profiel.Achternaam);
                lvw.SubItems.Add(profiel.Bedrijf);
                lvw.SubItems.Add(profiel.Functie);
                lvw.SubItems.Add(profiel.Kwaliteit);
                resultatenLvw.Items.Add(lvw);
            }
        }
    }
}
