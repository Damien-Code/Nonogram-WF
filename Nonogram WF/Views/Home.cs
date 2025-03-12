using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram_WF.Views
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonHomeLogout_Click(object sender, EventArgs e)
        {
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
    }
}
