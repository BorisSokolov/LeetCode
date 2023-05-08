﻿using System;
using System.Collections.Generic;

namespace _1704_Determine_if_String_Halves_Are_Alike
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HalvesAreAlike("AbCdEfGh"));
        }

        public static bool HalvesAreAlike(string s)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int count = 0;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (vowels.Contains(s[i]))
                    count++;

                if (vowels.Contains(s[^(i+1)]))
                    count--;
            }

            return count == 0;
        }
    }
}
