using System;

namespace Maximum_Average_Subarray_II
{
    /// <summary>
    /// You are given an integer array nums consisting of n elements, and an integer k.
    /// Find a contiguous subarray whose length is greater than or equal to k that has the maximum average value and return this value.Any answer with a calculation error less than 10e-5 will be accepted.
    /// </summary>
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double max = nums[0];
            double min = nums[0];

            foreach (var val in nums)
            {
                max = Math.Max(max, val);
                min = Math.Min(min, val);
            }

            while (max - min > 0.00001)
            {
                double mid = (max + min) / 2;
                if (Check(nums, mid, k))
                    min = mid;
                else
                    max = mid;
            }

            return min;
        }

        private bool Check(int[] nums, double mid, int k)
        {
            double sum = 0;
            double prev = 0;
            double minSum = 0;

            for (int i = 0; i < k; i++)
                sum += nums[i] - mid;

            if (sum >= 0)
                return true;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - mid;
                prev += nums[i - k] - mid;
                minSum = Math.Min(prev, minSum);
                if (sum >= minSum)
                    return true;
            }

            return false;
        }
    }
}
