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
    public partial class Difficulty : UserControl
    {
        public Difficulty()
        {
            InitializeComponent();
            //all views have this call to prevent flickering if the user has dark mode enabled on startup
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }

		private void buttonDifficultyHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Here you can choose your difficulty. Ranging from 1 to 16");
		}

        private void buttonDifficultyLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveSession();
            Application.Exit();
        }

		private void buttonDifficultyBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			FindForm().Controls.Find("Home", false).First().Show();
		}
        private void Difficulty_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }
    
		private void buttonDifficultyPlayGame_Click(object sender, EventArgs e)
		{
			this.Hide();
			int level = (int)numericUpDownDifficulty.Value;
			GameScreen test = (GameScreen)FindForm().Controls.Find("GameScreen", false).First();
			test.GridSize = level+4;
			test.ThemeChange();
			test.Test();
			test.Show();
		}

		private void numericUpDownDifficulty_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
