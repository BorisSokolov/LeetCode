using System;
using System.Collections.Generic;
using System.Text;

namespace Decode_Ways
{
    /// <summary>
    /// A message containing letters from A-Z is being encoded to numbers using the following mapping:
    /// 'A' -> 1
    /// 'B' -> 2
    /// ...
    /// 'Z' -> 26
    /// Given a non-empty string containing only digits, determine the total number of ways to decode it.
    /// The answer is guaranteed to fit in a 32-bit integer.
    /// </summary>
    public class Solution
    {
        public int NumDecodings(string s)
        {
            if (string.IsNullOrWhiteSpace(s) )
                return 0;

            int s1 = 1;
            int s2 = s[0] == '0' ? 0 : 1;

            for (int i = 2; i <= s.Length; i++)
            {
                int s3 = 0;

                //if single digit possible
                if (s[i - 1] != '0')
                    s3 += s2;

                //if two digit
                int twoDigit = int.Parse(s.Substring(i - 2, 2));
                if (twoDigit >= 10 && twoDigit <= 26)
                    s3 += s1;

                s1 = s2;
                s2 = s3;
            }

            return s2;
        }
    }
}
