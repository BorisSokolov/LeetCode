using System;
using System.Collections.Generic;
using System.Text;

namespace Cherry_Pickup_II
{
    /// <summary>
    /// Given a rows x cols matrix grid representing a field of cherries. Each cell in grid represents the number of cherries that you can collect.
    /// You have two robots that can collect cherries for you, Robot #1 is located at the top-left corner (0,0) , and Robot #2 is located at the top-right corner (0, cols-1) of the grid.
    /// Return the maximum number of cherries collection using both robots by following the rules below:
    /// From a cell(i, j), robots can move to cell(i+1, j-1) , (i+1, j) or(i+1, j+1).
    /// When any robot is passing through a cell, It picks it up all cherries, and the cell becomes an empty cell(0).
    /// When both robots stay on the same cell, only one of them takes the cherries.
    /// Both robots cannot move outside of the grid at any moment.
    /// Both robots should reach the bottom row in the grid.
    /// </summary>
    public class Solution
    {

        public int CherryPickup(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            var dp = new int[m, n, n];

            for (int row = m - 1; row >= 0; row--)
            {
                for (int col1 = 0; col1 < n; col1++)
                {
                    for (int col2 = 0; col2 < n; col2++)
                    {
                        int result = 0;
                        // current cell
                        result += grid[row][col1];
                        if (col1 != col2)
                        {
                            result += grid[row][col2];
                        }
                        // transition
                        if (row != m - 1)
                        {
                            int max = 0;
                            for (int newCol1 = col1 - 1; newCol1 <= col1 + 1; newCol1++)
                            {
                                for (int newCol2 = col2 - 1; newCol2 <= col2 + 1; newCol2++)
                                {
                                    if (newCol1 >= 0 && newCol1 < n && newCol2 >= 0 && newCol2 < n)
                                    {
                                        max = Math.Max(max, dp[row + 1, newCol1, newCol2]);
                                    }
                                }
                            }
                            result += max;
                        }
                        dp[row, col1, col2] = result;
                    }
                }
            }
            return dp[0, 0, n - 1];
        }
    }
}
