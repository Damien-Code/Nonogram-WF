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
	public partial class History : UserControl
	{
		public History()
		{
			InitializeComponent();
			PopulateDataGridView();
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
			Session.RemoveSession();
			Application.Exit();
		}

		/// <summary>
		/// Method that populates the datagridview for history
		/// for each row the level, count and solve is added
		/// </summary>
		private void PopulateDataGridView()
		{
			dataGridView1.Rows.Add(HistoryController.RetrieveHistory().Level, HistoryController.RetrieveHistory().HintCount, HistoryController.RetrieveHistory().UsedSolver);
		}
	}
        private void buttonHistoryLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveSession();
            Application.Exit();
        }

        private void History_VisibleChanged(object sender, EventArgs e)
        {
            Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
        }
    }
}
