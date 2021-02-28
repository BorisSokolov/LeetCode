using System.Collections.Generic;

namespace Max_Number_of_K_Sum_Pairs
{
    /// <summary>
    /// You are given an integer array nums and an integer k.
    /// In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.
    /// Return the maximum number of operations you can perform on the array.
    /// </summary>
    public class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                int complement = k - current;
                if (map.TryGetValue(complement, out int val1) && val1 > 0)
                {
                    // remove complement from the map
                    map[complement] = val1 - 1;
                    count++;
                }
                else
                {
                    // add current element in the map
                    map[current] = map.TryGetValue(current, out int val2) ? val2 + 1 : 1;
                }
            }
            return count;
        }
    }
}
