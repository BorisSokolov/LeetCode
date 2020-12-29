namespace Increasing_Triplet_Subsequence
{
    /// <summary>
    /// Given an integer array nums, return true if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exists, return false.
    /// </summary>
    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;

            foreach (int n in nums)
            {
                if (n <= first)
                    first = n;
                else if (n <= second)
                    second = n;
                else
                    return true;
            }

            return false;
        }
    }
}
