using System;
using System.Collections.Generic;
using System.Text;

namespace Valid_Mountain_Array
{
    /// <summary>
    /// Given an array of integers arr, return true if and only if it is a valid mountain array.
    /// Recall that arr is a mountain array if and only if:
    /// arr.length >= 3
    /// There exists some i with 0 < i<arr.length - 1 such that:
    /// arr[0] < arr[1] < ... < arr[i - 1] < A[i]
    /// arr[i]> arr[i + 1] > ... > arr[arr.length - 1]
    /// </summary>
    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            int i = 0;

            // walk up
            while (i + 1 < arr.Length && arr[i] < arr[i + 1])
                i++;

            // peak can't be first or last
            if (i == 0 || i == arr.Length - 1)
                return false;

            // walk down
            while (i + 1 < arr.Length && arr[i] > arr[i + 1])
                i++;

            return i + 1 == arr.Length;
        }
    }
}
