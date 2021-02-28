using System;
using System.Collections.Generic;
using System.Text;

namespace Squirrel_Simulation
{
    public class Solution
    {
        public int MinDistance(int height, int width, int[] tree, int[] squirrel, int[][] nuts)
        {
            int tot_dist = 0;
            int d = int.MinValue;
            foreach (var nut in nuts)
            {
                tot_dist += (Distance(nut, tree) * 2);
                d = Math.Max(d, Distance(nut, tree) - Distance(nut, squirrel));
            }
            return tot_dist - d;
        }

        public int Distance(int[] a, int[] b)
        {
            return Math.Abs(a[0] - b[0]) + Math.Abs(a[1] - b[1]);

        }
    }
}
