using System.Collections.Generic;

namespace Diagonal_Traverse
{
    /// <summary>
    /// Given a matrix of M x N elements (M rows, N columns), return all elements of the matrix in diagonal order as shown in the below image.
    /// </summary>
    public class Solution
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return new int[] { };

            var result = new List<int>();
            int row = 0;
            int col = 0;
            bool up = true;

            do
            {
                result.Add(matrix[row][col]);
            }

            while (Next(matrix, ref row, ref col, ref up));

            return result.ToArray();
        }

        private bool Next(int[][] matrix, ref int row, ref int col, ref bool up)
        {
            if (row == matrix.Length - 1 && col == matrix[row].Length - 1)
            {
                return false;
            }

            if (up)
            {
                if (row > 0 && col + 1 < matrix[row].Length)
                {
                    row--;
                    col++;
                    return true;
                }
                if (col + 1 < matrix[row].Length)
                {
                    col++;
                }
                else
                {
                    row++;
                }

                up = false;
                return true;
            }
            else
            {
                if (row + 1 < matrix.Length && col > 0)
                {
                    row++;
                    col--;
                    return true;
                }
                if (row + 1 < matrix.Length)
                {
                    row++;
                }
                else
                {
                    col++;
                }

                up = true;
                return true;
            }
        }
    }
}
