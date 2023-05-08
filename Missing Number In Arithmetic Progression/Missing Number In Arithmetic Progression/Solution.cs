namespace Missing_Number_In_Arithmetic_Progression
{
    /// <summary>
    /// In some array arr, the values were in arithmetic progression: the values arr[i + 1] - arr[i] are all equal for every 0 <= i < arr.length - 1.
    /// A value from arr was removed that was not the first or last value in the array.
    /// Given arr, return the removed value.
    /// </summary>
    public class Solution
    {
        public int MissingNumber(int[] arr)
        {
            int n = arr.Length;

            // 1. Get the difference `difference`.
            int difference = (arr[^1] - arr[0]) / n;
            int lo = 0;
            int hi = n - 1;

            // Basic binary search template.
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;

                // All numbers upto `mid` have no missing number, so search on the right side.
                if (arr[mid] == arr[0] + mid * difference)
                {
                    lo = mid + 1;
                }

                // A number is missing before `mid` inclusive of `mid` itself.
                else
                {
                    hi = mid;
                }
            }

            // Index `lo` will be the position with the first incorrect number.
            // Return the value that was supposed to be at this index.
            return arr[0] + difference * lo;
        }
    }
}
