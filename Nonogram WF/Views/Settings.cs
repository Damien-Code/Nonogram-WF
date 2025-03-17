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
	public partial class Settings : UserControl
	{
		public Settings()
		{
			InitializeComponent();
			SetThemeLabel();
		}

		private void buttonSettingsLogout_Click(object sender, EventArgs e)
		{
			Session.RemoveSession();
			Application.Exit();
		}

		private void buttonSettingsBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			FindForm().Controls.Find("Home", false).First().Show();
		}
		private void SetThemeLabel()
		{
			string userTheme = GetTheme(); //TODO: Get
			comboBoxSettingsTheme.Text = (userTheme == "Light" || userTheme == "Theme:") ? "Light" : "Dark";
			return;

		}

		private void comboBoxSettingsTheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetThemeLabel();

		}
		private string GetTheme() {
			//Get theme from data.json, return the theme if its there
			return "Dark";
		}
	}
}
