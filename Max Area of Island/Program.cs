using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Area_of_Island
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var grid = new int[][] { new[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, new[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 }, new[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 } };

            Console.WriteLine(s.MaxAreaOfIsland(grid));
        }
    }

    public class Solution
    {
        private readonly (int row, int col)[] directions = new[] { (-1, 0), (0, -1), (0, 1), (1, 0) };


        public int MaxAreaOfIsland(int[][] grid)
        {
            int max = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[0].Length; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        max = Math.Max(max, GetArea(grid, row, col));
                    }
                }
            }

            return max;
        }

        private int GetArea(int[][] grid, int row, int col)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] == 0)
                return 0;

            grid[row][col] = 0;

            int sum = 1;

            foreach (var d in directions)
                sum += GetArea(grid, row + d.row, col + d.col);

            return sum;
        }
    }
}
