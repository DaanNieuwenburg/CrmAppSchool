using System;
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
            Login();
        }
        private void Login()
        {
            string gebruikersnaam = gebruikersnaamTxb.Text;
            string wachtwoord = wachtwoordTxb.Text;
            LoginController logincontroller = new LoginController();
            bool resultaat = logincontroller.VerifieerGebruiker(gebruikersnaam, wachtwoord, true);
            if (resultaat == false && gebruikersnaamTxb.Text.Count() == 0)
            {
                MessageBox.Show("De gebruikersnaam mag niet leeg zijn.\nProbeer het opnieuw", "Inloggen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(resultaat == false && wachtwoordTxb.Text.Count() == 0)
            {
                MessageBox.Show("Het wachtwoord mag niet leeg zijn.\nProbeer het opnieuw", "Inloggen mislukt",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultaat == false && wachtwoordTxb.Text.Count() > 0)
            {
                MessageBox.Show("Inloggen mislukt\nControleer uw gebruikersnaam en of wachtwoord", "Inloggen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                wachtwoordTxb.Text = "";
            }
            else
            {
                SaveRemember();
                this.Hide();
            }
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

        private void wachtwoordTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void InlogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
