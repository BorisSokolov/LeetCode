using System;

namespace Check_If_All_1_s_Are_at_Least_Length_K_Places_Away
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1, 0, 0, 0, 1, 0, 0, 1], k = 2
            //Output: true
            //Explanation: Each of the 1s are at least 2 places away from each other.
            Console.WriteLine(s.KLengthApart(new[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2));
            //Input: nums = [1, 0, 0, 1, 0, 1], k = 2
            //Output: false
            //Explanation: The second 1 and third 1 are only one apart from each other.
            Console.WriteLine(s.KLengthApart(new[] { 1, 0, 0, 1, 0, 1 }, 2));
            //Input: nums = [1, 1, 1, 1, 1], k = 0
            //Output: true
            Console.WriteLine(s.KLengthApart(new[] { 1, 1, 1, 1, 1 }, 0));
            //Input: nums = [0, 1, 0, 1], k = 1
            //Output: true
            Console.WriteLine(s.KLengthApart(new[] { 0, 1, 0, 1 }, 1));
        }
    }
}
