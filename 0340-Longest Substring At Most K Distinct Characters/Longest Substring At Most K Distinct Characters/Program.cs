using System;

namespace Longest_Substring_At_Most_K_Distinct_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "eceba", k = 2
            //Output: 3
            //Explanation: The substring is "ece" with length 3.
            Console.WriteLine(s.LengthOfLongestSubstringKDistinct("eceba", 2));
            //Input: s = "aa", k = 1
            //Output: 2
            //Explanation: The substring is "aa" with length 2.
            Console.WriteLine(s.LengthOfLongestSubstringKDistinct("aa", 1));
        }
    }
}
