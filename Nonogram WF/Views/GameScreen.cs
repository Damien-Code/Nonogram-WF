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
using Nonogram_WF.Themes;

namespace Nonogram_WF.Views
{
	public partial class GameScreen : UserControl
	{
		public int GridSize;
		protected int MaxGridSize = 400;//max length of grid
		private List<int[]> _grid;
		private Theme _theme = ThemeController.GetTheme();
		private int _horizontalStartPosition = 375;
		private int _verticalStartPosition = 175;
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
			base.OnPaint(e);
			Graphics g = e.Graphics;

			Pen p = new(_theme.PenColor); 
			int TotalCellsPerRow = GridSize;
			//int cellSize = 30;
			int cellSize = (int)Math.Floor(MaxGridSize / (double)GridSize);
			//int horizontalStartPosition = 375;
			//int verticalStartPosition = 175;

			for (int i = 0; i <= TotalCellsPerRow; i++)
			{
				// Vertical
				g.DrawLine(p, (i * cellSize) + _horizontalStartPosition, _verticalStartPosition, i * cellSize + _horizontalStartPosition, TotalCellsPerRow * cellSize + _verticalStartPosition);
				// Horizontal
				g.DrawLine(p, _horizontalStartPosition, (i * cellSize) + _verticalStartPosition, TotalCellsPerRow * cellSize + _horizontalStartPosition, i * cellSize + _verticalStartPosition);
			}
		}

		private void GameScreen_VisibleChanged(object sender, EventArgs e)
		{
			_theme = ThemeController.GetTheme();

			Themes.Theme.ChangeTheme(_theme, Controls);
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
			//int gridPositionStartX = _horizontalStartPosition;
			//int gridPositionStartY = _verticalStartPosition;
			//int gridPositionEndX = _horizontalStartPosition + MaxGridSize;
			//int gridPositionEndY = _verticalStartPosition + MaxGridSize;
			//Point x = Cursor.Position;
			int mousePosX = relativePoint.X;
			int mousePosY = relativePoint.Y;
			if ((relativePoint.X >= gridStart.X && relativePoint.X <= gridEnd.X) && (relativePoint.Y >= gridStart.Y && relativePoint.Y <= gridEnd.Y))
			{
				MessageBox.Show("inside grid");
			}
			else { 
				MessageBox.Show("outside grid");
			}
			//MessageBox.Show($"start: {gridPositionStartX}, {gridPositionStartY}\nend: {gridPositionEndX}, {gridPositionEndY}\nMouse: {x}, {y}\nMouseGrid: {x - gridPositionStartX}, {y - gridPositionStartY}\n Relative: {relativePoint.X}, {relativePoint.Y}");
		}
	}
}
