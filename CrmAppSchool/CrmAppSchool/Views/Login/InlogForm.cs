﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmAppSchool.Controllers;

namespace CrmAppSchool.Views.Login
{
    public partial class InlogForm : Form
    {
        public InlogForm()
        {
            InitializeComponent();
        }

        private void inlogBtn_Click(object sender, EventArgs e)
        {
            
            string gebruikersnaam = gebruikersnaamTxb.Text;
            string wachtwoord = wachtwoordTxb.Text;
            GebruikerController logincontroller = new GebruikerController();
            bool resultaat = logincontroller.VerifieerGebruiker(gebruikersnaam, wachtwoord);
            if(resultaat == false)
            {
                errortitelLbl.Visible = true;
                errordescLbl.Visible = true;
            }
            else
            {
                SaveRemember();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InlogForm_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Remember == "True")
            {
                checkBox1.CheckState = CheckState.Checked;
                gebruikersnaamTxb.Text = Properties.Settings.Default.Username;
                wachtwoordTxb.Text = Properties.Settings.Default.Password;
            }
            else if (Properties.Settings.Default.Remember == "False")
            {         
                
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }
        private void SaveRemember()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Remember = "True";
                Properties.Settings.Default.Username = gebruikersnaamTxb.Text;
                Properties.Settings.Default.Password = wachtwoordTxb.Text;
            }
            else
            {
                Properties.Settings.Default.Remember = "False";
            }
            Properties.Settings.Default.Save();
        }
    }
}
