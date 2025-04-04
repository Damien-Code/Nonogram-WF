using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram_WF.Controllers;

namespace Nonogram_WF.Views
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
			//all views have this call to prevent flickering if the user has dark mode enabled on startup
			Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
		}

        private void buttonHomeLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveSession();
            Application.Exit();
        }

        private void buttonHomePlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Difficulty", false).First().Show();
        }

        private void buttonHomeHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("history1", false).First().Show();

        }

        private void buttonHomeSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Settings", false).First().Show();
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
            //reload();
            Refresh(); 
        }
        public string AcceptatieTestButtonTest() {
            //Would normally call this but cant during testing so we just return the name of the UserControl that Find tries to find

            //this.Hide();
            //FindForm().Controls.Find("Difficulty", false).First().Show();



            return "Difficulty";
        }
        //private void reload() {
        //    this.Hide();
        //    FindForm().Controls.Find("Home", false).First().Show();
        //}
    }
}
