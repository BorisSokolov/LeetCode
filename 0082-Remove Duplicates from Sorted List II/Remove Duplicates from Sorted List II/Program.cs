using LeetCode.Domain;
using System;

namespace Remove_Duplicates_from_Sorted_List_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: head = [1, 2, 3, 3, 4, 4, 5]
            //Output: [1, 2, 5]
            Console.WriteLine(s.DeleteDuplicates(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5)))))))).ToString());
        }
    }
}
