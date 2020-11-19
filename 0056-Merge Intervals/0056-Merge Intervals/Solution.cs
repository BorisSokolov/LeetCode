using System;
using System.Collections.Generic;

namespace Merge_Intervals
{
    /// <summary>
    /// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.
    /// </summary>
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
                return intervals;

            Array.Sort(intervals, new IntervalComparer());
            
            List<int[]> result = new List<int[]>
            {
                intervals[0]
            };

            for (int i = 1; i < intervals.Length; i++)
            {
                if (result[result.Count - 1][1] < intervals[i][0])
                    result.Add(intervals[i]);
                else if (result[result.Count - 1][1] < intervals[i][1])
                    result[result.Count - 1][1] = intervals[i][1];
            }

            return result.ToArray();
        }
    }

    public class IntervalComparer : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs[0] == rhs[0] ? lhs[1].CompareTo(rhs[1]) : lhs[0].CompareTo(rhs[0]);
        }
    }
}
