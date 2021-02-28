using LeetCode.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Nested_List_Weight_Sum
{
    /// <summary>
    /// You are given a nested list of integers nestedList. Each element is either an integer or a list whose elements may also be integers or other lists.
    /// The depth of an integer is the number of lists that it is inside of.For example, the nested list[1,[2, 2], [[3],2],1] has each integer's value set to its depth.
    /// Return the sum of each integer in nestedList multiplied by its depth.
    /// </summary>
    public class Solution
    {
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            if (!nestedList.Any())
                return 0;

            Queue<NestedInteger> queue = new Queue<NestedInteger>(nestedList);

            int depth = 1;
            int total = 0;

            while (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    NestedInteger nested = queue.Dequeue();
                    if (nested.IsInteger())
                    {
                        total += nested.GetInteger() * depth;
                    }
                    else
                    {
                        foreach (var n in nested.GetList())
                            queue.Enqueue(n);
                    }
                }
                depth++;
            }
            return total;
        }
    }
}
