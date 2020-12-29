using System;

namespace Smallest_Range_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: A = [0, 10], K = 2
            //Output: 6
            //Explanation: B = [2, 8]
            Console.WriteLine(s.SmallestRangeII(new[] { 0, 10}, 2));
        }
    }
}
