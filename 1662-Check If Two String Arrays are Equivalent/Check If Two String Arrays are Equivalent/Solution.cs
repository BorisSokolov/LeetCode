namespace Check_If_Two_String_Arrays_are_Equivalent
{
    /// <summary>
    /// Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
    /// A string is represented by an array if the array elements concatenated in order forms the string.
    /// </summary>
    public class Solution
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2) => string.Equals(string.Join("", word1), string.Join("", word2));
    }
}
