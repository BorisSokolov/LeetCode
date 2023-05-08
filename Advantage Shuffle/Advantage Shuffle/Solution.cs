using System;
using System.Collections.Generic;
using System.Text;

namespace Advantage_Shuffle
{
    public class Solution
    {
        public int[] AdvantageCount(int[] A, int[] B)
        {
            int[] sortedA = new int[A.Length];
            A.CopyTo(sortedA, 0);
            int[] sortedB = new int[B.Length];
            B.CopyTo(sortedB, 0);
            Array.Sort(sortedA);
            Array.Sort(sortedB);

        }
    }
}
