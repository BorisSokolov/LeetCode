using System;

namespace Longest_Valid_Parentheses
{
    /// <summary>
    /// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
    /// </summary>
    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int maxCount = 0;
            int open = 0;
            int close = 0;

            foreach (char c in s)
            {
                if (c == '(')
                {
                    open++;
                }
                else
                {
                    close++;
                }

                if (open == close)
                {
                    maxCount = Math.Max(maxCount, close);
                }
                else if (close >= open)
                {
                    open = 0;
                    close = 0;
                }
            }

            open = 0;
            close = 0;

            for (int i = 1; i <= s.Length; i++)
            {
                if (s[^i] == '(')
                {
                    open++;
                }
                else
                {
                    close++;
                }

                if (open == close)
                {
                    maxCount = Math.Max(maxCount, open);
                }
                else if (close <= open)
                {
                    open = 0;
                    close = 0;
                }
            }

            return maxCount * 2;
        }
    }
}
