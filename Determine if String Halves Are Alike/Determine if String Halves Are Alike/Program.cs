using System;

namespace Determine_if_String_Halves_Are_Alike
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //Input: s = "book"
            //Output: true
            //Explanation: a = "bo" and b = "ok".a has 1 vowel and b has 1 vowel.Therefore, they are alike.
            Console.WriteLine(s.HalvesAreAlike("book"));
            //Input: s = "textbook"
            //Output: false
            //Explanation: a = "text" and b = "book".a has 1 vowel whereas b has 2.Therefore, they are not alike.
            //Notice that the vowel o is counted twice.
            Console.WriteLine(s.HalvesAreAlike("textbook"));
            //Input: s = "MerryChristmas"
            //Output: false
            Console.WriteLine(s.HalvesAreAlike("MerryChristmas"));
            //Input: s = "AbCdEfGh"
            //Output: true
            Console.WriteLine(s.HalvesAreAlike("AbCdEfGh"));
        }
    }
}
