using Nonogram_WF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Controllers
{
    public class GameController
    {
        /// <summary>
        /// start function to generate grid
        /// </summary>
        /// <param name="size"></param>
        /// <returns>int[][]</returns>
        public static int[][] InitializeGrid(int size)
        {
            int[][] grid = GenerateGrid(size).ToArray();
            CalculateRow(grid);

            return grid;
        }
        /// <summary>
        /// generates grid
        /// </summary>
        /// <param name="size"></param>
        /// <returns>List<int[]></returns>
        private static List<int[]> GenerateGrid(int size)
        {
            List<int[]> grid = new();
            //add a new row to the grid list up to the amount {size}.
            for (int i = 0; i < size; i++)
            {
                grid.Add(GenerateRow(size));
            }
            return grid;
        }
        /// <summary>
        /// generates row and returns said row
        /// </summary>
        /// <param name="n"></param>
        /// <returns>int[]</returns>
        private static int[] GenerateRow(int n)
        {
            int[] row = new int[n];
            for (int i = 0; i < n; i++)
            {
                row[i] = Random.Shared.Next(0, 2);
            }
            return row;
        }
        /// <summary>
        /// sets win in data.json
        /// </summary>
        /// <param name="level"></param>
        /// <param name="hintsUsed"></param>
        public static void SetWin(int level, int hintsUsed, bool solverUsed)
        {
            Models.History gameHistory = new(level, hintsUsed, solverUsed);
            //get all history of user
            (Users currentUser, UserHistory userHistory) = HistoryController.RetrieveHistory();
            userHistory.AllHistory.Add(gameHistory);
            HistoryController.SetWin(currentUser, new History(level, hintsUsed, solverUsed));
        }



        /// <summary>
        /// calculates the hints for the rows and returns them as a list of list of ints
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>List<List<int>></returns>
        public static List<List<int>> CalculateRow(int[][] grid)
        {
            List<List<int>> returnList = new List<List<int>>();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                List<int> tmp_list = new List<int>();
                int sum = 0;

                for (int j = 0; j < grid[i].GetLength(0); j++)
                {
                    if (grid[i][j] == 1)
                    {
                        sum += 1;
                    }

                    else if (grid[i][j] == 0 && sum > 0)
                    {
                        tmp_list.Add(sum);
                        sum = 0;
                    }
                }

                if (sum > 0)
                {
                    tmp_list.Add(sum);
                }
                else if (sum == 0 && tmp_list.Count == 0)
                {
                    tmp_list.Add(0);
                }
                returnList.Add(tmp_list);
            }
            return returnList;
        }
        /// <summary>
        /// calculates the hints for the columns and returns them as a list of list of ints
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>List<List<int>></returns>
        public static List<List<int>> CalculateCol(int[][] grid)
        {
            List<List<int>> returnList = new List<List<int>>();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                List<int> tmp_list = new List<int>();
                int sum = 0;
                for (int j = 0; j < grid[i].GetLength(0); j++)
                {
                    if (grid[j][i] == 1)
                    {
                        sum += 1;
                    }

                    else if (grid[j][i] == 0 && sum > 0)
                    {
                        tmp_list.Add(sum);
                        sum = 0;
                    }
                }
                if (sum > 0)
                {
                    tmp_list.Add(sum);
                }
                else if (sum == 0 && tmp_list.Count == 0)
                {
                    tmp_list.Add(0);
                }
                returnList.Add(tmp_list);
            }
            return returnList;
        }

    }

}
