using System.Collections.Generic;

namespace Map_Sum_Pairs
{
    public class MapSum
    {
        Dictionary<string, int> map = new Dictionary<string, int>();
        TrieNode root = new TrieNode();

        /** Initialize your data structure here. */
        public MapSum()
        {

        }

        public void Insert(string key, int val)
        {
            int delta = val;
            if (map.ContainsKey(key))
                delta -= map[key];

            var currentNode = root;
            currentNode.score += delta;

            foreach (char c in key)
            {
                if (!currentNode.children.ContainsKey(c))
                    currentNode.children[c] = new TrieNode();

                currentNode = currentNode.children[c];
                currentNode.score += delta;
            }
        }

        public int Sum(string prefix)
        {
            var currentNode = root;

            foreach (char c in prefix)
            {
                if (!currentNode.children.ContainsKey(c))
                    return 0;

                currentNode = currentNode.children[c];
            }

            return currentNode.score;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public int score;
    }
}
