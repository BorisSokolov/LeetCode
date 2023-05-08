using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromic_Substrings
{
    public class Solution
    {
        public int CountSubstrings(string s)
        {
            int ans = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                // odd-length palindromes, single character center
                ans += countPalindromesAroundCenter(s, i, i);

                // even-length palindromes, consecutive characters center
                ans += countPalindromesAroundCenter(s, i, i + 1);
            }

            return ans;
        }

        private int countPalindromesAroundCenter(string s, int lo, int hi)
        {
            int ans = 0;

            while (lo >= 0 && hi < s.Length)
            {
                if (s[lo] != s[hi])
                    break;      // the first and last characters don't match!

                // expand around the center
                lo--;
                hi++;

                ans++;
            }

            return ans;
        }
    }
}
