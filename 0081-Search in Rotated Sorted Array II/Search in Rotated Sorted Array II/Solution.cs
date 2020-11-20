namespace Search_in_Rotated_Sorted_Array_II
{
    /// <summary>
    /// Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
    /// (i.e., [0, 0, 1, 2, 2, 5, 6] might become[2, 5, 6, 0, 0, 1, 2]).
    /// You are given a target value to search.If found in the array return true, otherwise return false.
    /// </summary>
    public class Solution
    {
        //https://leetcode.com/problems/search-in-rotated-sorted-array-ii/solution/
        public bool Search(int[] nums, int target)
        {
            int n = nums.Length;
            if (n == 0)
                return false;

            int end = n - 1;
            int start = 0;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return true;

                if (!this.IsBinarySearchHelpful(nums, start, nums[mid]))
                {
                    start++;
                    continue;
                }

                //  which array does pivot belong to.
                bool pivotArray = this.ExistsInFirst(nums, start, nums[mid]);
                //  which array does target belong to.
                bool targetArray = this.ExistsInFirst(nums, start, target);
                if (pivotArray ^ targetArray)
                {
                    //  If pivot and target exist in different sorted arrays, recall that xor is true when both operands are distinct
                    // The operator should be an XOR ^ instead of an OR, but not available in CodeDOM
                    if (pivotArray)
                        //  pivot in the first, target in the second
                        start = mid + 1;
                    else
                        //  target in the first, pivot in the second
                        end = mid - 1;
                }
                else
                {
                    //  If pivot and target exist in same sorted array
                    if (nums[mid] < target)
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
            }

            return false;
        }

        //  returns true if we can reduce the search space in current binary search space
        private bool IsBinarySearchHelpful(int[] arr, int start, int element) => arr[start] != element;

        //  returns true if element exists in first array, false if it exists in second
        private bool ExistsInFirst(int[] arr, int start, int element) => arr[start] <= element;
    }
}
