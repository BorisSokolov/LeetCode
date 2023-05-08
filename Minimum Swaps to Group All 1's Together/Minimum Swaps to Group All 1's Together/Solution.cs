using System;
using System.Linq;

namespace Minimum_Swaps_to_Group_All_1_s_Together
{
    public class Solution
    {
        public int MinSwaps(int[] data)
        {
            int sum = data.Sum();
            int ones = 0;
            int max = 0;
            int left = 0;
            int right = 0;

            while (right < data.Length)
            {
                ones += data[right++];

                if (right - left > sum)
                    ones -= data[left++];

                max = Math.Max(max, ones);
            }

            return sum - max;
        }
    }
}
