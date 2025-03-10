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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void buttonSettingsLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSettingsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Home", false).First().Show();
        }
    }
}
