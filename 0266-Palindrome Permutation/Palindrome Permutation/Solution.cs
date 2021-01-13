using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome_Permutation
{
    /// <summary>
    /// Given a string, determine if a permutation of the string could form a palindrome.
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if the string is palindrome</returns>
        public bool CanPermutePalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
                return true;

            HashSet<char> chars = new HashSet<char>();

            foreach (char c in s)
            {
                if (!chars.Add(c))
                    chars.Remove(c);
            }

            // Palindrome should contain not more than 1 single character
            return chars.Count <= 1;
        }
    }
}
