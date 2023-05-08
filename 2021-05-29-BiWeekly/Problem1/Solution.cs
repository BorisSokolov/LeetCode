using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Substrings of Size Three with Distinct Characters
    /// </summary>
    public class Solution
    {
        public int CountGoodSubstrings(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length < 3)
                return 0;

            int sum = 0;
            for (int i = 0; i < s.Length - 2; i++)
            {
                if (IsGood(new string(new[] { s[i], s[i + 1], s[i + 2] })))
                    sum++;
            }

            return sum;
        }

        private bool IsGood(string s)
        {
            var unique = new HashSet<char>(s);
            return unique.Count == s.Length;
        }
    }
}
