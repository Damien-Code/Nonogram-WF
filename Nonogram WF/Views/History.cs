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
			Nonogram_WF.Models.History history = HistoryController.RetrieveHistory();
			dataGridView1.Rows.Add(history.Level, history.HintCount, history.UsedSolver);
		}
	}
}
