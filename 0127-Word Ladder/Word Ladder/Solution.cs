using System;
using System.Collections.Generic;

namespace Word_Ladder
{
    public class Solution
    {
        private int length;
        private Dictionary<string, List<string>> allComboDict;

        private int VisitWordNode(Queue<Tuple<string, int>> queue, Dictionary<string, int> visited, Dictionary<string, int> othersVisited)
        {
            var node = queue.Dequeue();
            string word = node.Item1;
            int level = node.Item2;

            for (int i = 0; i < length; i++)
            {
                // Next states are all the words which share the same intermediate state.

                if (allComboDict.TryGetValue(IntermidiateWords(word, i), out List<string> adjacentWords))
                {
                    foreach (string adjacentWord in adjacentWords)
                    {
                        // If at any point if we find what we are looking for
                        // i.e. the end word - we can return with the answer.
                        if (othersVisited.ContainsKey(adjacentWord))
                        {
                            return level + othersVisited[adjacentWord];
                        }

                        if (!visited.ContainsKey(adjacentWord))
                        {

                            // Save the level as the value of the dictionary, to save number of hops.
                            visited[adjacentWord] = level + 1;
                            queue.Enqueue(new Tuple<string, int>(adjacentWord, level + 1));
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Intermediate words for current <paramref name="word"/>
        /// </summary>
        /// <param name="word"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private string IntermidiateWords(string word, int i) => $"{word.Substring(0, i)}*{word.Substring(i + 1, length - i - 1)}";

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord))
            {
                return 0;
            }

            allComboDict = new Dictionary<string, List<string>>();

            // Since all words are of same length.
            length = beginWord.Length;

            foreach (var word in wordList)
            {
                for (int i = 0; i < length; i++)
                {
                    // Key is the generic word
                    // Value is a list of words which have the same intermediate generic word.
                    string newWord = IntermidiateWords(word, i);
                    List<string> transformations = allComboDict.ContainsKey(newWord) ? allComboDict[newWord] : new List<string>();
                    transformations.Add(word);
                    allComboDict[newWord] = transformations;
                }
            };

            // Queues for birdirectional BFS
            // BFS starting from beginWord
            var queueBegin = new Queue<Tuple<string, int>>();
            queueBegin.Enqueue(new Tuple<string, int>(beginWord, 1));
            // BFS starting from endWord
            var queueEnd = new Queue<Tuple<string, int>>();
            queueEnd.Enqueue(new Tuple<string, int>(endWord, 1));

            // Visited to make sure we don't repeat processing same word.
            var visitedBegin = new Dictionary<string, int>
            {
                [beginWord] = 1
            };

            var visitedEnd = new Dictionary<string, int>
            {
                [endWord] = 1
            };

            while (queueBegin.Count > 0 && queueEnd.Count > 0)
            {
                // One hop from begin word
                int ans = VisitWordNode(queueBegin, visitedBegin, visitedEnd);
                if (ans > -1)
                {
                    return ans;
                }

                // One hop from end word
                ans = VisitWordNode(queueEnd, visitedEnd, visitedBegin);
                if (ans > -1)
                {
                    return ans;
                }
            }

            return 0;
        }
    }
}
