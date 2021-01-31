namespace LeetCode.BST.Easy.RangeSumOfBST
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    //https://leetcode.com/problems/range-sum-of-bst/
    public class Solution
    {
        private static int _result = 0;

        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            CalcSum(root, low, high);
            return _result;
        }

        private static void CalcSum(TreeNode root, int low, int high)
        {
            if (root == null) return;

            if (root.val >= low && root.val <= high)
            {
                _result += root.val;
            }
            if (root.val > low)
            {
                RangeSumBST(root.left, low, high);
            }
            if (root.val < high)
            {
                RangeSumBST(root.right, low, high);
            }
        }
    }
}
