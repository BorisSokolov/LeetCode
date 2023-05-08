using System;
using System.Collections.Generic;

namespace ReverseVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ReverseVowels("Hello World!"));
            Console.WriteLine(ReverseVowels("Hello"));
        }

        public static string ReverseVowels(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            var c = s.ToCharArray();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            while (left < right)
            {
                if (vowels.Contains(c[left]) && vowels.Contains(c[right]))
                {
                    (c[left], c[right]) = (c[right], c[left]);
                    left++;
                    right--;
                }
                else if (vowels.Contains(c[left]))
                {
                    right--;
                }
                else if (vowels.Contains(c[right]))
                {
                    left++;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return new string(c);
        }
    }
}
