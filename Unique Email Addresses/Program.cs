using System;
using System.Collections.Generic;

namespace Unique_Email_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            Console.WriteLine(s.NumUniqueEmails(new[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"}));
        }
    }

    public class Solution
    {
        public int NumUniqueEmails(string[] emails)
        {
            var hashSet = new HashSet<string>();

            foreach (string s in emails)
            {
                var split = s.Split('@');
                var name = split[0].Split('+');
                var nameTrimmed = name[0].Replace(".", "");

                hashSet.Add($"{nameTrimmed}@{split[1]}");
            }

            return hashSet.Count;
        }
    }
}
