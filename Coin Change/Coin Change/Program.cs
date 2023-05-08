using System;

namespace Coin_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: coins = [1, 2, 5], amount = 11
            //Output: 3
            //Explanation: 11 = 5 + 5 + 1
            Console.WriteLine(s.CoinChange(new[] { 1, 2, 5 }, 11));
            //Input: coins = [2], amount = 3
            //Output: -1
            Console.WriteLine(s.CoinChange(new[] { 2 }, 3));
            //Input: coins = [1], amount = 0
            //Output: 0
            Console.WriteLine(s.CoinChange(new[] { 1 }, 0));
            //Input: coins = [1], amount = 1
            //Output: 1
            Console.WriteLine(s.CoinChange(new[] { 1 }, 1));
            //Input: coins = [1], amount = 2
            //Output: 2
            Console.WriteLine(s.CoinChange(new[] { 1 }, 2));
        }
    }
}
