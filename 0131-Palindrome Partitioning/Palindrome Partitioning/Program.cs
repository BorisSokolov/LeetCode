using System;

namespace Palindrome_Partitioning
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "aab"
            //Output: [["a", "a", "b"],["aa","b"]]
            var result = s.Partition("aab");
            foreach (var arr in result)
                Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
    }
}
