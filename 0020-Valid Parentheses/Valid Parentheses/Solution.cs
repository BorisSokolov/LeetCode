using System.Collections.Generic;

namespace Valid_Parentheses
{
    /// <summary>
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// An input string is valid if:
    /// Open brackets must be closed by the same type of brackets.
    /// Open brackets must be closed in the correct order.
    /// </summary>
    public class Solution
    {
        private readonly Dictionary<char, char> parantetheses = new Dictionary<char, char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            //adding a dummy head
            stack.Push('#');
            foreach (char c in s)
            {
                if (parantetheses.ContainsKey(c))
                {
                    if (stack.Pop() != parantetheses[c])
                        return false;
                }
                else
                    stack.Push(c);
            }

            return stack.Count == 1;
        }
    }
}
