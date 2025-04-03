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
using Nonogram_WF.Models;

namespace Nonogram_WF.Views
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
            
            //all views have this call to prevent flickering if the user has dark mode enabled on startup
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }

        private void buttonHistoryBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindForm().Controls.Find("Home", false).First().Show();
        }

        private void buttonHistoryLogout_Click(object sender, EventArgs e)
        {
            Controllers.Session.RemoveSession();
            Application.Exit();
        }

        /// <summary>
        /// Method that populates the datagridview for history
        /// for each row the level, count and solve is added
        /// </summary>
        private void PopulateDataGridView()
        {
            //    (Users user, UserHistory history) = HistoryController.RetrieveHistory();
            //    //dataGridView1.Rows.Add(history.AllHistory.Level, history.HintCount, history.UsedSolver);
            //    foreach (Models.History userHistory in history.AllHistory)
            //    {
            //        dataGridView1.Rows.Add(userHistory.Level, userHistory.HintCount, userHistory.UsedSolver);
            //    }
        }

        private void History_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }

        private void History_Load(object sender, EventArgs e)
        {
            // Needed to have a Load method because the table would not show items on first load
            
            PopulateDataGridView();
        }
    }
}
