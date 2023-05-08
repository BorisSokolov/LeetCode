using System;
using System.Collections.Generic;
using System.Text;

namespace Minimum_Cost_to_Connect_Sticks
{
    public class Solution
    {
        public int ConnectSticks(int[] sticks)
        {
            int total = 0;
            Array.Sort(sticks);
            Queue<int> q = new Queue<int>(sticks);

            while (q.Count > 1)
            {
                int count = q.Dequeue() + q.Dequeue();

                total += count;
                q.Enqueue(count);
            }
        }
    }
}
