using System;

namespace Remove_Palindromic_Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "ababa"
            //Output: 1
            //Explanation: String is already palindrome
            Console.WriteLine(s.RemovePalindromeSub("ababa"));
        }
    }
}
