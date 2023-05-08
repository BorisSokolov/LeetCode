using System;

namespace Coin_Change
{
    /// <summary>
    /// You are given coins of different denominations and a total amount of money amount. Write a function to compute the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.
    /// You may assume that you have an infinite number of each kind of coin.
    /// </summary>
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[max];

            for(int i = 1; i < max; i++)
            {
                dp[i] = max;

                foreach (int coin in coins)
                {
                    if (i >= coin)
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}
