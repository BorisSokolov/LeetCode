using System;

namespace Shortest_Distance_to_a_Character
{
    /// <summary>
    /// Given a string s and a character c that occurs in s, return an array of integers answer where answer.length == s.length and answer[i] is the shortest distance from s[i] to the character c in s.
    /// </summary>
    public class Solution
    {
        public int[] ShortestToChar(string s, char c)
        {
            int n = s.Length;
            int[] ans = new int[n];
            int prev = int.MinValue / 2;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == c)
                    prev = i;

                ans[i] = i - prev;
            }

            prev = int.MaxValue / 2;

            for (int i = n - 1; i >= 0; i--)
            {
                if (s[i] == c)
                    prev = i;

                ans[i] = Math.Min(ans[i], prev - i);
            }

            return ans;
        }
    }
}
