using System;

namespace Sliding_Window_Maximum
{
    /// <summary>
    /// You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.
    /// Return the max sliding window.
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="k">Sliding window size</param>
        /// <returns></returns>
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;

            if (n * k == 0)
                return new int[0];

            if (k == 1)
                return nums;

            int[] left = new int[n];
            left[0] = nums[0];
            int[] right = new int[n];
            right[n - 1] = nums[n - 1];

            for (int i = 1; i < n; i++)
            {
                // from left to right
                if (i % k == 0)
                    left[i] = nums[i];  // block_start
                else
                    left[i] = Math.Max(left[i - 1], nums[i]);

                // from right to left
                int j = n - i - 1;
                if ((j + 1) % k == 0)
                    right[j] = nums[j];  // block_end
                else
                    right[j] = Math.Max(right[j + 1], nums[j]);
            }

            int[] output = new int[n - k + 1];
            for (int i = 0; i < n - k + 1; i++)
                output[i] = Math.Max(left[i + k - 1], right[i]);

            return output;
        }
    }
}
