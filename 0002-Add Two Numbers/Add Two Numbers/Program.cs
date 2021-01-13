using LeetCode.Domain;
using System;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
            //Output: [7, 0, 8]
            //Explanation: 342 + 465 = 807.
            Console.WriteLine(s.AddTwoNumbers(new ListNode(new[] { 2, 4, 3 }), new ListNode(new[] { 5, 6, 4 })).ToString());
            //Input: l1 = [0], l2 = [0]
            //Output: [0]
            Console.WriteLine(s.AddTwoNumbers(new ListNode(new[] { 0 }), new ListNode(new[] { 0 })).ToString());
            //Input: l1 = [9, 9, 9, 9, 9, 9, 9], l2 = [9, 9, 9, 9]
            //Output: [8, 9, 9, 9, 0, 0, 0, 1]
            Console.WriteLine(s.AddTwoNumbers(new ListNode(new[] { 9, 9, 9, 9, 9, 9, 9 } ), new ListNode(new[] { 9, 9, 9, 9 })).ToString());
        }
    }
}
