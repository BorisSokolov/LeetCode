using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Substring_At_Most_K_Distinct_Characters
{
    /// <summary>
    /// Given a string s and an integer k, return the length of the longest substring of s that contains at most k distinct characters.
    /// </summary>
    public class Solution
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
             if (s.Length * k == 0)
                return 0;

            int left = 0;
            int right = 0;

            var rightmostPosition = new Dictionary<char, int>();

            int maxLength = 1;

            while (right < s.Length)
            {
                rightmostPosition[s[right]] = right++;

                if (rightmostPosition.Count == k + 1)
                {
                    int lowestIndex = rightmostPosition.Values.Min();
                    rightmostPosition.Remove(s[lowestIndex]);
                    left = lowestIndex + 1;
                }

                maxLength = Math.Max(maxLength, right - left);
            }
            return maxLength;
        }
    }
}
