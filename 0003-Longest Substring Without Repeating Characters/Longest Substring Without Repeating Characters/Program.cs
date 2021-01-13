using System;

namespace Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "abcabcbb"
            //Output: 3
            //Explanation: The answer is "abc", with the length of 3.
            Console.WriteLine(s.LengthOfLongestSubstring("abcabcbb"));
            //Input: s = "bbbbb"
            //Output: 1
            //Explanation: The answer is "b", with the length of 1.
            Console.WriteLine(s.LengthOfLongestSubstring("bbbbb"));
            //Input: s = "pwwkew"
            //Output: 3
            //Explanation: The answer is "wke", with the length of 3.
            //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
            Console.WriteLine(s.LengthOfLongestSubstring("pwwkew"));
            //Input: s = ""
            //Output: 0
            Console.WriteLine(s.LengthOfLongestSubstring(""));
            //Expected: 1
            Console.WriteLine(s.LengthOfLongestSubstring(" "));
            Console.WriteLine(s.LengthOfLongestSubstring("au"));
        }
    }
}
