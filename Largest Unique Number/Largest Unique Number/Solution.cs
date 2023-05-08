using System;
using System.Collections.Generic;
using System.Text;

namespace Largest_Unique_Number
{
    /// <summary>
    /// 
    /// </summary>
    public class Solution
    {
        public int LargestUniqueNumber(int[] A)
        {
            SortedSet<int> uniqueNumbers = new SortedSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (duplicates.Add(A[i]))
                    uniqueNumbers.Add(A[i]);
                else
                    uniqueNumbers.Remove(A[i]);
            }

            return uniqueNumbers.Count == 0 ? -1 : uniqueNumbers.Max;
        }
    }
}
