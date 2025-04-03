using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram_WF.Controllers;

namespace Nonogram_WF.Views
{
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonRegisterRegister_Click(object sender, EventArgs e)
        {
            // gets the input from the textboxes and sets it to variables
            string email = textBoxRegisterEmail.Text;
            string password = textBoxRegisterPassword.Text;
            string confirmPassword = textBoxRegisterConfirm.Text;

            // if the ValidateUserData method is not true
            // give the user an error and return
            if (!UserController.ValidateUserData(email, password, confirmPassword)) 
            {
                return;
            };

            // if the UserData is validated, hide the current control and show the instructions
            this.Hide();
            FindForm().Controls.Find("Instructions", false).First().Show();
        }

        private void buttonRegisterLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("login1", false).First().Show();
        }
    }
}
