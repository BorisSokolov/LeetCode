using System;

namespace Longest_Substring_with_At_Least_K_Repeating_Characters
{
    public class Solution
    {
        public int LongestSubstring(string s, int k)
        {
            char[] str = s.ToCharArray();
            int[] countMap = new int[26];
            int maxUnique = getMaxUniqueLetters(s);
            int result = 0;
            for (int currUnique = 1; currUnique <= maxUnique; currUnique++)
            {
                // reset countMap
                Array.Clear(countMap, 0, countMap.Length);
                int windowStart = 0, windowEnd = 0, unique = 0, countAtLeastK = 0;
                while (windowEnd < str.Length)
                {
                    int idx;
                    // expand the sliding window
                    if (unique <= currUnique)
                    {
                        idx = str[windowEnd] - 'a';
                        if (countMap[idx] == 0) unique++;
                        countMap[idx]++;
                        if (countMap[idx] == k) countAtLeastK++;
                        windowEnd++;
                    }
                    // shrink the sliding window
                    else
                    {
                        idx = str[windowStart] - 'a';
                        if (countMap[idx] == k) countAtLeastK--;
                        countMap[idx]--;
                        if (countMap[idx] == 0) unique--;
                        windowStart++;
                    }
                    if (unique == currUnique && unique == countAtLeastK)
                        result = Math.Max(windowEnd - windowStart, result);
                }
            }

            return result;
        }

        // get the maximum number of unique letters in the string s
        private int getMaxUniqueLetters(string s)
        {
            var map = new bool[26];
            int maxUnique = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!map[s[i] - 'a'])
                {
                    maxUnique++;
                    map[s[i] - 'a'] = true;
                }
            }
            return maxUnique;
        }
    }
}
