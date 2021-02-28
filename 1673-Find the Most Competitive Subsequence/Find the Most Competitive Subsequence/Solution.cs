using System.Collections.Generic;

namespace Find_the_Most_Competitive_Subsequence
{
    /// <summary>
    /// Given an integer array nums and a positive integer k, return the most competitive subsequence of nums of size k.
    /// An array's subsequence is a resulting sequence obtained by erasing some (possibly zero) elements from the array.
    /// We define that a subsequence a is more competitive than a subsequence b(of the same length) if in the first position where a and b differ, subsequence a has a number less than the corresponding number in b.For example, [1, 3, 4] is more competitive than[1, 3, 5] because the first position they differ is at the final number, and 4 is less than 5.
    /// </summary>
    public class Solution
    {
        public int[] MostCompetitive(int[] nums, int k)
        {
            var list = new LinkedList<int>();
            int additionalCount = nums.Length - k;
            for (int i = 0; i < nums.Length; i++)
            {
                while (list.Count > 0 && list.Last.Value > nums[i] && additionalCount > 0)
                {
                    list.RemoveLast();
                    additionalCount--;
                }
                list.AddLast(nums[i]);
            }

            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = list.First.Value;
                list.RemoveFirst();
            }

            return result;
        }
    }
}
