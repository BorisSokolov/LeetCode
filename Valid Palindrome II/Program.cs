using System;

namespace Valid_Palindrome_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPalindrome("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga"));
        }

        public static bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    var first = s[left..right];
                    var second = s[(left + 1)..(right + 1)];

                    return first == Reverse(first) || second == Reverse(second);
                }

                left++;
                right--;
            }

            return true;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
