using System;
using System.Collections;
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
		//private PaintEventArgs _paint;
		protected int MaxGridSize = 300;//max length of grid
		private int[][] _solutionGrid;
		private int[][] _currentAttemptGrid;
		private Theme _theme = ThemeController.GetTheme();
		private int _horizontalStartPosition = 275;
		private int _verticalStartPosition = 75;
		public int GridSize;
		private int _hintsUsed = 0;
		public GameScreen()
		{
			//GridSize = GridSize + 4;
			InitializeComponent();
			DoubleBuffered = true;
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
			//GameController.initializeGrid(GridSize); // ? wat doet dit in de paint, gebruikt niet eens de return value
			//OnPaint(e);
			SuspendLayout();
			Graphics g = e.Graphics;

			Pen p = new(_theme.PenColor);
			int size = GridSize;
			int cellSize = (int)Math.Floor(MaxGridSize / (double)GridSize);

			for (int i = 0; i <= size; i++)
			{
				// Vertical
				g.DrawLine(p, (i * cellSize) + _horizontalStartPosition, _verticalStartPosition, i * cellSize + _horizontalStartPosition, size * cellSize + _verticalStartPosition);
				// Horizontal
				g.DrawLine(p, _horizontalStartPosition, (i * cellSize) + _verticalStartPosition, size * cellSize + _horizontalStartPosition, i * cellSize + _verticalStartPosition);
			}

			//fill rectangle via current sol
			Color color = _theme.PenColor;

			if (_currentAttemptGrid == null) { return; }
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (_currentAttemptGrid[i][j] == 1)
					{
						e.Graphics.FillRectangle(new SolidBrush(color), cellSize * j + _horizontalStartPosition, cellSize * i + _verticalStartPosition, cellSize, cellSize);
					}
				}
			}
			ResumeLayout(false);
		}

		private void GameScreen_VisibleChanged(object sender, EventArgs e)
		{
			_theme = ThemeController.GetTheme();
			Themes.Theme.ChangeTheme(_theme, Controls);
			//_solutionGrid = GameController.initializeGrid(GridSize);
			//_currentAttemptGrid = new int[GridSize][];
			
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
				if (_currentAttemptGrid[col][row] == 1)
				{
					_currentAttemptGrid[col][row] = 0;
				}
				else { _currentAttemptGrid[col][row] = 1; }
					//_currentAttemptGrid[col][row] == 0 ? _currentAttemptGrid[col][row] = 1 : _currentAttemptGrid[col][row] = 0;

					//redraw
					Refresh();

				//check for win
				logger();
				WinCheck();
			}
		}
		public void setGrid() {
			_solutionGrid = GameController.initializeGrid(GridSize);
			//insert damien stuff for hints

			//continue
			_currentAttemptGrid = new int[GridSize][];
			for (int i = 0; i < GridSize; i++)
			{
				_currentAttemptGrid[i] = new int[GridSize];
				for (int j = 0; j<GridSize;j++)
				{
					_currentAttemptGrid[i][j] = 0;
				}
			}
			logger();
			
		}
		private void WinCheck() {
			if (StructuralComparisons.StructuralEqualityComparer.Equals(_solutionGrid,_currentAttemptGrid))
			{
				MessageBox.Show("Win");

				//set win as history in db
				GameController.SetWin(GridSize-4, _hintsUsed);

				//redirect to home
				this.Hide();
				FindForm().Controls.Find("Home", false).First().Show();


			}
			else { Console.WriteLine("not yet"); }
		}
		private void logger() {
			Console.WriteLine("Sol\n");
			foreach (var item in _solutionGrid)
			{
				foreach (var item1 in item)
				{
					Console.Write((item1.ToString()));
				}
				Console.WriteLine();
			}
			Console.WriteLine("cur");
			//Console.WriteLine();
			foreach (var item in _currentAttemptGrid)
			{
				foreach (var item1 in item)
				{
					Console.Write((item1.ToString()));
				}
				Console.WriteLine();
			}
			//WinCheck();
		}
	}
}
