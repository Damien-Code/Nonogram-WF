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
        public static int[][] initializeGrid(int size)
        {
            int[][] grid = GenerateGrid(size).ToArray();
            CalculateRow(grid);
            /*
			 * TODO: add new game to user in db
			 * /code here
			*/

            return grid;
        }
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
        private static int[] GenerateRow(int n)
        {
            int[] row = new int[n];
            for (int i = 0; i < n; i++)
            {
                row[i] = Random.Shared.Next(0, 2);
            }
            return row;
        }

        public static void SetWin(int level, int hintsUsed)
        {
            Models.History gameHistory = new(level, hintsUsed, false);
            //get all history of user
            (Users currentUser, UserHistory userHistory) = HistoryController.RetrieveHistory();
            Console.WriteLine(userHistory.AllHistory.ToArray()[userHistory.AllHistory.ToArray().Length - 1].Level);
            userHistory.AllHistory.Add(gameHistory);
            Console.WriteLine(userHistory.AllHistory.ToArray()[userHistory.AllHistory.ToArray().Length - 1].Level);
            HistoryController.SetWin(currentUser, new History(level, hintsUsed, false));
        }




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
