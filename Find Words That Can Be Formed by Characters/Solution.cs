using System;

namespace Find_Words_That_Can_Be_Formed_by_Characters
{
    public class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            int sum = 0;

            var charCount = new int[26];

            foreach (char c in chars)
                charCount[c - 'a']++;

            foreach (var w in words)
            {
                var tmp = new int[26];
                Array.Copy(charCount, tmp, 26);
                int count = 0;

                foreach (char c in w)
                {
                    if (tmp[c - 'a'] > 0)
                    {
                        count++;
                        tmp[c - 'a']--;
                    }
                }

                if (count == w.Length)
                    sum += count;
            }

            return sum;
        }
    }
}
