using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram_WF.Controllers;

namespace Nonogram_WF.Views
{
	public partial class GameScreen : UserControl
	{
		public int GridSize; //{ get; set; }
		public GameScreen()
		{
			//GridSize = GridSize + 4;
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			GameController.initializeGrid(GridSize);
			OnPaint(e);
		}
		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			Graphics g = e.Graphics;

			Pen p = new(Color.Black);
			int TotalCells = GridSize;
			int cellSize = 30;
			int horizontalStartPosition = 100;
			int verticalStartPosition = 150;

			for (int i = 0; i < TotalCells+1; i++)
			{
				// Vertical
				g.DrawLine(p, (i * cellSize)+horizontalStartPosition, verticalStartPosition, i * cellSize + horizontalStartPosition, TotalCells * cellSize + verticalStartPosition);
				// Horizontal
				g.DrawLine(p, horizontalStartPosition, (i * cellSize) + verticalStartPosition, TotalCells * cellSize + horizontalStartPosition, i * cellSize + verticalStartPosition);
			}
		}
	}
}
