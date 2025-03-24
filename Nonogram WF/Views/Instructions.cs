using Nonogram_WF.Controllers;
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
    public partial class Instructions : UserControl
    {
        public Instructions()
        {
            InitializeComponent();
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }

        private void buttonGameInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Home", false).First().Show();
        }

        private void buttonGameInstructions_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }
    }
}
