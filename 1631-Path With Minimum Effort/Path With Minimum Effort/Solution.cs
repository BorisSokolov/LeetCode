using System;
namespace Path_With_Minimum_Effort
{
    /// <summary>
    /// You are a hiker preparing for an upcoming hike. You are given heights, a 2D array of size rows x columns, where heights[row][col] represents the height of cell (row, col). You are situated in the top-left cell, (0, 0), and you hope to travel to the bottom-right cell, (rows-1, columns-1) (i.e., 0-indexed). You can move up, down, left, or right, and you wish to find a route that requires the minimum effort.
    /// A route's effort is the maximum absolute difference in heights between two consecutive cells of the route.
    /// Return the minimum effort required to travel from the top-left cell to the bottom-right cell.
    /// </summary>
    public class Solution
    {
        readonly Tuple<int, int>[] directions =
            {
                Tuple.Create(1, 0),
                Tuple.Create(-1, 0),
                Tuple.Create(0, 1),
                Tuple.Create(0, -1)
            };

        public int MinimumEffortPath(int[][] heights)
        {
            int left = 0;
            int right = 1000000;
            int result = right;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (DfsUtil(heights, mid))
                {
                    result = Math.Min(result, mid);
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return result;
        }

        private bool DfsUtil(int[][] heights, int mid)
        {
            int row = heights.Length;
            int col = heights[0].Length;
            var visited = new bool[row, col];
            return CanReachDestinaton(0, 0, heights, visited, row, col, mid);
        }

        private bool CanReachDestinaton(int x, int y, int[][] heights, bool[,] visited, int row, int col, int mid)
        {
            if (x == row - 1 && y == col - 1)
            {
                return true;
            }

            visited[x, y] = true;
            foreach (var direction in directions)
            {
                int adjacentX = x + direction.Item1;
                int adjacentY = y + direction.Item2;
                if (IsValidCell(adjacentX, adjacentY, row, col) && !visited[adjacentX, adjacentY])
                {
                    int currentDifference = Math.Abs(heights[adjacentX][adjacentY] - heights[x][y]);
                    if (currentDifference <= mid)
                    {
                        if (CanReachDestinaton(adjacentX, adjacentY, heights, visited, row, col, mid))
                            return true;
                    }
                }
            }
            return false;
        }

        private bool IsValidCell(int x, int y, int row, int col)
        {
            return x >= 0 && x <= row - 1 && y >= 0 && y <= col - 1;
        }
    }
}
