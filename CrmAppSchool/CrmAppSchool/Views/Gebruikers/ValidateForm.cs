using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmAppSchool.Views.Gebruikers
{
    public partial class ValidateForm : Form
    {
        public string password { get; private set; }
        public ValidateForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            password = tbWachtwoord.Text;
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
