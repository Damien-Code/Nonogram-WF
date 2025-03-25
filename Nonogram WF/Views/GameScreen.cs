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
		public int GridSize;
		protected int MaxGridSize = 400;//max length of grid
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

			Pen p = new(Color.Black); // TODO: make it change depending on theme (light theme is Color.Black)
			int TotalCellsPerRow = GridSize;
			//int cellSize = 30;
			int cellSize = (int)Math.Floor(MaxGridSize/(double)GridSize);
			int horizontalStartPosition = 375;
			int verticalStartPosition = 150;

			for (int i = 0; i < TotalCellsPerRow+1; i++)
			{
				// Vertical
				g.DrawLine(p, (i * cellSize)+horizontalStartPosition, verticalStartPosition, i * cellSize + horizontalStartPosition, TotalCellsPerRow * cellSize + verticalStartPosition);
				// Horizontal
				g.DrawLine(p, horizontalStartPosition, (i * cellSize) + verticalStartPosition, TotalCellsPerRow * cellSize + horizontalStartPosition, i * cellSize + verticalStartPosition);
			}
		}
	}
}
