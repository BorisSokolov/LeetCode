using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode200
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;

                        SinkIsland(grid, i, j);
                    }
                }
            }

            return count;
        }

        private void SinkIsland(char[][] grid, int row, int col)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length || grid[row][col] == '0')
            {
                return;
            }

            grid[row][col] = '0';

            SinkIsland(grid, row - 1, col);
            SinkIsland(grid, row + 1, col);
            SinkIsland(grid, row, col + 1);
            SinkIsland(grid, row, col - 1);
        }
    }
}
