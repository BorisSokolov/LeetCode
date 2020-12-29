namespace Jump_Game_III
{
    /// <summary>
    /// Given an array of non-negative integers arr, you are initially positioned at start index of the array. When you are at index i, you can jump to i + arr[i] or i - arr[i], check if you can reach to any index with value 0.
    /// Notice that you can not jump outside of the array at any time.
    /// </summary>
    public class Solution
    {
        public bool CanReach(int[] arr, int start)
        {
            if (start >= 0 && start < arr.Length && arr[start] >= 0)
            {
                if (arr[start] == 0)
                    return true;

                //Assuming all the elements are positive we can inverse the value to omit an infinite loop
                arr[start] = -arr[start];

                return CanReach(arr, start + arr[start]) || CanReach(arr, start - arr[start]);
            }

            return false;
        }
    }
}
