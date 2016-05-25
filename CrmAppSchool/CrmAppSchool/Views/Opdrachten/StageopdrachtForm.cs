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
        StageopdrachtController soc = new StageopdrachtController();
        public StageopdrachtForm()
        {
            InitializeComponent();
            setListBox();
        }


        public void setListBox()
        {
            List<Stageopdracht> opdrachten = soc.getOpdrachten();
            foreach(Stageopdracht opdracht in opdrachten)
            {
                lbStage.Items.Add(opdracht);
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bZoek_Click(object sender, EventArgs e)
        {

        }
    }
}
