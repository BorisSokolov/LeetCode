using System;
using System.Collections.Generic;

namespace Longest_Substring_Without_Repeating_Characters
{
    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// </summary>
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
                return s.Length;

            int count = 0;
            var dict = new Dictionary<char, int>();

            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    j = Math.Max(j, dict[s[i]]);
                }

                count = Math.Max(i - j + 1, count);
                dict[s[i]] = i + 1;
            }

            return count;
        }
    }
}
