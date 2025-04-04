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
        protected int MaxGridSize = 200;//max length of grid
        private int[][] _solutionGrid;
        private int[][] _currentAttemptGrid;
        private int[][] _currentGridMask;
        private Theme _theme = ThemeController.GetTheme();
        private int _horizontalStartPosition = (Screen.PrimaryScreen.WorkingArea.Left + Screen.PrimaryScreen.WorkingArea.Width) / 5;
        private int _verticalStartPosition = (Screen.PrimaryScreen.WorkingArea.Top + Screen.PrimaryScreen.WorkingArea.Height) / 5;
      
        
        public int GridSize;
        private int _hintsUsed = 0;
        public GameScreen()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
            Pen Xpen = new Pen(Color.Red, 2);
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
                    else if (_currentAttemptGrid[i][j] == 2)
                    {
                        g.DrawLine(Xpen, cellSize * j + _horizontalStartPosition, cellSize * i + _verticalStartPosition, cellSize * j + _horizontalStartPosition + cellSize, cellSize * i + _verticalStartPosition + cellSize);
                        g.DrawLine(Xpen, cellSize * j + _horizontalStartPosition + cellSize, cellSize * i + _verticalStartPosition, cellSize * j + _horizontalStartPosition, cellSize * i + _verticalStartPosition + cellSize);
                    }
                }
            }
            ResumeLayout(false);
        }


        private void GameScreen_VisibleChanged(object sender, EventArgs e)
        {
            _theme = ThemeController.GetTheme();

            Themes.Theme.ChangeTheme(_theme, Controls);

        }


        public void setGrid()
        {
            _solutionGrid = GameController.initializeGrid(GridSize);
            RemoveLabels();
            SetLabels();


            _currentAttemptGrid = new int[GridSize][];
            _currentGridMask = new int[GridSize][];

            for (int i = 0; i < GridSize; i++)
            {
                _currentAttemptGrid[i] = new int[GridSize];
                _currentGridMask[i] = new int[GridSize];
                for (int j = 0; j < GridSize; j++)
                {
                    _currentAttemptGrid[i][j] = 0;
                    _currentGridMask[i][j] = 0;
                }
            }
            logger();

        }
        private void SetLabels()
        {
            CreateColLabels();
            CreateRowLabels();
        }


        private void WinCheck()
        {
            if (StructuralComparisons.StructuralEqualityComparer.Equals(_solutionGrid, _currentGridMask))
            {
                MessageBox.Show("Win");

                //set win as history in db
                GameController.SetWin(GridSize - 4, _hintsUsed);

                //saves game in db


                //redirect to home
                this.Hide();
                FindForm().Controls.Find("Home", false).First().Show();


            }
            else { Console.WriteLine("not yet"); }
        }
        private void logger()
        {
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
            Console.WriteLine("mask");
            //Console.WriteLine();
            foreach (var item in _currentGridMask)
            {
                foreach (var item1 in item)
                {
                    Console.Write((item1.ToString()));
                }
                Console.WriteLine();
            }
            //WinCheck();
        }


        public void ThemeChange()
        {
            _theme = ThemeController.GetTheme();
            Themes.Theme.ChangeTheme(_theme, Controls);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }



        private void buttonGameScreenHint_Click(object sender, EventArgs e)
        {

        }

        public void CreateRowLabels()
        {
            Point gridStart = new Point(_horizontalStartPosition, _verticalStartPosition);
            int cellSize = (int)Math.Floor(MaxGridSize / (double)GridSize);
            List<List<int>> RowHints = GameController.CalculateRow(_solutionGrid);
            Font font = new("ariel", cellSize, FontStyle.Regular, GraphicsUnit.Pixel);
            for (int i = 0; i < RowHints.Count; i++)
            {

                int labelStart = gridStart.X - (RowHints[i].Count * (cellSize));

                for (int j = 0; j < RowHints[i].Count; j++)
                {
                    Label label = new Label();
                    label.Size = new Size(cellSize, cellSize);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = font;
                    label.Name = "lblHint";

                    label.Location = new Point(labelStart + (j * cellSize), gridStart.Y + (i * cellSize));
                    label.Text = RowHints[i][j].ToString();

                    panel1.Controls.Add(label);
                }
            }
        }

        public void CreateColLabels()
        {
            Point gridStart = new Point(_horizontalStartPosition, _verticalStartPosition);
            int cellSize = (int)Math.Floor(MaxGridSize / (double)GridSize);

            List<List<int>> ColHints = GameController.CalculateCol(_solutionGrid);
            Font font = new("ariel", cellSize, FontStyle.Regular, GraphicsUnit.Pixel);

            for (int i = 0; i < ColHints.Count; i++)
            {

                int labelStart = gridStart.Y - (ColHints[i].Count * (cellSize));

                for (int j = 0; j < ColHints[i].Count; j++)
                {
                    Label label = new Label();
                    label.Size = new Size(cellSize, cellSize);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = font;
                    label.Name = "lblHint";

                    label.Location = new Point(gridStart.X + (i * cellSize), labelStart + (j * cellSize));
                    label.Text = ColHints[i][j].ToString();

                    panel1.Controls.Add(label);
                }
            }
        }

        /// <summary>
        /// Removes the labels because choosing another difficulty would result in hint overlap
        /// </summary>
        private void RemoveLabels()
        {

            panel1.Controls.Find("lblHint", false).ToList().ForEach(x => x.Dispose());

            Refresh();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point relativePoint = this.PointToClient(Cursor.Position);
            Point gridStart = new Point(_horizontalStartPosition, _verticalStartPosition);
            Point gridEnd = new Point(_horizontalStartPosition + MaxGridSize, _verticalStartPosition + MaxGridSize);

            int mousePosX = relativePoint.X;
            int mousePosY = relativePoint.Y;
            if ((relativePoint.X >= gridStart.X && relativePoint.X <= gridEnd.X) && (relativePoint.Y >= gridStart.Y && relativePoint.Y <= gridEnd.Y))
            {
                int row = (int)Math.Floor((relativePoint.X - gridStart.X) / (MaxGridSize / (double)GridSize));
                int col = (int)Math.Floor((relativePoint.Y - gridStart.Y) / (MaxGridSize / (double)GridSize));
                int cellStartX = _horizontalStartPosition + (int)Math.Floor(MaxGridSize / (double)GridSize);
                int cellStartY = _verticalStartPosition + (int)Math.Floor(MaxGridSize / (double)GridSize);

                //check for position of cell and set it in the list/array as 1 for fill square / 2 for cross.
                if (e.Button == MouseButtons.Left)
                {

                    if (_currentAttemptGrid[col][row] == 1)
                    {
                        _currentAttemptGrid[col][row] = 0;
                        _currentGridMask[col][row] = 0;
                    }
                    else
                    {
                        _currentAttemptGrid[col][row] = 1;
                        _currentGridMask[col][row] = 1;
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (_currentAttemptGrid[col][row] == 2)
                    {
                        _currentAttemptGrid[col][row] = 0;
                    }
                    else
                    {
                        _currentAttemptGrid[col][row] = 2;
                        _currentGridMask[col][row] = 0;
                    }
                }

                //redraw
                Refresh();

                //check for win
                logger();
                WinCheck();
            }
        }

        private void buttonGameScreenSolve_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            MessageBox.Show($"X:{g.DpiX}\nY:{g.DpiY}");
            _currentAttemptGrid = _solutionGrid;
            Refresh();
            MessageBox.Show("You did not fully solve it yourself.\nwont advance to the next level");
            buttonGameScreenBack_Click(sender, e);

        }
    }
}
