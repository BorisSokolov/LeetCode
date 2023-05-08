using System.Linq;

namespace Missing_Number
{
    /// <summary>
    /// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array. Follow up: Could you implement a solution using only O(1) extra space complexity and O(n) runtime complexity?
    /// </summary>
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int actualSum = nums.Sum();
            int sum = nums.Length * (nums.Length + 1) / 2;

            return sum - actualSum;
        }
    }
}
