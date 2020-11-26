using System;

namespace Smallest_Integer_Divisible_by_K
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: K = 1
            //Output: 1
            //Explanation: The smallest answer is N = 1, which has length 1.
            Console.WriteLine(s.SmallestRepunitDivByK(1));

            //Input: K = 3
            //Output: 3
            //Explanation: The smallest answer is N = 111, which has length 3.
            Console.WriteLine(s.SmallestRepunitDivByK(3));
        }
    }
}
