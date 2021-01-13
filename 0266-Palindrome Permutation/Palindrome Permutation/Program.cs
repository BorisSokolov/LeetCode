using System;

namespace Palindrome_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.CanPermutePalindrome("code"));
            Console.WriteLine(s.CanPermutePalindrome("aar"));
            Console.WriteLine(s.CanPermutePalindrome("arr"));
            Console.WriteLine(s.CanPermutePalindrome("carerac"));
        }
    }
}
