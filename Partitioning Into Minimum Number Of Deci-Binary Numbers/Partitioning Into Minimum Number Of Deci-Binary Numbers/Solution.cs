using System;

namespace Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers
{
    public class Solution
    {
        public int MinPartitions(string n)
        {
            int maximum = 0;
            foreach (char c in n)
            {
                maximum = Math.Max(maximum, c - '0');
            }
            return maximum;
        }
    }
}
