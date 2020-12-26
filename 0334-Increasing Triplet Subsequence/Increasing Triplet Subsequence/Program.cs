using System;

namespace Increasing_Triplet_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1, 2, 3, 4, 5]
            //Output: true
            //Explanation: Any triplet where i<j < k is valid.
            Console.WriteLine(s.IncreasingTriplet(new[] { 1, 2, 3, 4, 5 }));
            //Input: nums = [5, 4, 3, 2, 1]
            //Output: false
            //Explanation: No triplet exists.
            Console.WriteLine(s.IncreasingTriplet(new[] { 5, 4, 3, 2, 1 }));
            //Input: nums = [2, 1, 5, 0, 4, 6]
            //Output: true
            //Explanation: The triplet(3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
            Console.WriteLine(s.IncreasingTriplet(new[] { 2, 1, 5, 0, 4, 6 }));
        }
    }
}
