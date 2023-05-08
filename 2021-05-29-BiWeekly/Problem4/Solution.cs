using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem4
{
    /// <summary>
    /// Minimum XOR Sum of Two Arrays
    /// </summary>
    public class Solution
    {
        public int MinimumXORSum(int[] nums1, int[] nums2)
        {
            var perumations = GetPermutations(nums2, nums2.Length);

            int min = int.MaxValue;
            foreach (var p in perumations)
            {
                int sum = 0;
                var a = p.ToArray();
                for (int i = 0; i < nums1.Length; i++)
                {
                    sum += nums1[i] ^ a[i];
                }

                min = Math.Min(sum, min);
            }

            return min;
        }

        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
