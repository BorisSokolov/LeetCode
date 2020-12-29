using System;

namespace Reach_a_Number
{
    /// <summary>
    /// You are standing at position 0 on an infinite number line. There is a goal at position target.
    /// On each move, you can either go left or right.During the n-th move(starting from 1), you take n steps.
    /// Return the minimum number of steps required to reach the destination.
    /// </summary>
    public class Solution
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);

            int k = 0;
            while (target > 0)
                target -= ++k;

            return target % 2 == 0 ? k : k + 1 + k % 2;
        }

        // O(1) solution to retest and fix
        //public int ReachNumber(int target)
        //{
        //    target = Math.Abs(target);

        //    int n = (int)Math.Ceiling(Math.Sqrt(8 * target + 1) / 2);
        //    int d = n * (n + 1) / 2 - target;
        //    n++;

        //    if (d % 2 == 0)
        //        return d;
        //    else if ((d + n) % 2 == 0)
        //        return n;
        //    else
        //        return n + 1;
        //}
    }
}
