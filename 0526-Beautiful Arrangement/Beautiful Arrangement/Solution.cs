using System;
using System.Collections.Generic;
using System.Text;

namespace Beautiful_Arrangement
{
    /// <summary>
    /// Suppose you have n integers from 1 to n. We define a beautiful arrangement as an array that is constructed by these n numbers successfully if one of the following is true for the ith position (1 <= i <= n) in this array:
    /// The number at the ith position is divisible by i.
    /// i is divisible by the number at the ith position.
    /// Given an integer n, return the number of the beautiful arrangements that you can construct.
    /// </summary>
    public class Solution
    {
        private int count;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns> The number of the beautiful arrangements that you can construct</returns>
        public int CountArrangement(int n)
        {
            //for first 3 cases the number is the same as input
            if (n <= 3)
                return n;

            var visited = new bool[n + 1];
            Calculate(n, 1, visited);
            return count;
        }

        private void Calculate(int n, int pos, bool[] visited)
        {
            if (pos > n)
                count++;

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i] && (pos % i == 0 || i % pos == 0))
                {
                    visited[i] = true;
                    Calculate(n, pos + 1, visited);
                    visited[i] = false;
                }
            }
        }
    }
}
