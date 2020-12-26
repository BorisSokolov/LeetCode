using System;

namespace Decode_Ways
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "12"
            //Output: 2
            //Explanation: It could be decoded as "AB"(1 2) or "L"(12).
            Console.WriteLine(s.NumDecodings("12"));
            //Input: s = "226"
            //Output: 3
            //Explanation: It could be decoded as "BZ"(2 26), "VF"(22 6), or "BBF"(2 2 6).
            Console.WriteLine(s.NumDecodings("226"));
            //Input: s = "0"
            //Output: 0
            //Explanation: There is no character that is mapped to a number starting with '0'.We cannot ignore a zero when we face it while decoding.So, each '0' should be part of "10"-- > 'J' or "20"-- > 'T'.
            Console.WriteLine(s.NumDecodings("0"));
            //Input: s = "1"
            //Output: 1
            Console.WriteLine(s.NumDecodings("1"));
        }
    }
}
