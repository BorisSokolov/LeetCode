using System;

namespace Find_Words_That_Can_Be_Formed_by_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var words = new[] { "cat", "bt", "hat", "tree" };
            var chars = "atach";
            Console.WriteLine(s.CountCharacters(words, chars));
        }
    }
}
