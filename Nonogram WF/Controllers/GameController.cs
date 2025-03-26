using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Controllers
{
    class GameController
    {
		public static int[][] initializeGrid(int size) {
			List<int[]> grid = GenerateGrid(size);
			/*
			 * TODO: add new game to user in db
			 * /code here
			*/
			
			return grid.ToArray();
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
		
	}
}
