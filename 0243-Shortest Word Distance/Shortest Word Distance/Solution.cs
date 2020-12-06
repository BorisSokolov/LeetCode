using System;

namespace Shortest_Word_Distance
{
    /// <summary>
    /// Given a list of words and two words word1 and word2, return the shortest distance between these two words in the list.
    /// </summary>
    public class Solution
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            //most recent location of word1
            int i1 = -1;
            //most recent location of word2
            int i2 = -1;

            int minDistance = words.Length;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word1))
                    i1 = i;
                else if (words[i].Equals(word2))
                    i2 = i;

                if (i1 != -1 && i2 != -1)
                    minDistance = Math.Min(minDistance, Math.Abs(i1 - i2));
            }

            return minDistance;
        }
    }
}
