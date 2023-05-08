using System;
using System.Collections.Generic;

namespace Binary_Trees_With_Factors
{
    public class Solution
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            Array.Sort(arr);
            int sum = 0;
            var dict = new Dictionary<int, int>();
            int mod = 1000000007;

            foreach (int num in arr)
            {
                int ways = 1;

                for (int i = 0, x = arr[0]; x <= num * num && i < arr.Length - 1; x = arr[++i])
                {
                    if (num % x != 0)
                        continue;

                    int y = num / x;

                    if (dict.ContainsKey(y))
                        ways += dict[x] * dict[y] * (x == y ? 1 : 2);
                }

                dict.Add(num, ways);
                sum = (sum + ways) % mod;
            }

            return sum;
        }
    }
}
