using System;
using System.Collections.Generic;
using System.Linq;

namespace Determine_if_Two_Strings_Are_Close
{
    /// <summary>
    /// Two strings are considered close if you can attain one from the other using the following operations:
    /// Operation 1: Swap any two existing characters.
    /// For example, abcde -> aecdb
    /// Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
    /// For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
    /// You can use the operations on either string as many times as necessary.
    /// Given two strings, word1 and word2, return true if word1 and word2 are close, and false otherwise.
    /// </summary>
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            
            //the frequency of characters in each word
            var word1Freq = new SortedDictionary<char, int>();
            var word2Freq = new SortedDictionary<char, int>();
            foreach (char c in word1)
            {
                if (word1Freq.ContainsKey(c))
                    word1Freq[c]++;
                else
                    word1Freq[c] = 1;
            }
            foreach (char c in word2)
            {
                if (word2Freq.ContainsKey(c))
                    word2Freq[c]++;
                else
                    word2Freq[c] = 1;
            }
            if (!word1Freq.Keys.ToArray().SequenceEqual(word2Freq.Keys.ToArray()))
                return false;

            var sortedOccurances1 = word1Freq.Values.ToArray();
            Array.Sort(sortedOccurances1);
            var sortedOccurances2 = word2Freq.Values.ToArray();
            Array.Sort(sortedOccurances2);

            return sortedOccurances1.SequenceEqual(sortedOccurances2);
        }    
    }
}
