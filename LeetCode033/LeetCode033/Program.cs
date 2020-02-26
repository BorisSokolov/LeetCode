using System;

namespace LeetCode033
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            Solution solution = new Solution();
            
            //Console.WriteLine(solution.Search(nums, 4));
            //Console.WriteLine(solution.Search(nums, 3));
            //Console.WriteLine(solution.Search(nums, 5));

            var nums2 = new int[] { 9, 0, 2, 7, 8 };
            Console.WriteLine(solution.Search(nums2, 3));
        }
    }
}
