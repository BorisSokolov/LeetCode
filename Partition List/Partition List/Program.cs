using System;
using LeetCode.Domain;

namespace Partition_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: head = [1, 4, 3, 2, 5, 2], x = 3
            //Output: [1, 2, 2, 4, 3, 5]
            Console.WriteLine(s.Partition(new ListNode(new[] { 1, 4, 3, 2, 5, 2 }), 3).ToString());
            //Input: head = [2, 1], x = 2
            //Output: [1, 2]
            Console.WriteLine(s.Partition(new ListNode(new[] { 1, 2 }), 2).ToString());
        }
    }
}
