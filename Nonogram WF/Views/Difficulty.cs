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
    public partial class Difficulty : UserControl
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void buttonDifficultyHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can choose your difficulty. Ranging from 1 to 15");
        }

        private void buttonDifficultyLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDifficultyBack_Click(object sender, EventArgs e)
        {
            FindForm().Controls.Find("Home", false).First().Show();
        }
    }
}
