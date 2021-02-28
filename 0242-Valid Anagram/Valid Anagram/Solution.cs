namespace Valid_Anagram
{
    /// <summary>
    /// Given two strings s and t , write a function to determine if t is an anagram of s.
    /// </summary>
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] table = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                table[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                table[t[i] - 'a']--;
                if (table[t[i] - 'a'] < 0)
                    return false;
            }
            return true;
        }
    }
}
