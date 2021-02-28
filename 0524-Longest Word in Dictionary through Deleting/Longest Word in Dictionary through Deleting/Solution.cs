using System.Collections.Generic;

namespace Longest_Word_in_Dictionary_through_Deleting
{
    /// <summary>
    /// Given a string and a string dictionary, find the longest string in the dictionary that can be formed by deleting some characters of the given string. If there are more than one possible results, return the longest word with the smallest lexicographical order. If there is no possible result, return the empty string.
    /// </summary>
    public class Solution
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            string longestWord = string.Empty;

            foreach (string word in d)
            {
                if (IsSubsequence(word, s) && (word.Length > longestWord.Length || (word.Length == longestWord.Length && word.CompareTo(longestWord) < 0)))
                    longestWord = word;
            }

            return longestWord;
        }

        private bool IsSubsequence(string word, string s)
        {
            int j = 0;
            for (int i = 0; i < s.Length && j < word.Length; i++)
            {
                if (s[i] == word[j])
                    j++;
            }

            return j == word.Length;
        }
    }
}
