using System;

namespace Get_Maximum_in_Generated_Array
{
    /// <summary>
    /// You are given an integer n. An array nums of length n + 1 is generated in the following way:
    /// nums[0] = 0
    /// nums[1] = 1
    /// nums[2 * i] = nums[i] when 2 <= 2 * i <= n
    /// nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n
    /// Return the maximum integer in the array nums​​​.
    /// </summary>
    public class Solution
    {
        public int GetMaximumGenerated(int n)
        {
            if (n <= 1)
                return n;

            int[] nums = new int[n + 1];
            nums[0] = 0;
            nums[1] = 1;
            int maximumValue = 1;

            for (int i = 1; i <= n / 2; i++)
            {
                nums[i * 2] = nums[i];
                if (i * 2 + 1 <= n)
                {
                    nums[i * 2 + 1] = nums[i] + nums[i + 1];
                    maximumValue = Math.Max(maximumValue, nums[i * 2 + 1]);
                }
            }
            return maximumValue;
        }
    }
}
