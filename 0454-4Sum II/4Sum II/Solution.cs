using System.Collections.Generic;

namespace _4Sum_II
{
    /// <summary>
    /// Given four lists A, B, C, D of integer values, compute how many tuples (i, j, k, l) there are such that A[i] + B[j] + C[k] + D[l] is zero.
    /// To make problem a bit easier, all A, B, C, D have same length of N where 0 ≤ N ≤ 500. All integers are in the range of -228 to 228 - 1 and the result is guaranteed to be at most 231 - 1.
    /// </summary>
    public class Solution
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            // We can transform A[i] + B[j] + C[k] + D[l] = 0 into A[i] + B[j] = -C[k] - D[l]
            int count = 0;
            var dict = new Dictionary<int, int>();

            foreach (var a in A)
                foreach (var b in B)
                    dict[a + b] = dict.GetValueOrDefault(a + b, 0) + 1;

            foreach (var c in C)
                foreach (var d in D)
                    count += dict.GetValueOrDefault(-c - d, 0);

            return count;
        }
    }
}
