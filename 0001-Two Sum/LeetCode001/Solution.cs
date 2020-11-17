using System.Collections.Generic;

namespace LeetCode001
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var sum = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (sum.ContainsKey(nums[i]))
                {
                    return new int[] { sum[nums[i]], i };
                }

                sum[target - nums[i]] = i;
            }

            return null;
        }
    }
}
