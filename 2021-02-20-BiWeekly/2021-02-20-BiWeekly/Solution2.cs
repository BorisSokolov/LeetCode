using System;
using System.Collections.Generic;
using System.Linq;


namespace _2021_02_20_BiWeekly
{
    public class Solution2
    {
        public bool CanChoose(int[][] groups, int[] nums)
        {
            int index = -1;
            foreach (var group in groups)
            {
                var indexes = StartingIndex(nums, group);
                if (indexes?.Any() != true)
                    return false;

                if (indexes.ToArray()[0] > index)
                    index = indexes.ToArray()[0] + group.Length - 1;
                else
                    return false;
            }

            return true;
        }

        public static IEnumerable<int> StartingIndex(int[] x, int[] y)
        {
            IEnumerable<int> index = Enumerable.Range(0, x.Length - y.Length + 1);
            for (int i = 0; i < y.Length; i++)
            {
                index = index.Where(n => x[n + i] == y[i]).ToArray();
            }
            return index;
        }
    }
}
