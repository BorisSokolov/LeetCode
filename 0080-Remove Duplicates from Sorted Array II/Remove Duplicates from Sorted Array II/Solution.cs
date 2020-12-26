namespace Remove_Duplicates_from_Sorted_Array_II
{
    /// <summary>
    /// Given a sorted array nums, remove the duplicates in-place such that duplicates appeared at most twice and return the new length.
    /// Do not allocate extra space for another array; you must do this by modifying the input array in-place with O(1) extra memory.
    /// Clarification:
    /// Confused why the returned value is an integer, but your answer is an array?
    /// Note that the input array is passed in by reference, which means a modification to the input array will be known to the caller.
    /// Internally you can think of this:
    /// </summary>
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            foreach (var num in nums)
            {
                if (count <= 1 || nums[count - 2] != num)
                {
                    nums[count] = num;
                    count++;
                }
            }

            return count;
        }
    }
}
