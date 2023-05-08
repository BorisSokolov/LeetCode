using System.Linq;


namespace Determine_if_String_Halves_Are_Alike
{
    public class Solution
    {
        public bool HalvesAreAlike(string s) => CountVowels(s.Substring(0, s.Length / 2)) == CountVowels(s.Substring(s.Length / 2, s.Length / 2));

        //LINQ seems to be faster than Regex
        private int CountVowels(string s) => s.Count(c => "aeiou".Contains(char.ToLower(c)));
    }
}
