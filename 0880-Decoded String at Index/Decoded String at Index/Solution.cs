namespace Decoded_String_at_Index
{
    /// <summary>
    /// An encoded string S is given.  To find and write the decoded string to a tape, the encoded string is read one character at a time and the following steps are taken:
    /// If the character read is a letter, that letter is written onto the tape.
    /// If the character read is a digit (say d), the entire current tape is repeatedly written d-1 more times in total.
    /// Now for some encoded string S, and an index K, find and return the K-th letter (1 indexed) in the decoded string.
    /// </summary>
    public class Solution
    {
        public string DecodeAtIndex(string s, int k)
        {
            if (string.IsNullOrWhiteSpace(s))
                return null;

            long count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    count++;
                    if (count == k)
                        return s[i].ToString();
                }
                else
                {
                    long repeat = (s[i] - '0') * count;
                    if (repeat < k)
                    {
                        count = repeat;
                    }
                    else
                    {
                        k = (int)(k % count);
                        if (k == 0)
                        {
                            for (int j = i; j >= 0; --j)
                            {
                                if (char.IsLetter(s[j]))
                                    return s[j].ToString();
                            }
                        }
                        else
                        {
                            return DecodeAtIndex(s.Substring(0, i), k);
                        }
                    }
                }
            }

            return null;
        }
    }
}
