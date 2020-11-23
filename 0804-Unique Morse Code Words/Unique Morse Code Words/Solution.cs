using System.Collections.Generic;
using System.Text;

namespace Unique_Morse_Code_Words
{
    /// <summary>
    /// International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.
    /// For convenience, the full table for the 26 letters of the English alphabet is given below:
    /// [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
    /// Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter.For example, "cab" can be written as "-.-..--...", (which is the concatenation "-.-." + ".-" + "-..."). We'll call such a concatenation, the transformation of a word.
    /// Return the number of different transformations among all words we have.
    /// </summary>
    public class Solution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morse = new string[]{".-","-...","-.-.","-..",".","..-.","--.",
                         "....","..",".---","-.-",".-..","--","-.",
                         "---",".--.","--.-",".-.","...","-","..-",
                         "...-",".--","-..-","-.--","--.."};

            var seen = new HashSet<string>();
            foreach (var word in words)
            {
                StringBuilder code = new StringBuilder();
                foreach (var c in word.ToCharArray())
                    code.Append(morse[c - 'a']);

                seen.Add(code.ToString());
            }

            return seen.Count;
        }
    }
}
