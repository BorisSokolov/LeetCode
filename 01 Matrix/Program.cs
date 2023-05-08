using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var mat = new int[][] { new[] { 0, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 0 }};
            var res = s.UpdateMatrix(mat);
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            if (mat == null || !mat.Any())
                return mat;

            int rowCount = mat.Length;
            int colCount = mat[0].Length;

            var result = new int[rowCount][];
            var queue = new Queue<(int row, int col)>();

            for (int i = 0; i < rowCount; i++)
            {
                result[i] = new int[colCount];

                for (int j = 0; j < colCount; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        result[i][j] = 0;
                        queue.Enqueue((i, j));
                    }
                    else
                    {
                        result[i][j] = int.MaxValue;
                    }
                }
            }

            (int row, int col)[] directions = new[] { (-1, 0), (0, -1), (0, 1), (1, 0) };

            while (queue.Any())
            {
                var (row, col) = queue.Dequeue();

                foreach (var d in directions)
                {
                    (int row, int col) n = (row + d.row, col + d.col);

                    if (n.row >= 0 && n.col >= 0 && n.row < rowCount && n.col < colCount && result[n.row][n.col] > result[row][col] + 1)
                    {
                        result[n.row][n.col] = result[row][col] + 1;
                        queue.Enqueue(n);
                    }
                }
            }

            return result;
        }
    }
}
