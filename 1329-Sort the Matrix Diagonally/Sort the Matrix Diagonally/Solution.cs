using System.Collections.Generic;

namespace Sort_the_Matrix_Diagonally
{
    /// <summary>
    /// A matrix diagonal is a diagonal line of cells starting from some cell in either the topmost row or leftmost column and going in the bottom-right direction until reaching the matrix's end. For example, the matrix diagonal starting from mat[2][0], where mat is a 6 x 3 matrix, includes cells mat[2][0], mat[3][1], and mat[4][2].
    /// Given an m x n matrix mat of integers, sort each matrix diagonal in ascending order and return the resulting matrix.
    /// </summary>
    public class Solution
    {
        public int[][] DiagonalSort(int[][] mat)
        {

            var map = new Dictionary<int, List<int>>();     // key= i-j and value is all the values in that diagonal;

            for (int i = 0; i < mat.Length; i++)
            {               // Just add everything to the map;
                for (int j = 0; j < mat[0].Length; j++)
                {

                    var key = i - j;
                    if (!map.ContainsKey(key)) map.Add(key, new List<int>());
                    map[key].Add(mat[i][j]);
                }
            }

            foreach (var key in map.Keys)                   // Since we dont have priority queue in c#, just sort individual rows
                map[key].Sort();

            for (int i = 0; i < mat.Length; i++)
            {               // Pick the first element from the list and remove that element;
                for (int j = 0; j < mat[0].Length; j++)
                {

                    var val = map[i - j][0];
                    mat[i][j] = val;
                    map[i - j].RemoveAt(0);
                }
            }

            return mat;
        }
    }
}
