using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram_WF.Controllers;

namespace Nonogram_WF.Views
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxLoginEmail.Text;
            string password = textBoxLoginPassword.Text;
            if (LoginController.CheckUserData(email, password)) 
            {
                //add error method call to controller "password or email incorrect"
                return;
            }
            
            this.Hide();

            FindForm().Controls.Find("Instructions", false).First().Show();
          

        }
        private void buttonLoginRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Registration", false).First().Show();

        }
    }
}
