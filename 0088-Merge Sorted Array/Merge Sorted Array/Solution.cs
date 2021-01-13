using System;

namespace Merge_Sorted_Array
{
    /// <summary>
    /// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
    /// The number of elements initialized in nums1 and nums2 are m and n respectively.You may assume that nums1 has enough space (size that is equal to m + n) to hold additional elements from nums2.
    /// </summary>
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // two get pointers for nums1 and nums2
            int p1 = m - 1;
            int p2 = n - 1;
            // set pointer for nums1
            int p = m + n - 1;

            // while there are still elements to compare
            while ((p1 >= 0) && (p2 >= 0))
                // compare two elements from nums1 and nums2 
                // and add the largest one in nums1 
                nums1[p--] = (nums1[p1] < nums2[p2]) ? nums2[p2--] : nums1[p1--];

            // add missing elements from nums2
            Array.Copy(nums2, 0, nums1, 0, p2 + 1);
        }
    }
}
