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
        public Settings()
        {
            InitializeComponent();
            //all views have this call to prevent flickering if the user has dark mode enabled on startup
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }

        private void buttonSettingsLogout_Click(object sender, EventArgs e)
        {
            Controllers.SessionController.RemoveSession();
            Application.Exit();
        }

        private void buttonSettingsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Home", false).First().Show();
        }
        /// <summary>
        /// Sets the Theme combobox text to the type that is currently selected
        /// </summary>
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
       

        private void comboBoxSettingsTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_themeIndexChangecounter > 0)
            {
                SetTheme(comboBoxSettingsTheme.Text, Controls); //change this code to set new theme and call the func again
                Reload();
                // gets color before it has been changed
                //Refresh();
            }
            _themeIndexChangecounter++;
        }
       
        /// <summary>
        /// Gets the current theme
        /// </summary>
        /// <returns>string</returns>
        private string GetTheme()
        {
            //Get theme from session.json, return the theme if its there
            return Controllers.SettingsController.GetTheme();
        }
        
        /// <summary>
        /// sets the current theme
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="controls"></param>
        private void SetTheme(string theme, ControlCollection controls)
        {
            Controllers.SettingsController.SetTheme(theme);
        }
        

        private void Settings_Load(object sender, EventArgs e)
        {
            _themeIndexChangecounter = 0;
            GetThemeLabel();
        }

        private void buttonSettingsLogout_VisibleChanged(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// redirects the user to Home
        /// </summary>
        private void Reload()
        {
            this.Hide();
            FindForm().Controls.Find("Home", false).First().Show();
        }

        private void Settings_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }
        /// <summary>
        /// Method specifically created for testing hte logout function
        /// </summary>
        public void TestLogout() {
            Controllers.SessionController.RemoveSession();
            Application.Exit();
        }
    }
}
