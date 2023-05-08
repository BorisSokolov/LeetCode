using System;

namespace Word_Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: A = ["amazon", "apple", "facebook", "google", "leetcode"], B = ["e", "o"]
            //Output: ["facebook", "google", "leetcode"]
            Console.WriteLine(string.Join(',', s.WordSubsets(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "o" })));
            //Input: A = ["amazon", "apple", "facebook", "google", "leetcode"], B = ["l", "e"]
            //Output: ["apple", "google", "leetcode"]
            Console.WriteLine(string.Join(',', s.WordSubsets(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "l" })));
            //Input: A = ["amazon", "apple", "facebook", "google", "leetcode"], B = ["e", "oo"]
            //Output: ["facebook", "google"]
            Console.WriteLine(string.Join(',', s.WordSubsets(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "e", "oo" })));
            //Input: A = ["amazon", "apple", "facebook", "google", "leetcode"], B = ["lo", "eo"]
            //Output: ["google", "leetcode"]
            Console.WriteLine(string.Join(',', s.WordSubsets(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "eo", "lo" })));
            //Input: A = ["amazon", "apple", "facebook", "google", "leetcode"], B = ["ec", "oc", "ceo"]
            //Output: ["facebook", "leetcode"]
            Console.WriteLine(string.Join(',', s.WordSubsets(new[] { "amazon", "apple", "facebook", "google", "leetcode" }, new[] { "ec", "oc", "ceo" })));
        }
    }
}
