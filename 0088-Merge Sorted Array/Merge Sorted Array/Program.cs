using System;

namespace Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
            //Output: [1, 2, 2, 3, 5, 6]
            var a = new[] { 1, 2, 3, 0, 0, 0 };
            var b = new[] { 2, 5, 6 };
            s.Merge(a, 3, b, 3);
            Console.WriteLine(string.Join(", ", a));
            //Input: nums1 = [1], m = 1, nums2 = [], n = 0
            //Output: [1]
            a = new[] { 1,};
            b = new int[] { };
            s.Merge(a, 1, b, 0);
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
