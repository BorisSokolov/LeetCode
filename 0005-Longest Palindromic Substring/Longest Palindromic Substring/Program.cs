using System;

namespace Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "babad"
            //Output: "bab"
            //Note: "aba" is also a valid answer.
            Console.WriteLine(s.LongestPalindrome("babad"));
            //Input: s = "cbbd"
            //Output: "bb"
            Console.WriteLine(s.LongestPalindrome("cbbd"));
            //Input: s = "a"
            //Output: "a"
            Console.WriteLine(s.LongestPalindrome("a"));
            //Input: s = "ac"
            //Output: "a"
            Console.WriteLine(s.LongestPalindrome("ac"));
            //Input: s = "bb"
            //Output: "bb"
            Console.WriteLine(s.LongestPalindrome("bb"));
        }
    }
}
