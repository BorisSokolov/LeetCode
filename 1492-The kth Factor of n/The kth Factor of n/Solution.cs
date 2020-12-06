using System;
using System.Collections.Generic;

namespace The_kth_Factor_of_n
{
    /// <summary>
    /// Given two positive integers n and k.
    /// A factor of an integer n is defined as an integer i where n % i == 0.
    /// Consider a list of all factors of n sorted in ascending order, return the kth factor in this list or return -1 if n has less than k factors.
    /// </summary>
    public class Solution
    {
        public int KthFactor(int n, int k)
        {
            var divisors = new List<int>();
            int sqrtN = (int)Math.Sqrt(n);
            for (int x = 1; x < sqrtN + 1; ++x)
            {
                if (n % x == 0)
                {
                    --k;
                    divisors.Add(x);
                    if (k == 0)
                    {
                        return x;
                    }
                }
            }

            // If n is a perfect square
            // we have to skip the duplicate 
            // in the divisor list
            if (sqrtN * sqrtN == n)
            {
                ++k;
            }

            int nDiv = divisors.Count;
            return (k <= nDiv) ? n / divisors[nDiv - k] : -1;
        }
    }
}
