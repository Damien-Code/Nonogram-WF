using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nonogram_WF.Controllers;
using Nonogram_WF.Themes;

namespace Nonogram_WF.Views
{
	public partial class GameScreen : UserControl
	{
		private PaintEventArgs _paint;
		protected int MaxGridSize = 400;//max length of grid
		private int[][] _solutionGrid;
		private int[][] _currentAttemptGrid;
		private Theme _theme = ThemeController.GetTheme();
		private int _horizontalStartPosition = 375;
		private int _verticalStartPosition = 175;
		public int GridSize;
		public PaintEventArgs Paint { get { return _paint; } set { _paint = value; } }
		public GameScreen()
		{
			//GridSize = GridSize + 4;
			InitializeComponent();
			//all views have this call to prevent flickering if the user has dark mode enabled on startup
			Themes.Theme.ChangeTheme(ThemeController.GetTheme(), Controls);
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
		protected override void OnPaint(PaintEventArgs e)
		{
			Paint = e;
			base.OnPaint(e);
			Graphics g = e.Graphics;

			Pen p = new(_theme.PenColor); 
			int TotalCellsPerRow = GridSize;
			int cellSize = (int)Math.Floor(MaxGridSize / (double)GridSize);

			for (int i = 0; i <= TotalCellsPerRow; i++)
			{
				// Vertical
				g.DrawLine(p, (i * cellSize) + _horizontalStartPosition, _verticalStartPosition, i * cellSize + _horizontalStartPosition, TotalCellsPerRow * cellSize + _verticalStartPosition);
				// Horizontal
				g.DrawLine(p, _horizontalStartPosition, (i * cellSize) + _verticalStartPosition, TotalCellsPerRow * cellSize + _horizontalStartPosition, i * cellSize + _verticalStartPosition);
			}
			//fill rectangle
		}

		private void GameScreen_VisibleChanged(object sender, EventArgs e)
		{
			_theme = ThemeController.GetTheme();

			Themes.Theme.ChangeTheme(_theme, Controls);
			_solutionGrid = GameController.initializeGrid(GridSize);
			_currentAttemptGrid = new int[GridSize][];
			Refresh();
		}
		public void ThemeChange()
		{
			_theme = ThemeController.GetTheme();
			Themes.Theme.ChangeTheme(_theme, Controls);
		}

		private void panel1_Click(object sender, EventArgs e)
		{
			Point relativePoint = this.PointToClient(Cursor.Position);
			Point gridStart = new Point(_horizontalStartPosition, _verticalStartPosition);
			Point gridEnd = new Point(_horizontalStartPosition + MaxGridSize, _verticalStartPosition + MaxGridSize);

			int mousePosX = relativePoint.X;
			int mousePosY = relativePoint.Y;
			if ((relativePoint.X >= gridStart.X && relativePoint.X <= gridEnd.X) && (relativePoint.Y >= gridStart.Y && relativePoint.Y <= gridEnd.Y))
			{
				int row = (int)Math.Floor((relativePoint.X - gridStart.X)/(MaxGridSize / (double)GridSize));
				int col = (int)Math.Floor((relativePoint.Y - gridStart.Y)/(MaxGridSize / (double)GridSize));
				int cellStartX = _horizontalStartPosition + (int)Math.Floor(MaxGridSize / (double)GridSize);
				int cellStartY = _verticalStartPosition + (int)Math.Floor(MaxGridSize / (double)GridSize);
				//int cellSize = (int)Math.Floor(MaxGridSize / (double)GridSize);

				//check for position of cell and set it in the list/array as 1 for fill square / 2 for cross.
				DrawCell(row,col, e);

				//redraw
				Invalidate();
			}
			else { 
				MessageBox.Show("outside grid");
			}
		}
		private void DrawCell(int row, int col, EventArgs e) { }
	}
}
