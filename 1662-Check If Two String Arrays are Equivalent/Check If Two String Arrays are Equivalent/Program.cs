using System;

namespace Check_If_Two_String_Arrays_are_Equivalent
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
            //Output: true
            //Explanation:
            //            word1 represents string "ab" + "c"-> "abc"
            //word2 represents string "a" + "bc"-> "abc"
            //The strings are the same, so return true.
            Console.WriteLine(s.ArrayStringsAreEqual(new[] { "ab", "c" }, new[] { "a", "bc" }));
            //Input: word1 = ["a", "cb"], word2 = ["ab", "c"]
            //Output: false
            Console.WriteLine(s.ArrayStringsAreEqual(new[] { "ab", "c" }, new[] { "a", "cb" }));
            //Input: word1 = ["abc", "d", "defg"], word2 = ["abcddefg"]
            //Output: true
            Console.WriteLine(s.ArrayStringsAreEqual(new[] { "abc", "d", "defg" }, new[] { "abcddefg" }));
        }
    }
}
