using System;
using System.Collections.Generic;

namespace Word_Subsets
{
    public class Solution
    {
        private const int alphabethSize = 26;

        private int[] CountChars(string s)
        {
            int[] result = new int[alphabethSize];

            foreach (char c in s)
                result[c - 'a']++;

            return result;
        }

        public IList<string> WordSubsets(string[] A, string[] B)
        {
            List<string> result = new List<string>();
            int[] bMax = new int[alphabethSize];

            foreach (string s in B)
            {
                var currentCount = CountChars(s);

                for (int i = 0; i < alphabethSize; i++)
                {
                    bMax[i] = Math.Max(bMax[i], currentCount[i]);
                }
            }

            foreach (string s in A)
            {
                var currentCount = CountChars(s);
                bool flag = true;

                for (int i = 0; i < alphabethSize && flag; i++)
                {
                    if (currentCount[i] < bMax[i])
                        flag = false;
                }

                if (!flag)
                    result.Add(s);
            }

            return result;
        }
    }
}
