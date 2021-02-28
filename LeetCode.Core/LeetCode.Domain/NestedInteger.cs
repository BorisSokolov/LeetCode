using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Domain
{
    /// <summary>
    /// This is the interface that allows for creating nested lists.
    /// You should not implement it, or speculate about its implementation
    /// </summary>
    public class NestedInteger
    {
        private int val;
        private readonly List<NestedInteger> nested;

        // Constructor initializes an empty nested list.
        public NestedInteger()
        {
            nested = new List<NestedInteger>();
        }

        // Constructor initializes a single integer.
        public NestedInteger(int value)
        {
            val = value;
            nested = new List<NestedInteger>();
        }

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        public bool IsInteger()
        {
            return !nested.Any();
        }

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        public int GetInteger()
        {
            return val;
        }

        // Set this NestedInteger to hold a single integer.
        public void SetInteger(int value)
        {
            val = value;
        }

        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        public void Add(NestedInteger ni)
        {
            nested.Add(ni);
        }

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        public List<NestedInteger> GetList()
        {
            return nested;
        }
    }
}
