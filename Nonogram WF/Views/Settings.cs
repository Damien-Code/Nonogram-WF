using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram_WF.Controllers;
using Nonogram_WF.Models;

namespace Nonogram_WF.Views
{
    public partial class Settings : UserControl
    {
        private int _themeIndexChangecounter = 0;
        private int _fontSizeIndexChangecounter = 0;
        public Settings()
        {
            InitializeComponent();
            //all views have this call to prevent flickering if the user has dark mode enabled on startup
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }

        private void buttonSettingsLogout_Click(object sender, EventArgs e)
        {
            Controllers.Session.RemoveSession();
            Application.Exit();
        }

        private void buttonSettingsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Home", false).First().Show();
        }
        private void GetThemeLabel()
        {
            string userTheme = GetTheme();
            comboBoxSettingsTheme.Text =
                (userTheme == "Light") ? "Light" :
                (userTheme == "Dark") ? "Dark" :
                (userTheme == "DarkBlue") ? "DarkBlue" :
                "Grey";
            return;
        }
        private void GetFontLabel()
        {
            string userFontSize = GetFontSize();
            comboBoxSettingsFont.Text = userFontSize;
            return;

        }

        private void comboBoxSettingsTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_themeIndexChangecounter > 0)
            {
                SetTheme(comboBoxSettingsTheme.Text, Controls); //change this code to set new theme and call the func again
                reload();
                // gets color before it has been changed
                //Refresh();
            }
            _themeIndexChangecounter++;
        }
        private void comboBoxSettingsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show();
            if (_fontSizeIndexChangecounter > 0)
            {
                SetFontSize(comboBoxSettingsFont.Text); //change this code to set new theme and call the func again
            }
            _fontSizeIndexChangecounter++;
        }
        private string GetTheme()
        {
            //Get theme from session.json, return the theme if its there
            return Controllers.Settings.GetTheme();
        }
        private string GetFontSize()
        {
            //return "";
            return Controllers.Settings.GetFontSize();
        }
        private void SetTheme(string theme, ControlCollection controls)
        {
            Controllers.Settings.SetTheme(theme);
        }
        private void SetFontSize(string fontSize)
        {
            Controllers.Settings.SetFontSize(fontSize);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            _fontSizeIndexChangecounter = 0;
            _themeIndexChangecounter = 0;
            GetThemeLabel();
            GetFontLabel();
        }

        private void buttonSettingsLogout_VisibleChanged(object sender, EventArgs e)
        {
        }
        private void reload()
        {
            this.Hide();
            FindForm().Controls.Find("Home", false).First().Show();
        }

        private void Settings_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }
    }
}
