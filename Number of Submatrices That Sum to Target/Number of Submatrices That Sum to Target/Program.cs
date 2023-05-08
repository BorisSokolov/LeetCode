using System;

namespace Number_of_Submatrices_That_Sum_to_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: matrix = [[0, 1, 0],[1,1,1],[0,1,0]], target = 0
            //Output: 4
            //Explanation: The four 1x1 submatrices that only contain 0.
            Console.WriteLine(s.NumSubmatrixSumTarget(new int[][] { new[] { 0, 1, 0 }, new[] { 1, 1, 1 }, new[] { 0, 1, 0} }, 0));
            //Input: matrix = [[1,-1],[-1,1]], target = 0
            //Output: 5
            //Explanation: The two 1x2 submatrices, plus the two 2x1 submatrices, plus the 2x2 submatrix.
            Console.WriteLine(s.NumSubmatrixSumTarget(new int[][] { new[] { 1, -1}, new[] { -1, 1 } }, 0));
            //Input: matrix = [[904]], target = 0
            //Output: 0
            Console.WriteLine(s.NumSubmatrixSumTarget(new int[][]{ new []{ 904 }}, 0));
        }
    }
}
