using System.Collections.Generic;

namespace Strobogrammatic_Number
{
    /// <summary>
    /// Given a string num which represents an integer, return true if num is a strobogrammatic number.
    /// A strobogrammatic number is a number that looks the same when rotated 180 degrees(looked at upside down).
    /// </summary>
    public class Solution
    {
        public bool IsStrobogrammatic(string num)
        {
            var rotations = new Dictionary<char, char>
            {
                { '0', '0'},
                { '1', '1'},
                { '6', '9'},
                { '8', '8'},
                { '9', '6'}
            };

            for (int left = 0, right = num.Length - 1; left <= right; left++, right--)
            {
                if (!rotations.ContainsKey(num[left]) || rotations[num[left]] != num[right])
                    return false;
            }

            return true;
        }
    }
}
