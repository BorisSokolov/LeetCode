namespace Kth_Missing_Positive_Number
{
    /// <summary>
    /// Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
    /// Find the kth positive integer that is missing from this array.
    /// </summary>
    public class Solution
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int pivot = left + (right - left) / 2;
                // If number of positive integers
                // which are missing before arr[pivot]
                // is less than k -->
                // continue to search on the right.
                if (arr[pivot] - pivot - 1 < k)
                {
                    left = pivot + 1;
                }
                else // Otherwise, go left.
                {
                    right = pivot - 1;
                }
            }

            // At the end of the loop, left = right + 1,
            // and the kth missing is in-between arr[right] and arr[left].
            // The number of integers missing before arr[right] is
            // arr[right] - right - 1 -->
            // the number to return is
            // arr[right] + k - (arr[right] - right - 1) = k + left
            return left + k;
        }
    }
}
