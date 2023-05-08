using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.CountGoodSubstrings("xyzzaz"));
            Console.WriteLine(s.CountGoodSubstrings("aababcabc"));
            Console.WriteLine(s.CountGoodSubstrings("aababcabcz"));
        }
    }
}
