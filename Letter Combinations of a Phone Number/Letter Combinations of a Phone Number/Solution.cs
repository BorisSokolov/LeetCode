using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letter_Combinations_of_a_Phone_Number
{
    public class Solution
    {
        private Dictionary<char, string> keyMappings = new Dictionary<char, string>
        {
            { '2', "abc"},
            { '3', "def"},
            { '4', "ghi"},
            { '5', "jkl"},
            { '6', "mno"},
            { '7', "pqrs"},
            { '8', "tuv"},
            { '9', "wxyz"}
        };

        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            List<StringBuilder> combinations = new List<StringBuilder>();

            if (string.IsNullOrWhiteSpace(digits))
                return result;

            foreach (char key in digits)
            {
                if (!combinations.Any())
                {
                    foreach (char letter in keyMappings[key])
                    {
                        combinations.Add(new StringBuilder(letter));
                    }
                }
                else
                {
                    foreach (var combination in combinations)
                    {

                    }
                }
            }

            foreach (var combination in combinations)
            {
                result.Add(combination.ToString());
            }

            return result;
        }
    }
}
