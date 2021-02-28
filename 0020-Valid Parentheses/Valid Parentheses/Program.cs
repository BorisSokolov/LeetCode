using System;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "()"
            //Output: true
            Console.WriteLine(s.IsValid("()"));
            //Input: s = "()[]{}"
            //Output: true
            Console.WriteLine(s.IsValid("()[]{}"));
            //Input: s = "(]"
            //Output: false
            Console.WriteLine(s.IsValid("(]"));
            //Input: s = "([)]"
            //Output: false
            Console.WriteLine(s.IsValid("([)]"));
            //Input: s = "{[]}"
            //Output: true
            Console.WriteLine(s.IsValid("{[]}"));
        }
    }
}
