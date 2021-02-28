using System;

namespace One_Edit_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "ab", t = "acb"
            //Output: true
            //Explanation: We can insert 'c' into s to get t.
            Console.WriteLine(s.IsOneEditDistance("ab", "acb"));
            //Input: s = "", t = ""
            //Output: false
            //Explanation: We cannot get t from s by only one step.
            Console.WriteLine(s.IsOneEditDistance("", ""));
            //Input: s = "a", t = ""
            //Output: true
            Console.WriteLine(s.IsOneEditDistance("a", ""));
            //Input: s = "", t = "A"
            //Output: true
            Console.WriteLine(s.IsOneEditDistance("", "A"));
        }
    }
}
