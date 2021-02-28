using LeetCode.Domain;
using System;

namespace Merge_k_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: lists = [[1, 4, 5],[1,3,4],[2,6]]
            //Output: [1,1,2,3,4,4,5,6]
            //        Explanation: The linked-lists are:
            //[
            //  1->4->5,
            //  1->3->4,
            //  2->6
            //]
            //        merging them into one sorted list:
            //1->1->2->3->4->4->5->6
            Console.WriteLine(s.MergeKLists(new[]{
                new ListNode(1, new ListNode(4, new ListNode(5))),
                 new ListNode(1, new ListNode(3, new ListNode(4))),
                 new ListNode(2, new ListNode(6))

            }).ToString());
        }
    }
}
