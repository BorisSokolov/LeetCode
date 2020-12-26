using System;

namespace Remove_Duplicates_from_Sorted_Array_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [1, 1, 1, 2, 2, 3]
            //Output: 5, nums = [1, 1, 2, 2, 3]
            //Explanation: Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.It doesn't matter what you leave beyond the returned length.

            var nums = new[] { 1, 1, 1, 2, 2, 3 };
            Console.WriteLine(s.RemoveDuplicates(nums));
            Console.WriteLine(string.Join(", ", nums));
            //Input: nums = [0, 0, 1, 1, 1, 1, 2, 3, 3]
            //Output: 7, nums = [0, 0, 1, 1, 2, 3, 3]
            //Explanation: Your function should return length = 7, with the first seven elements of nums being modified to 0, 0, 1, 1, 2, 3 and 3 respectively.It doesn't matter what values are set beyond the returned length.
            var nums1 = new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            Console.WriteLine(s.RemoveDuplicates(nums1));
            Console.WriteLine(string.Join(", ", nums1));
        }
    }
}
