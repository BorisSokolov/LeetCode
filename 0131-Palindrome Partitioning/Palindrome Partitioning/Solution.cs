using System.Collections.Generic;

namespace Palindrome_Partitioning
{
    /// <summary>
    /// Given a string s, partition s such that every substring of the partition is a palindrome. Return all possible palindrome partitioning of s.
    /// A palindrome string is a string that reads the same backward as forward.
    /// </summary>
    public class Solution
    {
        public IList<IList<string>> Partition(string s)
        {
            var dp = new bool[s.Length, s.Length];
            IList<IList<string>> result = new List<IList<string>>();
            Dfs(result, s, 0, new List<string>(), dp);
            return result;
        }

        private void Dfs(IList<IList<string>> result, string s, int start, IList<string> currentList, bool[,] dp)
        {
            if (start >= s.Length)
                result.Add(new List<string>(currentList));
            for (int end = start; end < s.Length; end++)
            {
                if (s[start] == s[end] && (end - start <= 2 || dp[start + 1, end - 1]))
                {
                    dp[start, end] = true;
                    currentList.Add(s.Substring(start, end - start + 1));
                    Dfs(result, s, end + 1, currentList, dp);
                    currentList.RemoveAt(currentList.Count - 1);
                }
            }
        }
    }
}
