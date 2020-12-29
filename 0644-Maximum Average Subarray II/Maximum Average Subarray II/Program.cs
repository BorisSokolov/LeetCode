using System;

namespace Maximum_Average_Subarray_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1,12,-5,-6,50,3], k = 4
            //Output: 12.75000
            //Explanation:
            //- When the length is 4, averages are [0.5, 12.75, 10.5] and the maximum average is 12.75
            //- When the length is 5, averages are [10.4, 10.8] and the maximum average is 10.8
            //- When the length is 6, averages are [9.16667] and the maximum average is 9.16667
            //The maximum average is when we choose a subarray of length 4 (i.e., the sub array [12, -5, -6, 50]) which has the max average 12.75, so we return 12.75
            //Note that we do not consider the subarrays of length < 4.
            Console.WriteLine(s.FindMaxAverage(new[] { 1, 12, -5, -6, 50, 3 }, 4));
        }
    }
}
