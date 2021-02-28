using System;

namespace Get_Maximum_in_Generated_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: n = 7
            //Output: 3
            //Explanation: According to the given rules:
            //            nums[0] = 0
            //  nums[1] = 1
            //  nums[(1 * 2) = 2] = nums[1] = 1
            //  nums[(1 * 2) + 1 = 3] = nums[1] + nums[2] = 1 + 1 = 2
            //  nums[(2 * 2) = 4] = nums[2] = 1
            //  nums[(2 * 2) + 1 = 5] = nums[2] + nums[3] = 1 + 2 = 3
            //  nums[(3 * 2) = 6] = nums[3] = 2
            //  nums[(3 * 2) + 1 = 7] = nums[3] + nums[4] = 2 + 1 = 3
            //Hence, nums = [0, 1, 1, 2, 1, 3, 2, 3], and the maximum is 3.
            Console.WriteLine(s.GetMaximumGenerated(7));
            //Input: n = 2
            //Output: 1
            //Explanation: According to the given rules, the maximum between nums[0], nums[1], and nums[2] is 1.
            Console.WriteLine(s.GetMaximumGenerated(2));
            //Input: n = 3
            //Output: 2
            //Explanation: According to the given rules, the maximum between nums[0], nums[1], nums[2], and nums[3] is 2.
            Console.WriteLine(s.GetMaximumGenerated(3));
        }
    }
}
