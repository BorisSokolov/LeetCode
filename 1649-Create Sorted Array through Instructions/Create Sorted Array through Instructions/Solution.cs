using System;

namespace Create_Sorted_Array_through_Instructions
{
    /// <summary>
    /// Given an integer array instructions, you are asked to create a sorted array from the elements in instructions. You start with an empty container nums. For each element from left to right in instructions, insert it into nums. The cost of each insertion is the minimum of the following:
    /// The number of elements currently in nums that are strictly less than instructions[i].
    /// The number of elements currently in nums that are strictly greater than instructions[i].
    /// For example, if inserting element 3 into nums = [1, 2, 3, 5], the cost of insertion is min(2, 1) (elements 1 and 2 are less than 3, element 5 is greater than 3) and nums will become[1, 2, 3, 3, 5].
    /// Return the total cost to insert all elements from instructions into nums.Since the answer may be large, return it modulo 109 + 7
    /// </summary>
    public class Solution
    {
        public int CreateSortedArray(int[] instructions)
        {
            int m = (int)1e5 + 1;
            int[] tree = new int[m * 2];

            long cost = 0;
            long MOD = (int)1e9 + 7;
            foreach (int x in instructions)
            {
                cost += Math.Min(Query(0, x, tree, m), Query(x + 1, m, tree, m));
                Update(x, 1, tree, m);
            }
            return (int)(cost % MOD);
        }

        // implement Segment Tree
        private void Update(int index, int value, int[] tree, int m)
        {
            index += m;
            tree[index] += value;
            for (index >>= 1; index > 0; index >>= 1)
                tree[index] = tree[index << 1] + tree[(index << 1) + 1];
        }

        private int Query(int left, int right, int[] tree, int m)
        {
            int result = 0;
            for (left += m, right += m; left < right; left >>= 1, right >>= 1)
            {
                if ((left & 1) == 1)
                    result += tree[left++];
                if ((right & 1) == 1)
                    result += tree[--right];
            }
            return result;
        }
    }
}
