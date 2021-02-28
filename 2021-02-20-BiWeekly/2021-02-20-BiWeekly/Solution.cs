using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2021_02_20_BiWeekly
{
    public class Solution
    {
        public string LongestNiceSubstring(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            if (IsNice(s))
                return s;

            var substrings = GetAllSubstring(s);
            string result = string.Empty;

            foreach (var str in substrings)
            {
                if (IsNice(str) && str.Length > result.Length)
                    result = str;
            }

            return result;
        }

        static bool IsNice(string s)
        {
            foreach (char c in s)
            {
                if (char.IsLower(c))
                {
                    if (!s.Contains(char.ToUpper(c)))
                        return false;
                }
                else
                {
                    if (!s.Contains(char.ToLower(c)))
                        return false;
                }
            }
            return true;
        }

        static List<string> GetAllSubstring(string text)
        {
            var query =
                from i in Enumerable.Range(0, text.Length)
                from j in Enumerable.Range(0, text.Length - i + 1)
                where j >= 2
                select text.Substring(i, j);

            return query.ToList();
        }
    }
}
