using System.Collections.Generic;

namespace Find_Smallest_Common_Element_in_All_Rows
{
    public class Solution
    {
        public int SmallestCommonElement(int[][] mat)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (int[] row in mat)
                foreach (int item in row)
                {
                    if (!count.ContainsKey(item))
                    {
                        count[item] = 1;
                    }
                    else
                    {
                        if (++count[item] == mat.Length)
                            return item;
                    }
                }

            return -1;
        }
    }
}
