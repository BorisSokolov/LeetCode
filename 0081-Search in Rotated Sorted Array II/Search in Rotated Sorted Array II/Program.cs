using System;

namespace Search_in_Rotated_Sorted_Array_II
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums = [2,5,6,0,0,1,2], target = 0
            //Output: true
            var nums = new int[] { 2, 5, 6, 0, 0, 1, 2 };
            int target = 0;
            Console.WriteLine(s.Search(nums, target));
            //Input: nums = [2,5,6,0,0,1,2], target = 3
            //Output: false
            int target1 = 3;
            Console.WriteLine(s.Search(nums, target1));
            //Input: nums = [1], target = 0
            //Output: false
            var nums2 = new int[] {1};
            int target2 = 0;
            Console.WriteLine(s.Search(nums2, target2));
            //Input: nums = [1,3,5], target = 0
            //Output: true
            var nums3 = new int[] { 1, 3, 5 };
            int target3 = 1;
            Console.WriteLine(s.Search(nums3, target3));
        }
    }
}
