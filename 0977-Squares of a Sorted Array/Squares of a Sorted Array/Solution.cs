namespace Squares_of_a_Sorted_Array
{
    /// <summary>
    /// Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
    /// </summary>
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            //positive direction pointer
            int j = 0;
            while (j < nums.Length && nums[j] < 0)
                j++;

            //negative direction pointer
            int i = j - 1;

            int[] ans = new int[nums.Length];
            int t = 0;

            while (i >= 0 && j < nums.Length)
            {
                if (nums[i] * nums[i] < nums[j] * nums[j])
                {
                    ans[t++] = nums[i] * nums[i];
                    i--;
                }
                else
                {
                    ans[t++] = nums[j] * nums[j];
                    j++;
                }
            }

            while (i >= 0)
            {
                ans[t++] = nums[i] * nums[i];
                i--;
            }
            while (j < nums.Length)
            {
                ans[t++] = nums[j] * nums[j];
                j++;
            }

            return ans;
        }
    }
}
