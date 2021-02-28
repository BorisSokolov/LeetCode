using System;

namespace Longest_Word_in_Dictionary_through_Deleting
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "abpcplea", d = ["ale", "apple", "monkey", "plea"]
            //Output: "apple"
            Console.WriteLine(s.FindLongestWord("abpcplea", new[] { "ale", "apple", "monkey", "plea" }));
            //Input: s = "abpcplea", d = ["a", "b", "c"]
            //Output: "a"
            Console.WriteLine(s.FindLongestWord("abpcplea", new[] { "a", "b", "c" }));
        }
    }
}
