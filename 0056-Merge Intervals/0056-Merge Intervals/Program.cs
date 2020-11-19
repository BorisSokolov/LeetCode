using System;

namespace Merge_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: intervals = [[1, 3],[2,6],[8,10],[15,18]]
            //Output: [[1,6],[8,10],[15,18]]
            var intervals = new int[][] { new int[]{ 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
            foreach(var a in s.Merge(intervals))
            Console.WriteLine($"{a[0]} {a[1]}");
        }
    }
}
