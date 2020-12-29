using System.Collections.Generic;

namespace Missing_Ranges
{
    /// <summary>
    /// You are given an inclusive range [lower, upper] and a sorted unique integer array nums, where all elements are in the inclusive range.
    /// A number x is considered missing if x is in the range[lower, upper] and x is not in nums.
    /// Return the smallest sorted list of ranges that cover every missing number exactly.That is, no element of nums is in any of the ranges, and each missing number is in one of the ranges.
    /// Each range[a, b] in the list should be output as:
    /// "a->b" if a != b
    /// "a" if a == b
    /// </summary>
    public class Solution
    {
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            if (nums == null || nums.Length == 0)
            {
                return new[] { FormatRange(lower, upper) };
            }

           var missingRanges = new List<string>();

            // Edge case 1) Missing ranges at the beginning
            if (nums[0] > lower)
            {
                missingRanges.Add(FormatRange(lower, nums[0] - 1));
            }

            // Missing ranges between array elements
            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] - nums[i - 1] > 1)
                {
                    missingRanges.Add(FormatRange(nums[i - 1] + 1, nums[i] - 1));
                }
            }

            // Edge case 2) Missing ranges at the end
            if (nums[^1] < upper)
            {
                missingRanges.Add(FormatRange(nums[^1] + 1, upper));
            }

            return missingRanges;
        }

        /// <summary>
        /// formats range in the requested format 
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        string FormatRange(int lower, int upper)
        {
            if (lower == upper)
            {
                return $"{lower}";
            }
            else
            {
                return $"{lower}->{upper}";
            }
        }
    }
}
