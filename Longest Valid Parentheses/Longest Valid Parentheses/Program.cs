using System;

namespace Longest_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "(()"
            //Output: 2
            //Explanation: The longest valid parentheses substring is "()".
            Console.WriteLine(s.LongestValidParentheses("(()"));
            //Input: s = ")()())"
            //Output: 4
            //Explanation: The longest valid parentheses substring is "()()".
            Console.WriteLine(s.LongestValidParentheses(")()())"));
            //Input: s = ""
            //Output: 0
            Console.WriteLine(s.LongestValidParentheses(""));
        }
    }
}
