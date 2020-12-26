using System;
using System.Collections.Generic;
using System.Text;

namespace Spiral_Matrix_II
{
    /// <summary>
    /// Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.
    /// </summary>
    public class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
                result[i] = new int[n];

            int cnt = 1;
            var dir = new[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
            int d = 0;
            int row = 0;
            int col = 0;
            while (cnt <= n * n)
            {
                result[row][col] = cnt++;
                int r = MathMod(row + dir[d, 0], n);
                int c = MathMod(col + dir[d, 1], n);

                // change direction if next cell is non zero
                if (result[r][c] != 0) d = (d + 1) % 4;

                row += dir[d, 0];
                col += dir[d, 1];
            }
            return result;
        }

        static int MathMod(int a, int b)
        {
            return (Math.Abs(a * b) + a) % b;
        }
    }
}
