using System;

namespace Decoded_String_at_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: S = "leet2code3", K = 10
            //Output: "o"
            //Explanation:
            //The decoded string is "leetleetcodeleetleetcodeleetleetcode".
            //The 10th letter in the string is "o".
            Console.WriteLine(s.DecodeAtIndex("leet2code3", 10));
            //Input: S = "ha22", K = 5
            //Output: "h"
            //Explanation:
            //The decoded string is "hahahaha".The 5th letter is "h".
            Console.WriteLine(s.DecodeAtIndex("ha22", 5));
            //Input: S = "a2345678999999999999999", K = 1
            //Output: "a"
            //Explanation:
            //The decoded string is "a" repeated 8301530446056247680 times.The 1st letter is "a".
            Console.WriteLine(s.DecodeAtIndex("a2345678999999999999999", 1));
            //"a23", 6
            // a
            Console.WriteLine(s.DecodeAtIndex("a23", 6));
        }
    }
}
