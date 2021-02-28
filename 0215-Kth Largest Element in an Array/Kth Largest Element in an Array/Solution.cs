using System;

namespace Kth_Largest_Element_in_an_Array
{
    /// <summary>
    /// Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums">Unsorted array</param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[^k];
        }
    }
}
