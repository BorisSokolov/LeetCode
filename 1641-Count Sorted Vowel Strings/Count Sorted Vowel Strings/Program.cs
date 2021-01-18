using System;

namespace Count_Sorted_Vowel_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: n = 1
            //Output: 5
            //Explanation: The 5 sorted strings that consist of vowels only are["a", "e", "i", "o", "u"].
            Console.WriteLine(s.CountVowelStrings(1));
            //Input: n = 2
            //Output: 15
            //Explanation: The 15 sorted strings that consist of vowels only are
            //["aa", "ae", "ai", "ao", "au", "ee", "ei", "eo", "eu", "ii", "io", "iu", "oo", "ou", "uu"].
            //Note that "ea" is not a valid string since 'e' comes after 'a' in the alphabet.
            Console.WriteLine(s.CountVowelStrings(2));
            //Input: n = 33
            //Output: 66045
            Console.WriteLine(s.CountVowelStrings(33));
        }
    }
}
