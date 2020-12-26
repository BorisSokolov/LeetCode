using System;

namespace Burst_Balloons
{
    /// <summary>
    /// Given n balloons, indexed from 0 to n-1. Each balloon is painted with a number on it represented by array nums. You are asked to burst all the balloons. If the you burst balloon i you will get nums[left] * nums[i] * nums[right] coins. Here left and right are adjacent indices of i. After the burst, the left and right then becomes adjacent.
    /// Find the maximum coins you can collect by bursting the balloons wisely.
    /// Note:
    /// You may imagine nums[-1] = nums[n] = 1.They are not real therefore you can not burst them.
    /// 0 ≤ n ≤ 500, 0 ≤ nums[i] ≤ 100
    /// </summary>
    public class Solution
    {
        public int MaxCoins(int[] nums)
        {
            // reframe the problem
            int n = nums.Length + 2;
            int[] newNums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                newNums[i + 1] = nums[i];
            }

            newNums[0] = newNums[n - 1] = 1;

            // dp will store the results of our calls
            var dp = new int[n, n];

            // iterate over dp and incrementally build up to dp[0][n-1]
            for (int left = n - 2; left > -1; left--)
                for (int right = left + 2; right < n; right++)
                {
                    for (int i = left + 1; i < right; ++i)
                        // same formula to get the best score from (left, right) as before
                        dp[left, right] = Math.Max(dp[left, right],
                        newNums[left] * newNums[i] * newNums[right] + dp[left, i] + dp[i, right]);
                }

            return dp[0, n - 1];
        }
    }
}
