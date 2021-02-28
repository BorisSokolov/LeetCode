using System;

namespace Minimum_Remove_to_Make_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "lee(t(c)o)de)"
            //Output: "lee(t(c)o)de"
            //Explanation: "lee(t(co)de)" , "lee(t(c)ode)" would also be accepted.
            Console.WriteLine(s.MinRemoveToMakeValid("lee(t(c)o)de)"));
            //Input: s = "a)b(c)d"
            //Output: "ab(c)d"
            Console.WriteLine(s.MinRemoveToMakeValid("a)b(c)d"));
            //Input: s = "))(("
            //Output: ""
            //Explanation: An empty string is also valid.
            Console.WriteLine(s.MinRemoveToMakeValid("))(("));
            //Input: s = "(a(b(c)d)"
            //Output: "a(b(c)d)"
            Console.WriteLine(s.MinRemoveToMakeValid("(a(b(c)d)"));
        }
    }
}
