using System;

namespace The_kth_Factor_of_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: n = 12, k = 3
            //Output: 3
            //Explanation: Factors list is [1, 2, 3, 4, 6, 12], the 3rd factor is 3.
            Console.WriteLine(s.KthFactor(12,3));
        }
    }
}
