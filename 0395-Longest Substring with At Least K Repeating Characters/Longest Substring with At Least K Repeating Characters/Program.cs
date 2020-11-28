using System;

namespace Longest_Substring_with_At_Least_K_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "aaabb", k = 3
            //Output: 3
            //Explanation: The longest substring is "aaa", as 'a' is repeated 3 times.
            Console.WriteLine(s.LongestSubstring("aaabb", 3));
            //Input: s = "ababbc", k = 2
            //Output: 5
            //Explanation: The longest substring is "ababb", as 'a' is repeated 2 times and 'b' is repeated 3 times.
            Console.WriteLine(s.LongestSubstring("ababbc", 2));
        }
    }
}
