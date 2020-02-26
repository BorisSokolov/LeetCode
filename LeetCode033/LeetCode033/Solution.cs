using System;

namespace LeetCode033
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length < 1)
                return -1;

            if (nums[0] == target)
                return 0;

            if (nums.Length <= 4)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                        return i;
                }
            }
            else if (nums[0] < target)
            {
                for (int i = Math.Min(target - nums[0], nums.Length - 1); i >= 1; i--)
                {
                    if (nums[i] == target)
                        return i;
                }
            }
            else 
            {
                for (int i = Math.Min(nums.Length - nums[nums.Length-1] + target - 1, nums.Length - 1); i < nums.Length; i++)
                {

                    if (nums[i] == target)
                        return i;
                }
            }

            return -1;
        }
    }
}
