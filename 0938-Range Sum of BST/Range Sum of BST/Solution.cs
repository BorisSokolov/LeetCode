namespace Range_Sum_of_BST
{
    public class Solution
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            int sum = 0;

            if (root == null)
                return 0;

            if (root.val >= low && root.val <= high)
            {
                sum += root.val;
                sum += RangeSumBST(root.left, low, high);
                sum += RangeSumBST(root.right, low, high);
            }
            else if (root.val < low)
            {
                sum += RangeSumBST(root.right, low, high);
            }
            else if (root.val > high)
            {
                sum += RangeSumBST(root.left, low, high);
            }

            return sum;
        }
    }
}
