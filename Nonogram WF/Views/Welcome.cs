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
using Nonogram_WF.Database;

namespace Nonogram_WF
{
    public partial class Welcome : UserControl
    {
        
        //UserControl register;
        //UserControl login;
        public Welcome()
        {
            InitializeComponent();
            if (hasSession()) {
				this.Hide();
				FindForm().Controls.Find("Registration", false).First().Show();
				return;
            }
            
            //login = new login();
        }

        private void buttonWelcomeLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Parent.Controls.Add(login);
            //login.Dock = DockStyle.Fill;
            //login.Show();
            
            // finds the form where the control is on.
            // searches all the controls with the given name.
            // shows the first control that is found.
            FindForm().Controls.Find("Login", false).First().Show();    
        }

        private void buttonWelcomeRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Registration", false).First().Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
        }
        private bool hasSession() {
            return (Session.GetSession() != "");
        }
    }
}
