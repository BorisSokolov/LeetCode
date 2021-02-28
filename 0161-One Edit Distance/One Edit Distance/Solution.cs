using System;

namespace One_Edit_Distance
{
    /// <summary>
    /// Given two strings s and t, return true if they are both one edit distance apart, otherwise return false.
    /// A string s is said to be one distance apart from a string t if you can:
    /// Insert exactly one character into s to get t.
    /// Delete exactly one character from s to get t.
    /// Replace exactly one character of s with a different character to get t.
    /// </summary>
    public class Solution
    {
        public bool IsOneEditDistance(string s, string t)
        {
            if (Math.Abs(s.Length - t.Length) > 1 || s.Equals(t))
                return false;


            bool foundInequality = false;

            for (int i = 0, j = 0; i < s.Length && j < t.Length; i++, j++)
            {
                if (s[i] != t[j])
                {
                    //only one inequality allowed
                    if (foundInequality)
                        return false;

                    foundInequality = true;

                    if (s.Length < t.Length)
                        i--;
                    else if (s.Length > t.Length)
                        j--;
                }
            }

            return true;
        }
    }
}
