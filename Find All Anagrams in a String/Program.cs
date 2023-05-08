using System;
using System.Collections.Generic;

namespace Find_All_Anagrams_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(string.Join(',',FindAnagrams("cbaebabacd", "abc")));
        }

        public static IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            int length = p.Length;

            var pDict = new Dictionary<char, int>();

            foreach (char c in p)
            {
                if (pDict.ContainsKey(c))
                    pDict[c]++;
                else
                    pDict[c] = 1;
            }

            var sDict = new Dictionary<char, int>(pDict);
            int currentI = 0;
            int currentL = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (sDict.ContainsKey(s[i]) && sDict[s[i]] > 0)
                {
                    if (currentL != length - 1)
                    {
                        sDict[s[i]]--;
                        currentL++;
                        continue;
                    }

                    result.Add(currentI);
                }
                else
                    i = currentI;

                currentI = i + 1;
                currentL = 0;
                sDict = new Dictionary<char, int>(pDict); ;
            }

            return result;
        }
    }
}
