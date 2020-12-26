using System;

namespace Smallest_Range_II
{
    /// <summary>
    /// Given an array A of integers, for each integer A[i] we need to choose either x = -K or x = K, and add x to A[i] (only once).
    /// After this process, we have some array B.
    /// Return the smallest possible difference between the maximum value of B and the minimum value of B.
    /// </summary>
    public class Solution
    {
        public int SmallestRangeII(int[] a, int k)
        {
            Array.Sort(a);
            int ans = a[^1] - a[0];

            for (int i = 0; i < a.Length - 1; ++i)
            {
                int high = Math.Max(a[^1] - k, a[i] + k);
                int low = Math.Min(a[0] + k, a[i + 1] - k);
                ans = Math.Min(ans, high - low);
            }
            return ans;
        }
    }
}
