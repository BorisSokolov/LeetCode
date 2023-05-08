using System;
using System.Collections.Generic;

namespace Check_If_a_String_Contains_All_Binary_Codes_of_Size_K
{
    /// <summary>
    /// Given a binary string s and an integer k.
    /// Return True if every binary code of length k is a substring of s.Otherwise, return False.
    /// </summary>
    public class Solution
    {
        public bool HasAllCodes(string s, int k)
        {
            var set = new HashSet<string>();
            for (int i = 0; i <= s.Length - k; i++)
                set.Add(s.Substring(i, k));

            return set.Count == Math.Pow(2, k);
        }
    }
}
