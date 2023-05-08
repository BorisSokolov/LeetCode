using System;

namespace Reverse_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.ReverseWords("the sky is blue"));
        }
    }

    public class Solution
    {
        public string ReverseWords(string s)
        {
            var arr = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);

            return string.Join(' ', arr);
        }
    }
}
