using System;

namespace Combination_Sum_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1, 2, 3], target = 4
            //Output: 7
            //Explanation:
            //            The possible combination ways are:
            //            (1, 1, 1, 1)
            //            (1, 1, 2)
            //            (1, 2, 1)
            //            (1, 3)
            //            (2, 1, 1)
            //            (2, 2)
            //            (3, 1)
            //Note that different sequences are counted as different combinations.
            Console.WriteLine(s.CombinationSum4(new[] { 1, 2, 3 }, 4));
            //Input: nums = [9], target = 3
            //Output: 0
            Console.WriteLine(s.CombinationSum4(new[] { 9 }, 3));
        }
    }
}
