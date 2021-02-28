using System;

namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "anagram", t = "nagaram"
            //Output: true
            Console.WriteLine(s.IsAnagram("anagram", "nagaram"));
            //Input: s = "rat", t = "car"
            //Output: false
            Console.WriteLine(s.IsAnagram("rat", "car"));
        }
    }
}
