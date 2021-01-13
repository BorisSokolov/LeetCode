using System;

namespace Word_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: beginWord = "hit", endWord = "cog", wordList = ["hot", "dot", "dog", "lot", "log", "cog"]
            //Output: 5
            //Explanation: As one shortest transformation is "hit"-> "hot"-> "dot"-> "dog"-> "cog", return its length 5.
            Console.WriteLine(s.LadderLength("hit", "cog", new[] { "hot", "dot", "dog", "lot", "log", "cog" }));
            //Input: beginWord = "hit", endWord = "cog", wordList = ["hot", "dot", "dog", "lot", "log"]
            //Output: 0
            //Explanation: The endWord "cog" is not in wordList, therefore no possible transformation.
            Console.WriteLine(s.LadderLength("hit", "cog", new[] { "hot", "dot", "dog", "lot", "log" }));
        }
    }
}
