using System;

namespace Decode_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "3[a]2[bc]"
            //Output: "aaabcbc"
            var s1 = "3[a]2[bc]";
            Console.WriteLine($"input: {s1}");
            Console.WriteLine($"outut: {s.DecodeString(s1)}");

            //Input: s = "3[a2[c]]"
            //Output: "accaccacc"
            var s2 = "3[a2[c]]";
            Console.WriteLine($"input: {s2}");
            Console.WriteLine($"outut: {s.DecodeString(s2)}");
        }
    }
}
