using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Minimize Maximum Pair Sum in Array
    /// </summary>
    public class Solution
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);

            int max = 0;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                int sum = nums[i] + nums[^(i + 1)];
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
