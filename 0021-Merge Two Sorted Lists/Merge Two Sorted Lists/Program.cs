using LeetCode.Domain;
using System;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: l1 = [1, 2, 4], l2 = [1, 3, 4]
            //Output: [1, 1, 2, 3, 4, 4]
            Console.WriteLine(s.MergeTwoLists(
                new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4)))).ToString());
        }
    }
}
