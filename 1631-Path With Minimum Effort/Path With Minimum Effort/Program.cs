using System;

namespace Path_With_Minimum_Effort
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: heights = [[1, 2, 2],[3,8,2],[5,3,5]]
            //Output: 2
            //Explanation: The route of[1, 3, 5, 3, 5] has a maximum absolute difference of 2 in consecutive cells.
            //   This is better than the route of[1, 2, 2, 2, 5], where the maximum absolute difference is 3.
            Console.WriteLine(s.MinimumEffortPath(new int[][] { new[] { 1, 2, 2 }, new[] { 3, 8, 2 }, new[] { 5, 3, 5 } }));
            //Input: heights = [[1, 2, 3], [3,8,4], [5,3,5]]
            //Output: 1
            //Explanation: The route of[1, 2, 3, 4, 5] has a maximum absolute difference of 1 in consecutive cells, which is better than route[1, 3, 5, 3, 5].
            Console.WriteLine(s.MinimumEffortPath(new int[][] { new[] { 1, 2, 3 }, new[] { 3, 8, 4 }, new[] { 5, 3, 5 } }));
            //Input: heights = [[1,2,1,1,1],[1,2,1,2,1],[1,2,1,2,1],[1,2,1,2,1],[1,1,1,2,1]]
            //Output: 0
            //Explanation: This route does not require any effort.
            Console.WriteLine(s.MinimumEffortPath(new int[][]{ new[] { 1, 2, 1, 1, 1 }, new[] { 1, 2, 1, 2, 1 }, new[] { 1, 2, 1, 2, 1 }, new[] { 1, 1, 1, 2, 1 } }));
        }
    }
}
