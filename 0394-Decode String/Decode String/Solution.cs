using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decode_String
{
    /// <summary>
    /// Given an encoded string, return its decoded string.
    /// The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times.Note that k is guaranteed to be a positive integer.
    /// You may assume that the input string is always valid; No extra white spaces, square brackets are well-formed, etc.
    /// Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k.For example, there won't be input like 3a or 2[4].
    /// </summary>
    public class Solution
    {
        public string DecodeString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            Stack<string> strings = new Stack<string>();
            Stack<int> integers = new Stack<int>();
            var chars = s.ToCharArray();
            StringBuilder str = new StringBuilder();
            
            for(int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    int num = 0;
                    while (i < chars.Length && char.IsDigit(chars[i]))
                        num = 10 * num + (chars[i++] - '0');

                    integers.Push(num);
                    i--;
                }
                else if (chars[i] == '[')
                {
                    strings.Push(str.ToString());
                    str.Clear();
                }
                else if (chars[i] == ']')
                {
                    var tmp = new StringBuilder(strings.Pop());
                    tmp.Append(string.Concat(Enumerable.Repeat(str.ToString(), integers.Pop())));

                    str = tmp;
                }
                else
                    str.Append(chars[i]);
            }            

            return str.ToString();
        }
    }
}
