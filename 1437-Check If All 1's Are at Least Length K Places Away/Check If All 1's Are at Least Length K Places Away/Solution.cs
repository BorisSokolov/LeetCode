namespace Check_If_All_1_s_Are_at_Least_Length_K_Places_Away
{
    /// <summary>
    /// Given an array nums of 0s and 1s and an integer k, return True if all 1's are at least k places away from each other, otherwise return False.
    /// </summary>
    public class Solution
    {
        public bool KLengthApart(int[] nums, int k)
        {
            int count = k;

            foreach (int num in nums)
            {
                if (num == 1)
                {
                    if (count < k)
                        return false;

                    count = 0;
                }
                else
                {
                    count++;
                }
            }

            return true;
        }
    }
}
