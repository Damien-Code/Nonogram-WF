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
	public partial class GameScreen : UserControl
	{
		public GameScreen()
		{
			InitializeComponent();
		}

		private void buttonGameScreenBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			FindForm().Controls.Find("Difficulty", false).First().Show();
		}

		private void buttonGameScreenLogout_Click(object sender, EventArgs e)
		{
			Session.RemoveSession();
			Application.Exit();
		}
	}
}
