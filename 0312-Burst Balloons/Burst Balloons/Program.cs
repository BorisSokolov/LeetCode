using System;

namespace Burst_Balloons
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Output: 167
            //Explanation: nums = [3, 1, 5, 8]-- > [3, 5, 8]-- >   [3, 8]-- >  [8]-- > []
            //             coins = 3 * 1 * 5 + 3 * 5 * 8 + 1 * 3 * 8 + 1 * 8 * 1 = 167
            Console.WriteLine(s.MaxCoins(new[] { 3, 1, 5, 8 }));
        }
    }
}
