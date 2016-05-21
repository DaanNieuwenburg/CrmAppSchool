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
            string gebruikersnaam = gebruikersnaamTxb.Text;
            string wachtwoord = wachtwoordTxb.Text;
            LoginController logincontroller = new LoginController();
            bool resultaat = logincontroller.VerifieerGebruiker(gebruikersnaam, wachtwoord);
            if(resultaat == false)
            {
                errortitelLbl.Visible = true;
                errordescLbl.Visible = true;
            }
            else
            {
                this.Hide();
            }
        }

    }
}
