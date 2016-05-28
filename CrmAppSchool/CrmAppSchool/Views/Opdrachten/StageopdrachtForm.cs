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
            lbStage.Items.Clear();
            List<Stageopdracht> opdrachten = soc.getOpdrachten();
            foreach(Stageopdracht opdracht in opdrachten)
            {
                lbStage.Items.Add(opdracht);
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void zoek()
        {
            lbStage.Items.Clear();
            string input = "%" + tbZoek.Text + "%";
            List<Stageopdracht> opdrachten = soc.ZoekOpdrachten(input);
            foreach (Stageopdracht opdracht in opdrachten)
            {
                lbStage.Items.Add(opdracht);
            }
        }

        private void bZoek_Click(object sender, EventArgs e)
        {
            if (tbZoek.Text.Equals(""))
            {
                lbStage.Items.Clear();
                setListBox();
            }
            else
            {
                zoek();
            }
        }

        private void bVerwijderen_Click(object sender, EventArgs e)
        {
            if ((Stageopdracht)lbStage.SelectedItem != null)
            {
                soc.deleteStageopdracht(((Stageopdracht)lbStage.SelectedItem).Code);
                setListBox();
            }
        }

        private void bToevoegen_Click(object sender, EventArgs e)
        {

            opdrachtEditForm form = new opdrachtEditForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                setListBox();
            }
        }

        private void bAanpassen_Click(object sender, EventArgs e)
        {
            if (lbStage.SelectedItem != null)
            {
                opdrachtEditForm OEF = new opdrachtEditForm();
                OEF.Editopdracht((Stageopdracht)lbStage.SelectedItem);
                OEF.ShowDialog();
                if (OEF.DialogResult == DialogResult.OK)
                {
                    setListBox();
                }
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
            if (lbStage.SelectedItem != null)
            {
                opdrachtEditForm OEF = new opdrachtEditForm();
                OEF.Editopdracht((Stageopdracht)lbStage.SelectedItem);
                OEF.ShowDialog();
                if (OEF.DialogResult == DialogResult.OK)
                {
                    setListBox();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((Stageopdracht)lbStage.SelectedItem != null)
            {
                soc.deleteStageopdracht(((Stageopdracht)lbStage.SelectedItem).Code);
                setListBox();
            }
        }
    }
}
