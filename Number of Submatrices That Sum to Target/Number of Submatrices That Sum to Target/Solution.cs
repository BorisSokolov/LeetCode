using System.Collections.Generic;

namespace Number_of_Submatrices_That_Sum_to_Target
{
    public class Solution
    {
        public int NumSubmatrixSumTarget(int[][] matrix, int target)
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            // Using a 2D prefix sum, we can query the sum of any submatrix in O(1) time. 
            // https://en.wikipedia.org/wiki/Prefix_sum
            int[,] ps = new int[rowCount + 1, colCount + 1];

            for (int i = 1; i <= rowCount; i++)
                for (int j = 1; j <= colCount; j++)
                {
                    ps[i, j] = ps[i - 1, j] + ps[i, j - 1] - ps[i - 1, j - 1] + matrix[i - 1][j - 1];
                }

            // Now for each(r1, r2), we can find the largest sum of a submatrix
            // that uses every row in [r1, r2] in linear time using a sliding window.
            int sum = 0;
            int current;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int r1 = 1; r1 <= rowCount; r1++)
                for (int r2 = r1; r2 <= rowCount; r2++)
                {
                    dict.Clear();
                    dict.Add(0, 1);

                    for (int c = 1; c <= colCount; c++)
                    {
                        // 1D prefix sum
                        current = ps[r2, c] - ps[r1 - 1, c];

                        // add subarrays which sum up to (currSum - target)
                        if (dict.TryGetValue(current - target, out int val))
                            sum += val;

                        if (dict.ContainsKey(current))
                            dict[current]++;
                        else
                            dict.Add(current, 1);
                    }
                }

            return sum;
        }
    }
}
