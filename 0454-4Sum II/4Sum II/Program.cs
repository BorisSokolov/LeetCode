using System;

namespace _4Sum_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input:
            //A = [1, 2]
            //B = [-2, -1]
            //C = [-1, 2]
            //D = [0, 2]

            //Output:            2

            //Explanation:
            //The two tuples are:
            //1. (0, 0, 0, 1)->A[0] + B[0] + C[0] + D[1] = 1 + (-2) + (-1) + 2 = 0
            //2. (1, 1, 0, 0)->A[1] + B[1] + C[0] + D[0] = 2 + (-1) + (-1) + 0 = 0
            Console.WriteLine(s.FourSumCount(new[] { 1, 2 }, new[] { -2, -1 }, new[] { -1, 2 }, new[] { 0, 2 }));
        }
    }
}
