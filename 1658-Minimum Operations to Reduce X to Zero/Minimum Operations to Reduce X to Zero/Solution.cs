using System;
using System.Linq;

namespace Minimum_Operations_to_Reduce_X_to_Zero
{
    /// <summary>
    /// You are given an integer array nums and an integer x. In one operation, you can either remove the leftmost or the rightmost element from the array nums and subtract its value from x. Note that this modifies the array for future operations.
    /// Return the minimum number of operations to reduce x to exactly 0 if it's possible, otherwise, return -1.
    /// </summary>
    public class Solution
    {
        public int MinOperations(int[] nums, int x)
        {
            int current = nums.Sum();
            int n = nums.Length;
            int min = int.MaxValue;

            for (int left = 0, right = 0; right < n; right++)
            {
                // sum([0,..,left) + (right,...,n-1]) = x
                current -= nums[right];
                // if smaller, move `left` to left
                while (current < x && left <= right)
                    current += nums[left++];

                // check if equal
                if (current == x)
                    min = Math.Min(min, n - 1 - right + left);
            }
            return min != int.MaxValue ? min : -1;
        }
    }
}
