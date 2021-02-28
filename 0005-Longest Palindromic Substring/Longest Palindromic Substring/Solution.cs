using System;

namespace Longest_Palindromic_Substring
{
    /// <summary>
    /// Given a string s, return the longest palindromic substring in s.
    /// </summary>
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length <= 1)
                return s;

            if (s.Length == 2)
                return s[0] == s[1] ? s : s[0].ToString();

            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end + 1 - start);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            int l = left;
            int r = right;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            return r - l - 1;
        }
    }
}
