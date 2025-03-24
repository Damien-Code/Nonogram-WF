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
            FindForm().Controls.Find("History", false).First().Show();

        }

        private void buttonHomeSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Settings", false).First().Show();
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }
    }
}
