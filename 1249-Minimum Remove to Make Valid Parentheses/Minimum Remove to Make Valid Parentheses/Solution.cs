using System.Text;

namespace Minimum_Remove_to_Make_Valid_Parentheses
{
    /// <summary>
    /// Given a string s of '(' , ')' and lowercase English characters. 
    /// Your task is to remove the minimum number of parentheses( '(' or ')', in any positions) so that the resulting parentheses string is valid and return any valid string.
    /// Formally, a parentheses string is valid if and only if:
    /// It is the empty string, contains only lowercase characters, or
    /// It can be written as AB(A concatenated with B), where A and B are valid strings, or
    /// It can be written as (A), where A is a valid string.
    /// </summary>
    public class Solution
    {
        public string MinRemoveToMakeValid(string s)
        {
            // Pass 1: Remove all invalid ")"
            StringBuilder sb = new StringBuilder();
            int openSeen = 0;
            int balance = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    openSeen++;
                    balance++;
                }
                else if (c == ')')
                {
                    if (balance == 0)
                        continue;
                
                    balance--;
                }

                sb.Append(c);
            }

            // Pass 2: Remove the rightmost "("
            StringBuilder result = new StringBuilder();
            int openToKeep = openSeen - balance;

            foreach (char c in sb.ToString())
            {
                if (c == '(')
                {
                    openToKeep--;
                    if (openToKeep < 0)
                        continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
    }
}
